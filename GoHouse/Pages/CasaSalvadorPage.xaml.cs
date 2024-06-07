namespace GoHouse.Pages;

public partial class CasaSalvadorPage : ContentPage
{
	public CasaSalvadorPage()
	{
		InitializeComponent();
	}

    private async void CheckSalvador_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new FinalSalvador());
    }
}