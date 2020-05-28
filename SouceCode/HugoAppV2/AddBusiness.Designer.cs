using System.ComponentModel;

namespace HugoAppV2
{
    partial class AddBusiness
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(337, 119);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 22);
            this.txtDescription.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(337, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(247, 122);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Descripcion";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(247, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 26);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Nombre";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "AddBusiness";
            this.Text = "AddBusiness";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;

        #endregion
    }
}