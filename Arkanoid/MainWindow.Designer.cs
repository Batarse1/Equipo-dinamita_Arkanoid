namespace Arkanoid
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPlay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLeaderboards, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInstructions, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1562, 839);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPlay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.Location = new System.Drawing.Point(791, 429);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(755, 83);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "¡JUGAR!";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLeaderboards.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLeaderboards.Location = new System.Drawing.Point(791, 533);
            this.btnLeaderboards.Margin = new System.Windows.Forms.Padding(10);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(755, 83);
            this.btnLeaderboards.TabIndex = 1;
            this.btnLeaderboards.Text = "PUNTAJES";
            this.btnLeaderboards.UseVisualStyleBackColor = false;
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnInstructions.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnInstructions.Location = new System.Drawing.Point(791, 637);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(10);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(755, 83);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "INSTRUCCIONES";
            this.btnInstructions.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.Location = new System.Drawing.Point(791, 741);
            this.btnExit.Margin = new System.Windows.Forms.Padding(10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(755, 83);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1556, 419);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Arkanoid by RIBAL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Arkanoid by RIBAL";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Label lblTitle;
    }
}