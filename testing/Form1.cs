using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : UIserviceLayerWinForms.winforms.draggableForm
    {
        public Form1()
        {
            InitializeComponent();
            TextBox draggableTextBbox = new UIserviceLayerWinForms.winforms.draggableTextBoxAlongParent();
            //draggableTextBbox.Move += this.mousemove;

            this.Controls.Add(draggableTextBbox);
        }
    }
}
