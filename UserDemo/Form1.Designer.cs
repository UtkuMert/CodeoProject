namespace UserDemo
{
    partial class Form1
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
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.gbxAddUser = new System.Windows.Forms.GroupBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            this.gbxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUser
            // 
            this.dgwUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Location = new System.Drawing.Point(36, 30);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.Size = new System.Drawing.Size(503, 210);
            this.dgwUser.TabIndex = 0;
            // 
            // gbxAddUser
            // 
            this.gbxAddUser.Controls.Add(this.btnAddUser);
            this.gbxAddUser.Controls.Add(this.tbxPassword);
            this.gbxAddUser.Controls.Add(this.tbxUsername);
            this.gbxAddUser.Controls.Add(this.lblPassword);
            this.gbxAddUser.Controls.Add(this.lblName);
            this.gbxAddUser.Location = new System.Drawing.Point(593, 33);
            this.gbxAddUser.Name = "gbxAddUser";
            this.gbxAddUser.Size = new System.Drawing.Size(423, 207);
            this.gbxAddUser.TabIndex = 1;
            this.gbxAddUser.TabStop = false;
            this.gbxAddUser.Text = "Add an User";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(137, 73);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(139, 20);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(137, 37);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(139, 20);
            this.tbxUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(44, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Username";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(186, 110);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 29);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 507);
            this.Controls.Add(this.gbxAddUser);
            this.Controls.Add(this.dgwUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            this.gbxAddUser.ResumeLayout(false);
            this.gbxAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.GroupBox gbxAddUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnAddUser;
    }
}

