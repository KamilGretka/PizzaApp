namespace PizzaApp.Forms
{
    partial class ExtrasPanel
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
            this.DoubleCheeseCheckbox = new System.Windows.Forms.CheckBox();
            this.SalamiCheckbox = new System.Windows.Forms.CheckBox();
            this.HamCheckbox = new System.Windows.Forms.CheckBox();
            this.MushroomsCheckbox = new System.Windows.Forms.CheckBox();
            this.ExtrasLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoubleCheeseCheckbox
            // 
            this.DoubleCheeseCheckbox.AutoSize = true;
            this.DoubleCheeseCheckbox.Location = new System.Drawing.Point(12, 48);
            this.DoubleCheeseCheckbox.Name = "DoubleCheeseCheckbox";
            this.DoubleCheeseCheckbox.Size = new System.Drawing.Size(99, 17);
            this.DoubleCheeseCheckbox.TabIndex = 12;
            this.DoubleCheeseCheckbox.TabStop = false;
            this.DoubleCheeseCheckbox.Text = "Double Cheese";
            this.DoubleCheeseCheckbox.UseVisualStyleBackColor = true;
            // 
            // SalamiCheckbox
            // 
            this.SalamiCheckbox.AutoSize = true;
            this.SalamiCheckbox.Location = new System.Drawing.Point(126, 48);
            this.SalamiCheckbox.Name = "SalamiCheckbox";
            this.SalamiCheckbox.Size = new System.Drawing.Size(57, 17);
            this.SalamiCheckbox.TabIndex = 13;
            this.SalamiCheckbox.TabStop = false;
            this.SalamiCheckbox.Text = "Salami";
            this.SalamiCheckbox.UseVisualStyleBackColor = true;
            // 
            // HamCheckbox
            // 
            this.HamCheckbox.AutoSize = true;
            this.HamCheckbox.Location = new System.Drawing.Point(12, 86);
            this.HamCheckbox.Name = "HamCheckbox";
            this.HamCheckbox.Size = new System.Drawing.Size(48, 17);
            this.HamCheckbox.TabIndex = 14;
            this.HamCheckbox.TabStop = false;
            this.HamCheckbox.Text = "Ham";
            this.HamCheckbox.UseVisualStyleBackColor = true;
            // 
            // MushroomsCheckbox
            // 
            this.MushroomsCheckbox.AutoSize = true;
            this.MushroomsCheckbox.Location = new System.Drawing.Point(126, 86);
            this.MushroomsCheckbox.Name = "MushroomsCheckbox";
            this.MushroomsCheckbox.Size = new System.Drawing.Size(80, 17);
            this.MushroomsCheckbox.TabIndex = 15;
            this.MushroomsCheckbox.TabStop = false;
            this.MushroomsCheckbox.Text = "Mushrooms";
            this.MushroomsCheckbox.UseVisualStyleBackColor = true;
            // 
            // ExtrasLabel
            // 
            this.ExtrasLabel.AutoSize = true;
            this.ExtrasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExtrasLabel.Location = new System.Drawing.Point(19, 9);
            this.ExtrasLabel.Name = "ExtrasLabel";
            this.ExtrasLabel.Size = new System.Drawing.Size(164, 24);
            this.ExtrasLabel.TabIndex = 16;
            this.ExtrasLabel.Text = "Select your extras!";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(126, 126);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 126);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExtrasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 161);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ExtrasLabel);
            this.Controls.Add(this.MushroomsCheckbox);
            this.Controls.Add(this.HamCheckbox);
            this.Controls.Add(this.SalamiCheckbox);
            this.Controls.Add(this.DoubleCheeseCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtrasPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtrasPanel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DoubleCheeseCheckbox;
        private System.Windows.Forms.CheckBox SalamiCheckbox;
        private System.Windows.Forms.CheckBox HamCheckbox;
        private System.Windows.Forms.CheckBox MushroomsCheckbox;
        private System.Windows.Forms.Label ExtrasLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button BackButton;
    }
}