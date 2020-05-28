using System.ComponentModel;

namespace HugoAppV2
{
    partial class DeleteProduct
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.btnCancel.Location = new System.Drawing.Point(446, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 47);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnConfirm.Location = new System.Drawing.Point(201, 252);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(153, 47);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.txtProduct.Location = new System.Drawing.Point(234, 177);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(326, 22);
            this.txtProduct.TabIndex = 5;
            this.lblUsername.Location = new System.Drawing.Point(302, 151);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(197, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Ingrese el producto a eliminar";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblUsername);
            this.Name = "DeleteProduct";
            this.Text = "DeleteProduct";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtProduct;

        #endregion
    }
}