using PizzaApp.Logic.User;
using PizzaApp.Models;
using PizzaApp.Models.Database;
using PizzaApp.OutputMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class OrderConfirm : Form
    {
        private const string emailBodyFormat = "<p>Your order has been procedeed and will be sended to adress: <b> {0} </b></p> <p> Personal details: {1}, {2} </p> <p> Additional note: {3} </p>";
        public OrderConfirm()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            DataValidationManager validation = new DataValidationManager();
            List<(bool, string)> validators = new List<(bool, string)>()
            {
                validation.CheckEmail(EmailTextBox.Text),
                validation.CheckFirstName(FirstNameTextBox.Text),
                validation.CheckLastName(LastNameTextBox.Text),
                validation.CheckAddress(AddressTextBox.Text),
            };

            foreach (var validator in validators.Select(x => x).ToList())
            {
                if (!string.IsNullOrEmpty(validator.Item2))
                {
                    MessageBox.Show(validator.Item2, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (validators.All(x => x.Item1 == true))
            {
                var emailBody = string.Format(emailBodyFormat, AddressTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, NotesTextBox.Text);

                EmailSendStatus emailSendStatus = new EmailManager().SendEmail(EmailTextBox.Text, "Pizza Application Order", emailBody);

                if (emailSendStatus.SendSuccessfully == true)
                {
                    MessageBox.Show(UserMessages.EmailSended, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddHistoryRecordToDatabase();
                    Helpers.ClearAllTextBoxData();
                    Hide();
                    WindowsManagement.GetMainWindowInstance().Show();
                }
                else
                    MessageBox.Show(UserMessages.EmailFailedToSend, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal void AddHistoryRecordToDatabase()
        {
            OrderHistory history = new OrderHistory()
            {
                Id = Guid.NewGuid(),
                OrderTime = DateTime.Now,
                Adress = AddressTextBox.Text,
                OrderMessage = NotesTextBox.Text,
                CustomerName = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}"
            };
            try
            {
                using (AppDBContext db = new AppDBContext())
                {
                    db.OrderHistory.Add(history);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            { 
                //Information from this exception should go to logs (connection with database failed, record not added)
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            WindowsManagement.GetOrderWindowInstance().Show();
        }

        private void OrderConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}