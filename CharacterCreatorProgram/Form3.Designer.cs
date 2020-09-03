namespace CharacterCreatorProgram
{
    partial class FRM_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Class));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxRaces = new System.Windows.Forms.ListBox();
            this.lblRaceDesc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(342, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(261, 185);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbxRaces);
            this.groupBox1.Controls.Add(this.lblRaceDesc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Options";
            // 
            // lbxRaces
            // 
            this.lbxRaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxRaces.FormattingEnabled = true;
            this.lbxRaces.ItemHeight = 15;
            this.lbxRaces.Items.AddRange(new object[] {
            "Brute",
            "Guardsman",
            "Oracle",
            "Archon",
            "Huntsman",
            "Reprobate",
            "Reaper",
            "Caster",
            "Elementalist"});
            this.lbxRaces.Location = new System.Drawing.Point(6, 20);
            this.lbxRaces.Name = "lbxRaces";
            this.lbxRaces.Size = new System.Drawing.Size(155, 137);
            this.lbxRaces.TabIndex = 2;
            // 
            // lblRaceDesc
            // 
            this.lblRaceDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRaceDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRaceDesc.Location = new System.Drawing.Point(167, 20);
            this.lblRaceDesc.Name = "lblRaceDesc";
            this.lblRaceDesc.Size = new System.Drawing.Size(225, 137);
            this.lblRaceDesc.TabIndex = 1;
            // 
            // FRM_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_Class";
            this.Text = "Classes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxRaces;
        private System.Windows.Forms.Label lblRaceDesc;
    }
}