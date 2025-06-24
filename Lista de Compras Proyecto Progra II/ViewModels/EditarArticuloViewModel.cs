using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Lista_de_Compras_Proyecto_Progra_II.Models;
using System.Windows.Input;

namespace Lista_de_Compras_Proyecto_Progra_II.ViewModels
{
    public class EditarArticuloViewModel : BaseViewModel
    {
        public Articulo Articulo { get; set; }

        public ICommand GuardarCommand { get; }

        public INavigation Navigation { get; set; }

        public EditarArticuloViewModel(Articulo articulo, INavigation navigation)
        {
            Articulo = articulo;
            Navigation = navigation;

            GuardarCommand = new Command(async () =>
            {
                await Navigation.PopAsync(); // Regresa a la pantalla anterior
            });
        }
    }
}
