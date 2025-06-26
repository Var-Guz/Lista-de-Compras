using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lista_de_Compras_Proyecto_Progra_II.Models;
using Lista_de_Compras_Proyecto_Progra_II.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;



namespace Lista_de_Compras_Proyecto_Progra_II.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Articulo> Articulos { get; set; } = new();
        private int _nextId = 1;

        public ICommand AgregarCommand { get; }
        public ICommand EliminarCommand { get; }
        public ICommand MarcarCompradoCommand { get; }

        public ICommand EditarCommand { get; }

        public MainViewModel()
        {
            AgregarCommand = new Command<string>((nombre) =>
            {
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    Articulos.Add(new Articulo { Id = _nextId++, Nombre = nombre, Comprado = false });
                }
            });

            EliminarCommand = new Command<Articulo>((articulo) =>
            {
                if (Articulos.Contains(articulo))
                    Articulos.Remove(articulo);
            });

            MarcarCompradoCommand = new Command<Articulo>((articulo) =>
            {
                articulo.Comprado = !articulo.Comprado;
                OnPropertyChanged(nameof(Articulos));
            });

            EditarCommand = new Command<Articulo>(async (articulo) =>
            {
                if (articulo != null)
                {
                    var page = new EditarArticuloPage(articulo);
                    await Application.Current.MainPage.Navigation.PushAsync(page);
                }
            });
        }
    }
}
