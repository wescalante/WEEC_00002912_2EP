using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class DeleteAddress : Form
    {
        public DeleteAddress()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var sql = $"DELETE FROM ADDRESS WHERE idAddress = {txtIDAddress.Text}";
            
            Conection.DoAction(sql);
            MessageBox.Show("Eliminado");
            this.Hide();
            new MainMenuRegular().Show();
        }
    }
}