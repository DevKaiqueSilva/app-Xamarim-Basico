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
using Android.Provider;
using Android.Graphics;

namespace appCompilacao
{
    [Activity(Label = "Camera")]
    public class Camera : Activity
    {
        Button btnCamera, btnVoltar;
        ImageView imgView1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.frmCamera);
            imgView1 = (ImageView)FindViewById(Resource.Id.imgView1);
            btnCamera = (Button)FindViewById(Resource.Id.btnCamera);
            btnVoltar = (Button)FindViewById(Resource.Id.btnVoltar);
            btnCamera.Click += btnCameraClick;

            btnVoltar.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }


        private void btnCameraClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            global::Android.Graphics.Bitmap bitmap = (Bitmap)data.Extras.Get("data");
            imgView1.SetImageBitmap(bitmap);

        }


    }
}