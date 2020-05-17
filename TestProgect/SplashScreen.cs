using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Java.Util;

namespace testProgect
{
    [Activity(Label = "SplashScreen", MainLauncher =true, Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class SplashScreen : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            int progress = 0;
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SplashScreen);
            var progressBar = FindViewById<Android.Widget.ProgressBar>(Resource.Id.progressBar1);
            var TextViewer = FindViewById<Android.Widget.TextView>(Resource.Id.textView1);
           new Thread(new ThreadStart(delegate 
               {
                   while (progress < 100)
                   {
                       progress += 1;
                       progressBar.Progress = progress;
                       TextViewer.Text = "Downloding "+Convert.ToString(progress)+"%";
                       Thread.Sleep(50);
                   }
                   StartActivity(new Intent(this, typeof(MainActivity)));
               })).Start();
        }
    }
}