using System;
using System.Threading;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class MainWindow : Form
    {
        Thread orderWindowThread, historyWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Close();
            orderWindowThread = new Thread(Helpers.OpenNewWindow<OrderWindow>);
            orderWindowThread.SetApartmentState(ApartmentState.STA);
            orderWindowThread.Start();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            historyWindow = new Thread(Helpers.OpenNewWindow<HistoryWindow>);
            historyWindow.SetApartmentState(ApartmentState.STA);
            historyWindow.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}