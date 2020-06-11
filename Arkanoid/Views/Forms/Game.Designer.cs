using System.ComponentModel;

namespace Arkanoid.Views.Forms
{
    partial class Game
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tableLayoutPanelGame = new System.Windows.Forms.TableLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBoxLives = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblClockTimer = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxLives)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGame
            // 
            this.tableLayoutPanelGame.ColumnCount = 4;
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.5F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanelGame.Controls.Add(this.lblScore, 2, 0);
            this.tableLayoutPanelGame.Controls.Add(this.pictureBoxLives, 0, 0);
            this.tableLayoutPanelGame.Controls.Add(this.lblLives, 1, 0);
            this.tableLayoutPanelGame.Controls.Add(this.lblClockTimer, 3, 0);
            this.tableLayoutPanelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGame.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGame.Name = "tableLayoutPanelGame";
            this.tableLayoutPanelGame.RowCount = 4;
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelGame.Size = new System.Drawing.Size(882, 503);
            this.tableLayoutPanelGame.TabIndex = 1;
            this.tableLayoutPanelGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanelGame_MouseMove);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Firebrick;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(639, 0);
            this.lblScore.Margin = new System.Windows.Forms.Padding(0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(127, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLives
            // 
            this.pictureBoxLives.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBoxLives.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBoxLives.BackgroundImage")));
            this.pictureBoxLives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLives.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLives.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLives.Name = "pictureBoxLives";
            this.pictureBoxLives.Size = new System.Drawing.Size(22, 25);
            this.pictureBoxLives.TabIndex = 0;
            this.pictureBoxLives.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.BackColor = System.Drawing.Color.Firebrick;
            this.lblLives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLives.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLives.Location = new System.Drawing.Point(22, 0);
            this.lblLives.Margin = new System.Windows.Forms.Padding(0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(617, 25);
            this.lblLives.TabIndex = 1;
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClockTimer
            // 
            this.lblClockTimer.BackColor = System.Drawing.Color.Firebrick;
            this.lblClockTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClockTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblClockTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClockTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClockTimer.Location = new System.Drawing.Point(766, 0);
            this.lblClockTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lblClockTimer.Name = "lblClockTimer";
            this.lblClockTimer.Size = new System.Drawing.Size(116, 25);
            this.lblClockTimer.TabIndex = 4;
            this.lblClockTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.tableLayoutPanelGame);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(19, 19);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.tableLayoutPanelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxLives)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label lblClockTimer;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBoxLives;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGame;

        #endregion
    }
}