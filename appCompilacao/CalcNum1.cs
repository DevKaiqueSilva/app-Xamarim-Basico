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
    [Activity(Label = "CalcNum1")]
    public class CalcNum1 : Activity
    {

        EditText txtNum1;
        Button btnEnviar1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frmCalculadoraNum1);
            txtNum1 = (EditText)FindViewById(Resource.Id.txtNum1);
            btnEnviar1 = (Button)FindViewById(Resource.Id.btnEnviar1);
            btnEnviar1.Click += (sender, e) =>
            {
                string Num1 = txtNum1.Text;
                Intent intent = new Intent(this, typeof(CalcNum2));
                int Num3 = int.Parse(Num1);
                intent.PutExtra("vNum3", Num3);
                StartActivity(intent);
            };
        }
    }
    
}