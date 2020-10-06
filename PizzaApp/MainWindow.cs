using System;
using System.Threading;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class MainWindow : Form
    {
        Thread orderWindowThread, historyWindow;
        private readonly Helpers actions = new Helpers();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Close();
            orderWindowThread = new Thread(actions.OpenNewWindow<OrderWindow>);
            orderWindowThread.SetApartmentState(ApartmentState.STA);
            orderWindowThread.Start();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            historyWindow = new Thread(actions.OpenNewWindow<HistoryWindow>);
            historyWindow.SetApartmentState(ApartmentState.STA);
            historyWindow.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}