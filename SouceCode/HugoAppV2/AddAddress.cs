using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class AddAddress : Form
    {
        public AddAddress()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                        var sql =
                            $"INSERT INTO ADDRESS (address, idUser) VALUES('{txtAddress.Text}', {txtIDUser.Text})";
                        //     
                        Conection.DoAction(sql);
                        
                        MessageBox.Show("Agregado");
                        this.Hide();
                        new MainMenuRegular().Show();
        }
    }
}