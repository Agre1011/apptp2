namespace TPMauiLoginApp;

public partial class AcercaPage : ContentPage
{
    public AcercaPage()
    {
        InitializeComponent();
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Vuelve a la pantalla anterior (Menú)
    }
}
