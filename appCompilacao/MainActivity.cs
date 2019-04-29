
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace appCompilacao
{
    [Activity(Label = "appCompilacao", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnCalc, btnNavegador, btnSMS, btnDiscador, btnTirarFoto, btnGravarVideo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btnCalc = (Button)FindViewById(Resource.Id.btnCalc);
            btnNavegador = (Button)FindViewById(Resource.Id.btnNavegador);
            btnSMS = (Button)FindViewById(Resource.Id.btnSMS);
            btnDiscador = (Button)FindViewById(Resource.Id.btnDiscador);
            btnTirarFoto = (Button)FindViewById(Resource.Id.btnTirarFoto);
            btnGravarVideo = (Button)FindViewById(Resource.Id.btnGravarVideo);
            btnCalc.Click += (sender, e) =>
            {
                
                Intent intent = new Intent(this, typeof(CalcNum1));
                //int Num4 = int.Parse(Num2);
                
                StartActivity(intent);
            };
            btnNavegador.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(Navagador));
                //int Num4 = int.Parse(Num2);

                StartActivity(intent);
            };
            btnSMS.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(SMS));
                //int Num4 = int.Parse(Num2);

                StartActivity(intent);
            };
            btnDiscador.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(Discador));
                //int Num4 = int.Parse(Num2);
                StartActivity(intent);
            };
            btnTirarFoto.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(Camera));
                //int Num4 = int.Parse(Num2);

                StartActivity(intent);

            };
            btnGravarVideo.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(Video));
                //int Num4 = int.Parse(Num2);

                StartActivity(intent);
            };

        }
    }
}

