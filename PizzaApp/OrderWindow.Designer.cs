namespace PizzaApp
{
    partial class OrderWindow
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
            this.MargherittaPlus = new System.Windows.Forms.Button();
            this.MargherittaCountBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.MargherittaLabel = new System.Windows.Forms.Label();
            this.OrderTabs = new System.Windows.Forms.TabControl();
            this.PizzaTab = new System.Windows.Forms.TabPage();
            this.VeneciaPlus = new System.Windows.Forms.Button();
            this.VeneciaCountBox = new System.Windows.Forms.TextBox();
            this.VeneciaMinus = new System.Windows.Forms.Button();
            this.VeneciaLabel = new System.Windows.Forms.Label();
            this.ToscaPlus = new System.Windows.Forms.Button();
            this.ToscaCountBox = new System.Windows.Forms.TextBox();
            this.ToscaMinus = new System.Windows.Forms.Button();
            this.ToscaLabel = new System.Windows.Forms.Label();
            this.VegeterianaPlus = new System.Windows.Forms.Button();
            this.VegeterianaCountBox = new System.Windows.Forms.TextBox();
            this.VegeterianaMinus = new System.Windows.Forms.Button();
            this.VegeterianaLabel = new System.Windows.Forms.Label();
            this.MargherittaMinus = new System.Windows.Forms.Button();
            this.DishesTab = new System.Windows.Forms.TabPage();
            this.HungarianCountBox = new System.Windows.Forms.TextBox();
            this.HungarianCakePlus = new System.Windows.Forms.Button();
            this.HungarianCakeMinus = new System.Windows.Forms.Button();
            this.HungarianCakeLabel = new System.Windows.Forms.Label();
            this.FishPlus = new System.Windows.Forms.Button();
            this.FishCountBox = new System.Windows.Forms.TextBox();
            this.FishMinus = new System.Windows.Forms.Button();
            this.FishFriesLabel = new System.Windows.Forms.Label();
            this.PorkHopPlus = new System.Windows.Forms.Button();
            this.PorkHopCountBox = new System.Windows.Forms.TextBox();
            this.PorkhopMinus = new System.Windows.Forms.Button();
            this.PorkHopLabel = new System.Windows.Forms.Label();
            this.SoupsTab = new System.Windows.Forms.TabPage();
            this.ChickenSoupPlus = new System.Windows.Forms.Button();
            this.ChickenSoupCountBox = new System.Windows.Forms.TextBox();
            this.ChickenSoupMinus = new System.Windows.Forms.Button();
            this.ChickenSoulLabel = new System.Windows.Forms.Label();
            this.TomatoSoupPlus = new System.Windows.Forms.Button();
            this.TomatoSoupCountBox = new System.Windows.Forms.TextBox();
            this.TomatoSoupLabel = new System.Windows.Forms.Label();
            this.TomatoSoupMinus = new System.Windows.Forms.Button();
            this.DrinksTab = new System.Windows.Forms.TabPage();
            this.ColaPlus = new System.Windows.Forms.Button();
            this.ColaCountBox = new System.Windows.Forms.TextBox();
            this.ColaMinus = new System.Windows.Forms.Button();
            this.ColaLabel = new System.Windows.Forms.Label();
            this.TeaPlus = new System.Windows.Forms.Button();
            this.TeaCountBox = new System.Windows.Forms.TextBox();
            this.TeaMinus = new System.Windows.Forms.Button();
            this.TeaLabel = new System.Windows.Forms.Label();
            this.CoffiePlus = new System.Windows.Forms.Button();
            this.CoffieCountBox = new System.Windows.Forms.TextBox();
            this.CoffieLabel = new System.Windows.Forms.Label();
            this.CoffieMinus = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ZlotyLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderTabs.SuspendLayout();
            this.PizzaTab.SuspendLayout();
            this.DishesTab.SuspendLayout();
            this.SoupsTab.SuspendLayout();
            this.DrinksTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MargherittaPlus
            // 
            this.MargherittaPlus.Location = new System.Drawing.Point(307, 19);
            this.MargherittaPlus.Name = "MargherittaPlus";
            this.MargherittaPlus.Size = new System.Drawing.Size(40, 20);
            this.MargherittaPlus.TabIndex = 0;
            this.MargherittaPlus.Text = "+";
            this.MargherittaPlus.UseVisualStyleBackColor = true;
            this.MargherittaPlus.Click += new System.EventHandler(this.MargherittaPlus_Click);
            // 
            // MargherittaCountBox
            // 
            this.MargherittaCountBox.Location = new System.Drawing.Point(261, 19);
            this.MargherittaCountBox.Name = "MargherittaCountBox";
            this.MargherittaCountBox.ReadOnly = true;
            this.MargherittaCountBox.Size = new System.Drawing.Size(40, 20);
            this.MargherittaCountBox.TabIndex = 1;
            this.MargherittaCountBox.Text = "0";
            this.MargherittaCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MargherittaCountBox.TextChanged += new System.EventHandler(this.MargherittaCountBox_TextChanged);
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(66, 212);
            this.CostBox.Name = "CostBox";
            this.CostBox.ReadOnly = true;
            this.CostBox.Size = new System.Drawing.Size(100, 20);
            this.CostBox.TabIndex = 2;
            this.CostBox.Text = "0";
            this.CostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MargherittaLabel
            // 
            this.MargherittaLabel.AutoSize = true;
            this.MargherittaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MargherittaLabel.Location = new System.Drawing.Point(5, 19);
            this.MargherittaLabel.Name = "MargherittaLabel";
            this.MargherittaLabel.Size = new System.Drawing.Size(90, 20);
            this.MargherittaLabel.TabIndex = 3;
            this.MargherittaLabel.Text = "Margheritta";
            // 
            // OrderTabs
            // 
            this.OrderTabs.Controls.Add(this.PizzaTab);
            this.OrderTabs.Controls.Add(this.DishesTab);
            this.OrderTabs.Controls.Add(this.SoupsTab);
            this.OrderTabs.Controls.Add(this.DrinksTab);
            this.OrderTabs.Location = new System.Drawing.Point(12, 12);
            this.OrderTabs.Name = "OrderTabs";
            this.OrderTabs.SelectedIndex = 0;
            this.OrderTabs.Size = new System.Drawing.Size(361, 175);
            this.OrderTabs.TabIndex = 4;
            this.OrderTabs.Tag = "";
            // 
            // PizzaTab
            // 
            this.PizzaTab.BackColor = System.Drawing.Color.White;
            this.PizzaTab.Controls.Add(this.VeneciaPlus);
            this.PizzaTab.Controls.Add(this.VeneciaCountBox);
            this.PizzaTab.Controls.Add(this.VeneciaMinus);
            this.PizzaTab.Controls.Add(this.VeneciaLabel);
            this.PizzaTab.Controls.Add(this.ToscaPlus);
            this.PizzaTab.Controls.Add(this.ToscaCountBox);
            this.PizzaTab.Controls.Add(this.ToscaMinus);
            this.PizzaTab.Controls.Add(this.ToscaLabel);
            this.PizzaTab.Controls.Add(this.VegeterianaPlus);
            this.PizzaTab.Controls.Add(this.VegeterianaCountBox);
            this.PizzaTab.Controls.Add(this.VegeterianaMinus);
            this.PizzaTab.Controls.Add(this.VegeterianaLabel);
            this.PizzaTab.Controls.Add(this.MargherittaMinus);
            this.PizzaTab.Controls.Add(this.MargherittaLabel);
            this.PizzaTab.Controls.Add(this.MargherittaCountBox);
            this.PizzaTab.Controls.Add(this.MargherittaPlus);
            this.PizzaTab.Location = new System.Drawing.Point(4, 22);
            this.PizzaTab.Name = "PizzaTab";
            this.PizzaTab.Padding = new System.Windows.Forms.Padding(3);
            this.PizzaTab.Size = new System.Drawing.Size(353, 149);
            this.PizzaTab.TabIndex = 0;
            this.PizzaTab.Text = "Pizza";
            // 
            // VeneciaPlus
            // 
            this.VeneciaPlus.Location = new System.Drawing.Point(307, 109);
            this.VeneciaPlus.Name = "VeneciaPlus";
            this.VeneciaPlus.Size = new System.Drawing.Size(40, 20);
            this.VeneciaPlus.TabIndex = 16;
            this.VeneciaPlus.Text = "+";
            this.VeneciaPlus.UseVisualStyleBackColor = true;
            this.VeneciaPlus.Click += new System.EventHandler(this.VeneciaPlus_Click);
            // 
            // VeneciaCountBox
            // 
            this.VeneciaCountBox.Location = new System.Drawing.Point(261, 109);
            this.VeneciaCountBox.Name = "VeneciaCountBox";
            this.VeneciaCountBox.ReadOnly = true;
            this.VeneciaCountBox.Size = new System.Drawing.Size(40, 20);
            this.VeneciaCountBox.TabIndex = 15;
            this.VeneciaCountBox.Text = "0";
            this.VeneciaCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VeneciaCountBox.TextChanged += new System.EventHandler(this.Venecia_TextChanged);
            // 
            // VeneciaMinus
            // 
            this.VeneciaMinus.Location = new System.Drawing.Point(215, 109);
            this.VeneciaMinus.Name = "VeneciaMinus";
            this.VeneciaMinus.Size = new System.Drawing.Size(40, 20);
            this.VeneciaMinus.TabIndex = 14;
            this.VeneciaMinus.Text = "-";
            this.VeneciaMinus.UseVisualStyleBackColor = true;
            this.VeneciaMinus.Click += new System.EventHandler(this.VeneciaMinus_Click);
            // 
            // VeneciaLabel
            // 
            this.VeneciaLabel.AutoSize = true;
            this.VeneciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VeneciaLabel.Location = new System.Drawing.Point(5, 109);
            this.VeneciaLabel.Name = "VeneciaLabel";
            this.VeneciaLabel.Size = new System.Drawing.Size(67, 20);
            this.VeneciaLabel.TabIndex = 13;
            this.VeneciaLabel.Text = "Venecia";
            // 
            // ToscaPlus
            // 
            this.ToscaPlus.Location = new System.Drawing.Point(307, 79);
            this.ToscaPlus.Name = "ToscaPlus";
            this.ToscaPlus.Size = new System.Drawing.Size(40, 20);
            this.ToscaPlus.TabIndex = 12;
            this.ToscaPlus.Text = "+";
            this.ToscaPlus.UseVisualStyleBackColor = true;
            this.ToscaPlus.Click += new System.EventHandler(this.ToscaPlus_Click);
            // 
            // ToscaCountBox
            // 
            this.ToscaCountBox.Location = new System.Drawing.Point(261, 79);
            this.ToscaCountBox.Name = "ToscaCountBox";
            this.ToscaCountBox.ReadOnly = true;
            this.ToscaCountBox.Size = new System.Drawing.Size(40, 20);
            this.ToscaCountBox.TabIndex = 11;
            this.ToscaCountBox.Text = "0";
            this.ToscaCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToscaCountBox.TextChanged += new System.EventHandler(this.Tosca_TextChanged);
            // 
            // ToscaMinus
            // 
            this.ToscaMinus.Location = new System.Drawing.Point(215, 79);
            this.ToscaMinus.Name = "ToscaMinus";
            this.ToscaMinus.Size = new System.Drawing.Size(40, 20);
            this.ToscaMinus.TabIndex = 10;
            this.ToscaMinus.Text = "-";
            this.ToscaMinus.UseVisualStyleBackColor = true;
            this.ToscaMinus.Click += new System.EventHandler(this.ToscaMinus_Click);
            // 
            // ToscaLabel
            // 
            this.ToscaLabel.AutoSize = true;
            this.ToscaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToscaLabel.Location = new System.Drawing.Point(5, 79);
            this.ToscaLabel.Name = "ToscaLabel";
            this.ToscaLabel.Size = new System.Drawing.Size(52, 20);
            this.ToscaLabel.TabIndex = 9;
            this.ToscaLabel.Text = "Tosca";
            // 
            // VegeterianaPlus
            // 
            this.VegeterianaPlus.Location = new System.Drawing.Point(307, 49);
            this.VegeterianaPlus.Name = "VegeterianaPlus";
            this.VegeterianaPlus.Size = new System.Drawing.Size(40, 20);
            this.VegeterianaPlus.TabIndex = 8;
            this.VegeterianaPlus.Text = "+";
            this.VegeterianaPlus.UseVisualStyleBackColor = true;
            this.VegeterianaPlus.Click += new System.EventHandler(this.VegeterianaPlus_Click);
            // 
            // VegeterianaCountBox
            // 
            this.VegeterianaCountBox.Location = new System.Drawing.Point(261, 49);
            this.VegeterianaCountBox.Name = "VegeterianaCountBox";
            this.VegeterianaCountBox.ReadOnly = true;
            this.VegeterianaCountBox.Size = new System.Drawing.Size(40, 20);
            this.VegeterianaCountBox.TabIndex = 7;
            this.VegeterianaCountBox.Text = "0";
            this.VegeterianaCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VegeterianaCountBox.TextChanged += new System.EventHandler(this.VegeterianaCountBox_TextChanged);
            // 
            // VegeterianaMinus
            // 
            this.VegeterianaMinus.Location = new System.Drawing.Point(215, 49);
            this.VegeterianaMinus.Name = "VegeterianaMinus";
            this.VegeterianaMinus.Size = new System.Drawing.Size(40, 20);
            this.VegeterianaMinus.TabIndex = 6;
            this.VegeterianaMinus.Text = "-";
            this.VegeterianaMinus.UseVisualStyleBackColor = true;
            this.VegeterianaMinus.Click += new System.EventHandler(this.VegeterianaMinus_Click);
            // 
            // VegeterianaLabel
            // 
            this.VegeterianaLabel.AutoSize = true;
            this.VegeterianaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VegeterianaLabel.Location = new System.Drawing.Point(5, 49);
            this.VegeterianaLabel.Name = "VegeterianaLabel";
            this.VegeterianaLabel.Size = new System.Drawing.Size(96, 20);
            this.VegeterianaLabel.TabIndex = 5;
            this.VegeterianaLabel.Text = "Vegeteriana";
            // 
            // MargherittaMinus
            // 
            this.MargherittaMinus.Location = new System.Drawing.Point(215, 19);
            this.MargherittaMinus.Name = "MargherittaMinus";
            this.MargherittaMinus.Size = new System.Drawing.Size(40, 20);
            this.MargherittaMinus.TabIndex = 4;
            this.MargherittaMinus.Text = "-";
            this.MargherittaMinus.UseVisualStyleBackColor = true;
            this.MargherittaMinus.Click += new System.EventHandler(this.MargherittaMinus_Click);
            // 
            // DishesTab
            // 
            this.DishesTab.Controls.Add(this.HungarianCountBox);
            this.DishesTab.Controls.Add(this.HungarianCakePlus);
            this.DishesTab.Controls.Add(this.HungarianCakeMinus);
            this.DishesTab.Controls.Add(this.HungarianCakeLabel);
            this.DishesTab.Controls.Add(this.FishPlus);
            this.DishesTab.Controls.Add(this.FishCountBox);
            this.DishesTab.Controls.Add(this.FishMinus);
            this.DishesTab.Controls.Add(this.FishFriesLabel);
            this.DishesTab.Controls.Add(this.PorkHopPlus);
            this.DishesTab.Controls.Add(this.PorkHopCountBox);
            this.DishesTab.Controls.Add(this.PorkhopMinus);
            this.DishesTab.Controls.Add(this.PorkHopLabel);
            this.DishesTab.Location = new System.Drawing.Point(4, 22);
            this.DishesTab.Name = "DishesTab";
            this.DishesTab.Padding = new System.Windows.Forms.Padding(3);
            this.DishesTab.Size = new System.Drawing.Size(353, 149);
            this.DishesTab.TabIndex = 1;
            this.DishesTab.Text = "Dishes";
            this.DishesTab.UseVisualStyleBackColor = true;
            // 
            // HungarianCountBox
            // 
            this.HungarianCountBox.Location = new System.Drawing.Point(261, 79);
            this.HungarianCountBox.Name = "HungarianCountBox";
            this.HungarianCountBox.ReadOnly = true;
            this.HungarianCountBox.Size = new System.Drawing.Size(40, 20);
            this.HungarianCountBox.TabIndex = 15;
            this.HungarianCountBox.Text = "0";
            this.HungarianCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HungarianCountBox.TextChanged += new System.EventHandler(this.HungarianCake_TextChanged);
            // 
            // HungarianCakePlus
            // 
            this.HungarianCakePlus.Location = new System.Drawing.Point(307, 79);
            this.HungarianCakePlus.Name = "HungarianCakePlus";
            this.HungarianCakePlus.Size = new System.Drawing.Size(40, 20);
            this.HungarianCakePlus.TabIndex = 14;
            this.HungarianCakePlus.Text = "+";
            this.HungarianCakePlus.UseVisualStyleBackColor = true;
            this.HungarianCakePlus.Click += new System.EventHandler(this.HungarianCakePlus_Click);
            // 
            // HungarianCakeMinus
            // 
            this.HungarianCakeMinus.Location = new System.Drawing.Point(215, 79);
            this.HungarianCakeMinus.Name = "HungarianCakeMinus";
            this.HungarianCakeMinus.Size = new System.Drawing.Size(40, 20);
            this.HungarianCakeMinus.TabIndex = 13;
            this.HungarianCakeMinus.Text = "-";
            this.HungarianCakeMinus.UseVisualStyleBackColor = true;
            this.HungarianCakeMinus.Click += new System.EventHandler(this.HungarianCakeMinus_Click);
            // 
            // HungarianCakeLabel
            // 
            this.HungarianCakeLabel.AutoSize = true;
            this.HungarianCakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HungarianCakeLabel.Location = new System.Drawing.Point(5, 79);
            this.HungarianCakeLabel.Name = "HungarianCakeLabel";
            this.HungarianCakeLabel.Size = new System.Drawing.Size(124, 20);
            this.HungarianCakeLabel.TabIndex = 12;
            this.HungarianCakeLabel.Text = "Hungarian Cake";
            // 
            // FishPlus
            // 
            this.FishPlus.Location = new System.Drawing.Point(307, 49);
            this.FishPlus.Name = "FishPlus";
            this.FishPlus.Size = new System.Drawing.Size(40, 20);
            this.FishPlus.TabIndex = 11;
            this.FishPlus.Text = "+";
            this.FishPlus.UseVisualStyleBackColor = true;
            this.FishPlus.Click += new System.EventHandler(this.FishPlus_Click);
            // 
            // FishCountBox
            // 
            this.FishCountBox.Location = new System.Drawing.Point(261, 49);
            this.FishCountBox.Name = "FishCountBox";
            this.FishCountBox.ReadOnly = true;
            this.FishCountBox.Size = new System.Drawing.Size(40, 20);
            this.FishCountBox.TabIndex = 10;
            this.FishCountBox.Text = "0";
            this.FishCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FishCountBox.TextChanged += new System.EventHandler(this.Fish_TextChanged);
            // 
            // FishMinus
            // 
            this.FishMinus.Location = new System.Drawing.Point(215, 49);
            this.FishMinus.Name = "FishMinus";
            this.FishMinus.Size = new System.Drawing.Size(40, 20);
            this.FishMinus.TabIndex = 9;
            this.FishMinus.Text = "-";
            this.FishMinus.UseVisualStyleBackColor = true;
            this.FishMinus.Click += new System.EventHandler(this.FishMinus_Click);
            // 
            // FishFriesLabel
            // 
            this.FishFriesLabel.AutoSize = true;
            this.FishFriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FishFriesLabel.Location = new System.Drawing.Point(5, 49);
            this.FishFriesLabel.Name = "FishFriesLabel";
            this.FishFriesLabel.Size = new System.Drawing.Size(110, 20);
            this.FishFriesLabel.TabIndex = 8;
            this.FishFriesLabel.Text = "Fish with Fries";
            // 
            // PorkHopPlus
            // 
            this.PorkHopPlus.Location = new System.Drawing.Point(307, 19);
            this.PorkHopPlus.Name = "PorkHopPlus";
            this.PorkHopPlus.Size = new System.Drawing.Size(40, 20);
            this.PorkHopPlus.TabIndex = 7;
            this.PorkHopPlus.Text = "+";
            this.PorkHopPlus.UseVisualStyleBackColor = true;
            this.PorkHopPlus.Click += new System.EventHandler(this.PorkHopPlus_Click);
            // 
            // PorkHopCountBox
            // 
            this.PorkHopCountBox.Location = new System.Drawing.Point(261, 19);
            this.PorkHopCountBox.Name = "PorkHopCountBox";
            this.PorkHopCountBox.ReadOnly = true;
            this.PorkHopCountBox.Size = new System.Drawing.Size(40, 20);
            this.PorkHopCountBox.TabIndex = 6;
            this.PorkHopCountBox.Text = "0";
            this.PorkHopCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PorkHopCountBox.TextChanged += new System.EventHandler(this.Porkhop_TextChanged);
            // 
            // PorkhopMinus
            // 
            this.PorkhopMinus.Location = new System.Drawing.Point(215, 19);
            this.PorkhopMinus.Name = "PorkhopMinus";
            this.PorkhopMinus.Size = new System.Drawing.Size(40, 20);
            this.PorkhopMinus.TabIndex = 5;
            this.PorkhopMinus.Text = "-";
            this.PorkhopMinus.UseVisualStyleBackColor = true;
            this.PorkhopMinus.Click += new System.EventHandler(this.PorkhopMinus_Click);
            // 
            // PorkHopLabel
            // 
            this.PorkHopLabel.AutoSize = true;
            this.PorkHopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PorkHopLabel.Location = new System.Drawing.Point(5, 19);
            this.PorkHopLabel.Name = "PorkHopLabel";
            this.PorkHopLabel.Size = new System.Drawing.Size(75, 20);
            this.PorkHopLabel.TabIndex = 0;
            this.PorkHopLabel.Text = "Pork Hop";
            // 
            // SoupsTab
            // 
            this.SoupsTab.Controls.Add(this.ChickenSoupPlus);
            this.SoupsTab.Controls.Add(this.ChickenSoupCountBox);
            this.SoupsTab.Controls.Add(this.ChickenSoupMinus);
            this.SoupsTab.Controls.Add(this.ChickenSoulLabel);
            this.SoupsTab.Controls.Add(this.TomatoSoupPlus);
            this.SoupsTab.Controls.Add(this.TomatoSoupCountBox);
            this.SoupsTab.Controls.Add(this.TomatoSoupLabel);
            this.SoupsTab.Controls.Add(this.TomatoSoupMinus);
            this.SoupsTab.Location = new System.Drawing.Point(4, 22);
            this.SoupsTab.Name = "SoupsTab";
            this.SoupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SoupsTab.Size = new System.Drawing.Size(353, 149);
            this.SoupsTab.TabIndex = 2;
            this.SoupsTab.Text = "Soups";
            this.SoupsTab.UseVisualStyleBackColor = true;
            // 
            // ChickenSoupPlus
            // 
            this.ChickenSoupPlus.Location = new System.Drawing.Point(307, 49);
            this.ChickenSoupPlus.Name = "ChickenSoupPlus";
            this.ChickenSoupPlus.Size = new System.Drawing.Size(40, 20);
            this.ChickenSoupPlus.TabIndex = 12;
            this.ChickenSoupPlus.Text = "+";
            this.ChickenSoupPlus.UseVisualStyleBackColor = true;
            this.ChickenSoupPlus.Click += new System.EventHandler(this.ChickenSoupPlus_Click);
            // 
            // ChickenSoupCountBox
            // 
            this.ChickenSoupCountBox.Location = new System.Drawing.Point(261, 49);
            this.ChickenSoupCountBox.Name = "ChickenSoupCountBox";
            this.ChickenSoupCountBox.ReadOnly = true;
            this.ChickenSoupCountBox.Size = new System.Drawing.Size(40, 20);
            this.ChickenSoupCountBox.TabIndex = 11;
            this.ChickenSoupCountBox.Text = "0";
            this.ChickenSoupCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChickenSoupCountBox.TextChanged += new System.EventHandler(this.ChickenSoup_TextChanged);
            // 
            // ChickenSoupMinus
            // 
            this.ChickenSoupMinus.Location = new System.Drawing.Point(215, 49);
            this.ChickenSoupMinus.Name = "ChickenSoupMinus";
            this.ChickenSoupMinus.Size = new System.Drawing.Size(40, 20);
            this.ChickenSoupMinus.TabIndex = 10;
            this.ChickenSoupMinus.Text = "-";
            this.ChickenSoupMinus.UseVisualStyleBackColor = true;
            this.ChickenSoupMinus.Click += new System.EventHandler(this.ChickenSoupMinus_Click);
            // 
            // ChickenSoulLabel
            // 
            this.ChickenSoulLabel.AutoSize = true;
            this.ChickenSoulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChickenSoulLabel.Location = new System.Drawing.Point(5, 49);
            this.ChickenSoulLabel.Name = "ChickenSoulLabel";
            this.ChickenSoulLabel.Size = new System.Drawing.Size(108, 20);
            this.ChickenSoulLabel.TabIndex = 9;
            this.ChickenSoulLabel.Text = "Chicken Soup";
            // 
            // TomatoSoupPlus
            // 
            this.TomatoSoupPlus.Location = new System.Drawing.Point(307, 19);
            this.TomatoSoupPlus.Name = "TomatoSoupPlus";
            this.TomatoSoupPlus.Size = new System.Drawing.Size(40, 20);
            this.TomatoSoupPlus.TabIndex = 8;
            this.TomatoSoupPlus.Text = "+";
            this.TomatoSoupPlus.UseVisualStyleBackColor = true;
            this.TomatoSoupPlus.Click += new System.EventHandler(this.TomatoSoupPlus_Click);
            // 
            // TomatoSoupCountBox
            // 
            this.TomatoSoupCountBox.Location = new System.Drawing.Point(261, 19);
            this.TomatoSoupCountBox.Name = "TomatoSoupCountBox";
            this.TomatoSoupCountBox.ReadOnly = true;
            this.TomatoSoupCountBox.Size = new System.Drawing.Size(40, 20);
            this.TomatoSoupCountBox.TabIndex = 7;
            this.TomatoSoupCountBox.Text = "0";
            this.TomatoSoupCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TomatoSoupCountBox.TextChanged += new System.EventHandler(this.TomatoSoup_TextChanged);
            // 
            // TomatoSoupLabel
            // 
            this.TomatoSoupLabel.AutoSize = true;
            this.TomatoSoupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TomatoSoupLabel.Location = new System.Drawing.Point(5, 19);
            this.TomatoSoupLabel.Name = "TomatoSoupLabel";
            this.TomatoSoupLabel.Size = new System.Drawing.Size(105, 20);
            this.TomatoSoupLabel.TabIndex = 1;
            this.TomatoSoupLabel.Text = "Tomato Soup";
            // 
            // TomatoSoupMinus
            // 
            this.TomatoSoupMinus.Location = new System.Drawing.Point(215, 19);
            this.TomatoSoupMinus.Name = "TomatoSoupMinus";
            this.TomatoSoupMinus.Size = new System.Drawing.Size(40, 20);
            this.TomatoSoupMinus.TabIndex = 6;
            this.TomatoSoupMinus.Text = "-";
            this.TomatoSoupMinus.UseVisualStyleBackColor = true;
            this.TomatoSoupMinus.Click += new System.EventHandler(this.TomatoSoupMinus_Click);
            // 
            // DrinksTab
            // 
            this.DrinksTab.Controls.Add(this.ColaPlus);
            this.DrinksTab.Controls.Add(this.ColaCountBox);
            this.DrinksTab.Controls.Add(this.ColaMinus);
            this.DrinksTab.Controls.Add(this.ColaLabel);
            this.DrinksTab.Controls.Add(this.TeaPlus);
            this.DrinksTab.Controls.Add(this.TeaCountBox);
            this.DrinksTab.Controls.Add(this.TeaMinus);
            this.DrinksTab.Controls.Add(this.TeaLabel);
            this.DrinksTab.Controls.Add(this.CoffiePlus);
            this.DrinksTab.Controls.Add(this.CoffieCountBox);
            this.DrinksTab.Controls.Add(this.CoffieLabel);
            this.DrinksTab.Controls.Add(this.CoffieMinus);
            this.DrinksTab.Location = new System.Drawing.Point(4, 22);
            this.DrinksTab.Name = "DrinksTab";
            this.DrinksTab.Padding = new System.Windows.Forms.Padding(3);
            this.DrinksTab.Size = new System.Drawing.Size(353, 149);
            this.DrinksTab.TabIndex = 3;
            this.DrinksTab.Text = "Drinks";
            this.DrinksTab.UseVisualStyleBackColor = true;
            // 
            // ColaPlus
            // 
            this.ColaPlus.Location = new System.Drawing.Point(307, 79);
            this.ColaPlus.Name = "ColaPlus";
            this.ColaPlus.Size = new System.Drawing.Size(40, 20);
            this.ColaPlus.TabIndex = 18;
            this.ColaPlus.Text = "+";
            this.ColaPlus.UseVisualStyleBackColor = true;
            this.ColaPlus.Click += new System.EventHandler(this.ColaPlus_Click);
            // 
            // ColaCountBox
            // 
            this.ColaCountBox.Location = new System.Drawing.Point(261, 79);
            this.ColaCountBox.Name = "ColaCountBox";
            this.ColaCountBox.ReadOnly = true;
            this.ColaCountBox.Size = new System.Drawing.Size(40, 20);
            this.ColaCountBox.TabIndex = 17;
            this.ColaCountBox.Text = "0";
            this.ColaCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColaCountBox.TextChanged += new System.EventHandler(this.Cola_TextChanged);
            // 
            // ColaMinus
            // 
            this.ColaMinus.Location = new System.Drawing.Point(215, 79);
            this.ColaMinus.Name = "ColaMinus";
            this.ColaMinus.Size = new System.Drawing.Size(40, 20);
            this.ColaMinus.TabIndex = 16;
            this.ColaMinus.Text = "-";
            this.ColaMinus.UseVisualStyleBackColor = true;
            this.ColaMinus.Click += new System.EventHandler(this.ColaMinus_Click);
            // 
            // ColaLabel
            // 
            this.ColaLabel.AutoSize = true;
            this.ColaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColaLabel.Location = new System.Drawing.Point(5, 79);
            this.ColaLabel.Name = "ColaLabel";
            this.ColaLabel.Size = new System.Drawing.Size(41, 20);
            this.ColaLabel.TabIndex = 15;
            this.ColaLabel.Text = "Cola";
            // 
            // TeaPlus
            // 
            this.TeaPlus.Location = new System.Drawing.Point(307, 49);
            this.TeaPlus.Name = "TeaPlus";
            this.TeaPlus.Size = new System.Drawing.Size(40, 20);
            this.TeaPlus.TabIndex = 14;
            this.TeaPlus.Text = "+";
            this.TeaPlus.UseVisualStyleBackColor = true;
            this.TeaPlus.Click += new System.EventHandler(this.TeaPlus_Click);
            // 
            // TeaCountBox
            // 
            this.TeaCountBox.Location = new System.Drawing.Point(261, 49);
            this.TeaCountBox.Name = "TeaCountBox";
            this.TeaCountBox.ReadOnly = true;
            this.TeaCountBox.Size = new System.Drawing.Size(40, 20);
            this.TeaCountBox.TabIndex = 13;
            this.TeaCountBox.Text = "0";
            this.TeaCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TeaCountBox.TextChanged += new System.EventHandler(this.Tea_TextChanged);
            // 
            // TeaMinus
            // 
            this.TeaMinus.Location = new System.Drawing.Point(215, 49);
            this.TeaMinus.Name = "TeaMinus";
            this.TeaMinus.Size = new System.Drawing.Size(40, 20);
            this.TeaMinus.TabIndex = 12;
            this.TeaMinus.Text = "-";
            this.TeaMinus.UseVisualStyleBackColor = true;
            this.TeaMinus.Click += new System.EventHandler(this.TeaMinus_Click);
            // 
            // TeaLabel
            // 
            this.TeaLabel.AutoSize = true;
            this.TeaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeaLabel.Location = new System.Drawing.Point(5, 49);
            this.TeaLabel.Name = "TeaLabel";
            this.TeaLabel.Size = new System.Drawing.Size(36, 20);
            this.TeaLabel.TabIndex = 11;
            this.TeaLabel.Text = "Tea";
            // 
            // CoffiePlus
            // 
            this.CoffiePlus.Location = new System.Drawing.Point(307, 19);
            this.CoffiePlus.Name = "CoffiePlus";
            this.CoffiePlus.Size = new System.Drawing.Size(40, 20);
            this.CoffiePlus.TabIndex = 10;
            this.CoffiePlus.Text = "+";
            this.CoffiePlus.UseVisualStyleBackColor = true;
            this.CoffiePlus.Click += new System.EventHandler(this.CoffiePlus_Click);
            // 
            // CoffieCountBox
            // 
            this.CoffieCountBox.Location = new System.Drawing.Point(261, 19);
            this.CoffieCountBox.Name = "CoffieCountBox";
            this.CoffieCountBox.ReadOnly = true;
            this.CoffieCountBox.Size = new System.Drawing.Size(40, 20);
            this.CoffieCountBox.TabIndex = 9;
            this.CoffieCountBox.Text = "0";
            this.CoffieCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CoffieCountBox.TextChanged += new System.EventHandler(this.Coffie_TextChanged);
            // 
            // CoffieLabel
            // 
            this.CoffieLabel.AutoSize = true;
            this.CoffieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CoffieLabel.Location = new System.Drawing.Point(5, 19);
            this.CoffieLabel.Name = "CoffieLabel";
            this.CoffieLabel.Size = new System.Drawing.Size(51, 20);
            this.CoffieLabel.TabIndex = 8;
            this.CoffieLabel.Text = "Coffie";
            // 
            // CoffieMinus
            // 
            this.CoffieMinus.Location = new System.Drawing.Point(215, 19);
            this.CoffieMinus.Name = "CoffieMinus";
            this.CoffieMinus.Size = new System.Drawing.Size(40, 20);
            this.CoffieMinus.TabIndex = 7;
            this.CoffieMinus.Text = "-";
            this.CoffieMinus.UseVisualStyleBackColor = true;
            this.CoffieMinus.Click += new System.EventHandler(this.CoffieMinus_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CostLabel.Location = new System.Drawing.Point(8, 207);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(52, 24);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(147, 247);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ZlotyLabel
            // 
            this.ZlotyLabel.AutoSize = true;
            this.ZlotyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZlotyLabel.Location = new System.Drawing.Point(185, 214);
            this.ZlotyLabel.Name = "ZlotyLabel";
            this.ZlotyLabel.Size = new System.Drawing.Size(37, 18);
            this.ZlotyLabel.TabIndex = 8;
            this.ZlotyLabel.Text = "PLN";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 247);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 291);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ZlotyLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.OrderTabs);
            this.Controls.Add(this.CostBox);
            this.Name = "OrderWindow";
            this.Text = "Making Order";
            this.OrderTabs.ResumeLayout(false);
            this.PizzaTab.ResumeLayout(false);
            this.PizzaTab.PerformLayout();
            this.DishesTab.ResumeLayout(false);
            this.DishesTab.PerformLayout();
            this.SoupsTab.ResumeLayout(false);
            this.SoupsTab.PerformLayout();
            this.DrinksTab.ResumeLayout(false);
            this.DrinksTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MargherittaPlus;
        private System.Windows.Forms.TextBox MargherittaCountBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label MargherittaLabel;
        private System.Windows.Forms.TabControl OrderTabs;
        private System.Windows.Forms.TabPage PizzaTab;
        private System.Windows.Forms.Button MargherittaMinus;
        private System.Windows.Forms.TabPage DishesTab;
        private System.Windows.Forms.TabPage SoupsTab;
        private System.Windows.Forms.TabPage DrinksTab;
        private System.Windows.Forms.Button VegeterianaMinus;
        private System.Windows.Forms.Label VegeterianaLabel;
        private System.Windows.Forms.TextBox VegeterianaCountBox;
        private System.Windows.Forms.Button VegeterianaPlus;
        private System.Windows.Forms.Button VeneciaPlus;
        private System.Windows.Forms.TextBox VeneciaCountBox;
        private System.Windows.Forms.Button VeneciaMinus;
        private System.Windows.Forms.Label VeneciaLabel;
        private System.Windows.Forms.Button ToscaPlus;
        private System.Windows.Forms.TextBox ToscaCountBox;
        private System.Windows.Forms.Button ToscaMinus;
        private System.Windows.Forms.Label ToscaLabel;
        private System.Windows.Forms.TextBox HungarianCountBox;
        private System.Windows.Forms.Button HungarianCakePlus;
        private System.Windows.Forms.Button HungarianCakeMinus;
        private System.Windows.Forms.Label HungarianCakeLabel;
        private System.Windows.Forms.Button FishPlus;
        private System.Windows.Forms.TextBox FishCountBox;
        private System.Windows.Forms.Button FishMinus;
        private System.Windows.Forms.Label FishFriesLabel;
        private System.Windows.Forms.Button PorkHopPlus;
        private System.Windows.Forms.TextBox PorkHopCountBox;
        private System.Windows.Forms.Button PorkhopMinus;
        private System.Windows.Forms.Label PorkHopLabel;
        private System.Windows.Forms.Label TomatoSoupLabel;
        private System.Windows.Forms.Button TomatoSoupMinus;
        private System.Windows.Forms.Button ChickenSoupPlus;
        private System.Windows.Forms.TextBox ChickenSoupCountBox;
        private System.Windows.Forms.Button ChickenSoupMinus;
        private System.Windows.Forms.Label ChickenSoulLabel;
        private System.Windows.Forms.Button TomatoSoupPlus;
        private System.Windows.Forms.TextBox TomatoSoupCountBox;
        private System.Windows.Forms.Button ColaPlus;
        private System.Windows.Forms.TextBox ColaCountBox;
        private System.Windows.Forms.Button ColaMinus;
        private System.Windows.Forms.Label ColaLabel;
        private System.Windows.Forms.Button TeaPlus;
        private System.Windows.Forms.TextBox TeaCountBox;
        private System.Windows.Forms.Button TeaMinus;
        private System.Windows.Forms.Label TeaLabel;
        private System.Windows.Forms.Button CoffiePlus;
        private System.Windows.Forms.TextBox CoffieCountBox;
        private System.Windows.Forms.Label CoffieLabel;
        private System.Windows.Forms.Button CoffieMinus;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label ZlotyLabel;
        private System.Windows.Forms.Button BackButton;
    }
}