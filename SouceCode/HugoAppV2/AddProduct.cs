using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sql =
                $"INSERT INTO PRODUCT (name, idBusiness) VALUES('{txtName.Text}', {txtIDNegocio.Text})";
            //     
            Conection.DoAction(sql);
            MessageBox.Show("Agregado");
            this.Hide();
            new MainMenu().Show();
        }
    }
}