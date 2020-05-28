using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var sql = $"DELETE FROM APPUSER WHERE username = '{txtUsername.Text}'";
            
            Conection.DoAction(sql);
            MessageBox.Show("Eliminado");
            this.Hide();
            new MainMenu().Show();
        }
    }
}