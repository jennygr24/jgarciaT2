namespace jgarciaT2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuarioRegistro)
	{
        InitializeComponent();

        DisplayAlert("Alerta", "Bienvenido " + usuarioRegistro, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuarioRegistro;
    }

    private void btncalculonota_Clicked(object sender, EventArgs e)
    {
		if (pkEstudiante.SelectedIndex == -1){
			DisplayAlert("aviso", "seleccione un estudiante","salir");

			return;
		}
		try {
			double notas1 = Convert.ToDouble(seguimiento1.Text) * 0.3;
            double exa1 = Convert.ToDouble(examen1.Text) * 0.2;
            double notas2 = Convert.ToDouble(seguimiento2.Text) * 0.3;
            double exa2 = Convert.ToDouble(examen2.Text) * 0.2;


			double parcial1 = notas1 + exa1;
			double parcial2 = notas1 + exa2;
			double notafinal = parcial1 + parcial2;


			string estado = pkEstudiante.Items[pkEstudiante.SelectedIndex].ToString();
			if (notafinal >= 7) {
				estado = "Aprobado";

			}
			else if (notafinal >= 5 && notafinal <= 6.9)
			{ estado = "Complementario"; }
			if (notafinal < 5) 
			{ estado = "REPROBADO"; }

            DisplayAlert("Resultado Final", "Nombre: "+pkEstudiante.SelectedItem+ "\n"+"Fecha: "+dtFecha.Date.ToString("dd/MM/yyyy")+ "\n"
                + "Parcial 1: "+parcial1.ToString("N2")+ "\n"+"Parcial 2: " +parcial2.ToString("N2")+ "\n"+"Nota Final: " +notafinal.ToString("N2")+ "\n"+"Estado: " +estado, "salir");

        }

		catch (FormatException)
		{
            DisplayAlert("Alerta", "Digite la nota valida del estudiante","salir");
        }
       

    }
}