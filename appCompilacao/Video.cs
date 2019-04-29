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
using Android.Media;

namespace appCompilacao
{
    [Activity(Label = "Video")]
    public class Video : Activity
    {
        VideoView video;
        Button btnGravar, btnParar, btnTocar, btnVoltar;
        MediaRecorder recorder;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.frmVideo);
            btnGravar = (Button)FindViewById(Resource.Id.btnGravar);
            btnVoltar = (Button)FindViewById(Resource.Id.btnVoltar);
            btnParar = (Button)FindViewById(Resource.Id.btnParar);
            btnTocar = (Button)FindViewById(Resource.Id.btnTocar);
            video = (VideoView)FindViewById(Resource.Id.video);
            string path = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath + "/teste.mp4";
            btnGravar.Click += delegate
            {
                video.StopPlayback();
                recorder = new MediaRecorder();
                recorder.SetVideoSource(VideoSource.Camera);
                recorder.SetAudioSource(AudioSource.Mic);
                recorder.SetOutputFormat(OutputFormat.Default);
                recorder.SetVideoEncoder(VideoEncoder.Default);
                recorder.SetAudioEncoder(AudioEncoder.Default);
                recorder.SetOutputFile(path);
                recorder.SetPreviewDisplay(video.Holder.Surface);
                recorder.Prepare();
                recorder.Start();
            };

            btnParar.Click += delegate
            {
                if (recorder != null)
                {
                    recorder.Stop();
                    recorder.Release();
                }
            };

            btnTocar.Click += delegate
            {
                var uri = Android.Net.Uri.Parse(path);
                video.SetVideoURI(uri);
                video.Start();
            };
            btnVoltar.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}