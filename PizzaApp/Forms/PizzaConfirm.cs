using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class PizzaConfirm : Form
    {
        public PizzaConfirm()
        {
            InitializeComponent();
        }

        private void PizzaConfirmButton_Click(object sender, EventArgs e)
        {
            //OrderWindow orderWindow = new OrderWindow();
            //var tets = OrderWindow.CurrencyTextBox;

            var checkedExtras = new List<bool>()
            {
                HamCheckbox.Checked,
                SalamiCheckbox.Checked,
                DoubleCheeseCheckbox.Checked,
                MushroomsCheckbox.Checked
            }.Where(x => x == true).ToList();

            //checkedExtras.ForEach(OrderWindow.AddValueToCurrentPrice("Ham"));
           // orderWindow.ChangeCurrentPriceValue("Ham", tets);

            this.Close();
        }

        private void PizzaConfirmBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
