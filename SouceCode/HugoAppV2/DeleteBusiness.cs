using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class DeleteBusiness : Form
    {
        public DeleteBusiness()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var sql = $"DELETE FROM BUSINESS WHERE name = '{txtName.Text}'";
            
            Conection.DoAction(sql);
            MessageBox.Show("Eliminado");
            this.Hide();
            new MainMenu().Show();
        }
    }
}