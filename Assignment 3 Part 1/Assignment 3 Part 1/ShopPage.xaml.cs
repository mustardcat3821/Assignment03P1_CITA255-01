namespace Assignment_3_Part_1;

public partial class ShopPage : ContentPage
{
    List<string> products = new List<string>
    {
        "Plain Bagel — $2.25",
        "Chicken Sandwich — $6.49",
        "Hash Brown — $1.95",
        "Sausage Biscuit — $2.25"
    };

    public ShopPage()
    {
        InitializeComponent();

        ProductList.ItemsSource = products;
    }

    private async void ProductSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
        {
            return;
        }

        string picked = (string)e.CurrentSelection[0];

        int index = products.IndexOf(picked);

        ProductList.SelectedItem = null;

        if (index >= 0)
        {
            await Shell.Current.GoToAsync($"product?index={index}");
        }
    }
}