
namespace Assignment_3_Part_1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("product", typeof(ProductDetailPage));
    }
}