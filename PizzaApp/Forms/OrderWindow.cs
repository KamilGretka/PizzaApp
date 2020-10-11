using PizzaApp.Logic;
using PizzaApp.Logic.User;
using PizzaApp.Models;
using PizzaApp.OutputMessages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp.Forms
{
    public partial class OrderWindow : Form
    {
        internal List<Order> orderList = new List<Order>();

        internal TextBox choosedTextBox;
        public OrderWindow()
        {
            InitializeComponent();
        }

        internal void ChangeCurrentPriceValue()
        {
            try
            {
                CostBox.Text = (orderList.Sum(x => x.Price)).ToString();

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
                MessageBox.Show(UserMessages.NoOrder, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (decimal.Parse(CostBox.Text) <= 150m)
            {
                Hide();
                WindowsManagement.GetOrderConfirmInstance().Show();
            }
            else
                MessageBox.Show(UserMessages.HugeOrder, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetMainWindowInstance().Show();
            UserActionHelpers.ClearAllTextBoxData();
        }

        private void MargherittaPlus_Click(object sender, EventArgs e)
        {
            choosedTextBox = Margheritta;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void MargherittaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Margheritta");
            UserActionHelpers.SubstractValuInCountBox(Margheritta);
        }

        private void MargherittaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void VegeterianaPlus_Click(object sender, EventArgs e)
        {
            choosedTextBox = Vegetariana;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void VegeterianaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Vegetariana");
            UserActionHelpers.SubstractValuInCountBox(Vegetariana);
        }

        private void VegeterianaCountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ToscaPlus_Click(object sender, EventArgs e)
        {
            choosedTextBox = Tosca;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void ToscaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Tosca");
            UserActionHelpers.SubstractValuInCountBox(Tosca);
        }

        private void Tosca_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void VeneciaPlus_Click(object sender, EventArgs e)
        {
            choosedTextBox = Venecia;
            Hide();
            WindowsManagement.GetExtrasPanelInstance().Show();
        }

        private void VeneciaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Venecia");
            UserActionHelpers.SubstractValuInCountBox(Venecia);
        }

        private void Venecia_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void PorkHopPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(PorkHop.Name, decimal.Parse(ConfigurationManager.AppSettings[PorkHop.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(PorkHop);
        }

        private void PorkhopMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("PorkHop");
            UserActionHelpers.SubstractValuInCountBox(PorkHop);
        }

        private void Porkhop_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void FishPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(Fish.Name, decimal.Parse(ConfigurationManager.AppSettings[Fish.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(Fish);
        }

        private void FishMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Fish");
            UserActionHelpers.SubstractValuInCountBox(Fish);
        }

        private void Fish_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void HungarianCakePlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(Hungarian.Name, decimal.Parse(ConfigurationManager.AppSettings[Hungarian.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(Hungarian);
        }

        private void HungarianCakeMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Hungarian");
            UserActionHelpers.SubstractValuInCountBox(Hungarian);
        }

        private void HungarianCake_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void TomatoSoupPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(TomatoSoup.Name, decimal.Parse(ConfigurationManager.AppSettings[TomatoSoup.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(TomatoSoup);
        }

        private void TomatoSoupMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("TomatoSoup");
            UserActionHelpers.SubstractValuInCountBox(TomatoSoup);
        }

        private void TomatoSoup_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ChickenSoupPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(ChickenSoup.Name, decimal.Parse(ConfigurationManager.AppSettings[ChickenSoup.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(ChickenSoup);
        }

        private void ChickenSoupMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("ChickenSoup");
            UserActionHelpers.SubstractValuInCountBox(ChickenSoup);
        }

        private void ChickenSoup_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void CoffiePlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(Coffie.Name, decimal.Parse(ConfigurationManager.AppSettings[Coffie.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(Coffie);
        }

        private void CoffieMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Coffie");
            UserActionHelpers.SubstractValuInCountBox(Coffie);
        }

        private void Coffie_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void TeaPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(Tea.Name, decimal.Parse(ConfigurationManager.AppSettings[Tea.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(Tea);
        }

        private void TeaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Tea");
            UserActionHelpers.SubstractValuInCountBox(Tea);
        }

        private void Tea_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentPriceValue();
        }

        private void ColaPlus_Click(object sender, EventArgs e)
        {
            orderList.Add(new Order(Cola.Name, decimal.Parse(ConfigurationManager.AppSettings[Cola.Name]), string.Empty));
            UserActionHelpers.AddValueToCountBox(Cola);
        }

        private void ColaMinus_Click(object sender, EventArgs e)
        {
            UserActionHelpers.RemoveLastItemFromOrderListByName("Cola");
            UserActionHelpers.SubstractValuInCountBox(Cola);
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