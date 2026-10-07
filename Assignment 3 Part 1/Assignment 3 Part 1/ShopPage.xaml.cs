namespace Assignment_3_Part_1;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
    }

    private async void PlainBagelTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new PlainBagelPage());
    }

    private async void ChickenSandwichTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ChickenSandwichPage());
    }

    private async void HashBrownTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new HashBrownPage());
    }

    private async void SausageBiscuitTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SausageBiscuitPage());
    }
}