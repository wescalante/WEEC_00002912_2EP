using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class ViewHistory : Form
    {
        public ViewHistory()
        {
            InitializeComponent();
            var sql =
                $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
            "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                "WHERE ao.idProduct = pr.idProduct " +
            "AND ao.idAddress = ad.idAddress " +
            "AND ad.idUser = au.idUser;";
            
            var sql2 =
                $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
            "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                "WHERE ao.idProduct = pr.idProduct " +
            "AND ao.idAddress = ad.idAddress " +
            "AND ad.idUser = au.idUser " +
            "AND au.idUser = 2;";
            
            
            

            var conn = Conection.QueryDB(sql2);
            dataGridView1.DataSource = conn;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}