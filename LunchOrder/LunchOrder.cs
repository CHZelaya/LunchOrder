namespace LunchOrder
{
    //Information on Author
    // Author:  Carlos Hernandez-Zelaya
    // Date:    10/26/2024
    // Class:   RAD OOSD (CRPG 200-A)
    // Purpose: This application calculates the total cost of a lunch order based on the user's selection of a main course and add-ons.

    public partial class FRMLunchOrder : Form
    {   // CONST GLOBAL VARIABLES DECLARED

        // Pricing for the lunch items
        const decimal HAMBURGER_PRICE = 6.95m;
        const decimal PIZZA_PRICE = 5.95m;
        const decimal SALAD_PRICE = 4.95m;

        // Declaring Hamburger addons and price
        const decimal VEGGIES = 0.75m;
        const decimal CONDIMENTS = 0.75m;
        const decimal FRENCH_FRIES = 0.75m;

        // Declaring Pizza addons and price
        const decimal PEPPERONI = 0.50m;
        const decimal SAUSAGE = 0.50m;
        const decimal OLIVES = 0.50m;

        // Declaring Salad addons and price
        const decimal CRUTONS = 0.25m;
        const decimal BACON_BITS = 0.25m;
        const decimal BREAD_STICKS = 0.25m;

        // Declaring the tax rate
        const decimal TAX_RATE = 0.05m;

        // Declaring the total price
        decimal TOTAL = 0.0m;


        public FRMLunchOrder()
        {
            InitializeComponent();

            // Subscribe to the CheckedChanged event for each radio button
            RadioHamburger.Text = "Hamburger - $" + HAMBURGER_PRICE.ToString("f2");
            RadioPizza.Text = "Pizza - $" + PIZZA_PRICE.ToString("f2");
            RadioSalad.Text = "Salad - $" + SALAD_PRICE.ToString("f2");


            RadioHamburger.CheckedChanged += RadioButton_CheckedChanged;
            RadioPizza.CheckedChanged += RadioButton_CheckedChanged;
            RadioSalad.CheckedChanged += RadioButton_CheckedChanged;

            CheckAddOn1.CheckedChanged += CheckBox_CheckedChanged;
            CheckAddOn2.CheckedChanged += CheckBox_CheckedChanged;
            CheckAddOn3.CheckedChanged += CheckBox_CheckedChanged;

            // Call Method to set up the initial add-on options based on selected radio button
            UpdateOnScreenText();


            // Alt key shortcuts for the buttons
            ButtonPlaceOrder.Text = "Place &Order"; // Alt + O
            ButtonResetForm.Text = "&Reset"; // Alt + R
            ButtonExitForm.Text = "&Exit"; // Alt + E
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e) // Method watching the Radio Buttons to see if they are selected.
        {
            UpdateOnScreenText(); 
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e) // Method watching the Check Boxes to see if they are checked/unchecked.
                                                                         // Used in Add-Ons to update the price of the dynamic subtotal.
        {
            UpdateOnScreenText();
        }


        private void UpdateOnScreenText() // Method to update the text on the screen based on the selected radio button and add-ons
        {
            decimal DYNAMIC_SUBTOTAL = 0.0m; // Declare a dynamic total to keep track of the subtotal price of the order
            // Declaring DYNAMIC_SUBTOTAL inside the method to limit its scope to this method only, effectively ending its life cycle after the method is done executing.
            // I had it declared in the Global scope initially, but it was causing issues with the dynamic, and not dynamic subtotal price calculation.

            if (RadioHamburger.Checked) // If Hamburger is selected display the following add-ons, and dynamically update the price
            {
                CheckAddOn1.Text = "Lettuce, Tomato, Onions - $" + VEGGIES.ToString("f2");
                CheckAddOn2.Text = "Ketchup, Mustard, Mayo - $" + CONDIMENTS.ToString("f2");
                CheckAddOn3.Text = "French Fries - $" + FRENCH_FRIES.ToString("f2");

                DYNAMIC_SUBTOTAL = HAMBURGER_PRICE;
                if (CheckAddOn1.Checked)
                    DYNAMIC_SUBTOTAL += VEGGIES;
                if (CheckAddOn2.Checked)
                    DYNAMIC_SUBTOTAL += CONDIMENTS;
                if (CheckAddOn3.Checked)
                    DYNAMIC_SUBTOTAL += FRENCH_FRIES;

            }
            else if (RadioPizza.Checked) // If Pizza is selected display the following add-ons, and dynmically update the price
            {
                CheckAddOn1.Text = "Pepperoni - $" + PEPPERONI.ToString("f2");
                CheckAddOn2.Text = "Sausage - $" + SAUSAGE.ToString("f2");
                CheckAddOn3.Text = "Olives - $" + OLIVES.ToString("f2");

                DYNAMIC_SUBTOTAL = PIZZA_PRICE;
                if (CheckAddOn1.Checked)
                    DYNAMIC_SUBTOTAL += PEPPERONI;
                if (CheckAddOn2.Checked)
                    DYNAMIC_SUBTOTAL += SAUSAGE;
                if (CheckAddOn3.Checked)
                    DYNAMIC_SUBTOTAL += OLIVES;

            }
            else if (RadioSalad.Checked) // If Salad is selected display the following add-ons, and dynmically update the price
            {
                CheckAddOn1.Text = "Crutons - $" + CRUTONS.ToString("f2");
                CheckAddOn2.Text = "Bacon Bits - $" + BACON_BITS.ToString("f2");
                CheckAddOn3.Text = "Bread Sticks - $" + BREAD_STICKS.ToString("f2");

                DYNAMIC_SUBTOTAL = SALAD_PRICE;
                if (CheckAddOn1.Checked)
                    DYNAMIC_SUBTOTAL += CRUTONS;
                if (CheckAddOn2.Checked)
                    DYNAMIC_SUBTOTAL += BACON_BITS;
                if (CheckAddOn3.Checked)
                    DYNAMIC_SUBTOTAL += BREAD_STICKS;

            }

            // Dynamically update subtotal while user selects mains and add-ons
            TextBoxSubtotal.Text = DYNAMIC_SUBTOTAL.ToString("c");


        }

        private void ButtonPlaceOrder_Click(object sender, EventArgs e) // Method handling the "Place Order" button click event
        {
            // Calculate the total cost of the order
            if (RadioHamburger.Checked)
            {
                TOTAL = HAMBURGER_PRICE;
                if (CheckAddOn1.Checked)
                    TOTAL += VEGGIES;
                if (CheckAddOn2.Checked)
                    TOTAL += CONDIMENTS;
                if (CheckAddOn3.Checked)
                    TOTAL += FRENCH_FRIES;
            }
            else if (RadioPizza.Checked)
            {
                TOTAL = PIZZA_PRICE;
                if (CheckAddOn1.Checked)
                    TOTAL += PEPPERONI;
                if (CheckAddOn2.Checked)
                    TOTAL += SAUSAGE;
                if (CheckAddOn3.Checked)
                    TOTAL += OLIVES;
            }
            else if (RadioSalad.Checked)
            {
                TOTAL = SALAD_PRICE;
                if (CheckAddOn1.Checked)
                    TOTAL += CRUTONS;
                if (CheckAddOn2.Checked)
                    TOTAL += BACON_BITS;
                if (CheckAddOn3.Checked)
                    TOTAL += BREAD_STICKS;
            }

            // Calculate the tax and total cost of the order
            decimal tax = TOTAL * TAX_RATE;
            decimal totalCost = TOTAL + tax;

            // Display the total cost of the order
            TextBoxSubtotal.Text = TOTAL.ToString("c");
            TextBoxTax.Text = tax.ToString("c");
            TextBoxTotal.Text = totalCost.ToString("c");

        }

        private void ButtonResetForm_Click(object sender, EventArgs e) // Methond handling the "Reset" button click event
        {
            // Reset the form to its initial state
            RadioHamburger.Checked = true;
            CheckAddOn1.Checked = false;
            CheckAddOn2.Checked = false;
            CheckAddOn3.Checked = false;
            TextBoxSubtotal.Text = "";
            TextBoxTax.Text = "";
            TextBoxTotal.Text = "";
            UpdateOnScreenText(); // Call UpdateAddOnTexts method to trigger the dynamic subtotal update again.
                                // Dynamic subtotal would not update if this method is not called AFTER the reset button is clicked.
        }

        private void ButtonExitForm_Click(object sender, EventArgs e) // Method handling the exit button click event
        { // Prompt the user first, to make sure that they want to close the application
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the response
            if (dialogResult == DialogResult.Yes)
            {
                // Close the application
                Close();

            }
            // Otherwise, do nothing.
        }

    }
}
