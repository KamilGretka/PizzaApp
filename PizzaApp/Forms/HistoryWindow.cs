using PizzaApp.Models.Database;
using PizzaApp.OutputMessages;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class HistoryWindow : Form
    {
        public HistoryWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetMainWindowInstance().Show();
        }

        private void HistoryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HistoryWindow_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                using (AppDBContext db = new AppDBContext())
                {
                    dbDataGridView.DataSource = db.OrderHistory.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(UserMessages.DatabaseConnectionProblem, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}