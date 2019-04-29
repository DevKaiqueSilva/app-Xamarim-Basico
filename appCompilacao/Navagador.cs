using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace appCompilacao
{
    [Activity(Label = "Navagador")]
    public class Navagador : Activity
    {
        EditText txtLink;
        Button btnNavegador, btnVoltar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frmNavegador);
            txtLink = (EditText)FindViewById(Resource.Id.txtLink);
            btnNavegador = (Button)FindViewById(Resource.Id.btnNavegador);
            btnVoltar = (Button)FindViewById(Resource.Id.btnVoltar);

            btnNavegador.Click += (Sender, e) =>
            {
                var link = "http://" + txtLink.Text;
                var uri = Android.Net.Uri.Parse(link);
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
                txtLink.Text = "";

            };
            btnVoltar.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}