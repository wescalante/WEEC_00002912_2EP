using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddUser().Show();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteUser().Show();
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddBusiness().Show();
        }

        private void btnRemoveBusiness_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteBusiness().Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct().Show();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteProduct().Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewHistory().Show();
        }
    }
}
