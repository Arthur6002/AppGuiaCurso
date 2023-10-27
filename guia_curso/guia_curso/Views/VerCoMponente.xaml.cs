using guia_curso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace guia_curso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerCoMponente : ContentPage
    {
        public VerCoMponente(Componente c)
        {
            InitializeComponent();

            BindingContext = c;
        }
    }
}