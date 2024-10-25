namespace LunchOrder
{
    public partial class FRMLunchOrder : Form
    {
        const double HAMBURGER_PRICE = 6.95;
        const double PIZZA = 5.95;
        const double SALAD = 4.95;
        const double ADD_ON = 0.25;
        public FRMLunchOrder()
        {
            InitializeComponent();
        }
        private void ButtonPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Place Order handler is working.");
        }

        private void ButtonResetForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The reset buttong handler is working.");
        }

        private void ButtonExitForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The exit button handler is working.");
        }
    }

}
