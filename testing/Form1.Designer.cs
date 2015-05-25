namespace testing
{
    partial class Form1
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
            this.draggableTextBoxAlongParent1 = new UIserviceLayerWinForms.winforms.draggableTextBoxAlongParent();
            this.SuspendLayout();
            // 
            // draggableTextBoxAlongParent1
            // 
            this.draggableTextBoxAlongParent1.Location = new System.Drawing.Point(54, 66);
            this.draggableTextBoxAlongParent1.Multiline = true;
            this.draggableTextBoxAlongParent1.Name = "draggableTextBoxAlongParent1";
            this.draggableTextBoxAlongParent1.Size = new System.Drawing.Size(245, 138);
            this.draggableTextBoxAlongParent1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 300);
            this.Controls.Add(this.draggableTextBoxAlongParent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIserviceLayerWinForms.winforms.draggableTextBoxAlongParent draggableTextBoxAlongParent1;

    }
}

