using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp.Forms
{
    public partial class ExtrasPanel : Form
    {
        public ExtrasPanel()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            OrderWindow orderWindow = WindowsManagement.GetOrderWindowInstance();
            TextBox choosedFoodType = orderWindow.choosedTextBox;
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                DoubleCheeseCheckbox,
                HamCheckbox,
                MushroomsCheckbox,
                SalamiCheckbox
            };

            Order order = new Order(choosedFoodType.Name, decimal.Parse(ConfigurationManager.AppSettings[choosedFoodType.Name]), string.Empty);

            List<string> extras = new List<string>();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkBox.Checked = false;
                    extras.Add(checkBox.Text);
                    order.Price += 2;
                }
            }

            order.Extras = extras.Aggregate((i, j) => string.Format("{0}, {1}", i, j));
            orderWindow.orderList.Add(order);
            Helpers.AddValueToCountBox(choosedFoodType);
            Hide();
            orderWindow.Show();
        }

        private void ExtrasPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}