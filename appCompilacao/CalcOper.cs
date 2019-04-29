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
    [Activity(Label = "CalcOper")]
    public class CalcOper : Activity
    {
        TextView txtResult;
        Button btnSoma;
        Button btnSub;
        Button btnDivisao;
        Button btnMulti;
        Button btnVoltar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Create your application here
            SetContentView(Resource.Layout.frmCalculadoraOper);
            txtResult = (TextView)FindViewById(Resource.Id.txtResult);
            btnSoma = (Button)FindViewById(Resource.Id.btnSoma);
            btnDivisao = (Button)FindViewById(Resource.Id.btnDivisao);
            btnSub = (Button)FindViewById(Resource.Id.btnSub);
            btnMulti = (Button)FindViewById(Resource.Id.btnMulti);
            btnVoltar = (Button)FindViewById(Resource.Id.btnVoltar);
            btnSoma.Click += (sender, e) =>
            {
                string Num1 = Intent.GetStringExtra("vNum3");
                string Num2 = Intent.GetStringExtra("vNum2");
                int Num3 = int.Parse(Num1);
                int Num4 = int.Parse(Num2);
                int resultado = Num3 + Num4;
                string Resultado = resultado.ToString();
                txtResult.Text = Resultado;
            };
            btnSub.Click += (sender, e) =>
            {
                string Num1 = Intent.GetStringExtra("vNum3");
                string Num2 = Intent.GetStringExtra("vNum2");
                int Num3 = int.Parse(Num1);
                int Num4 = int.Parse(Num2);
                int resultado = Num3 - Num4;
                string Resultado = resultado.ToString();
                txtResult.Text = Resultado;
            };
            btnMulti.Click += (sender, e) =>
            {
                string Num1 = Intent.GetStringExtra("vNum1");
                string Num2 = Intent.GetStringExtra("vNum2");
                int Num3 = int.Parse(Num1);
                int Num4 = int.Parse(Num2);
                int resultado = Num3 * Num4;
                string Resultado = resultado.ToString();
                txtResult.Text = Resultado;
            };
            btnDivisao.Click += (sender, e) =>
            {
                string Num1 = Intent.GetStringExtra("vNum1");
                string Num2 = Intent.GetStringExtra("vNum2");
                int Num3 = int.Parse(Num1);
                int Num4 = int.Parse(Num2);
                int resultado = Num3 / Num4;
                string Resultado = resultado.ToString();
                txtResult.Text = Resultado;
            };

            btnVoltar.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}