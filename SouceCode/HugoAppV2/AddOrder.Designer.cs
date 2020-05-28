using System.ComponentModel;

namespace HugoAppV2
{
    partial class AddOrder
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
            this.txtIDAddress = new System.Windows.Forms.TextBox();
            this.lblIDAddress = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIDAddress
            // 
            this.txtIDAddress.Location = new System.Drawing.Point(317, 200);
            this.txtIDAddress.Name = "txtIDAddress";
            this.txtIDAddress.Size = new System.Drawing.Size(211, 22);
            this.txtIDAddress.TabIndex = 27;
            // 
            // lblIDAddress
            // 
            this.lblIDAddress.Location = new System.Drawing.Point(227, 203);
            this.lblIDAddress.Name = "lblIDAddress";
            this.lblIDAddress.Size = new System.Drawing.Size(91, 26);
            this.lblIDAddress.TabIndex = 26;
            this.lblIDAddress.Text = "ID Direccion";
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
            // txtIDProduct
            // 
            this.txtIDProduct.Location = new System.Drawing.Point(317, 152);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.Size = new System.Drawing.Size(211, 22);
            this.txtIDProduct.TabIndex = 23;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.Location = new System.Drawing.Point(227, 155);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(91, 26);
            this.lblIDProduct.TabIndex = 22;
            this.lblIDProduct.Text = "ID Producto";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDAddress);
            this.Controls.Add(this.lblIDAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIDProduct);
            this.Controls.Add(this.lblIDProduct);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIDAddress;
        private System.Windows.Forms.Label lblIDProduct;
        private System.Windows.Forms.TextBox txtIDAddress;
        private System.Windows.Forms.TextBox txtIDProduct;

        #endregion
    }
}