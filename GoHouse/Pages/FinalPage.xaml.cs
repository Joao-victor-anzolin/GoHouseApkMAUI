namespace GoHouse.Pages;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

    private async void Spcompra_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Parab�ns", "Voc� concluiu sua compra", "� nois");
        await Navigation.PushAsync(new HomePage());
    }    
    private async void Spvolta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CasaSaoPauloPage());
    }
}