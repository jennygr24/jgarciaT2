namespace jgarciaT2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.vLogin()); //Cambiar la página de ejecución
        }
    }
}
