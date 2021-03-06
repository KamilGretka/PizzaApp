﻿using PizzaApp.Logic;
using PizzaApp.Logic.User;
using PizzaApp.Models;
using PizzaApp.Models.Database;
using PizzaApp.OutputMessages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaApp.Forms
{
    public partial class OrderConfirm : Form
    {
        private const string emailBodyFormat = "<p>Your order has been procedeed and will be sended to address: <b> {0} </b></p> <p> Personal details: {1}, {2} </p> <p> Additional note: {3} </p>";
        public OrderConfirm()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            List<(bool, string)> validators = new List<(bool, string)>()
            {
                DataValidationManager.CheckEmail(EmailTextBox.Text),
                DataValidationManager.CheckFirstName(FirstNameTextBox.Text),
                DataValidationManager.CheckLastName(LastNameTextBox.Text),
                DataValidationManager.CheckAddress(AddressTextBox.Text),
            };

            foreach (var validator in validators)
            {
                if (!string.IsNullOrEmpty(validator.Item2))
                {
                    MessageBox.Show(validator.Item2, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (validators.TrueForAll(x => x.Item1))
            {
                var emailBody = string.Format(emailBodyFormat, AddressTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, NotesTextBox.Text);

                EmailSendStatus emailSendStatus = new EmailManager().SendEmail(EmailTextBox.Text, "Pizza Application Order", emailBody);

                if (emailSendStatus.SendSuccessfully)
                {
                    MessageBox.Show(UserMessages.EmailSended, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddHistoryRecordToDatabase();
                    UserActionHelpers.ClearAllTextBoxData();
                    Hide();
                    WindowsManagement.GetMainWindowInstance().Show();
                }
                else
                {
                    MessageBox.Show(UserMessages.EmailFailedToSend, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        internal void AddHistoryRecordToDatabase()
        {
            OrderHistory history = new OrderHistory()
            {
                Id = Guid.NewGuid(),
                OrderTime = DateTime.Now,
                Address = AddressTextBox.Text,
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
                MessageBox.Show(UserMessages.DatabaseRecordNotAdded, WindowsTypes.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
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