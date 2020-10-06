namespace PizzaApp
{
    partial class HistoryWindow
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
            this.dbDataGridView = new System.Windows.Forms.DataGridView();
            this.RestaurantOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbDataGridView
            // 
            this.dbDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbDataGridView.Location = new System.Drawing.Point(12, 45);
            this.dbDataGridView.Name = "dbDataGridView";
            this.dbDataGridView.Size = new System.Drawing.Size(545, 153);
            this.dbDataGridView.TabIndex = 0;
            // 
            // RestaurantOrderLabel
            // 
            this.RestaurantOrderLabel.AutoSize = true;
            this.RestaurantOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RestaurantOrderLabel.Location = new System.Drawing.Point(184, 9);
            this.RestaurantOrderLabel.Name = "RestaurantOrderLabel";
            this.RestaurantOrderLabel.Size = new System.Drawing.Size(243, 25);
            this.RestaurantOrderLabel.TabIndex = 1;
            this.RestaurantOrderLabel.Text = "Restaurant order history";
            // 
            // HistoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 221);
            this.Controls.Add(this.RestaurantOrderLabel);
            this.Controls.Add(this.dbDataGridView);
            this.Name = "HistoryWindow";
            this.Text = "Order History";
            this.Load += new System.EventHandler(this.HistoryWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbDataGridView;
        private System.Windows.Forms.Label RestaurantOrderLabel;
    }
}