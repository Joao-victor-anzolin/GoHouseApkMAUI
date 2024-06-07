namespace GoHouse.Pages;

public partial class CasaSaoPauloPage : ContentPage
{
	public CasaSaoPauloPage()
	{
		InitializeComponent();
    }

    private async void checkoutSP_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalPage());
    }
}