using System.Security.Principal;

namespace jgarciaT2.Vistas;

public partial class vLogin : ContentPage
{
    string[] user = { "Carlos", "Ana", "Jose" };
    string[] pass= { "carlos123", "ana123", "jose123" };

    string usuario1;
    string contrasena1;
    
    public vLogin()
    {
        InitializeComponent();
        usuario1 = string.Empty;
        contrasena1 = string.Empty;
    }
    public void datosRegistro(string usuarioRegistro, string contrasenaRegistro)
    {
        usuario1 = usuarioRegistro;
        contrasena1 = contrasenaRegistro;
    }
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioInicio = txtUsuario.Text;
        string contrasenaInicio = txtContrasena.Text;

        bool userValidacion = false;

        for (int i = 0; i < user.Length; i++)
        {
            if (usuarioInicio == user[i] && contrasenaInicio == pass[i])
            {
                userValidacion = true;
                break;
            }
        }

        if (userValidacion)
            {
                Navigation.PushAsync(new vPrincipal(usuarioInicio));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
            }

    }
    
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}