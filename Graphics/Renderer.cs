using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Graphics
{
    class Renderer
    {
        Shader sh;
        //uint vertexBufferID;
        uint s, gf, ds;
        public void Initialize()
        {
            string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            sh = new Shader(projectPath + "\\Shaders\\SimpleVertexShader.vertexshader", projectPath + "\\Shaders\\SimpleFragmentShader.fragmentshader");
            /*Gl.glClearColor(0, 0, 0.4f, 1);
            float[] points =
            {
               0,  1,  0,
               1, -1,  0,
              -1, -1,  0
            };
            vertexBufferID = GPU.GenerateBuffer(points);*/
            Gl.glClearColor(0, 0, 0, 1);
            float[] points = {
                 0,0,0,
                 1,0,0,
                 0,-1,0,
                 1,-1,0,
                 

            };//[1]. data --> array
            s = GPU.GenerateBuffer(points);//[2]. cpu-->gpu(buffer)
            //sh = new Shader(projectPath + "\\shaders\\SimpleFragmentShader.fragmentshader", projectPath + "\\shaders\\SimpleVertexShader.vertexshader");
            ushort[] ind =
            {
                0,1,2,
                1,2,3
            };
            gf = GPU.GenerateElementBuffer(ind);
            float[] tri =
            {
                -0.5f,0,0,
                0,-1,0,
                -1,-1,0
            };
            ds = GPU.GenerateBuffer(tri);
        }

        public void Draw()
        {

           /* Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            sh.UseShader();
            Gl.glEnableVertexAttribArray(0);
            Gl.glVertexAttribPointer(0, 3, Gl.GL_FLOAT, Gl.GL_FALSE, 0, IntPtr.Zero);
            Gl.glDrawArrays(Gl.GL_TRIANGLES, 0, 3);
            Gl.glDisableVertexAttribArray(0);*/
            sh.UseShader();
            Gl.glEnableVertexAttribArray(0);//[3] enable vertex attribute
            Gl.glBindBuffer(Gl.GL_ARRAY_BUFFER, s);// [4] active  buffer--> data buffer
            Gl.glVertexAttribPointer(0, 3, Gl.GL_FLOAT, Gl.GL_FALSE, 0, IntPtr.Zero); //[5] vertex attribute pointer
            Gl.glBindBuffer(Gl.GL_ELEMENT_ARRAY_BUFFER,gf);
            //Gl.glDrawArrays(Gl.GL_TRIANGLES, 0, 6);//[6] draw array
            Gl.glDrawElements(Gl.GL_TRIANGLES, 6, Gl.GL_UNSIGNED_SHORT, IntPtr.Zero);
            Gl.glDisableVertexAttribArray(0);




            sh.UseShader();
            Gl.glEnableVertexAttribArray(0);//[3] enable vertex attribute
            Gl.glBindBuffer(Gl.GL_ARRAY_BUFFER, ds);// [4] active  buffer--> data buffer
            Gl.glVertexAttribPointer(0, 3, Gl.GL_FLOAT, Gl.GL_FALSE, 0, IntPtr.Zero); //[5] vertex attribute pointer
            Gl.glDrawArrays(Gl.GL_TRIANGLES, 0, 3);//[6] draw array
            Gl.glDisableVertexAttribArray(0);

        }
        public void Update()
        {

        }
        public void CleanUp()
        {
            sh.DestroyShader();
        }
    }
}
