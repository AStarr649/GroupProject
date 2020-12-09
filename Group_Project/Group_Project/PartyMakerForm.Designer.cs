namespace Group_Project
{
    partial class PartyMakerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPartyCreatorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbListPartyList = new System.Windows.Forms.DataGridView();
            this.playerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbListCharList = new System.Windows.Forms.DataGridView();
            this.player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharGend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharRace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd2Pt = new System.Windows.Forms.Button();
            this.btnRemovePt = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectChar = new System.Windows.Forms.Button();
            this.btnDeleteParty = new System.Windows.Forms.Button();
            this.btnLoadParty = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbListPartyList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbListCharList)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(775, 29);
            this.menuStrip1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPartyCreatorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPartyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dbListPartyList);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 359);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Party Selection";
            // 
            // txtPartyCreatorName
            // 
            this.txtPartyCreatorName.Enabled = false;
            this.txtPartyCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyCreatorName.Location = new System.Drawing.Point(133, 47);
            this.txtPartyCreatorName.Name = "txtPartyCreatorName";
            this.txtPartyCreatorName.Size = new System.Drawing.Size(177, 29);
            this.txtPartyCreatorName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party Creater:";
            // 
            // txtPartyName
            // 
            this.txtPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(133, 19);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(177, 29);
            this.txtPartyName.TabIndex = 1;
            this.txtPartyName.Enter += new System.EventHandler(this.OnEnterName);
            this.txtPartyName.Leave += new System.EventHandler(this.OnLeaveName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party Name:";
            // 
            // dbListPartyList
            // 
            this.dbListPartyList.AllowUserToAddRows = false;
            this.dbListPartyList.AllowUserToDeleteRows = false;
            this.dbListPartyList.AllowUserToOrderColumns = true;
            this.dbListPartyList.AllowUserToResizeColumns = false;
            this.dbListPartyList.AllowUserToResizeRows = false;
            this.dbListPartyList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dbListPartyList.ColumnHeadersHeight = 48;
            this.dbListPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dbListPartyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerCol,
            this.playerID});
            this.dbListPartyList.Location = new System.Drawing.Point(6, 80);
            this.dbListPartyList.Name = "dbListPartyList";
            this.dbListPartyList.RowHeadersWidth = 51;
            this.dbListPartyList.RowTemplate.Height = 24;
            this.dbListPartyList.Size = new System.Drawing.Size(304, 273);
            this.dbListPartyList.TabIndex = 2;
            this.dbListPartyList.TabStop = false;
            this.dbListPartyList.Enter += new System.EventHandler(this.DoEnterPartyList);
            // 
            // playerCol
            // 
            this.playerCol.HeaderText = "Player";
            this.playerCol.Name = "playerCol";
            this.playerCol.Width = 250;
            // 
            // playerID
            // 
            this.playerID.HeaderText = "playerID";
            this.playerID.Name = "playerID";
            this.playerID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dbListCharList);
            this.groupBox2.Location = new System.Drawing.Point(335, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Created Characters";
            // 
            // dbListCharList
            // 
            this.dbListCharList.AllowUserToAddRows = false;
            this.dbListCharList.AllowUserToDeleteRows = false;
            this.dbListCharList.AllowUserToOrderColumns = true;
            this.dbListCharList.AllowUserToResizeColumns = false;
            this.dbListCharList.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbListCharList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dbListCharList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbListCharList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player,
            this.CharacterName,
            this.CharGend,
            this.CharClass,
            this.CharRace,
            this.CharID});
            this.dbListCharList.Location = new System.Drawing.Point(6, 30);
            this.dbListCharList.Name = "dbListCharList";
            this.dbListCharList.RowHeadersWidth = 25;
            this.dbListCharList.RowTemplate.Height = 24;
            this.dbListCharList.Size = new System.Drawing.Size(417, 173);
            this.dbListCharList.TabIndex = 0;
            this.dbListCharList.TabStop = false;
            this.dbListCharList.Enter += new System.EventHandler(this.DoEnterCharList);
            // 
            // player
            // 
            this.player.HeaderText = "Player";
            this.player.Name = "player";
            this.player.Width = 80;
            // 
            // CharacterName
            // 
            this.CharacterName.HeaderText = "Character Name";
            this.CharacterName.Name = "CharacterName";
            // 
            // CharGend
            // 
            this.CharGend.HeaderText = "Gender";
            this.CharGend.Name = "CharGend";
            this.CharGend.Width = 80;
            // 
            // CharClass
            // 
            this.CharClass.HeaderText = "Class";
            this.CharClass.Name = "CharClass";
            this.CharClass.Width = 60;
            // 
            // CharRace
            // 
            this.CharRace.HeaderText = "Race";
            this.CharRace.Name = "CharRace";
            this.CharRace.Width = 70;
            // 
            // CharID
            // 
            this.CharID.HeaderText = "CharacterID";
            this.CharID.Name = "CharID";
            this.CharID.Visible = false;
            // 
            // btnAdd2Pt
            // 
            this.btnAdd2Pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2Pt.Location = new System.Drawing.Point(341, 307);
            this.btnAdd2Pt.Name = "btnAdd2Pt";
            this.btnAdd2Pt.Size = new System.Drawing.Size(251, 39);
            this.btnAdd2Pt.TabIndex = 0;
            this.btnAdd2Pt.Text = "&Add to Party";
            this.btnAdd2Pt.UseVisualStyleBackColor = true;
            this.btnAdd2Pt.Click += new System.EventHandler(this.btnAdd2Pt_Click);
            // 
            // btnRemovePt
            // 
            this.btnRemovePt.AutoSize = true;
            this.btnRemovePt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePt.Location = new System.Drawing.Point(341, 352);
            this.btnRemovePt.Name = "btnRemovePt";
            this.btnRemovePt.Size = new System.Drawing.Size(251, 39);
            this.btnRemovePt.TabIndex = 7;
            this.btnRemovePt.Text = "Re&move from Party";
            this.btnRemovePt.UseVisualStyleBackColor = true;
            this.btnRemovePt.Click += new System.EventHandler(this.btnRemovePt_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(623, 352);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(135, 41);
            this.btnReturnMenu.TabIndex = 5;
            this.btnReturnMenu.Text = "&Return to Menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.Location = new System.Drawing.Point(341, 261);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(251, 29);
            this.txtbxSearch.TabIndex = 7;
            this.txtbxSearch.Enter += new System.EventHandler(this.OnEnterSearch);
            this.txtbxSearch.Leave += new System.EventHandler(this.OnLeaveSearch);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Location = new System.Drawing.Point(337, 238);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(76, 20);
            this.lblAddUser.TabIndex = 9;
            this.lblAddUser.Text = "Add User";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(623, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // btnSelectChar
            // 
            this.btnSelectChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectChar.Location = new System.Drawing.Point(341, 353);
            this.btnSelectChar.Name = "btnSelectChar";
            this.btnSelectChar.Size = new System.Drawing.Size(251, 39);
            this.btnSelectChar.TabIndex = 2;
            this.btnSelectChar.Text = "Select Character";
            this.btnSelectChar.UseVisualStyleBackColor = true;
            this.btnSelectChar.Click += new System.EventHandler(this.btnSelectChar_Click);
            // 
            // btnDeleteParty
            // 
            this.btnDeleteParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteParty.Location = new System.Drawing.Point(623, 265);
            this.btnDeleteParty.Name = "btnDeleteParty";
            this.btnDeleteParty.Size = new System.Drawing.Size(135, 39);
            this.btnDeleteParty.TabIndex = 12;
            this.btnDeleteParty.Text = "&Delete";
            this.btnDeleteParty.UseVisualStyleBackColor = true;
            this.btnDeleteParty.Visible = false;
            // 
            // btnLoadParty
            // 
            this.btnLoadParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadParty.Location = new System.Drawing.Point(623, 265);
            this.btnLoadParty.Name = "btnLoadParty";
            this.btnLoadParty.Size = new System.Drawing.Size(135, 39);
            this.btnLoadParty.TabIndex = 13;
            this.btnLoadParty.Text = "&Load";
            this.btnLoadParty.UseVisualStyleBackColor = true;
            this.btnLoadParty.Visible = false;
            this.btnLoadParty.Click += new System.EventHandler(this.btnLoadParty_Click);
            // 
            // PartyMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 408);
            this.Controls.Add(this.btnLoadParty);
            this.Controls.Add(this.btnDeleteParty);
            this.Controls.Add(this.btnSelectChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnRemovePt);
            this.Controls.Add(this.btnAdd2Pt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PartyMakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartyMakerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbListPartyList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbListCharList)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dbListCharList;
        private System.Windows.Forms.Button btnAdd2Pt;
        private System.Windows.Forms.Button btnRemovePt;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dbListPartyList;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectChar;
        private System.Windows.Forms.DataGridViewTextBoxColumn player;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharGend;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharRace;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharID;
        private System.Windows.Forms.Button btnDeleteParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerID;
        private System.Windows.Forms.TextBox txtPartyCreatorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadParty;
    }
}