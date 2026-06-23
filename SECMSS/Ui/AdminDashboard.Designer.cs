namespace SECMSS.Ui
{
    partial class AdminDashboard
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearchReportOwner = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearchUserReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(25, 77);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1577, 248);
            this.dgvUsers.TabIndex = 0;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(25, 362);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(1577, 215);
            this.dgvReports.TabIndex = 1;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(1229, 32);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(373, 26);
            this.txtSearchId.TabIndex = 2;
            // 
            // btnSearchReportOwner
            // 
            this.btnSearchReportOwner.Location = new System.Drawing.Point(74, 597);
            this.btnSearchReportOwner.Name = "btnSearchReportOwner";
            this.btnSearchReportOwner.Size = new System.Drawing.Size(213, 40);
            this.btnSearchReportOwner.TabIndex = 3;
            this.btnSearchReportOwner.Text = "Find Report\'s Owner";
            this.btnSearchReportOwner.UseVisualStyleBackColor = true;
            this.btnSearchReportOwner.Click += new System.EventHandler(this.btnSearchReportOwner_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1469, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Logout";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchUserReports
            // 
            this.btnSearchUserReports.Location = new System.Drawing.Point(382, 597);
            this.btnSearchUserReports.Name = "btnSearchUserReports";
            this.btnSearchUserReports.Size = new System.Drawing.Size(187, 40);
            this.btnSearchUserReports.TabIndex = 5;
            this.btnSearchUserReports.Text = "Find User\'s Reports";
            this.btnSearchUserReports.UseVisualStyleBackColor = true;
            this.btnSearchUserReports.Click += new System.EventHandler(this.btnSearchUserReports_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show All Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1287, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SECMSS.Properties.Resources.smart_eco_campus_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 649);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearchUserReports);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearchReportOwner);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.dgvUsers);
            this.DoubleBuffered = true;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearchReportOwner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearchUserReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}