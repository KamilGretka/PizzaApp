using System;
using System.Windows.Forms;

namespace PizzaApp.Forms
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetOrderWindowInstance().Show();
        }

        private void ShopCart_VisibleChanged(object sender, EventArgs e)
        {
            ShopCartGridView.DataSource = null;
            var orderWindow = WindowsManagement.GetOrderWindowInstance();
            ShopCartGridView.DataSource = orderWindow.orderList;
        }

        private void ShopCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
