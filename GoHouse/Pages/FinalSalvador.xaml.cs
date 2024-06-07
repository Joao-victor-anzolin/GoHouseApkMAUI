namespace GoHouse.Pages;

public partial class FinalSalvador : ContentPage
{
	public FinalSalvador()
	{
		InitializeComponent();
	}

    private async void Salcompra_Clicked_1(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new HomePage());
    }

    private async void Salvolta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CasaSalvadorPage());
    }
}