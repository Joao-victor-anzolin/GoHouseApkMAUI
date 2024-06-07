namespace GoHouse.Pages;

public partial class FinalFloripa : ContentPage
{
	public FinalFloripa()
	{
		InitializeComponent();
	}

    private async void Flocompra_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Parabéns", "Você concluiu sua compra", "É nois");
        await Navigation.PushAsync(new HomePage());
    }
    private async void Flovolta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CasaFloripaPage());
    }
}