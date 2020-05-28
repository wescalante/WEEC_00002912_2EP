using System.ComponentModel;

namespace HugoAppV2
{
    partial class DeleteOrder
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
            this.txtIDOrder = new System.Windows.Forms.TextBox();
            this.lblIDOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 47);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(201, 252);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(153, 47);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Location = new System.Drawing.Point(234, 177);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.Size = new System.Drawing.Size(326, 22);
            this.txtIDOrder.TabIndex = 13;
            // 
            // lblIDOrder
            // 
            this.lblIDOrder.Location = new System.Drawing.Point(260, 151);
            this.lblIDOrder.Name = "lblIDOrder";
            this.lblIDOrder.Size = new System.Drawing.Size(266, 23);
            this.lblIDOrder.TabIndex = 12;
            this.lblIDOrder.Text = "Ingrese el ID de la orden a eliminar";
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtIDOrder);
            this.Controls.Add(this.lblIDOrder);
            this.Name = "DeleteOrder";
            this.Text = "DeleteOrder";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblIDOrder;
        private System.Windows.Forms.TextBox txtIDOrder;

        #endregion
    }
}