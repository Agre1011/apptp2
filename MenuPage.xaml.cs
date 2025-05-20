namespace TPMauiLoginApp;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private async void OnAcercaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaPage());
    }

    private async void OnServicioClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicioPage());
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // Volver al login
    }
}
