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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.tableLayoutPanelInstructions = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanelInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelInstructions
            // 
            this.tableLayoutPanelInstructions.ColumnCount = 3;
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelInstructions.Controls.Add(this.btnReturn, 1, 1);
            this.tableLayoutPanelInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInstructions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInstructions.Name = "tableLayoutPanelInstructions";
            this.tableLayoutPanelInstructions.RowCount = 6;
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanelInstructions.Size = new System.Drawing.Size(882, 503);
            this.tableLayoutPanelInstructions.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReturn.Location = new System.Drawing.Point(55, 104);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(11);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(771, 40);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "VOLVER";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Instructions
            // 
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
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInstructions;

        #endregion
    }
}