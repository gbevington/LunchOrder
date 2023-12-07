namespace LunchOrder
{
    partial class frmLunchOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            txtOrderTotal = new TextBox();
            btnOrder = new Button();
            btnReset = new Button();
            btnExit = new Button();
            btnHamburger = new RadioButton();
            btnPizza = new RadioButton();
            btnSalad = new RadioButton();
            btnBurgerFries = new Button();
            btnBurgerCondiments = new Button();
            btnBurgerVegetables = new Button();
            btnPizzaPepperoni = new Button();
            btnPizzaSausage = new Button();
            btnPizzaOlives = new Button();
            labelBurgerAdd = new Label();
            btnSaladCroutons = new Button();
            btnSaladBacon = new Button();
            btnSaladBread = new Button();
            labelPizzaAdd = new Label();
            labelSaladAdd = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "Main Course";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 214);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 8;
            label3.Text = "Order Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 234);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 263);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 10;
            label5.Text = "Tax (%5):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 292);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 11;
            label6.Text = "Order Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(175, 231);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 12;
            txtSubtotal.TabStop = false;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(175, 260);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 13;
            txtTax.TabStop = false;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(175, 289);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(100, 23);
            txtOrderTotal.TabIndex = 14;
            txtOrderTotal.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(324, 205);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(153, 40);
            btnOrder.TabIndex = 15;
            btnOrder.Text = "Place Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(324, 251);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(153, 40);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(324, 298);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 40);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHamburger
            // 
            btnHamburger.AutoSize = true;
            btnHamburger.Location = new Point(80, 65);
            btnHamburger.Name = "btnHamburger";
            btnHamburger.Size = new Size(124, 19);
            btnHamburger.TabIndex = 18;
            btnHamburger.TabStop = true;
            btnHamburger.Text = "Hamburger - $6.95";
            btnHamburger.UseVisualStyleBackColor = true;
            btnHamburger.CheckedChanged += btnHamburger_CheckedChanged;
            // 
            // btnPizza
            // 
            btnPizza.AutoSize = true;
            btnPizza.Location = new Point(80, 111);
            btnPizza.Name = "btnPizza";
            btnPizza.Size = new Size(89, 19);
            btnPizza.TabIndex = 19;
            btnPizza.TabStop = true;
            btnPizza.Text = "Pizza - $5.95";
            btnPizza.UseVisualStyleBackColor = true;
            btnPizza.CheckedChanged += btnPizza_CheckedChanged;
            // 
            // btnSalad
            // 
            btnSalad.AutoSize = true;
            btnSalad.Location = new Point(80, 158);
            btnSalad.Name = "btnSalad";
            btnSalad.Size = new Size(91, 19);
            btnSalad.TabIndex = 20;
            btnSalad.TabStop = true;
            btnSalad.Text = "Salad - $4.95";
            btnSalad.UseVisualStyleBackColor = true;
            btnSalad.CheckedChanged += btnSalad_CheckedChanged;
            // 
            // btnBurgerFries
            // 
            btnBurgerFries.Location = new Point(281, 156);
            btnBurgerFries.Name = "btnBurgerFries";
            btnBurgerFries.Size = new Size(109, 23);
            btnBurgerFries.TabIndex = 24;
            btnBurgerFries.Text = "French Fries";
            btnBurgerFries.UseVisualStyleBackColor = true;
            btnBurgerFries.Visible = false;
            btnBurgerFries.Click += btnBurgerFries_Click;
            // 
            // btnBurgerCondiments
            // 
            btnBurgerCondiments.Location = new Point(206, 109);
            btnBurgerCondiments.Name = "btnBurgerCondiments";
            btnBurgerCondiments.Size = new Size(184, 23);
            btnBurgerCondiments.TabIndex = 25;
            btnBurgerCondiments.Text = "Ketchup, mustard, and mayo";
            btnBurgerCondiments.UseVisualStyleBackColor = true;
            btnBurgerCondiments.Visible = false;
            btnBurgerCondiments.Click += btnBurgerCondiments_Click;
            // 
            // btnBurgerVegetables
            // 
            btnBurgerVegetables.Location = new Point(206, 63);
            btnBurgerVegetables.Name = "btnBurgerVegetables";
            btnBurgerVegetables.Size = new Size(184, 23);
            btnBurgerVegetables.TabIndex = 26;
            btnBurgerVegetables.Text = "Lettuce, tomatoes, and onions";
            btnBurgerVegetables.UseVisualStyleBackColor = true;
            btnBurgerVegetables.Visible = false;
            btnBurgerVegetables.Click += btnBurgerVegetables_Click;
            // 
            // btnPizzaPepperoni
            // 
            btnPizzaPepperoni.Location = new Point(404, 65);
            btnPizzaPepperoni.Name = "btnPizzaPepperoni";
            btnPizzaPepperoni.Size = new Size(73, 23);
            btnPizzaPepperoni.TabIndex = 29;
            btnPizzaPepperoni.Text = "Pepperoni";
            btnPizzaPepperoni.UseVisualStyleBackColor = true;
            btnPizzaPepperoni.Visible = false;
            btnPizzaPepperoni.Click += btnPizzaPepperoni_Click;
            // 
            // btnPizzaSausage
            // 
            btnPizzaSausage.Location = new Point(404, 111);
            btnPizzaSausage.Name = "btnPizzaSausage";
            btnPizzaSausage.Size = new Size(73, 23);
            btnPizzaSausage.TabIndex = 28;
            btnPizzaSausage.Text = "Sausage";
            btnPizzaSausage.UseVisualStyleBackColor = true;
            btnPizzaSausage.Visible = false;
            btnPizzaSausage.Click += btnPizzaSausage_Click;
            // 
            // btnPizzaOlives
            // 
            btnPizzaOlives.Location = new Point(404, 158);
            btnPizzaOlives.Name = "btnPizzaOlives";
            btnPizzaOlives.Size = new Size(73, 23);
            btnPizzaOlives.TabIndex = 27;
            btnPizzaOlives.Text = "Olives";
            btnPizzaOlives.UseVisualStyleBackColor = true;
            btnPizzaOlives.Visible = false;
            btnPizzaOlives.Click += btnPizzaOlives_Click;
            // 
            // labelBurgerAdd
            // 
            labelBurgerAdd.AutoSize = true;
            labelBurgerAdd.Location = new Point(206, 36);
            labelBurgerAdd.Name = "labelBurgerAdd";
            labelBurgerAdd.Size = new Size(148, 15);
            labelBurgerAdd.TabIndex = 30;
            labelBurgerAdd.Text = "Add-on items ($0.75/each)";
            labelBurgerAdd.Visible = false;
            // 
            // btnSaladCroutons
            // 
            btnSaladCroutons.Location = new Point(498, 65);
            btnSaladCroutons.Name = "btnSaladCroutons";
            btnSaladCroutons.Size = new Size(73, 23);
            btnSaladCroutons.TabIndex = 33;
            btnSaladCroutons.Text = "Croutons";
            btnSaladCroutons.UseVisualStyleBackColor = true;
            btnSaladCroutons.Visible = false;
            btnSaladCroutons.Click += btnSaladCroutons_Click;
            // 
            // btnSaladBacon
            // 
            btnSaladBacon.Location = new Point(498, 111);
            btnSaladBacon.Name = "btnSaladBacon";
            btnSaladBacon.Size = new Size(73, 23);
            btnSaladBacon.TabIndex = 32;
            btnSaladBacon.Text = "Bacon Bits";
            btnSaladBacon.UseVisualStyleBackColor = true;
            btnSaladBacon.Visible = false;
            btnSaladBacon.Click += btnSaladBacon_Click;
            // 
            // btnSaladBread
            // 
            btnSaladBread.Location = new Point(498, 158);
            btnSaladBread.Name = "btnSaladBread";
            btnSaladBread.Size = new Size(73, 23);
            btnSaladBread.TabIndex = 31;
            btnSaladBread.Text = "Bread Sticks";
            btnSaladBread.UseVisualStyleBackColor = true;
            btnSaladBread.Visible = false;
            btnSaladBread.Click += btnSaladBread_Click;
            // 
            // labelPizzaAdd
            // 
            labelPizzaAdd.AutoSize = true;
            labelPizzaAdd.Location = new Point(404, 36);
            labelPizzaAdd.Name = "labelPizzaAdd";
            labelPizzaAdd.Size = new Size(148, 15);
            labelPizzaAdd.TabIndex = 34;
            labelPizzaAdd.Text = "Add-on items ($0.50/each)";
            labelPizzaAdd.Visible = false;
            // 
            // labelSaladAdd
            // 
            labelSaladAdd.AutoSize = true;
            labelSaladAdd.Location = new Point(498, 36);
            labelSaladAdd.Name = "labelSaladAdd";
            labelSaladAdd.Size = new Size(148, 15);
            labelSaladAdd.TabIndex = 35;
            labelSaladAdd.Text = "Add-on items ($0.25/each)";
            labelSaladAdd.Visible = false;
            // 
            // frmLunchOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSaladAdd);
            Controls.Add(labelPizzaAdd);
            Controls.Add(btnSaladCroutons);
            Controls.Add(btnSaladBacon);
            Controls.Add(btnSaladBread);
            Controls.Add(labelBurgerAdd);
            Controls.Add(btnPizzaPepperoni);
            Controls.Add(btnPizzaSausage);
            Controls.Add(btnPizzaOlives);
            Controls.Add(btnBurgerVegetables);
            Controls.Add(btnBurgerCondiments);
            Controls.Add(btnBurgerFries);
            Controls.Add(btnSalad);
            Controls.Add(btnPizza);
            Controls.Add(btnHamburger);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(txtOrderTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmLunchOrder";
            Text = "Lunch Order";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtOrderTotal;
        private Button btnOrder;
        private Button btnReset;
        private Button btnExit;
        private RadioButton btnHamburger;
        private RadioButton btnPizza;
        private RadioButton btnSalad;
        private Button btnBurgerFries;
        private Button btnBurgerCondiments;
        private Button btnBurgerVegetables;
        private Button btnPizzaPepperoni;
        private Button btnPizzaSausage;
        private Button btnPizzaOlives;
        private Label labelBurgerAdd;
        private Button btnSaladCroutons;
        private Button btnSaladBacon;
        private Button btnSaladBread;
        private Label labelPizzaAdd;
        private Label labelSaladAdd;
    }
}