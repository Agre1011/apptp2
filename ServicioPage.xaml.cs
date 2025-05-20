namespace TPMauiLoginApp;

public partial class ServicioPage : ContentPage
{
    public ServicioPage()
    {
        InitializeComponent();
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}

