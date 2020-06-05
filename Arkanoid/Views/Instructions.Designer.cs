using System.ComponentModel;

namespace Arkanoid
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid.Instructions));
            this.tableLayoutPanelInstructions = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBoxPeach = new System.Windows.Forms.PictureBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pictureBoxControls = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxControls)).BeginInit();
            this.SuspendLayout();
            this.tableLayoutPanelInstructions.ColumnCount = 4;
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.Controls.Add(this.btnReturn, 2, 4);
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBoxPeach, 2, 1);
            this.tableLayoutPanelInstructions.Controls.Add(this.lblHelp, 1, 1);
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBoxControls, 1, 3);
            this.tableLayoutPanelInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInstructions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInstructions.Name = "tableLayoutPanelInstructions";
            this.tableLayoutPanelInstructions.RowCount = 7;
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.Size = new System.Drawing.Size(882, 503);
            this.tableLayoutPanelInstructions.TabIndex = 0;
            this.btnReturn.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.Location = new System.Drawing.Point(496, 380);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(11);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(330, 40);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "VOLVER";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.pictureBoxPeach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPeach.Location = new System.Drawing.Point(488, 28);
            this.pictureBoxPeach.Name = "pictureBoxPeach";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBoxPeach, 2);
            this.pictureBoxPeach.Size = new System.Drawing.Size(346, 294);
            this.pictureBoxPeach.TabIndex = 1;
            this.pictureBoxPeach.TabStop = false;
            this.lblHelp.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.lblHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHelp.Font = new System.Drawing.Font("Super Mario 256", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHelp.Location = new System.Drawing.Point(47, 25);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(435, 150);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = "Bowser me tiene secuestrada, gran gei\r\n";
            this.pictureBoxControls.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBoxControls.BackgroundImage")));
            this.pictureBoxControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxControls.Location = new System.Drawing.Point(47, 328);
            this.pictureBoxControls.Name = "pictureBoxControls";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBoxControls, 3);
            this.pictureBoxControls.Size = new System.Drawing.Size(435, 144);
            this.pictureBoxControls.TabIndex = 3;
            this.pictureBoxControls.TabStop = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.tableLayoutPanelInstructions);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid by RIBAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelInstructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxControls)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.PictureBox pictureBoxControls;
        private System.Windows.Forms.PictureBox pictureBoxPeach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInstructions;

        #endregion
    }
}