namespace jgarciaT2.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}
    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuarioRegistro = txtUsuario.Text;
        string contrasenaRegistro = txtContrasena.Text;
        vLogin paginaInicio = new vLogin();
        paginaInicio.datosRegistro(usuarioRegistro, contrasenaRegistro);

        Navigation.PushAsync(paginaInicio);

    }
}