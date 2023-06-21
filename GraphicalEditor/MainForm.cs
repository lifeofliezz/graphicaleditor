using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeEditor
{
    public partial class MainForm : Form
    {
        private List<Shape> shapes; // List to store all the shapes
        private Shape selectedShape; // Currently selected shape
        private Point lastMousePosition; // Last recorded mouse position

        public MainForm()
        {
            InitializeComponent();
            shapes = new List<Shape>();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Paint all the shapes
            foreach (Shape shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Check if a shape is clicked
                foreach (Shape shape in shapes)
                {
                    if (shape.Contains(e.Location))
                    {
                        if (selectedShape != null)
                            selectedShape.IsSelected = false; // Deselect the previously selected shape

                        selectedShape = shape;
                        selectedShape.IsSelected = true; // Select the clicked shape
                        lastMousePosition = e.Location;
                        Invalidate();
                        return;
                    }
                }

                // If no shape is clicked, create a new shape
                if (rbEllipse.Checked)
                {
                    shapes.Add(new Ellipse(e.Location));
                }
                else if (rbRectangle.Checked)
                {
                    shapes.Add(new RectangleShape(e.Location));
                }

                Invalidate();
            }
        }


        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedShape != null)
            {
                // Move the selected shape
                int deltaX = e.Location.X - lastMousePosition.X;
                int deltaY = e.Location.Y - lastMousePosition.Y;
                selectedShape.Move(deltaX, deltaY);
                lastMousePosition = e.Location;
                Invalidate();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            selectedShape = null;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedShape != null)
            {
                int sizeChange = 5; // Amount of size change for each key press
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        selectedShape.Resize(-sizeChange, 0);
                        break;
                    case Keys.Right:
                        selectedShape.Resize(sizeChange, 0);
                        break;
                    case Keys.Up:
                        selectedShape.Resize(0, -sizeChange);
                        break;
                    case Keys.Down:
                        selectedShape.Resize(0, sizeChange);
                        break;
                }
                Invalidate();
            }
        }
    }

    // Base class for all shapes
    public abstract class Shape
    {
        protected Rectangle bounds; // Bounds of the shape
        public bool IsSelected { get; set; } // Indicates if the shape is selected

        public Shape(Point startPoint)
        {
            bounds = new Rectangle(startPoint, new Size(0, 0));
        }

        public bool Contains(Point point)
        {
            return bounds.Contains(point);
            IsSelected = false; // Initialize IsSelected to false
        }

        public void Move(int deltaX, int deltaY)
        {
            bounds.X += deltaX;
            bounds.Y += deltaY;
        }

        public void Resize(int deltaX, int deltaY)
        {
            bounds.Width += deltaX;
            bounds.Height += deltaY;
        }

        public abstract void Draw(Graphics g);
    }

    // Ellipse shape
    public class Ellipse : Shape
    {
        public Ellipse(Point startPoint) : base(startPoint)
        {
            bounds.Width = 100;
            bounds.Height = 100;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, bounds);
        }
    }

    // Rectangle shape
    public class RectangleShape : Shape
    {
        public RectangleShape(Point startPoint) : base(startPoint) 
        {
            bounds.Width = 100;
            bounds.Height = 100;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, bounds);
        }
    }
}
