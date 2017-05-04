using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

namespace ExemploAbrirChromeDeListView
{
    [Activity(Label = "ExemploAbrirChromeDeListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        //lista para usar como BD
        List<string> recursos;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            //popula a lista
            CarregarList();

            //insere os dados na listview
            ListAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, recursos);

        }

        //sobreescreve o metodo de clique na list
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            //seleciona o item clicado
            var item = recursos[position];

            Toast.MakeText(this, item, ToastLength.Short).Show();

            //abrir o navegador
            var uri = Android.Net.Uri.Parse("https://www.google.com/#q=" + item);

            //define uma intent
            var intent = new Intent(Intent.ActionView, uri);

            //inicia a intent
            StartActivity(intent);
        }

        //metodo que popula a lista
        private void CarregarList()
        {
            recursos = new List<string>();
            recursos.Add("Visual C#");
            recursos.Add("Visual Basic");
            recursos.Add("VB .NET");
            recursos.Add("JavaScript");
        }

        
    }
}

