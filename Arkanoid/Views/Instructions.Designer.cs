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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.tableLayoutPanelInstructions = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pictureBoxPeach = new System.Windows.Forms.PictureBox();
            this.pictureBoxControls = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelInstructions
            // 
            this.tableLayoutPanelInstructions.ColumnCount = 4;
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBoxPeach, 2, 1);
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBoxControls, 2, 3);
            this.tableLayoutPanelInstructions.Controls.Add(this.btnReturn, 1, 5);
            this.tableLayoutPanelInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInstructions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelInstructions.Name = "tableLayoutPanelInstructions";
            this.tableLayoutPanelInstructions.RowCount = 7;
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.Size = new System.Drawing.Size(772, 472);
            this.tableLayoutPanelInstructions.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.Location = new System.Drawing.Point(47, 397);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(368, 39);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "VOLVER";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pictureBoxPeach
            // 
            this.pictureBoxPeach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPeach.Location = new System.Drawing.Point(426, 25);
            this.pictureBoxPeach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPeach.Name = "pictureBoxPeach";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBoxPeach, 2);
            this.pictureBoxPeach.Size = new System.Drawing.Size(304, 278);
            this.pictureBoxPeach.TabIndex = 1;
            this.pictureBoxPeach.TabStop = false;
            // 
            // pictureBoxControls
            // 
            this.pictureBoxControls.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBoxControls.BackgroundImage")));
            this.pictureBoxControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxControls.Location = new System.Drawing.Point(426, 307);
            this.pictureBoxControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxControls.Name = "pictureBoxControls";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBoxControls, 3);
            this.pictureBoxControls.Size = new System.Drawing.Size(304, 137);
            this.pictureBoxControls.TabIndex = 3;
            this.pictureBoxControls.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(380, 358);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(772, 472);
            this.Controls.Add(this.tableLayoutPanelInstructions);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid by RIBAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelInstructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBoxControls;
        private System.Windows.Forms.PictureBox pictureBoxPeach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInstructions;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}