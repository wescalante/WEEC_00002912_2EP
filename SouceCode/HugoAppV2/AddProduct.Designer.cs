using System.ComponentModel;

namespace HugoAppV2
{
    partial class AddProduct
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.txtIDNegocio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(317, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(227, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 26);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Nombre";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBusiness
            // 
            this.lblBusiness.Location = new System.Drawing.Point(227, 150);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(91, 26);
            this.lblBusiness.TabIndex = 20;
            this.lblBusiness.Text = "ID Negocio";
            // 
            // txtIDNegocio
            // 
            this.txtIDNegocio.Location = new System.Drawing.Point(317, 147);
            this.txtIDNegocio.Name = "txtIDNegocio";
            this.txtIDNegocio.Size = new System.Drawing.Size(211, 22);
            this.txtIDNegocio.TabIndex = 21;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDNegocio);
            this.Controls.Add(this.lblBusiness);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIDNegocio;
        private System.Windows.Forms.TextBox txtName;

        #endregion
    }
}