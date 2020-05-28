using System.ComponentModel;

namespace HugoAppV2
{
    partial class DeleteBusiness
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 47);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(201, 252);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(153, 47);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 22);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(255, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(287, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "ingrese el nombre del negocio a eliminar";
            // 
            // DeleteBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "DeleteBusiness";
            this.Text = "DeleteBusiness";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        #endregion
    }
}