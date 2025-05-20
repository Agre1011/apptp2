namespace TPMauiLoginApp;

public partial class RegistroPage : ContentPage
{
    public RegistroPage()
    {
        InitializeComponent();
    }

    private async void OnRegistrarClicked(object sender, EventArgs e)
    {
        string usuario = entryUsuario.Text;
        string correo = entryCorreo.Text;
        string password = entryPassword.Text;
        string repetir = entryRepetirPassword.Text;

        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(correo) ||
            string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repetir))
        {
            await DisplayAlert("Error", "Completa todos los campos.", "OK");
            return;
        }

        if (password != repetir)
        {
            await DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
            return;
        }

        if (DB.Usuarios.Any(u => u.NombreUsuario == usuario))
        {
            await DisplayAlert("Error", "El usuario ya existe.", "OK");
            return;
        }

        DB.Usuarios.Add(new Usuario
        {
            NombreUsuario = usuario,
            Correo = correo,
            Contraseña = password
        });

        await DisplayAlert("Éxito", "Usuario registrado. Iniciá sesión.", "OK");
        await Navigation.PopAsync(); // Volver al login
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
