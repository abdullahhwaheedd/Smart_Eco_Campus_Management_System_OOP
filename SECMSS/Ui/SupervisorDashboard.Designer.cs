namespace SECMSS.Ui
{
    partial class SupervisorDashboard
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
            this.dgvAllReports = new System.Windows.Forms.DataGridView();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllReports
            // 
            this.dgvAllReports.AllowUserToAddRows = false;
            this.dgvAllReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAllReports.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAllReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllReports.Location = new System.Drawing.Point(12, 101);
            this.dgvAllReports.Name = "dgvAllReports";
            this.dgvAllReports.ReadOnly = true;
            this.dgvAllReports.RowHeadersVisible = false;
            this.dgvAllReports.RowHeadersWidth = 62;
            this.dgvAllReports.RowTemplate.Height = 28;
            this.dgvAllReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllReports.Size = new System.Drawing.Size(1328, 269);
            this.dgvAllReports.TabIndex = 1;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(51, 463);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(199, 37);
            this.btnLoadAll.TabIndex = 2;
            this.btnLoadAll.Text = "Refresh Campus List";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Cyan;
            this.btnAssign.Location = new System.Drawing.Point(339, 463);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(188, 37);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign Selected Task";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click_1);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.LawnGreen;
            this.btnComplete.Location = new System.Drawing.Point(820, 459);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(181, 41);
            this.btnComplete.TabIndex = 4;
            this.btnComplete.Text = "Mark As Completed";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(75, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SupervisorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SECMSS.Properties.Resources.smart_eco_campus_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1756, 654);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.dgvAllReports);
            this.DoubleBuffered = true;
            this.Name = "SupervisorDashboard";
            this.Text = "SupervisorDashboard";
            this.Load += new System.EventHandler(this.SupervisorDashboard_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllReports;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnBack;
    }
}