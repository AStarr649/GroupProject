namespace Group_Project
{
    partial class InfoForm
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
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblObsPass = new System.Windows.Forms.Label();
            this.lblPlayPass = new System.Windows.Forms.Label();
            this.lblDMPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(186, 392);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(112, 35);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "&Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(466, 231);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Observer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dungeon Master";
            // 
            // lblObsPass
            // 
            this.lblObsPass.AutoSize = true;
            this.lblObsPass.Location = new System.Drawing.Point(332, 260);
            this.lblObsPass.Name = "lblObsPass";
            this.lblObsPass.Size = new System.Drawing.Size(52, 20);
            this.lblObsPass.TabIndex = 5;
            this.lblObsPass.Text = "pass7";
            // 
            // lblPlayPass
            // 
            this.lblPlayPass.AutoSize = true;
            this.lblPlayPass.Location = new System.Drawing.Point(332, 305);
            this.lblPlayPass.Name = "lblPlayPass";
            this.lblPlayPass.Size = new System.Drawing.Size(52, 20);
            this.lblPlayPass.TabIndex = 6;
            this.lblPlayPass.Text = "pass3";
            // 
            // lblDMPass
            // 
            this.lblDMPass.AutoSize = true;
            this.lblDMPass.Location = new System.Drawing.Point(332, 350);
            this.lblDMPass.Name = "lblDMPass";
            this.lblDMPass.Size = new System.Drawing.Size(52, 20);
            this.lblDMPass.TabIndex = 7;
            this.lblDMPass.Text = "pass1";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 444);
            this.Controls.Add(this.lblDMPass);
            this.Controls.Add(this.lblPlayPass);
            this.Controls.Add(this.lblObsPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOkay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblObsPass;
        private System.Windows.Forms.Label lblPlayPass;
        private System.Windows.Forms.Label lblDMPass;
    }
}