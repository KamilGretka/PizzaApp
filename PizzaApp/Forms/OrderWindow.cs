using PizzaApp.Config;
using PizzaApp.Logic;
using PizzaApp.Logic.User;
using PizzaApp.Models;
using PizzaApp.Models.Products.Abstract;
using PizzaApp.OutputMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp.Forms
{
    public partial class OrderWindow : Form
    {
        internal List<Order> orderList = new List<Order>();

        internal TextBox choosedCountBox;
        public OrderWindow()
        {
            InitializeComponent();
        }

        internal void ChangeCurrentPriceValue()
        {
            try
            {
                CostBox.Text = orderList.Sum(x => x.Product.Price).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid parameter.", WindowsTypes.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            decimal currentPrice = decimal.Parse(CostBox.Text);
            if (currentPrice.Equals(0))
            {
                MessageBox.Show(UserMessages.NoOrder, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (decimal.Parse(CostBox.Text) <= 150m)
            {
                Hide();
                WindowsManagement.GetOrderConfirmInstance().Show();
            }
            else
            {
                MessageBox.Show(UserMessages.HugeOrder, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetMainWindowInstance().Show();
            UserActionHelpers.ClearAllTextBoxData();
        }

        private void MargherittaPlus_Click(object sender, EventArgs e)
        {
            choosedCountBox = MargherittaCountBox;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void MargherittaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Margheritta);
            UserActionHelpers.SubstractValuInCountBox(MargherittaCountBox);
        }

        private void MargherittaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void VegeterianaPlus_Click(object sender, EventArgs e)
        {
            choosedCountBox = VegetarianaCountBox;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void VegeterianaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Vegetariana);
            UserActionHelpers.SubstractValuInCountBox(VegetarianaCountBox);
        }

        private void VegeterianaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ToscaPlus_Click(object sender, EventArgs e)
        {
            choosedCountBox = ToscaCountBox;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void ToscaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Tosca);
            UserActionHelpers.SubstractValuInCountBox(ToscaCountBox);
        }

        private void Tosca_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void VeneciaPlus_Click(object sender, EventArgs e)
        {
            choosedCountBox = VeneciaCountBox;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void VeneciaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Venecia);
            UserActionHelpers.SubstractValuInCountBox(VeneciaCountBox);
        }

        private void Venecia_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void PorkHopPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.PorkHop, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(PorkHopCountBox);
        }

        private void PorkhopMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.PorkHop);
            UserActionHelpers.SubstractValuInCountBox(PorkHopCountBox);
        }

        private void Porkhop_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void FishPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.FishFries, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(FishCountBox);
        }

        private void FishMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.FishFries);
            UserActionHelpers.SubstractValuInCountBox(FishCountBox);
        }

        private void Fish_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void HungarianCakePlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.HungarianCake, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(HungarianCountBox);
        }

        private void HungarianCakeMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.HungarianCake);
            UserActionHelpers.SubstractValuInCountBox(HungarianCountBox);
        }

        private void HungarianCake_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void TomatoSoupPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.TomatoSoup, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(TomatoSoupCountBox);
        }

        private void TomatoSoupMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.TomatoSoup);
            UserActionHelpers.SubstractValuInCountBox(TomatoSoupCountBox);
        }

        private void TomatoSoup_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ChickenSoupPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.ChickenSoup, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(ChickenSoupCountBox);
        }

        private void ChickenSoupMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.ChickenSoup);
            UserActionHelpers.SubstractValuInCountBox(ChickenSoupCountBox);
        }

        private void ChickenSoup_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void CoffiePlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.Cola, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(CoffieCountBox);
        }

        private void CoffieMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Cola);
            UserActionHelpers.SubstractValuInCountBox(CoffieCountBox);
        }

        private void Coffie_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void TeaPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.Tea, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(TeaCountBox);
        }

        private void TeaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Tea);
            UserActionHelpers.SubstractValuInCountBox(TeaCountBox);
        }

        private void Tea_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ColaPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(new Product(ProductsConfiguration.Product.TryGetValue(ProductsNames.Cola, out Product product) ? product.Name : string.Empty, product.Price)));
            UserActionHelpers.AddValueToCountBox(ColaCountBox);
        }

        private void ColaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName(ProductsNames.Cola);
            UserActionHelpers.SubstractValuInCountBox(ColaCountBox);
        }

        private void Cola_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void OrderWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShopCartButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetShopCartInstance().Show();
        }
    }
}