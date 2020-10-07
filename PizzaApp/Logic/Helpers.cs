using System;
using System.Windows.Forms;

namespace PizzaApp
{
    internal static class Helpers
    {
        internal static void OpenNewWindow<T>() where T : Form
        {
            Application.Run(Activator.CreateInstance<T>());
        }

        internal static void AddValueToCountBox(TextBox countTextBox)
        {
            float value = float.Parse(countTextBox.Text);
            if (value < 10)
                countTextBox.Text = (value + 1).ToString();
        }

        internal static void SubstractValuInCountBox(TextBox countTextBox)
        {
            float value = float.Parse(countTextBox.Text);
            if (value > 0)
                countTextBox.Text = (value - 1).ToString();
        }

        internal static string GetContentFromObject(object obj, string prop)
        {
            var text = obj.GetType().GetProperty(prop);
            return (string)text.GetValue(obj, null);
        }
    }
}