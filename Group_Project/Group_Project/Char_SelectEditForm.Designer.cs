namespace Group_Project
{
    partial class Char_SelectEditForm
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
            this.btnLoadChar = new System.Windows.Forms.Button();
            this.btnCreateChar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadChar
            // 
            this.btnLoadChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadChar.Location = new System.Drawing.Point(144, 34);
            this.btnLoadChar.Name = "btnLoadChar";
            this.btnLoadChar.Size = new System.Drawing.Size(126, 38);
            this.btnLoadChar.TabIndex = 0;
            this.btnLoadChar.Text = "Load Character";
            this.btnLoadChar.UseVisualStyleBackColor = true;
            this.btnLoadChar.Click += new System.EventHandler(this.btnLoadChar_Click);
            // 
            // btnCreateChar
            // 
            this.btnCreateChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateChar.Location = new System.Drawing.Point(12, 34);
            this.btnCreateChar.Name = "btnCreateChar";
            this.btnCreateChar.Size = new System.Drawing.Size(126, 38);
            this.btnCreateChar.TabIndex = 1;
            this.btnCreateChar.Text = "Create Character";
            this.btnCreateChar.UseVisualStyleBackColor = true;
            this.btnCreateChar.Click += new System.EventHandler(this.btnCreateChar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an option below.";
            // 
            // Char_SelectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 84);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateChar);
            this.Controls.Add(this.btnLoadChar);
            this.Name = "Char_SelectEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadChar;
        private System.Windows.Forms.Button btnCreateChar;
        private System.Windows.Forms.Label label1;
    }
}