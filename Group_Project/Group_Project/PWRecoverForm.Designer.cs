namespace Group_Project
{
    partial class PWRecoverForm
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
            this.gbxRecoverPW = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail_In = new System.Windows.Forms.TextBox();
            this.btnRecover = new System.Windows.Forms.Button();
            this.gbxSecurity = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecurityQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecurAnw = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxChangePW = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPW = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPW = new System.Windows.Forms.TextBox();
            this.btnChangePW = new System.Windows.Forms.Button();
            this.gbxRecoverPW.SuspendLayout();
            this.gbxSecurity.SuspendLayout();
            this.gbxChangePW.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRecoverPW
            // 
            this.gbxRecoverPW.Controls.Add(this.btnRecover);
            this.gbxRecoverPW.Controls.Add(this.txtEmail_In);
            this.gbxRecoverPW.Controls.Add(this.label1);
            this.gbxRecoverPW.Location = new System.Drawing.Point(12, 12);
            this.gbxRecoverPW.Name = "gbxRecoverPW";
            this.gbxRecoverPW.Size = new System.Drawing.Size(641, 105);
            this.gbxRecoverPW.TabIndex = 0;
            this.gbxRecoverPW.TabStop = false;
            this.gbxRecoverPW.Text = "Recover Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Email";
            // 
            // txtEmail_In
            // 
            this.txtEmail_In.Location = new System.Drawing.Point(229, 40);
            this.txtEmail_In.Name = "txtEmail_In";
            this.txtEmail_In.Size = new System.Drawing.Size(291, 30);
            this.txtEmail_In.TabIndex = 1;
            // 
            // btnRecover
            // 
            this.btnRecover.AutoSize = true;
            this.btnRecover.Location = new System.Drawing.Point(532, 38);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(94, 35);
            this.btnRecover.TabIndex = 2;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // gbxSecurity
            // 
            this.gbxSecurity.Controls.Add(this.btnSubmit);
            this.gbxSecurity.Controls.Add(this.txtSecurAnw);
            this.gbxSecurity.Controls.Add(this.label3);
            this.gbxSecurity.Controls.Add(this.txtSecurityQ);
            this.gbxSecurity.Controls.Add(this.label2);
            this.gbxSecurity.Location = new System.Drawing.Point(13, 124);
            this.gbxSecurity.Name = "gbxSecurity";
            this.gbxSecurity.Size = new System.Drawing.Size(640, 138);
            this.gbxSecurity.TabIndex = 1;
            this.gbxSecurity.TabStop = false;
            this.gbxSecurity.Text = "Security Question and Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Security Question";
            // 
            // txtSecurityQ
            // 
            this.txtSecurityQ.Location = new System.Drawing.Point(228, 39);
            this.txtSecurityQ.Name = "txtSecurityQ";
            this.txtSecurityQ.ReadOnly = true;
            this.txtSecurityQ.Size = new System.Drawing.Size(292, 30);
            this.txtSecurityQ.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer";
            // 
            // txtSecurAnw
            // 
            this.txtSecurAnw.Location = new System.Drawing.Point(228, 81);
            this.txtSecurAnw.Name = "txtSecurAnw";
            this.txtSecurAnw.Size = new System.Drawing.Size(292, 30);
            this.txtSecurAnw.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(531, 39);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 70);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxChangePW
            // 
            this.gbxChangePW.Controls.Add(this.btnChangePW);
            this.gbxChangePW.Controls.Add(this.txtConfirmNewPW);
            this.gbxChangePW.Controls.Add(this.txtNewPW);
            this.gbxChangePW.Controls.Add(this.label5);
            this.gbxChangePW.Controls.Add(this.label4);
            this.gbxChangePW.Location = new System.Drawing.Point(12, 278);
            this.gbxChangePW.Name = "gbxChangePW";
            this.gbxChangePW.Size = new System.Drawing.Size(641, 147);
            this.gbxChangePW.TabIndex = 2;
            this.gbxChangePW.TabStop = false;
            this.gbxChangePW.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm New Password";
            // 
            // txtNewPW
            // 
            this.txtNewPW.Location = new System.Drawing.Point(230, 43);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.Size = new System.Drawing.Size(291, 30);
            this.txtNewPW.TabIndex = 2;
            // 
            // txtConfirmNewPW
            // 
            this.txtConfirmNewPW.Location = new System.Drawing.Point(230, 85);
            this.txtConfirmNewPW.Name = "txtConfirmNewPW";
            this.txtConfirmNewPW.Size = new System.Drawing.Size(291, 30);
            this.txtConfirmNewPW.TabIndex = 3;
            // 
            // btnChangePW
            // 
            this.btnChangePW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePW.Location = new System.Drawing.Point(532, 43);
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.Size = new System.Drawing.Size(94, 72);
            this.btnChangePW.TabIndex = 4;
            this.btnChangePW.Text = "Change Password";
            this.btnChangePW.UseVisualStyleBackColor = true;
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // PWRecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 448);
            this.Controls.Add(this.gbxChangePW);
            this.Controls.Add(this.gbxSecurity);
            this.Controls.Add(this.gbxRecoverPW);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PWRecoverForm";
            this.Text = "PWRecoverForm";
            this.Load += new System.EventHandler(this.PWRecoverForm_Load);
            this.gbxRecoverPW.ResumeLayout(false);
            this.gbxRecoverPW.PerformLayout();
            this.gbxSecurity.ResumeLayout(false);
            this.gbxSecurity.PerformLayout();
            this.gbxChangePW.ResumeLayout(false);
            this.gbxChangePW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRecoverPW;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.TextBox txtEmail_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSecurity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSecurAnw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecurityQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxChangePW;
        private System.Windows.Forms.Button btnChangePW;
        private System.Windows.Forms.TextBox txtConfirmNewPW;
        private System.Windows.Forms.TextBox txtNewPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}