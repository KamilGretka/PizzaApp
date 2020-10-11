namespace PizzaApp
{
    partial class OrderConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moreInformationLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moreInformationLabel
            // 
            this.moreInformationLabel.AutoSize = true;
            this.moreInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moreInformationLabel.Location = new System.Drawing.Point(31, 9);
            this.moreInformationLabel.Name = "moreInformationLabel";
            this.moreInformationLabel.Size = new System.Drawing.Size(415, 24);
            this.moreInformationLabel.TabIndex = 0;
            this.moreInformationLabel.Text = "Before we proceed, we need more informations!";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(340, 61);
            this.EmailTextBox.MaxLength = 30;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(111, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.Location = new System.Drawing.Point(258, 56);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(57, 24);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(412, 238);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(340, 99);
            this.AddressTextBox.MaxLength = 50;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(111, 20);
            this.AddressTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressLabel.Location = new System.Drawing.Point(258, 95);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(80, 24);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Address";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(120, 60);
            this.FirstNameTextBox.MaxLength = 30;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 56);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(98, 24);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(120, 100);
            this.LastNameTextBox.MaxLength = 30;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Optional notes:";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(18, 166);
            this.NotesTextBox.MaxLength = 300;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(239, 96);
            this.NotesTextBox.TabIndex = 5;
            this.NotesTextBox.Text = "";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(287, 238);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.moreInformationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm your order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderConfirm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moreInformationLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NotesTextBox;
        private System.Windows.Forms.Button BackButton;
    }
}