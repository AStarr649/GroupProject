namespace Group_Project
{
    partial class PartySelectEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadAllParties = new System.Windows.Forms.Button();
            this.btnLoadPlayerParties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose an option below.";
            // 
            // btnLoadAllParties
            // 
            this.btnLoadAllParties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAllParties.Location = new System.Drawing.Point(12, 38);
            this.btnLoadAllParties.Name = "btnLoadAllParties";
            this.btnLoadAllParties.Size = new System.Drawing.Size(126, 38);
            this.btnLoadAllParties.TabIndex = 4;
            this.btnLoadAllParties.Text = "View All Parties";
            this.btnLoadAllParties.UseVisualStyleBackColor = true;
            this.btnLoadAllParties.Click += new System.EventHandler(this.btnLoadAllParties_Click);
            // 
            // btnLoadPlayerParties
            // 
            this.btnLoadPlayerParties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPlayerParties.Location = new System.Drawing.Point(144, 38);
            this.btnLoadPlayerParties.Name = "btnLoadPlayerParties";
            this.btnLoadPlayerParties.Size = new System.Drawing.Size(126, 38);
            this.btnLoadPlayerParties.TabIndex = 3;
            this.btnLoadPlayerParties.Text = "Your Parties";
            this.btnLoadPlayerParties.UseVisualStyleBackColor = true;
            this.btnLoadPlayerParties.Click += new System.EventHandler(this.btnLoadPlayerParties_Click);
            // 
            // PartySelectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadAllParties);
            this.Controls.Add(this.btnLoadPlayerParties);
            this.Name = "PartySelectEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartySelectEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadAllParties;
        private System.Windows.Forms.Button btnLoadPlayerParties;
    }
}