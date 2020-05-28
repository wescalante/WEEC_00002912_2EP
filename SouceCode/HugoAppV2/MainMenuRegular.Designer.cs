using System.ComponentModel;

namespace HugoAppV2
{
    partial class MainMenuRegular
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
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnRemoveAddress = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(217, 82);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(348, 31);
            this.btnAddAddress.TabIndex = 1;
            this.btnAddAddress.Text = "Agregar direccion";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(217, 278);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(348, 31);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Ver historial";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRemoveAddress
            // 
            this.btnRemoveAddress.Location = new System.Drawing.Point(217, 133);
            this.btnRemoveAddress.Name = "btnRemoveAddress";
            this.btnRemoveAddress.Size = new System.Drawing.Size(348, 31);
            this.btnRemoveAddress.TabIndex = 3;
            this.btnRemoveAddress.Text = "Eliminar direccion";
            this.btnRemoveAddress.UseVisualStyleBackColor = true;
            this.btnRemoveAddress.Click += new System.EventHandler(this.btnRemoveAddress_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(217, 180);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(348, 31);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Crear orden";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(217, 230);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(348, 31);
            this.btnRemoveOrder.TabIndex = 5;
            this.btnRemoveOrder.Text = "Eliminar orden";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // MainMenuRegular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnRemoveAddress);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnAddAddress);
            this.Name = "MainMenuRegular";
            this.Text = "MainMenuRegular";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRemoveAddress;
        private System.Windows.Forms.Button btnRemoveOrder;

        #endregion
    }
}