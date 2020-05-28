using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class AddBusiness : Form
    {
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sql =
                $"INSERT INTO BUSINESS (name, description) VALUES('{txtName.Text}', '{txtDescription.Text}')";
            //     
            Conection.DoAction(sql);
            
            MessageBox.Show("Agregado");
            this.Hide();
            new MainMenu().Show();
        }
    }
}