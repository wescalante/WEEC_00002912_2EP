using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool usrtype;

            if (chkAdmin.CheckState==(CheckState) 1)
            {
                usrtype = true;
            }
            else
            {
                usrtype = false;
            }
            
            var sql =
                $"INSERT INTO APPUSER (fullname, username, password, userType) VALUES('{txtName.Text}', '{txtUser.Text}', '{txtPassword.Text}', {usrtype})";
            //     
            Conection.DoAction(sql);
            MessageBox.Show("Agregado");
            this.Hide();
            new MainMenu().Show();

            //MessageBox.Show(chkAdmin.ToString());
        }
    }
}