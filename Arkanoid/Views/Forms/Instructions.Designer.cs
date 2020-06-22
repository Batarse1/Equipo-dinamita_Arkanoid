using System.ComponentModel;

namespace Arkanoid.Views.Forms
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
            this.pictureBoxControls = new System.Windows.Forms.PictureBox();
            this.pictureBoxPeachMessage = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanelInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPeachMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelInstructions
            // 
            this.tableLayoutPanelInstructions.ColumnCount = 4;
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBoxControls, 2, 3);
            this.tableLayoutPanelInstructions.Controls.Add(this.pictureBoxPeachMessage, 2, 1);
            this.tableLayoutPanelInstructions.Controls.Add(this.btnReturn, 1, 5);
            this.tableLayoutPanelInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInstructions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInstructions.Margin = new System.Windows.Forms.Padding(2);
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
            this.tableLayoutPanelInstructions.Size = new System.Drawing.Size(882, 629);
            this.tableLayoutPanelInstructions.TabIndex = 0;
            // 
            // pictureBoxControls
            // 
            this.pictureBoxControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxControls.Location = new System.Drawing.Point(398, 409);
            this.pictureBoxControls.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxControls.Name = "pictureBoxControls";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBoxControls, 3);
            this.pictureBoxControls.Size = new System.Drawing.Size(437, 184);
            this.pictureBoxControls.TabIndex = 3;
            this.pictureBoxControls.TabStop = false;
            // 
            // pictureBoxPeachMessage
            // 
            this.pictureBoxPeachMessage.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBoxPeachMessage.BackgroundImage")));
            this.pictureBoxPeachMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPeachMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPeachMessage.Location = new System.Drawing.Point(398, 33);
            this.pictureBoxPeachMessage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPeachMessage.Name = "pictureBoxPeachMessage";
            this.tableLayoutPanelInstructions.SetRowSpan(this.pictureBoxPeachMessage, 2);
            this.pictureBoxPeachMessage.Size = new System.Drawing.Size(437, 372);
            this.pictureBoxPeachMessage.TabIndex = 4;
            this.pictureBoxPeachMessage.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.Location = new System.Drawing.Point(54, 531);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(10, 14, 10, 14);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(331, 49);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "VOLVER";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(882, 629);
            this.Controls.Add(this.tableLayoutPanelInstructions);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid by RIBAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.tableLayoutPanelInstructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxPeachMessage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pictureBoxControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInstructions;

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPeachMessage;
    }
}