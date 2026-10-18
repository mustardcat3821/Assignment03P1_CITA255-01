namespace Assignment_3_Part_1;

public partial class CheckoutPage : ContentPage
{
    public CheckoutPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        List<string> lines = new List<string>();
        double total = 0;

        for (int i = 0; i < Cart.Names.Count; i++)
        {
            double price = Cart.Prices[i] * Cart.Quantities[i];

            lines.Add($"{Cart.Quantities[i]} x {Cart.Names[i]} - {price:C}");

            total = total + price;
        }

        CartItems.ItemsSource = null;
        CartItems.ItemsSource = lines;

        TotalLabel.Text = $"Total: {total:C}";
        OrderMessageLabel.Text = "";
    }

    private void CheckoutClicked(object sender, EventArgs e)
    {
        if (Cart.Names.Count == 0)
        {
            OrderMessageLabel.Text = "Your cart is empty.";
            OrderMessageLabel.TextColor = Colors.Gray;
        }
        else
        {
            Cart.Names.Clear();
            Cart.Quantities.Clear();
            Cart.Prices.Clear();

            CartItems.ItemsSource = null;
            CartItems.ItemsSource = new List<string>();

            TotalLabel.Text = $"Total: {0:C}";

            OrderMessageLabel.Text = "Thanks for your order!";
            OrderMessageLabel.TextColor = Colors.MediumSpringGreen;
        }
    }
}