namespace banking_system.Pages
{
    partial class frmCustomerDashboard
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTransFerMoney = new System.Windows.Forms.Button();
            this.btnMakePayments = new System.Windows.Forms.Button();
            this.btnManagePayees = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.btnTransFerMoney);
            this.pnlMenu.Controls.Add(this.btnMakePayments);
            this.pnlMenu.Controls.Add(this.btnManagePayees);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnBalance);
            this.pnlMenu.Controls.Add(this.btnTransactions);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(797, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(183, 627);
            this.pnlMenu.TabIndex = 8;
            // 
            // btnTransFerMoney
            // 
            this.btnTransFerMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransFerMoney.FlatAppearance.BorderSize = 0;
            this.btnTransFerMoney.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnTransFerMoney.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnTransFerMoney.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnTransFerMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransFerMoney.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransFerMoney.ForeColor = System.Drawing.Color.Gold;
            this.btnTransFerMoney.Location = new System.Drawing.Point(0, 245);
            this.btnTransFerMoney.Name = "btnTransFerMoney";
            this.btnTransFerMoney.Size = new System.Drawing.Size(183, 49);
            this.btnTransFerMoney.TabIndex = 9;
            this.btnTransFerMoney.Text = "Money Transfer ";
            this.btnTransFerMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransFerMoney.UseVisualStyleBackColor = true;
            this.btnTransFerMoney.Click += new System.EventHandler(this.btnTransFerMoney_Click);
            // 
            // btnMakePayments
            // 
            this.btnMakePayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakePayments.FlatAppearance.BorderSize = 0;
            this.btnMakePayments.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnMakePayments.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnMakePayments.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnMakePayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakePayments.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayments.ForeColor = System.Drawing.Color.Gold;
            this.btnMakePayments.Location = new System.Drawing.Point(0, 196);
            this.btnMakePayments.Name = "btnMakePayments";
            this.btnMakePayments.Size = new System.Drawing.Size(183, 49);
            this.btnMakePayments.TabIndex = 8;
            this.btnMakePayments.Text = "Payments";
            this.btnMakePayments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMakePayments.UseVisualStyleBackColor = true;
            this.btnMakePayments.Click += new System.EventHandler(this.btnMakePayments_Click);
            // 
            // btnManagePayees
            // 
            this.btnManagePayees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePayees.FlatAppearance.BorderSize = 0;
            this.btnManagePayees.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnManagePayees.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnManagePayees.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnManagePayees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePayees.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePayees.ForeColor = System.Drawing.Color.Gold;
            this.btnManagePayees.Location = new System.Drawing.Point(0, 147);
            this.btnManagePayees.Name = "btnManagePayees";
            this.btnManagePayees.Size = new System.Drawing.Size(183, 49);
            this.btnManagePayees.TabIndex = 4;
            this.btnManagePayees.Text = "My Payees";
            this.btnManagePayees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManagePayees.UseVisualStyleBackColor = true;
            this.btnManagePayees.Click += new System.EventHandler(this.btnManagePayees_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gold;
            this.btnLogout.Location = new System.Drawing.Point(0, 578);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(183, 49);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalance.FlatAppearance.BorderSize = 0;
            this.btnBalance.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnBalance.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.Gold;
            this.btnBalance.Location = new System.Drawing.Point(0, 98);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(183, 49);
            this.btnBalance.TabIndex = 6;
            this.btnBalance.Text = "Account Balances";
            this.btnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Gold;
            this.btnTransactions.Location = new System.Drawing.Point(0, 49);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(183, 49);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "ALL TRANS";
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Gold;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(183, 49);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(189, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 32);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Customer Reviews";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 49);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(797, 578);
            this.pnlFormLoader.TabIndex = 9;
            // 
            // frmCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 627);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerDashboard";
            this.Load += new System.EventHandler(this.frmCustomerDashboard_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnManagePayees;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Button btnMakePayments;
        private System.Windows.Forms.Button btnTransFerMoney;
    }
}