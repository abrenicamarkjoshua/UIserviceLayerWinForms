using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UIserviceLayerWinForms.winforms
{
    public class draggableTextBoxAlongParent : RichTextBox
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
        void move(Control parent)
        {
            if (parent is Form)
            {
                parent.Top = System.Windows.Forms.Cursor.Position.Y - parentMouseY;
                parent.Left = System.Windows.Forms.Cursor.Position.X - parentMouseX;
            } else{
                move(parent.Parent);
            }
        }
        public void mousemove(object sender, EventArgs e)
        {
            if (draggable)
            {
                //this.Top = System.Windows.Forms.Cursor.Position.Y - mousey;
                //this.Left = System.Windows.Forms.Cursor.Position.X - mousex;
                move(this.Parent);
                
            }
        }
        void setParentMouseLocation(Control parent)
        {
            if (parent is Form)
            {
                parentMouseX = System.Windows.Forms.Cursor.Position.X - parent.Left;
                parentMouseY = System.Windows.Forms.Cursor.Position.Y - parent.Top;

            }
            else
            {
                setParentMouseLocation(parent.Parent);
            }
        }
        public virtual void mousedown(object sender, EventArgs e){
            draggable = true;
          
            setParentMouseLocation(this.Parent);

        }
        public void mouseup(object sender, EventArgs e)
        {
            draggable = false;
        }
    }
}
