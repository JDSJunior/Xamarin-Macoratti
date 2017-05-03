using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace ExemploCursoMacoratti
{
    [Activity(Label = "ExemploCursoMacoratti", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {

            int count = 0;

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btnHello = FindViewById<Button>(Resource.Id.MyButton);

            Button btnMudarCor = FindViewById<Button>(Resource.Id.btnJunior);

            Button btnToast = FindViewById<Button>(Resource.Id.btnToast);

            Button btnAviso = FindViewById<Button>(Resource.Id.btnAvisos);

            btnHello.Click += delegate 
            {
                btnHello.Text = string.Format(" {0} clicks ", count++);
                if(count % 2 == 0)
                {
                    btnHello.SetBackgroundColor(Android.Graphics.Color.Yellow);
                }
                else
                {
                    btnHello.SetBackgroundColor(Android.Graphics.Color.Green);
                }
            };

            btnMudarCor.Click += delegate 
            {
                btnMudarCor.SetBackgroundColor(Android.Graphics.Color.Red);
            };

            btnToast.Click += delegate
            {
                //objeto que cria a janela de alerta
                AlertDialog.Builder buider = new AlertDialog.Builder(this);

                //cria a janela de alerta
                AlertDialog alerta = buider.Create();

                //define o titulo, icon e menssagem
                alerta.SetTitle("Alerta - deseja continuar?");
                alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
                alerta.SetMessage("Aviso do alert");

                //define a funcao do botao e seu texto
                //toast definido atraves de funcao lambda
                alerta.SetButton("Ok", (s,e) => 
                {
                    //parametro do toast
                    string textToast = "Toast";
                    var time = ToastLength.Short;

                    //exibi o toast
                    Toast.MakeText(this, textToast, time).Show();
                });

                //exibi a janela de aviso
                alerta.Show();

            };

            btnAviso.Click += delegate
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                AlertDialog alert = builder.Create();

                alert.SetCancelable(false);
                //define o titulo
                alert.SetTitle("Aviso");
                //define o icone
                alert.SetIcon(Android.Resource.Drawable.IcDialogInfo);

                //tres botoes na janela de aviso
                alert.SetButton("Sim", (e,s) => 
                {
                    Toast.MakeText(this, "Sim", ToastLength.Short).Show();
                });

                alert.SetButton2("Nao", (e, s) => 
                {
                    Toast.MakeText(this, "Nao", ToastLength.Short).Show();
                });

                alert.SetButton3("Cancelar", (e, s) => 
                {
                    Toast.MakeText(this, "Cancelar", ToastLength.Short).Show();
                });

                alert.Show();
                
            };

        }

    }
}

