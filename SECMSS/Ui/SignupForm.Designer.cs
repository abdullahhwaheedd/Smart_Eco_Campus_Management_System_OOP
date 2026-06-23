namespace SECMSS.Ui
{
    partial class SignupForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSignupEmail = new System.Windows.Forms.TextBox();
            this.txtSignupPassword = new System.Windows.Forms.TextBox();
            this.txtSignupName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitSignup = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // txtSignupEmail
            // 
            this.txtSignupEmail.Location = new System.Drawing.Point(171, 151);
            this.txtSignupEmail.Name = "txtSignupEmail";
            this.txtSignupEmail.Size = new System.Drawing.Size(457, 26);
            this.txtSignupEmail.TabIndex = 5;
            // 
            // txtSignupPassword
            // 
            this.txtSignupPassword.Location = new System.Drawing.Point(171, 207);
            this.txtSignupPassword.Name = "txtSignupPassword";
            this.txtSignupPassword.Size = new System.Drawing.Size(208, 26);
            this.txtSignupPassword.TabIndex = 6;
            // 
            // txtSignupName
            // 
            this.txtSignupName.Location = new System.Drawing.Point(171, 56);
            this.txtSignupName.Name = "txtSignupName";
            this.txtSignupName.Size = new System.Drawing.Size(353, 26);
            this.txtSignupName.TabIndex = 7;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(171, 105);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 26);
            this.numAge.TabIndex = 8;
            // 
            // btnSubmitSignup
            // 
            this.btnSubmitSignup.Location = new System.Drawing.Point(275, 282);
            this.btnSubmitSignup.Name = "btnSubmitSignup";
            this.btnSubmitSignup.Size = new System.Drawing.Size(177, 57);
            this.btnSubmitSignup.TabIndex = 9;
            this.btnSubmitSignup.Text = "Create Account";
            this.btnSubmitSignup.UseVisualStyleBackColor = true;
            this.btnSubmitSignup.Click += new System.EventHandler(this.btnSubmitSignup_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(625, 282);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SECMSS.Properties.Resources.smart_eco_campus_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1714, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmitSignup);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtSignupName);
            this.Controls.Add(this.txtSignupPassword);
            this.Controls.Add(this.txtSignupEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "SignupForm";
            this.Text = "Email";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSignupEmail;
        private System.Windows.Forms.TextBox txtSignupPassword;
        private System.Windows.Forms.TextBox txtSignupName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Button btnSubmitSignup;
        private System.Windows.Forms.Button btnBack;
    }
}