using PizzaApp.Models;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp
{
    internal static class Helpers
    {
        internal static void AddValueToCountBox(TextBox countTextBox)
        {
            int value = int.Parse(countTextBox.Text);
                countTextBox.Text = (value + 1).ToString();
        }

        internal static void SubstractValuInCountBox(TextBox countTextBox)
        {
            int value = int.Parse(countTextBox.Text);
            if (value > 0)
                countTextBox.Text = (value - 1).ToString();
        }

        internal static void RemoveLastItemFromOrderListByName(string itemName)
        {
            var orderWindow = WindowsManagement.GetOrderWindowInstance();
            Order item = orderWindow.orderList.Where(x => x.Name.Equals(itemName)).ToList().LastOrDefault();
            orderWindow.orderList.Remove(item);
        }

        internal static void ClearAllTextBoxData()
        {
            WindowsManagement.GetOrderConfirmInstance().Dispose();
            WindowsManagement.GetOrderWindowInstance().Dispose();
            WindowsManagement.GetOrderWindowInstance().orderList.Clear();
        }
    }
}