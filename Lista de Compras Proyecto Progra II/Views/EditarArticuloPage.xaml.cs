using Lista_de_Compras_Proyecto_Progra_II.Models;
using Lista_de_Compras_Proyecto_Progra_II.ViewModels;

namespace Lista_de_Compras_Proyecto_Progra_II.Views;

public partial class EditarArticuloPage : ContentPage
{
    public EditarArticuloPage(Articulo articulo)
    {
        InitializeComponent();
        BindingContext = new EditarArticuloViewModel(articulo, Navigation);
    }
}
