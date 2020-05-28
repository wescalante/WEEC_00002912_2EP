using System.ComponentModel;

namespace HugoAppV2
{
    partial class MainMenu
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.btnRemoveBusiness = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(225, 92);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(348, 31);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Agregar usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(225, 140);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(348, 31);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Eliminar usuario";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Location = new System.Drawing.Point(225, 189);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(348, 31);
            this.btnAddBusiness.TabIndex = 2;
            this.btnAddBusiness.Text = "Agregar negocio";
            this.btnAddBusiness.UseVisualStyleBackColor = true;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // btnRemoveBusiness
            // 
            this.btnRemoveBusiness.Location = new System.Drawing.Point(225, 238);
            this.btnRemoveBusiness.Name = "btnRemoveBusiness";
            this.btnRemoveBusiness.Size = new System.Drawing.Size(348, 31);
            this.btnRemoveBusiness.TabIndex = 3;
            this.btnRemoveBusiness.Text = "Eliminar negocio";
            this.btnRemoveBusiness.UseVisualStyleBackColor = true;
            this.btnRemoveBusiness.Click += new System.EventHandler(this.btnRemoveBusiness_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(225, 284);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(348, 31);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Agregar producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(225, 331);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(348, 31);
            this.btnRemoveProduct.TabIndex = 5;
            this.btnRemoveProduct.Text = "Eliminar producto";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(225, 378);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(348, 31);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "Ver historial";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnRemoveBusiness);
            this.Controls.Add(this.btnAddBusiness);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddUser);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRemoveBusiness;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnRemoveUser;

        #endregion
    }
}