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
    [Activity(Label = "Discador")]
    public class Discador : Activity
    {
        EditText txtNum;
        Button btnTelefone, btnVoltar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.frmDiscador);
            // Create your application here
            txtNum = (EditText)FindViewById(Resource.Id.txtNum);
            btnTelefone = (Button)FindViewById(Resource.Id.btnTelefone);
            btnVoltar = (Button)FindViewById(Resource.Id.btnVoltar);

            btnTelefone.Click += (Sender, e) =>
            {
                var num = txtNum.Text;
                var telefone = Android.Net.Uri.Parse("tel: " + num);
                Intent intent = new Intent(Intent.ActionDial, telefone);
                StartActivity(intent);
                txtNum.Text = "";
            };
            btnVoltar.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

        }
    }
}