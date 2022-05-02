using System.Windows.Forms;
using Tao.OpenGl;

namespace Graphics
{
    public partial class GraphicsForm : Form
    {
		bool OpenGlControlInitialized;
        Renderer renderer;

        public GraphicsForm()
        {
            InitializeComponent();

			OpenGlControlInitialized = false;
			OpenGlControl.InitializeContexts();
			OpenGlControlInitialized = true;

			renderer = new Renderer();
			renderer.Initialize();
        }

		private void OpenGlControl_Paint(object sender, PaintEventArgs e)
        {
            renderer.Update();
            renderer.Draw();
        }

        private void GraphicsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            renderer.CleanUp();
        }

		private void OpenGlControl_SizeChanged(object sender, System.EventArgs e)
		{
			if (OpenGlControlInitialized)
			{
				Gl.glViewport(OpenGlControl.Location.X, OpenGlControl.Location.Y, OpenGlControl.Size.Width, OpenGlControl.Size.Height);
			}
		}
    }
}
