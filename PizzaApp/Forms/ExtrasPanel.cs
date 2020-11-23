using PizzaApp.Config;
using PizzaApp.Logic;
using PizzaApp.Logic.User;
using PizzaApp.Models;
using PizzaApp.Models.Products.Abstract;
using System;
using System.Collections.Generic;
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
            WindowsManagement.GetOrderWindowInstance().Show();
            Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            AddExtrasProductToOrderList();
        }

        private void ExtrasPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddExtrasProductToOrderList()
        {
            OrderWindow orderWindow = WindowsManagement.GetOrderWindowInstance();
            TextBox foodTextBox = orderWindow.choosedCountBox;
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                DoubleCheeseCheckbox,
                HamCheckbox,
                MushroomsCheckbox,
                SalamiCheckbox
            };

            string foodName = foodTextBox.Name.Replace("CountBox", string.Empty);
            ProductsConfiguration.ExtrasProduct.TryGetValue(foodName, out Product value);
            var order = new Order(new Product(value.Name, value.Price, value.Extras));

            List<string> extras = new List<string>();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkBox.Checked = false;
                    extras.Add(checkBox.Text);
                    order.Product.Price += 2;
                }
            }

            if (extras.Any())
            {
                order.Product.Extras.Add(extras.Aggregate((i, j) => string.Format("{0}, {1}", i, j)));
            }

            orderWindow.orderList.Add(order);
            UserActionHelpers.AddValueToCountBox(foodTextBox);
            Hide();
            orderWindow.Show();
        }
    }
}