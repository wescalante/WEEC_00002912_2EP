using System.ComponentModel;

namespace HugoAppV2
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(228, 109);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 22);
            this.txtUser.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(138, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 23);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Usuario";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(138, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 26);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(228, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Location = new System.Drawing.Point(138, 195);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(91, 23);
            this.lblAdmin.TabIndex = 10;
            this.lblAdmin.Text = "Admin";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(138, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 26);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña";
            // 
            // chkAdmin
            // 
            this.chkAdmin.Location = new System.Drawing.Point(235, 195);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(23, 24);
            this.chkAdmin.TabIndex = 12;
            this.chkAdmin.Text = "checkBox1";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;

        #endregion
    }
}