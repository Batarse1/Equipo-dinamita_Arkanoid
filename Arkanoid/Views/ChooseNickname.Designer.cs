using System.ComponentModel;

namespace Arkanoid
{
    partial class ChooseNickname
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(ChooseNickname));
            this.tableLayoutPanelChooseNickname = new System.Windows.Forms.TableLayoutPanel();
            this.lblAskForNickname = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.tableLayoutPanelChooseNickname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelChooseNickname
            // 
            this.tableLayoutPanelChooseNickname.ColumnCount = 5;
            this.tableLayoutPanelChooseNickname.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChooseNickname.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelChooseNickname.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelChooseNickname.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelChooseNickname.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChooseNickname.Controls.Add(this.lblAskForNickname, 1, 1);
            this.tableLayoutPanelChooseNickname.Controls.Add(this.btnReturn, 1, 5);
            this.tableLayoutPanelChooseNickname.Controls.Add(this.pictureBox1, 2, 2);
            this.tableLayoutPanelChooseNickname.Controls.Add(this.btnPlay, 3, 5);
            this.tableLayoutPanelChooseNickname.Controls.Add(this.txtNickname, 2, 1);
            this.tableLayoutPanelChooseNickname.Controls.Add(this.lblNickname, 3, 3);
            this.tableLayoutPanelChooseNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChooseNickname.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelChooseNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelChooseNickname.Name = "tableLayoutPanelChooseNickname";
            this.tableLayoutPanelChooseNickname.RowCount = 7;
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelChooseNickname.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelChooseNickname.Size = new System.Drawing.Size(772, 472);
            this.tableLayoutPanelChooseNickname.TabIndex = 0;
            // 
            // lblAskForNickname
            // 
            this.lblAskForNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAskForNickname.Font = new System.Drawing.Font("Super Mario 256", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAskForNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAskForNickname.Location = new System.Drawing.Point(40, 25);
            this.lblAskForNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblAskForNickname.Name = "lblAskForNickname";
            this.lblAskForNickname.Size = new System.Drawing.Size(227, 55);
            this.lblAskForNickname.TabIndex = 1;
            this.lblAskForNickname.Text = "ALIAS";
            this.lblAskForNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Snow;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.Location = new System.Drawing.Point(47, 398);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(213, 39);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "VOLVER";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(271, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanelChooseNickname.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(227, 361);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Snow;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.Location = new System.Drawing.Point(509, 398);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(213, 39);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "JUGAR";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelChooseNickname.SetColumnSpan(this.txtNickname, 2);
            this.txtNickname.Font = new System.Drawing.Font("Super Mario 256", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNickname.Location = new System.Drawing.Point(271, 37);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(458, 31);
            this.txtNickname.TabIndex = 2;
            this.txtNickname.TextChanged += new System.EventHandler(this.nickname_TextChanged);
            // 
            // lblNickname
            // 
            this.lblNickname.BackColor = System.Drawing.Color.Firebrick;
            this.lblNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNickname.Font = new System.Drawing.Font("Super Mario 256", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNickname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNickname.Location = new System.Drawing.Point(502, 107);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(227, 55);
            this.lblNickname.TabIndex = 4;
            this.lblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChooseNickname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(772, 472);
            this.Controls.Add(this.tableLayoutPanelChooseNickname);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChooseNickname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid By Ribal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseNickname_FormClosing);
            this.tableLayoutPanelChooseNickname.ResumeLayout(false);
            this.tableLayoutPanelChooseNickname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAskForNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChooseNickname;
        private System.Windows.Forms.TextBox txtNickname;

        #endregion
    }
}