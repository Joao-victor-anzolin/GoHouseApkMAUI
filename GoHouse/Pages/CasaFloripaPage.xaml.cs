namespace GoHouse.Pages;

public partial class CasaFloripaPage : ContentPage
{
	public CasaFloripaPage()
	{
		InitializeComponent();
	}

    private async void CheckoutFloripa_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new FinalFloripa());
    }
}