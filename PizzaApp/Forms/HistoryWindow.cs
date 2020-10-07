using PizzaApp.Models.Database;
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
            using (AppDBContext db = new AppDBContext())
            {
                dbDataGridView.DataSource = db.OrderHistory.ToList();
            }
        }
    }
}
 