using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidateUser();
            
        }

        public void ValidateUser()
        {
            var sql =
                $"SELECT userType FROM public.APPUSER WHERE username='{txtUsername.Text}' AND password='{txtPassword.Text}'";

            var conn = Conection.QueryDB(sql);
            

            if (conn.Rows.Count==0)
            {
                MessageBox.Show("Usuario inválido. Intente de nuevo.");
            }
            else
            {
                string isAdmin = conn.Rows[0][0].ToString();
                //MessageBox.Show(Convert.ToString(isAdmin));
                if (isAdmin == "True")
                {
                    MessageBox.Show("Login exitoso");
                    this.Hide();
                    new MainMenu().Show();
                    
                }
                else
                {
                    MessageBox.Show("Login exitoso");
                    this.Hide();
                    new MainMenuRegular().Show();
                    
                }
            }
        }
    }
}