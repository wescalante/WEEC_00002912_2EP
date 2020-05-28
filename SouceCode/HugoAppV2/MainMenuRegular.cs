using System;
using System.Windows.Forms;

namespace HugoAppV2
{
    public partial class MainMenuRegular : Form
    {
        public MainMenuRegular()
        {
            InitializeComponent();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAddress().Show();
        }

        private void btnRemoveAddress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteAddress().Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddOrder().Show();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteOrder().Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewHistory().Show();
        }
    }
}