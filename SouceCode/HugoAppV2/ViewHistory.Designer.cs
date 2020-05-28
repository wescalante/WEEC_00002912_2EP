using System.ComponentModel;

namespace HugoAppV2
{
    partial class ViewHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblHistory
            // 
            this.lblHistory.Location = new System.Drawing.Point(54, 20);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(712, 49);
            this.lblHistory.TabIndex = 1;
            this.lblHistory.Text = "Historial de ordenes";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(639, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 42);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewHistory";
            this.Text = "ViewHistory";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHistory;

        #endregion
    }
}