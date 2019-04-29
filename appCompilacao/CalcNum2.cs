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
    [Activity(Label = "CalcNum2")]
    public class CalcNum2 : Activity
    {
        EditText txtNum2;
        Button btnEnviar2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frmCalculadoraNum2);
            txtNum2 = (EditText)FindViewById(Resource.Id.txtNum2);
            btnEnviar2 = (Button)FindViewById(Resource.Id.btnEnviar2);
            btnEnviar2.Click += (sender, e) =>
            {
                string Num2 = txtNum2.Text;
                Intent intent = new Intent(this, typeof(CalcOper));
                int Num4 = int.Parse(Num2);
                intent.PutExtra("vNum2", Num2);
                StartActivity(intent);
            };
        }
    }
}