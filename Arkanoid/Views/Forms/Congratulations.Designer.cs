using System.ComponentModel;

namespace Arkanoid.Views.Forms
{
    partial class Congratulations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Congratulations));
            this.tableLayoutCongratulations = new System.Windows.Forms.TableLayoutPanel();
            this.LblPlayer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutCongratulations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutCongratulations
            // 
            this.tableLayoutCongratulations.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutCongratulations.ColumnCount = 2;
            this.tableLayoutCongratulations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutCongratulations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutCongratulations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutCongratulations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutCongratulations.Controls.Add(this.LblPlayer, 1, 1);
            this.tableLayoutCongratulations.Controls.Add(this.lblScore, 1, 2);
            this.tableLayoutCongratulations.Controls.Add(this.btnExit, 1, 3);
            this.tableLayoutCongratulations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCongratulations.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutCongratulations.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutCongratulations.Name = "tableLayoutCongratulations";
            this.tableLayoutCongratulations.RowCount = 5;
            this.tableLayoutCongratulations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableLayoutCongratulations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutCongratulations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutCongratulations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutCongratulations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutCongratulations.Size = new System.Drawing.Size(1066, 554);
            this.tableLayoutCongratulations.TabIndex = 0;
            // 
            // LblPlayer
            // 
            this.LblPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPlayer.Location = new System.Drawing.Point(749, 290);
            this.LblPlayer.Name = "LblPlayer";
            this.LblPlayer.Size = new System.Drawing.Size(314, 69);
            this.LblPlayer.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Location = new System.Drawing.Point(749, 359);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(314, 69);
            this.lblScore.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.Location = new System.Drawing.Point(756, 439);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(299, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Congratulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.tableLayoutCongratulations);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Congratulations";
            this.Text = "Arkanoid by RIBAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Congratulations_FormClosing);
            this.Load += new System.EventHandler(this.Congratulations_Load);
            this.tableLayoutCongratulations.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCongratulations;

        #endregion
    }
}