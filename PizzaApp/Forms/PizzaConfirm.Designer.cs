namespace PizzaApp
{
    partial class PizzaConfirm
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
            this.extrasLabel = new System.Windows.Forms.Label();
            this.DoubleCheeseCheckbox = new System.Windows.Forms.CheckBox();
            this.SalamiCheckbox = new System.Windows.Forms.CheckBox();
            this.HamCheckbox = new System.Windows.Forms.CheckBox();
            this.MushroomsCheckbox = new System.Windows.Forms.CheckBox();
            this.PizzaConfirmButton = new System.Windows.Forms.Button();
            this.PizzaConfirmBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extrasLabel
            // 
            this.extrasLabel.AutoSize = true;
            this.extrasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.extrasLabel.Location = new System.Drawing.Point(61, 9);
            this.extrasLabel.Name = "extrasLabel";
            this.extrasLabel.Size = new System.Drawing.Size(184, 20);
            this.extrasLabel.TabIndex = 0;
            this.extrasLabel.Text = "Please select your extras";
            // 
            // DoubleCheeseCheckbox
            // 
            this.DoubleCheeseCheckbox.AutoSize = true;
            this.DoubleCheeseCheckbox.Location = new System.Drawing.Point(12, 55);
            this.DoubleCheeseCheckbox.Name = "DoubleCheeseCheckbox";
            this.DoubleCheeseCheckbox.Size = new System.Drawing.Size(99, 17);
            this.DoubleCheeseCheckbox.TabIndex = 1;
            this.DoubleCheeseCheckbox.Text = "Double Cheese";
            this.DoubleCheeseCheckbox.UseVisualStyleBackColor = true;
            // 
            // SalamiCheckbox
            // 
            this.SalamiCheckbox.AutoSize = true;
            this.SalamiCheckbox.Location = new System.Drawing.Point(174, 55);
            this.SalamiCheckbox.Name = "SalamiCheckbox";
            this.SalamiCheckbox.Size = new System.Drawing.Size(57, 17);
            this.SalamiCheckbox.TabIndex = 2;
            this.SalamiCheckbox.Text = "Salami";
            this.SalamiCheckbox.UseVisualStyleBackColor = true;
            // 
            // HamCheckbox
            // 
            this.HamCheckbox.AutoSize = true;
            this.HamCheckbox.Location = new System.Drawing.Point(12, 105);
            this.HamCheckbox.Name = "HamCheckbox";
            this.HamCheckbox.Size = new System.Drawing.Size(48, 17);
            this.HamCheckbox.TabIndex = 3;
            this.HamCheckbox.Text = "Ham";
            this.HamCheckbox.UseVisualStyleBackColor = true;
            // 
            // MushroomsCheckbox
            // 
            this.MushroomsCheckbox.AutoSize = true;
            this.MushroomsCheckbox.Location = new System.Drawing.Point(174, 105);
            this.MushroomsCheckbox.Name = "MushroomsCheckbox";
            this.MushroomsCheckbox.Size = new System.Drawing.Size(80, 17);
            this.MushroomsCheckbox.TabIndex = 4;
            this.MushroomsCheckbox.Text = "Mushrooms";
            this.MushroomsCheckbox.UseVisualStyleBackColor = true;
            // 
            // PizzaConfirmButton
            // 
            this.PizzaConfirmButton.Location = new System.Drawing.Point(179, 150);
            this.PizzaConfirmButton.Name = "PizzaConfirmButton";
            this.PizzaConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.PizzaConfirmButton.TabIndex = 5;
            this.PizzaConfirmButton.Text = "Confirm";
            this.PizzaConfirmButton.UseVisualStyleBackColor = true;
            this.PizzaConfirmButton.Click += new System.EventHandler(this.PizzaConfirmButton_Click);
            // 
            // PizzaConfirmBackButton
            // 
            this.PizzaConfirmBackButton.Location = new System.Drawing.Point(25, 150);
            this.PizzaConfirmBackButton.Name = "PizzaConfirmBackButton";
            this.PizzaConfirmBackButton.Size = new System.Drawing.Size(75, 23);
            this.PizzaConfirmBackButton.TabIndex = 6;
            this.PizzaConfirmBackButton.Text = "Back";
            this.PizzaConfirmBackButton.UseVisualStyleBackColor = true;
            this.PizzaConfirmBackButton.Click += new System.EventHandler(this.PizzaConfirmBackButton_Click);
            // 
            // PizzaConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 185);
            this.Controls.Add(this.PizzaConfirmBackButton);
            this.Controls.Add(this.PizzaConfirmButton);
            this.Controls.Add(this.MushroomsCheckbox);
            this.Controls.Add(this.HamCheckbox);
            this.Controls.Add(this.SalamiCheckbox);
            this.Controls.Add(this.DoubleCheeseCheckbox);
            this.Controls.Add(this.extrasLabel);
            this.Name = "PizzaConfirm";
            this.Text = "PizzaConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label extrasLabel;
        private System.Windows.Forms.CheckBox DoubleCheeseCheckbox;
        private System.Windows.Forms.CheckBox SalamiCheckbox;
        private System.Windows.Forms.CheckBox HamCheckbox;
        private System.Windows.Forms.CheckBox MushroomsCheckbox;
        private System.Windows.Forms.Button PizzaConfirmButton;
        private System.Windows.Forms.Button PizzaConfirmBackButton;
    }
}