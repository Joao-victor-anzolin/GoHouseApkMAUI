namespace GoHouse.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    
    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await App.BancoDados.UserDataTable.GetUsuarioAsync(email, senha);

            if (usuario != null)
            {
                await DisplayAlert("Sucesso", "Bem vindo ao seu perfil GoHouse", "Vamos l�");
                await Navigation.PushAsync(new AppShell());
                App.Usuario = usuario;
            }
            else
            {
                await DisplayAlert("Erro", "Usu�rio ou senha inv�lidos", "OK");
                return;
            }
        }
        else
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                await DisplayAlert("Erro", "Preencha o campo de e-mail", "OK");
            }
            else if (string.IsNullOrWhiteSpace(senha))
            {
                await DisplayAlert("Erro", "Preencha o campo de senha", "OK");
            }
        }
    }


    private async void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditsUsuarioPage());
    }
}