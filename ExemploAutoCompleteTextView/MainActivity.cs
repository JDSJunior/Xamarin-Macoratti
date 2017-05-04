using Android.App;
using Android.Widget;
using Android.OS;

namespace ExemploAutoCompleteTextView
{
    [Activity(Label = "ExemploAutoCompleteTextView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        string[] estados;
        AutoCompleteTextView autoCompletar1;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            estados = new string[] { "Acre", "Alagoas","Amapá", "Amazonas",
                                     "Bahia", "Ceará", "Distrito Federal",
                                     "Espírito Santo", "Goiás", "Maranhão",
                                     "Mato Grosso", "Mato Grosso do Sul",
                                     "Minas Gerais", "Pará", "Paraíba",
                                     "Paraná", "Pernambuco", "Piauí",
                                     "Rio de Janeiro", "Rio Grande do Norte",
                                     "Rio Grande do Sul", "Rondônia", "Roraima",
                                     "Santa Catarina", "São Paulo", "Sergipe",
                                     "Tocantins" };

            autoCompletar1 = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView1);
            autoCompletar1.Threshold = 3;

            //adpter do tipo string para a insercao no AutoCompleteTextView 
            //parametros
            //contexto onde o adapter deve estar, layout do android que deve mostrar os dados na tela, origem dos dados
            ArrayAdapter adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, estados);

            autoCompletar1.Adapter = adapter;

            Button btnEnviar = FindViewById<Button>(Resource.Id.btnEnviar);

            btnEnviar.Click += delegate
            {

                if(autoCompletar1.Text != string.Empty)
                {
                    Toast.MakeText(this, "Estado: " + autoCompletar1.Text, ToastLength.Short).Show();
                }
                else
                {
                    Toast.MakeText(this, "Selecione um Estado", ToastLength.Short).Show();
                }

            };



        }
    }
}

