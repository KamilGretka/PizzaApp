using PizzaApp.Logic;
using System;
using System.Windows.Forms;

namespace PizzaApp.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetOrderWindowInstance().Show();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetHistoryWindowInstance().Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}