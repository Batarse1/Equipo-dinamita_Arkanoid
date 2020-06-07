using System.ComponentModel;

namespace Arkanoid
{
    partial class MarioAndBricks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MarioAndBricks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MarioAndBricks";
            this.Size = new System.Drawing.Size(582, 465);
            this.Load += new System.EventHandler(this.Mario_and_bricks_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MarioAndBricks_MouseMove);
            this.ResumeLayout(false);
        }

        #endregion
    }
}