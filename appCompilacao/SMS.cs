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
    [Activity(Label = "SMS")]
    public class SMS : Activity
    {
        EditText txtDest, txtMensagem;
        Button btnSMS, btnVoltar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frmSMS);
            txtDest = (EditText)FindViewById(Resource.Id.txtDest);
            txtMensagem = (EditText)FindViewById(Resource.Id.txtMensagem);
            btnSMS = (Button)FindViewById(Resource.Id.btnSMS);
            btnVoltar = (Button)FindViewById(Resource.Id.btnVoltar);

            btnSMS.Click += (sender, e) =>
            {
                var dest = txtDest.Text;
                var mens = txtMensagem.Text;
                var sms = Android.Net.Uri.Parse("smsto:" + dest);
                var intent = new Intent(Intent.ActionSendto, sms);
                intent.PutExtra("sms_body", mens);
                StartActivity(intent);
                txtDest.Text = "";
                txtMensagem.Text = "";
            };
            btnVoltar.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

        }
    }
}