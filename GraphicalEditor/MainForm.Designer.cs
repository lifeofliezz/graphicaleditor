
namespace ShapeEditor
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.rbResize = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(13, 13);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(74, 17);
            this.rbEllipse.TabIndex = 0;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Draw elips";
            this.rbEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(13, 37);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(97, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Draw rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(13, 61);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(52, 17);
            this.rbMove.TabIndex = 2;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // rbResize
            // 
            this.rbResize.AutoSize = true;
            this.rbResize.Location = new System.Drawing.Point(13, 85);
            this.rbResize.Name = "rbResize";
            this.rbResize.Size = new System.Drawing.Size(57, 17);
            this.rbResize.TabIndex = 3;
            this.rbResize.TabStop = true;
            this.rbResize.Text = "Resize";
            this.rbResize.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.rbResize);
            this.Controls.Add(this.rbMove);
            this.Controls.Add(this.rbRectangle);
            this.Controls.Add(this.rbEllipse);
            this.Name = "MainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.RadioButton rbResize;
    }
}

