using System.ComponentModel;

namespace HugoAppV2
{
    partial class AddAddress
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
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.lblIDUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIDUser
            // 
            this.txtIDUser.Location = new System.Drawing.Point(317, 200);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(211, 22);
            this.txtIDUser.TabIndex = 27;
            // 
            // lblIDUser
            // 
            this.lblIDUser.Location = new System.Drawing.Point(227, 203);
            this.lblIDUser.Name = "lblIDUser";
            this.lblIDUser.Size = new System.Drawing.Size(91, 26);
            this.lblIDUser.TabIndex = 26;
            this.lblIDUser.Text = "ID Cliente";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(317, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 22);
            this.txtAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(227, 155);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 26);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Direccion";
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.lblIDUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Name = "AddAddress";
            this.Text = "AddAddress";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIDUser;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIDUser;

        #endregion
    }
}