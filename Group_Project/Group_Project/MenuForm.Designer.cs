namespace Group_Project
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fantasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCharCreate = new System.Windows.Forms.Button();
            this.btnParCreate = new System.Windows.Forms.Button();
            this.btnCharBrowse = new System.Windows.Forms.Button();
            this.btnViewParty = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(213, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.passwordSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.fantasyToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.themesToolStripMenuItem.Text = "&Themes";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            // 
            // fantasyToolStripMenuItem
            // 
            this.fantasyToolStripMenuItem.Name = "fantasyToolStripMenuItem";
            this.fantasyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fantasyToolStripMenuItem.Text = "Fantasy";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.smallToolStripMenuItem.Text = "Small";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.largeToolStripMenuItem.Text = "Large";
            // 
            // passwordSettingsToolStripMenuItem
            // 
            this.passwordSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordManagerToolStripMenuItem});
            this.passwordSettingsToolStripMenuItem.Name = "passwordSettingsToolStripMenuItem";
            this.passwordSettingsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.passwordSettingsToolStripMenuItem.Text = "Account";
            // 
            // passwordManagerToolStripMenuItem
            // 
            this.passwordManagerToolStripMenuItem.Name = "passwordManagerToolStripMenuItem";
            this.passwordManagerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.passwordManagerToolStripMenuItem.Text = "Password Manager";
            this.passwordManagerToolStripMenuItem.Click += new System.EventHandler(this.passwordManagerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // btnCharCreate
            // 
            this.btnCharCreate.AutoSize = true;
            this.btnCharCreate.Location = new System.Drawing.Point(13, 33);
            this.btnCharCreate.Name = "btnCharCreate";
            this.btnCharCreate.Size = new System.Drawing.Size(188, 35);
            this.btnCharCreate.TabIndex = 2;
            this.btnCharCreate.Text = "&Character Creation";
            this.btnCharCreate.UseVisualStyleBackColor = true;
            this.btnCharCreate.Click += new System.EventHandler(this.btnCharCreate_Click);
            // 
            // btnParCreate
            // 
            this.btnParCreate.AutoSize = true;
            this.btnParCreate.Location = new System.Drawing.Point(13, 69);
            this.btnParCreate.Name = "btnParCreate";
            this.btnParCreate.Size = new System.Drawing.Size(188, 35);
            this.btnParCreate.TabIndex = 3;
            this.btnParCreate.Text = "&Party Creation";
            this.btnParCreate.UseVisualStyleBackColor = true;
            this.btnParCreate.Click += new System.EventHandler(this.btnParCreate_Click);
            // 
            // btnCharBrowse
            // 
            this.btnCharBrowse.AutoSize = true;
            this.btnCharBrowse.Location = new System.Drawing.Point(13, 105);
            this.btnCharBrowse.Name = "btnCharBrowse";
            this.btnCharBrowse.Size = new System.Drawing.Size(188, 35);
            this.btnCharBrowse.TabIndex = 4;
            this.btnCharBrowse.Text = "&Browse Characters";
            this.btnCharBrowse.UseVisualStyleBackColor = true;
            this.btnCharBrowse.Click += new System.EventHandler(this.btnCharBrowse_Click);
            // 
            // btnViewParty
            // 
            this.btnViewParty.Location = new System.Drawing.Point(13, 141);
            this.btnViewParty.Name = "btnViewParty";
            this.btnViewParty.Size = new System.Drawing.Size(188, 30);
            this.btnViewParty.TabIndex = 5;
            this.btnViewParty.Text = "&View Parties";
            this.btnViewParty.UseVisualStyleBackColor = true;
            this.btnViewParty.Click += new System.EventHandler(this.btnViewParty_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(13, 177);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(188, 30);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 221);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewParty);
            this.Controls.Add(this.btnCharBrowse);
            this.Controls.Add(this.btnParCreate);
            this.Controls.Add(this.btnCharCreate);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fantasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button btnCharCreate;
        private System.Windows.Forms.Button btnParCreate;
        private System.Windows.Forms.Button btnCharBrowse;
        private System.Windows.Forms.Button btnViewParty;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem passwordSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordManagerToolStripMenuItem;
    }
}