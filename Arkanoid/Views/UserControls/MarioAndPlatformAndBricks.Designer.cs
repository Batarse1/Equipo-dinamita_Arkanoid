using System.ComponentModel;

namespace Arkanoid.Views.UserControls
{
    partial class MarioAndPlatformAndBricks
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
            this.components = new System.ComponentModel.Container();
            this.platformTimer = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.PictureBox();
            this.mario = new System.Windows.Forms.PictureBox();
            this.Collider2D = new System.Windows.Forms.Timer(this.components);
            this.MarioTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.mario)).BeginInit();
            this.SuspendLayout();
            this.platformTimer.Enabled = true;
            this.platformTimer.Interval = 30;
            this.platformTimer.Tick += new System.EventHandler(this.platformTimer_Tick);
            this.platform.Location = new System.Drawing.Point(175, 392);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(212, 40);
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            this.mario.Location = new System.Drawing.Point(204, 295);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(130, 88);
            this.mario.TabIndex = 1;
            this.mario.TabStop = false;
            this.Collider2D.Enabled = true;
            this.Collider2D.Interval = 30;
            this.Collider2D.Tick += new System.EventHandler(this.Collider2D_Tick);
            this.MarioTimer.Enabled = true;
            this.MarioTimer.Interval = 30;
            this.MarioTimer.Tick += new System.EventHandler(this.MarioTimer_Tick_1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mario);
            this.Controls.Add(this.platform);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MarioAndPlatformAndBricks";
            this.Size = new System.Drawing.Size(582, 465);
            this.Load += new System.EventHandler(this.Mario_and_bricks_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MarioAndBricks_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MarioAndBricks_MouseMove);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MarioAndBricks_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.mario)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer Collider2D;
        private System.Windows.Forms.PictureBox mario;
        private System.Windows.Forms.Timer MarioTimer;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer platformTimer;

        #endregion
    }
}