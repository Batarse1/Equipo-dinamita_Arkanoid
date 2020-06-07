using System.ComponentModel;

namespace Arkanoid
{
    partial class PlatformMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformMovement));
            this.platform = new System.Windows.Forms.PictureBox();
            this.platformTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.platform)).BeginInit();
            this.SuspendLayout();
            // 
            // platform
            // 
            this.platform.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("platform.BackgroundImage")));
            this.platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platform.Location = new System.Drawing.Point(0, 0);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(208, 68);
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            this.platform.MouseMove += new System.Windows.Forms.MouseEventHandler(this.platform_MouseMove);
            // 
            // platformTimer
            // 
            this.platformTimer.Enabled = true;
            this.platformTimer.Interval = 30;
            this.platformTimer.Tick += new System.EventHandler(this.platformTimer_Tick);
            // 
            // PlatformMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.platform);
            this.Name = "PlatformMovement";
            this.Size = new System.Drawing.Size(571, 68);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlatformMovement_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlatformMovement_MouseMove);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PlatformMovement_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.platform)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer platformTimer;

        #endregion
    }
}