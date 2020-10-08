using PizzaApp.Cryptography;
using PizzaApp.OutputMessages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class OrderWindow : Form
    {
        Thread orderConfirm, mainWindow;
        private static decimal extrasPrice;
        public OrderWindow()
        {
            InitializeComponent();
        }
        private void OrderWindow_Load(object sender, EventArgs e)
        {
            DoubleCheeseCheckbox.Hide();
            SalamiCheckbox.Hide();
            HamCheckbox.Hide();
            MushroomsCheckbox.Hide();
        }

        internal void ChangeCurrentPriceValue()
        {
            try
            {
                CostBox.Text = (GenerateOrderList().Sum(x => x) + extrasPrice).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid parameter.", WindowsTypes.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private List<decimal> GenerateOrderList()
        {
            List<KeyValuePair<int, decimal>> orderList = new List<KeyValuePair<int, decimal>>()
            {
                new KeyValuePair<int, decimal>(int.Parse(MargherittaCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Margheritta"])),
                new KeyValuePair<int, decimal>(int.Parse(VegeterianaCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Vegetariana"])),
                new KeyValuePair<int, decimal>(int.Parse(ToscaCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Tosca"])),
                new KeyValuePair<int, decimal>(int.Parse(VeneciaCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Venecia"])),
                new KeyValuePair<int, decimal>(int.Parse(PorkHopCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Porkhop"])),
                new KeyValuePair<int, decimal>(int.Parse(FishCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Fish"])),
                new KeyValuePair<int, decimal>(int.Parse(HungarianCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Hungarian Cake"])),
                new KeyValuePair<int, decimal>(int.Parse(TomatoSoupCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Tomato Soup"])),
                new KeyValuePair<int, decimal>(int.Parse(ChickenSoupCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Chicken Soup"])),
                new KeyValuePair<int, decimal>(int.Parse(CoffieCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Coffie"])),
                new KeyValuePair<int, decimal>(int.Parse(TeaCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Tea"])),
                new KeyValuePair<int, decimal>(int.Parse(ColaCountBox.Text), decimal.Parse(ConfigurationManager.AppSettings["Cola"])),
            };

            List<decimal> countedOrderList = new List<decimal>();

            foreach (var order in orderList)
            {
                countedOrderList.Add(order.Key * order.Value);
            }

            if (countedOrderList.All(x => x.Equals(0)))
                extrasPrice = 0;
            return countedOrderList;
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Crypto crypto = new Crypto();
            decimal currentPrice = decimal.Parse(CostBox.Text);
            if (currentPrice.Equals(0))
                MessageBox.Show(UserMessages.NoOrder, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (decimal.Parse(CostBox.Text) <= 150)
            {
                orderConfirm = new Thread(Helpers.OpenNewWindow<OrderConfirm>);
                orderConfirm.SetApartmentState(ApartmentState.STA);
                orderConfirm.Start();
            }
            else
                MessageBox.Show(UserMessages.HugeOrder, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            extrasPrice = 0;
            mainWindow = new Thread(Helpers.OpenNewWindow<MainWindow>);
            mainWindow.SetApartmentState(ApartmentState.STA);
            mainWindow.Start();
            Close();
        }

        private void ShowExtrasPanel(object sender)
        {
            ExtrasLabel.Show();
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                DoubleCheeseCheckbox,
                HamCheckbox,
                MushroomsCheckbox,
                SalamiCheckbox
            };

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (Helpers.GetContentFromObject(sender, "Text").Equals("+"))
                    checkBox.Show();
                else
                    checkBox.Hide();

                checkBox.Checked = false;
                extrasGroupBox.Show();
            }
        }

        private void ChangeExtrasPrice(CheckBox checkbox)
        {
            if (checkbox.Checked)
                extrasPrice += 2;
            else
                extrasPrice -= 2;
        }

        private void MargherittaPlus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.AddValueToCountBox(MargherittaCountBox);
        }

        private void MargherittaMinus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.SubstractValuInCountBox(MargherittaCountBox);
        }

        private void MargherittaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void VegeterianaPlus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.AddValueToCountBox(VegeterianaCountBox);
        }

        private void VegeterianaMinus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.SubstractValuInCountBox(VegeterianaCountBox);
        }

        private void VegeterianaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ToscaPlus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.AddValueToCountBox(ToscaCountBox);
        }

        private void ToscaMinus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.SubstractValuInCountBox(ToscaCountBox);
        }

        private void Tosca_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void VeneciaPlus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.AddValueToCountBox(VeneciaCountBox);
        }

        private void VeneciaMinus_Click(object sender, EventArgs e)
        {
            ShowExtrasPanel(sender);
            Helpers.SubstractValuInCountBox(VeneciaCountBox);
        }

        private void Venecia_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void PorkHopPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(PorkHopCountBox);
        }

        private void PorkhopMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(PorkHopCountBox);
        }

        private void Porkhop_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void FishPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(FishCountBox);
        }

        private void FishMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(FishCountBox);
        }
        private void Fish_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void HungarianCakePlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(HungarianCountBox);
        }

        private void HungarianCakeMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(HungarianCountBox);
        }

        private void HungarianCake_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void TomatoSoupPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(TomatoSoupCountBox);
        }

        private void TomatoSoupMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(TomatoSoupCountBox);
        }

        private void TomatoSoup_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ChickenSoupPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(ChickenSoupCountBox);
        }

        private void ChickenSoupMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(ChickenSoupCountBox);
        }

        private void ChickenSoup_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void CoffiePlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(CoffieCountBox);
        }

        private void CoffieMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(CoffieCountBox);
        }

        private void Coffie_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void TeaPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(TeaCountBox);
        }

        private void TeaMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(TeaCountBox);
        }

        private void Tea_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ColaPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(ColaCountBox);
        }

        private void ColaMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(ColaCountBox);
        }

        private void Cola_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void SalamiCheckbox_Click(object sender, EventArgs e)
        {
            ChangeExtrasPrice(SalamiCheckbox);
            ChangeCurrentPriceValue();
        }

        private void HamCheckbox_Click(object sender, EventArgs e)
        {
            ChangeExtrasPrice(HamCheckbox);
            ChangeCurrentPriceValue();
        }

        private void MushroomsCheckbox_Click(object sender, EventArgs e)
        {
            ChangeExtrasPrice(MushroomsCheckbox);
            ChangeCurrentPriceValue();
        }

        private void DoubleCheeseCheckbox_Click(object sender, EventArgs e)
        {
            ChangeExtrasPrice(DoubleCheeseCheckbox);
            ChangeCurrentPriceValue();
        }
    }
}