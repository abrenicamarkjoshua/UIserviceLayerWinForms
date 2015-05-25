using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UIserviceLayerWinForms.winforms
{
    public class draggableTextBoxAlongParent : TextBox
    {
         protected bool draggable = false;
        protected int mousex;
        protected int mousey;
        protected int parentMouseX;
        protected int parentMouseY;
        public draggableTextBoxAlongParent()
        {
            this.MouseDown += mousedown;
            this.MouseMove += mousemove;
            this.MouseUp += mouseup;
        }
        public void mousemove(object sender, EventArgs e)
        {
            if (draggable)
            {
                //this.Top = System.Windows.Forms.Cursor.Position.Y - mousey;
                //this.Left = System.Windows.Forms.Cursor.Position.X - mousex;
                this.Parent.Top = System.Windows.Forms.Cursor.Position.Y - parentMouseY;
                this.Parent.Left = System.Windows.Forms.Cursor.Position.X - parentMouseX; 
                
            }
        }
        public void mousedown(object sender, EventArgs e){
            draggable = true;
            //mousex = System.Windows.Forms.Cursor.Position.X - this.Left;
            //mousey = System.Windows.Forms.Cursor.Position.Y - this.Top;
            parentMouseX = System.Windows.Forms.Cursor.Position.X - this.Parent.Left;
            parentMouseY = System.Windows.Forms.Cursor.Position.Y - this.Parent.Top;

        }
        public void mouseup(object sender, EventArgs e)
        {
            draggable = false;
        }
    }
}
