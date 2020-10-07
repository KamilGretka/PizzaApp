using PizzaApp.Models.Database;
using PizzaApp.Output_Messages;
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

        private void HistoryWindow_Load(object sender, EventArgs e)
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