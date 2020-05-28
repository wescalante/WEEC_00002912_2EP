using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sql =
                $"INSERT INTO APPORDER (createDate, idProduct, idAddress) VALUES('26-05-2020',{txtIDProduct.Text}, {txtIDAddress.Text})";
            //     
            Conection.DoAction(sql);
            MessageBox.Show("Agregado");
            this.Hide();
            new MainMenuRegular().Show();
        }
    }
}