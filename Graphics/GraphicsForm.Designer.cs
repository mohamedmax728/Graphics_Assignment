namespace Graphics
{
    partial class GraphicsForm
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
			this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
			this.SuspendLayout();
			// 
			// OpenGlControl
			// 
			this.OpenGlControl.AccumBits = ((byte)(0));
			this.OpenGlControl.AutoCheckErrors = false;
			this.OpenGlControl.AutoFinish = false;
			this.OpenGlControl.AutoMakeCurrent = true;
			this.OpenGlControl.AutoSwapBuffers = true;
			this.OpenGlControl.BackColor = System.Drawing.Color.Black;
			this.OpenGlControl.ColorBits = ((byte)(32));
			this.OpenGlControl.DepthBits = ((byte)(16));
			this.OpenGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OpenGlControl.Location = new System.Drawing.Point(0, 0);
			this.OpenGlControl.Name = "OpenGlControl";
			this.OpenGlControl.Size = new System.Drawing.Size(765, 439);
			this.OpenGlControl.StencilBits = ((byte)(0));
			this.OpenGlControl.TabIndex = 0;
			this.OpenGlControl.SizeChanged += new System.EventHandler(this.OpenGlControl_SizeChanged);
			this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGlControl_Paint);
			// 
			// GraphicsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 439);
			this.Controls.Add(this.OpenGlControl);
			this.Name = "GraphicsForm";
			this.Text = "Graphics";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphicsForm_FormClosing);
			this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
    }
}

