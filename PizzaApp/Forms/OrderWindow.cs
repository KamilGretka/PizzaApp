using PizzaApp.Output_Messages;
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

        public OrderWindow()
        {
            InitializeComponent();
        }

        #region Others
        internal void ChangeCurrentPriceValue()
        {
            try
            {
                CostBox.Text = GenerateOrderList().Sum(x => x).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid parameter");
            }
        }
        private List<float> GenerateOrderList()
        {
            List<KeyValuePair<int, float>> orderList = new List<KeyValuePair<int, float>>()
            {
                new KeyValuePair<int, float>(int.Parse(MargherittaCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Margheritta"])),
                new KeyValuePair<int, float>(int.Parse(VegeterianaCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Vegetariana"])),
                new KeyValuePair<int, float>(int.Parse(ToscaCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Tosca"])),
                new KeyValuePair<int, float>(int.Parse(VeneciaCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Venecia"])),
                new KeyValuePair<int, float>(int.Parse(PorkHopCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Porkhop"])),
                new KeyValuePair<int, float>(int.Parse(FishCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Fish"])),
                new KeyValuePair<int, float>(int.Parse(HungarianCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Hungarian Cake"])),
                new KeyValuePair<int, float>(int.Parse(TomatoSoupCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Tomato Soup"])),
                new KeyValuePair<int, float>(int.Parse(ChickenSoupCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Chicken Soup"])),
                new KeyValuePair<int, float>(int.Parse(CoffieCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Coffie"])),
                new KeyValuePair<int, float>(int.Parse(TeaCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Tea"])),
                new KeyValuePair<int, float>(int.Parse(ColaCountBox.Text), float.Parse(ConfigurationManager.AppSettings["Cola"])),
            };

            //foreach (Products product in (Products[])Enum.GetValues(typeof(Products)))
            //{
            //    orderList.Add(new KeyValuePair<int, float>(int.Parse(MargherittaCountBox.Text), float.Parse(ConfigurationManager.AppSettings[product.ToString()])));
            //}

            List<float> countedOrderList = new List<float>();

            foreach (var order in orderList)
            {
                countedOrderList.Add(order.Key * order.Value);
            }

            return countedOrderList;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            float currentPrice = float.Parse(CostBox.Text);
            if (currentPrice == 0)
                MessageBox.Show(UserMessages.NoOrder);
            else if (float.Parse(CostBox.Text) <= 150)
            {
                orderConfirm = new Thread(Helpers.OpenNewWindow<OrderConfirm>);
                orderConfirm.SetApartmentState(ApartmentState.STA);
                orderConfirm.Start();
            }
            else
                MessageBox.Show(UserMessages.HugeOrder, WindowsTypes.Information.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainWindow = new Thread(Helpers.OpenNewWindow<MainWindow>);
            mainWindow.SetApartmentState(ApartmentState.STA);
            mainWindow.Start();
            Close();
        }

        #endregion

        #region Margheritta
        private void MargherittaPlus_Click(object sender, EventArgs e)
        {
            //pizzaConfirm = new Thread(helpers.OpenNewWindow<PizzaConfirm>);
            //pizzaConfirm.SetApartmentState(ApartmentState.STA);
            //pizzaConfirm.Start();
            Helpers.AddValueToCountBox(MargherittaCountBox);
        }

        private void MargherittaMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(MargherittaCountBox);
        }

        private void MargherittaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }
        #endregion

        #region Vegeteriana
        private void VegeterianaPlus_Click(object sender, EventArgs e)
        {
            //pizzaConfirm = new Thread(helpers.OpenNewWindow<PizzaConfirm>);
            //pizzaConfirm.SetApartmentState(ApartmentState.STA);
            //pizzaConfirm.Start();
            Helpers.AddValueToCountBox(VegeterianaCountBox);
        }

        private void VegeterianaMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(VegeterianaCountBox);
        }

        private void VegeterianaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }
        #endregion

        #region Tosca
        private void ToscaPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(ToscaCountBox);
        }

        private void ToscaMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(ToscaCountBox);
        }

        private void Tosca_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        #endregion

        #region Venecia
        private void VeneciaPlus_Click(object sender, EventArgs e)
        {
            Helpers.AddValueToCountBox(VeneciaCountBox);
        }

        private void VeneciaMinus_Click(object sender, EventArgs e)
        {
            Helpers.SubstractValuInCountBox(VeneciaCountBox);
        }

        private void Venecia_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }
        #endregion

        #region PorkHop
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
        #endregion

        #region Fish
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
        #endregion

        #region Hungarian Cake
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
        #endregion

        #region Tomato Soup
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
        #endregion

        #region Chicken Soup
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
        #endregion

        #region Coffie
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
        #endregion

        #region Tea
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

        #endregion

        #region Cola
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
        #endregion
    }
}