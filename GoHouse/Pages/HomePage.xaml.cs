namespace GoHouse.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void btnComprarbr_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CasaSaoPauloPage());
    }

    private async void btnComprarsa_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CasaSalvadorPage());
    }

    private async void btnComprarfa_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CasaFloripaPage());
    }

}