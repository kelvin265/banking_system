namespace banking_system.Pages
{
    partial class frmManagePayees
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
            this.btnUpdatePayee = new System.Windows.Forms.Button();
            this.btnNewPayee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeletePayee = new System.Windows.Forms.Button();
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
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdatePayee
            // 
            this.btnUpdatePayee.FlatAppearance.BorderSize = 2;
            this.btnUpdatePayee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdatePayee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePayee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePayee.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdatePayee.Location = new System.Drawing.Point(148, 12);
            this.btnUpdatePayee.Name = "btnUpdatePayee";
            this.btnUpdatePayee.Size = new System.Drawing.Size(128, 49);
            this.btnUpdatePayee.TabIndex = 17;
            this.btnUpdatePayee.Text = "UPDATE PAYEE";
            this.btnUpdatePayee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdatePayee.UseVisualStyleBackColor = true;
            this.btnUpdatePayee.Click += new System.EventHandler(this.btnUpdatePayee_Click);
            // 
            // btnNewPayee
            // 
            this.btnNewPayee.FlatAppearance.BorderSize = 2;
            this.btnNewPayee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNewPayee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPayee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPayee.ForeColor = System.Drawing.Color.Gold;
            this.btnNewPayee.Location = new System.Drawing.Point(11, 12);
            this.btnNewPayee.Name = "btnNewPayee";
            this.btnNewPayee.Size = new System.Drawing.Size(131, 49);
            this.btnNewPayee.TabIndex = 16;
            this.btnNewPayee.Text = "NEW PAYEE";
            this.btnNewPayee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNewPayee.UseVisualStyleBackColor = true;
            this.btnNewPayee.Click += new System.EventHandler(this.btnNewPayee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payee,
            this.Firstname,
            this.Lastname,
            this.AccountNumber,
            this.edit});
            this.dataGridView1.Location = new System.Drawing.Point(11, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 443);
            this.dataGridView1.TabIndex = 19;
            // 
            // payee
            // 
            this.payee.HeaderText = "Payee Id";
            this.payee.Name = "payee";
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.Width = 170;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.Width = 170;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 170;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDeletePayee
            // 
            this.btnDeletePayee.FlatAppearance.BorderSize = 2;
            this.btnDeletePayee.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDeletePayee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePayee.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayee.ForeColor = System.Drawing.Color.Gold;
            this.btnDeletePayee.Location = new System.Drawing.Point(282, 12);
            this.btnDeletePayee.Name = "btnDeletePayee";
            this.btnDeletePayee.Size = new System.Drawing.Size(129, 49);
            this.btnDeletePayee.TabIndex = 20;
            this.btnDeletePayee.Text = "DELETE PAYEE";
            this.btnDeletePayee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeletePayee.UseVisualStyleBackColor = true;
            this.btnDeletePayee.Click += new System.EventHandler(this.btnDeletePayee_Click);
            // 
            // frmManagePayees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 539);
            this.Controls.Add(this.btnDeletePayee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnUpdatePayee);
            this.Controls.Add(this.btnNewPayee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePayees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagePayees";
            this.Load += new System.EventHandler(this.frmManagePayees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdatePayee;
        private System.Windows.Forms.Button btnNewPayee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletePayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn payee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn edit;
    }
}