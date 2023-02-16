namespace banking_system.Pages
{
    partial class frmMakePayments
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNewPayee = new System.Windows.Forms.Button();
            this.btnExistingPayee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Threshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 2;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Gold;
            this.btnLoad.Location = new System.Drawing.Point(696, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(73, 33);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNewPayee
            // 
            this.btnNewPayee.FlatAppearance.BorderSize = 2;
            this.btnNewPayee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNewPayee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPayee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPayee.ForeColor = System.Drawing.Color.Gold;
            this.btnNewPayee.Location = new System.Drawing.Point(213, 12);
            this.btnNewPayee.Name = "btnNewPayee";
            this.btnNewPayee.Size = new System.Drawing.Size(183, 49);
            this.btnNewPayee.TabIndex = 22;
            this.btnNewPayee.Text = "NEW PAYEE";
            this.btnNewPayee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNewPayee.UseVisualStyleBackColor = true;
            this.btnNewPayee.Click += new System.EventHandler(this.btnNewPayee_Click_1);
            // 
            // btnExistingPayee
            // 
            this.btnExistingPayee.FlatAppearance.BorderSize = 2;
            this.btnExistingPayee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnExistingPayee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExistingPayee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingPayee.ForeColor = System.Drawing.Color.Gold;
            this.btnExistingPayee.Location = new System.Drawing.Point(12, 12);
            this.btnExistingPayee.Name = "btnExistingPayee";
            this.btnExistingPayee.Size = new System.Drawing.Size(183, 49);
            this.btnExistingPayee.TabIndex = 21;
            this.btnExistingPayee.Text = "EXISTING PAYEE";
            this.btnExistingPayee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExistingPayee.UseVisualStyleBackColor = true;
            this.btnExistingPayee.Click += new System.EventHandler(this.btnExistingPayee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 118;
            this.label1.Text = "SELECT ACCOUNT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.Account_Type,
            this.interest,
            this.Balance,
            this.Status,
            this.Threshold,
            this.edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 403);
            this.dataGridView1.TabIndex = 119;
            // 
            // idd
            // 
            this.idd.HeaderText = "idd";
            this.idd.Name = "idd";
            this.idd.Visible = false;
            // 
            // Account_Type
            // 
            this.Account_Type.HeaderText = "Account Type";
            this.Account_Type.Name = "Account_Type";
            this.Account_Type.Width = 140;
            // 
            // interest
            // 
            this.interest.HeaderText = "Interest";
            this.interest.Name = "interest";
            this.interest.Width = 120;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.Width = 140;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 140;
            // 
            // Threshold
            // 
            this.Threshold.HeaderText = "Threshold";
            this.Threshold.Name = "Threshold";
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.Width = 70;
            // 
            // frmMakePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNewPayee);
            this.Controls.Add(this.btnExistingPayee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMakePayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMakePayments";
            this.Load += new System.EventHandler(this.frmMakePayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNewPayee;
        private System.Windows.Forms.Button btnExistingPayee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Threshold;
        private System.Windows.Forms.DataGridViewCheckBoxColumn edit;
    }
}