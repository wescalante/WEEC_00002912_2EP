using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var sql = $"DELETE FROM APPORDER WHERE idOrder = {txtIDOrder.Text}";
            
            Conection.DoAction(sql);
            MessageBox.Show("Eliminado");
            this.Hide();
            new MainMenuRegular().Show();
        }
    }
}