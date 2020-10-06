using Microsoft.Data.SqlClient;
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
                validation.CheckString(AdressTextBox.Text)
            };
            foreach (var validator in validators.Select(x => x).ToList())
            {
                if (validator.Item2 != string.Empty)
                {
                    MessageBox.Show(validator.Item2, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (validators.All(x => x.Item1 == true))
            {
                EmailSendStatus emailSendStatus = new EmailManager().SendEmail(EmailTextBox.Text, "Pizza Application Order",
                                                                    $"<p> Your order has been procedeed and will be sended to adress: <b> {AdressTextBox.Text} </b></p>" +
                                                                    $"<p> Personal details: {FirstNameTextBox.Text}, {LastNameTextBox.Text} </p>" +
                                                                    $"<p> Additional note: { NotesTextBox.Text} </p> ");

                if (emailSendStatus.SendSuccessfully == true)
                    MessageBox.Show(UserMessages.EmailSended, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(UserMessages.EmailFailedToSend, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddHistoryRecordToDatabase();
                this.Close();
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