namespace Assignment_3_Part_1;

[QueryProperty(nameof(Index), "index")]
public partial class ProductDetailPage : ContentPage
{
    int index;

    string[] names = { "Plain Bagel", "Chicken Sandwich", "Hash Brown", "Sausage Biscuit" };
    double[] prices = { 2.25, 6.49, 1.95, 2.25 };
    string[] images = { "plain_bagel.jpeg", "chicken_sandwich.jpg", "hash_brown.jpg", "sausage_biscuit.jpg" };

    string[] descriptions =
    {
        "A simple plain bagel.",
        "A hot and ready chicken sandwich.",
        "A crispy golden hash brown.",
        "A warm biscuit with a sausage patty."
    };

    bool[] inStock = { true, true, false, true };

    public ProductDetailPage()
    {
        InitializeComponent();
    }

    public string Index
    {
        set
        {
            index = int.Parse(value);

            NameLabel.Text = names[index];
            PriceLabel.Text = $"{prices[index]:C}";
            DescriptionLabel.Text = descriptions[index];
            ProductImage.Source = images[index];

            Title = names[index];

            if (inStock[index] == true)
            {
                StockLabel.Text = "In stock";
                StockLabel.TextColor = Colors.Green;

                QuantityEntry.IsEnabled = true;
                AddButton.IsEnabled = true;

                messageLabel.Text = "";
            }
            else
            {
                StockLabel.Text = "Out of stock";
                StockLabel.TextColor = Colors.Red;

                QuantityEntry.IsEnabled = false;
                AddButton.IsEnabled = false;
                AddButton.BackgroundColor = Colors.Gray;

                messageLabel.Text = "This item is currently unavailable.";
                messageLabel.TextColor = Colors.Gray;
            }
        }
    }

    private void AddToCartClicked(object sender, EventArgs e)
    {
        if (inStock[index] == false)
        {
            messageLabel.Text = "This item is currently unavailable.";
            return;
        }

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
            Cart.Names.Add(names[index]);
            Cart.Quantities.Add(quantity);
            Cart.Prices.Add(prices[index]);

            messageLabel.Text = "Added " + quantity + " x " + names[index] + " to your cart.";
            messageLabel.TextColor = Colors.MediumSpringGreen;
        }
    }
}