namespace Group_Project
{
    partial class PartyLists
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewParty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dbListPartiesList = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dbListPlayersCharactersList = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacrterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbListPartiesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbListPlayersCharactersList)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(547, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesToolStripMenuItem,
            this.fontToolStripMenuItem});
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
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
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
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
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
            // btnViewParty
            // 
            this.btnViewParty.AutoSize = true;
            this.btnViewParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewParty.Location = new System.Drawing.Point(13, 394);
            this.btnViewParty.Name = "btnViewParty";
            this.btnViewParty.Size = new System.Drawing.Size(80, 39);
            this.btnViewParty.TabIndex = 4;
            this.btnViewParty.Text = "&View";
            this.btnViewParty.UseVisualStyleBackColor = true;
            this.btnViewParty.Click += new System.EventHandler(this.btnViewParty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(434, 394);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 39);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dbListPartiesList
            // 
            this.dbListPartiesList.AllowUserToAddRows = false;
            this.dbListPartiesList.AllowUserToDeleteRows = false;
            this.dbListPartiesList.AllowUserToResizeColumns = false;
            this.dbListPartiesList.AllowUserToResizeRows = false;
            this.dbListPartiesList.ColumnHeadersHeight = 48;
            this.dbListPartiesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dbListPartiesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartyName,
            this.partyOwner,
            this.partyID,
            this.ownerID});
            this.dbListPartiesList.Location = new System.Drawing.Point(13, 38);
            this.dbListPartiesList.Name = "dbListPartiesList";
            this.dbListPartiesList.RowHeadersWidth = 51;
            this.dbListPartiesList.RowTemplate.Height = 24;
            this.dbListPartiesList.Size = new System.Drawing.Size(343, 304);
            this.dbListPartiesList.TabIndex = 3;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(13, 350);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(231, 36);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous Page";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(303, 350);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(231, 36);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dbListPlayersCharactersList
            // 
            this.dbListPlayersCharactersList.AllowUserToAddRows = false;
            this.dbListPlayersCharactersList.AllowUserToDeleteRows = false;
            this.dbListPlayersCharactersList.AllowUserToResizeColumns = false;
            this.dbListPlayersCharactersList.AllowUserToResizeRows = false;
            this.dbListPlayersCharactersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbListPlayersCharactersList.ColumnHeadersHeight = 48;
            this.dbListPlayersCharactersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dbListPlayersCharactersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.CharacrterName,
            this.playerID,
            this.characterID});
            this.dbListPlayersCharactersList.Location = new System.Drawing.Point(362, 38);
            this.dbListPlayersCharactersList.Name = "dbListPlayersCharactersList";
            this.dbListPlayersCharactersList.ReadOnly = true;
            this.dbListPlayersCharactersList.RowHeadersWidth = 4;
            this.dbListPlayersCharactersList.RowTemplate.Height = 24;
            this.dbListPlayersCharactersList.Size = new System.Drawing.Size(172, 304);
            this.dbListPlayersCharactersList.TabIndex = 9;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player ";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Width = 80;
            // 
            // CharacrterName
            // 
            this.CharacrterName.HeaderText = "Character";
            this.CharacrterName.Name = "CharacrterName";
            this.CharacrterName.ReadOnly = true;
            this.CharacrterName.Width = 85;
            // 
            // playerID
            // 
            this.playerID.HeaderText = "PlayerID";
            this.playerID.Name = "playerID";
            this.playerID.ReadOnly = true;
            this.playerID.Visible = false;
            // 
            // characterID
            // 
            this.characterID.HeaderText = "CharacterID";
            this.characterID.Name = "characterID";
            this.characterID.ReadOnly = true;
            this.characterID.Visible = false;
            // 
            // PartyName
            // 
            this.PartyName.HeaderText = "Party";
            this.PartyName.Name = "PartyName";
            this.PartyName.Width = 145;
            // 
            // partyOwner
            // 
            this.partyOwner.HeaderText = "Owner";
            this.partyOwner.Name = "partyOwner";
            this.partyOwner.Width = 145;
            // 
            // partyID
            // 
            this.partyID.HeaderText = "PartyID";
            this.partyID.Name = "partyID";
            this.partyID.Visible = false;
            // 
            // ownerID
            // 
            this.ownerID.HeaderText = "OwnerID";
            this.ownerID.Name = "ownerID";
            this.ownerID.Visible = false;
            // 
            // PartyLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 440);
            this.Controls.Add(this.dbListPlayersCharactersList);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnViewParty);
            this.Controls.Add(this.dbListPartiesList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PartyLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyLists";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbListPartiesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbListPlayersCharactersList)).EndInit();
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
        private System.Windows.Forms.Button btnViewParty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dbListPartiesList;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dbListPlayersCharactersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacrterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerID;
    }
}