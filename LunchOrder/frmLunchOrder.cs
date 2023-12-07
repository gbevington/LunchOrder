namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        double subtotal = 0;
        double tax = 0;
        double orderTotal = 0;

        //menu prices
        const double hamburger = 6.95; const double pizza = 5.95; const double salad = 4.95;

        const double burgerAddOn = .75;
        const double pizzaAddOn = .50;
        const double saladAddon = .25;

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Exits program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //calculate subtotal, tax, and total 
        private void costOfLunch(Double entree)
        {
            subtotal = entree;
            tax = Math.Round((subtotal * .05), 2);
            orderTotal = subtotal + tax;

        }
        //adds burger to subtotal, displays burger add on buttons
        private void btnHamburger_CheckedChanged(object sender, EventArgs e)
        {
            costOfLunch(hamburger);

            //display hamburger add ons
            this.AddOns(labelBurgerAdd, btnBurgerVegetables, btnBurgerCondiments, btnBurgerFries);


        }
        //adds pizza to subtotal, displays pizza add on buttons

        private void btnPizza_CheckedChanged(object sender, EventArgs e)
        {
            costOfLunch(pizza);

            //display pizza add ons
            this.AddOns(labelPizzaAdd, btnPizzaPepperoni, btnPizzaSausage, btnPizzaOlives);

        }
        //adds salad to subtotal, displays salad add on buttons

        private void btnSalad_CheckedChanged(object sender, EventArgs e)
        {
            costOfLunch(salad);

            //display salad add ons
            this.AddOns(labelSaladAdd, btnSaladCroutons, btnSaladBacon, btnSaladBread);

        }

        private void testText_Click(object sender, EventArgs e)
        {

        }

        //toggles add on buttons
        private void AddOns(Label price, Button btn1, Button btn2, Button btn3)
        {
            //display price and set of buttons relevant to the type passed as an argument
            price.Visible = !price.Visible;
            btn1.Visible = !btn1.Visible;           //check whether there is a way to pass indefinite # of arguments to a method
            btn2.Visible = !btn2.Visible;
            btn3.Visible = !btn3.Visible;
        }

        // displays subtotal, tax, and total
        private void btnOrder_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "$" + subtotal.ToString("c");
            txtTax.Text = "$" + tax.ToString("c");

            txtOrderTotal.Text = "$" + (orderTotal).ToString("c");
        }

        // clears all check boxes and unselects entree
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = null;
            txtTax.Text = null;
            txtOrderTotal.Text = null;

            btnHamburger.Checked = false;
            btnPizza.Checked = false;
            btnSalad.Checked = false;
        }
        // next three buttons add cost of hamburger add ons to subtotal
        private void btnBurgerVegetables_Click(object sender, EventArgs e)
        {
            subtotal += .75;
        }

        private void btnBurgerCondiments_Click(object sender, EventArgs e)
        {
            subtotal += .75;
        }

        private void btnBurgerFries_Click(object sender, EventArgs e)
        {
            subtotal += .75;
        }
        //next three buttons add cost of pizza add ons to subtotal
        private void btnPizzaPepperoni_Click(object sender, EventArgs e)
        {
            subtotal += .5;
        }

        private void btnPizzaSausage_Click(object sender, EventArgs e)
        {
            subtotal += .5;
        }

        private void btnPizzaOlives_Click(object sender, EventArgs e)
        {
            subtotal += .5;
        }
        // next three buttons add cost of salad add ons to subtotal
        private void btnSaladCroutons_Click(object sender, EventArgs e)
        {
            subtotal += .25;                            // these nine buttons seem redundant in code - find a way to make a button event-handler generating method
        }

        private void btnSaladBacon_Click(object sender, EventArgs e)
        {
            subtotal += .25;
        }

        private void btnSaladBread_Click(object sender, EventArgs e)
        {
            subtotal += .25;
        }
    }
}