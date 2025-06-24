using Lista_de_Compras_Proyecto_Progra_II.Views;

namespace Lista_de_Compras_Proyecto_Progra_II
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
