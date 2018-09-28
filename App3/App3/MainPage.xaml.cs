using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        readonly List<int> teste = new List<int>();
        public MainPage()
        {
            InitializeComponent();
            

            PopularLista();

            Lista.ItemsSource = teste;

        }

        private void PopularLista()
        {
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(1);
            teste.Add(2);
            teste.Add(3);
            teste.Add(4);
            teste.Add(4);
        }
    }
}
