namespace TPMauiLoginApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var usuario = DB.Usuarios.FirstOrDefault(u =>
            u.NombreUsuario == entryUsuario.Text && u.Contraseña == entryPassword.Text);

        if (usuario != null)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private async void OnIrARegistroClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistroPage());
    }
}

