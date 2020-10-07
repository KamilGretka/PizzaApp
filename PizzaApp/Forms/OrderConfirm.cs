using PizzaApp.Logic.User;
using PizzaApp.Models;
using PizzaApp.Models.Database;
using PizzaApp.Output_Messages;
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
            ValidationManager validation = new ValidationManager();
            List<(bool, string)> validators = new List<(bool, string)>()
            {
                validation.CheckEmail(EmailTextBox.Text),
                validation.CheckString(FirstNameTextBox.Text),
                validation.CheckString(LastNameTextBox.Text),
                validation.CheckAdress(AdressTextBox.Text),
            };

            foreach (var validator in validators.Select(x => x).ToList())
            {
                if (!string.IsNullOrEmpty(validator.Item2))
                {
                    MessageBox.Show(validator.Item2, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (validators.All(x => x.Item1 == true))
            {
                var emailBody = string.Format(emailBodyFormat, AdressTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, NotesTextBox.Text);

                EmailSendStatus emailSendStatus = new EmailManager().SendEmail(EmailTextBox.Text, "Pizza Application Order", emailBody);

                if (emailSendStatus.SendSuccessfully == true)
                {
                    MessageBox.Show(UserMessages.EmailSended, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddHistoryRecordToDatabase();
                }
                else
                    MessageBox.Show(UserMessages.EmailFailedToSend, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        internal void AddHistoryRecordToDatabase()
        {
            OrderHistory history = new OrderHistory()
            {
                Id = Guid.NewGuid(),
                OrderTime = DateTime.Now,
                Adress = AdressTextBox.Text,
                OrderMessage = NotesTextBox.Text,
                CustomerName = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}"
            };

            using (AppDBContext db = new AppDBContext())
            {
                db.OrderHistory.Add(history);
                db.SaveChanges();
            }
        }
    }
}