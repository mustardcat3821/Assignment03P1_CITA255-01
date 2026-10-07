namespace Assignment_3_Part_1;

public partial class PlainBagelPage : ContentPage
{
    public PlainBagelPage()
    {
        InitializeComponent();
    }

    private void AddToCartClicked(object sender, EventArgs e)
    {
        int quantity = 0;

        bool validNumber = int.TryParse(QuantityEntry.Text, out quantity);

        if (validNumber == false)
        {
            messageLabel.Text = "Please pick a quantity between 1 and 99.";
            messageLabel.TextColor = Colors.PaleGoldenrod;
        }
        else if (quantity < 1 || quantity > 99)
        {
            messageLabel.Text = "Please pick a quantity between 1 and 99.";
            messageLabel.TextColor = Colors.PaleGoldenrod;
        }
        else
        {
            messageLabel.Text = "Added " + quantity + " x Plain Bagel to your cart.";
            messageLabel.TextColor = Colors.MediumSpringGreen;
        }
    }
}