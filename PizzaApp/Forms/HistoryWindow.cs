using PizzaApp.Models.Database;
using PizzaApp.OutputMessages;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class HistoryWindow : Form
    {
        Thread mainWindow;
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            mainWindow = new Thread(Helpers.OpenNewWindow<MainWindow>);
            mainWindow.SetApartmentState(ApartmentState.STA);
            mainWindow.Start();
        }
    }
}