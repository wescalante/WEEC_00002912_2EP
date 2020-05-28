using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var sql = $"DELETE FROM PRODUCT WHERE name = '{txtProduct.Text}'";
            
            Conection.DoAction(sql);
            MessageBox.Show("Eliminado");
            this.Hide();
            new MainMenu().Show();
        }
    }
}