using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Lista_de_Compras_Proyecto_Progra_II
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
