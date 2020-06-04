namespace Arkanoid
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.tableLayoutPanelStartMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelStartMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelStartMenu
            // 
            this.tableLayoutPanelStartMenu.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelStartMenu.ColumnCount = 2;
            this.tableLayoutPanelStartMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStartMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStartMenu.Controls.Add(this.btnPlay, 1, 1);
            this.tableLayoutPanelStartMenu.Controls.Add(this.btnLeaderboards, 1, 2);
            this.tableLayoutPanelStartMenu.Controls.Add(this.btnInstructions, 1, 3);
            this.tableLayoutPanelStartMenu.Controls.Add(this.btnExit, 1, 4);
            this.tableLayoutPanelStartMenu.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanelStartMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStartMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStartMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelStartMenu.Name = "tableLayoutPanelStartMenu";
            this.tableLayoutPanelStartMenu.RowCount = 5;
            this.tableLayoutPanelStartMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStartMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelStartMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelStartMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelStartMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelStartMenu.Size = new System.Drawing.Size(832, 433);
            this.tableLayoutPanelStartMenu.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Super Mario 256", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPlay.Location = new System.Drawing.Point(427, 227);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(11);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(394, 32);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "JUGAR";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLeaderboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeaderboards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaderboards.Font = new System.Drawing.Font("Super Mario 256", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLeaderboards.Location = new System.Drawing.Point(427, 281);
            this.btnLeaderboards.Margin = new System.Windows.Forms.Padding(11);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(394, 32);
            this.btnLeaderboards.TabIndex = 1;
            this.btnLeaderboards.Text = "PUNTAJES";
            this.btnLeaderboards.UseVisualStyleBackColor = false;
            this.btnLeaderboards.Click += new System.EventHandler(this.btnLeaderboards_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstructions.Font = new System.Drawing.Font("Super Mario 256", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnInstructions.Location = new System.Drawing.Point(427, 335);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(11);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(394, 32);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "INSTRUCCIONES";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Super Mario 256", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.Location = new System.Drawing.Point(427, 389);
            this.btnExit.Margin = new System.Windows.Forms.Padding(11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(394, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.tableLayoutPanelStartMenu.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Super Mario 256", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(826, 216);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Arkanoid by RIBAL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.tableLayoutPanelStartMenu);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid by RIBAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartMenu_FormClosing);
            this.tableLayoutPanelStartMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStartMenu;

        #endregion
    }
}