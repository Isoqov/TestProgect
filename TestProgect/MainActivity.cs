using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Webkit;

namespace testProgect
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        WebView webView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            webView = FindViewById<WebView>(Resource.Id.webView);
            webView.SetWebViewClient(new ExtendWebViewClient());

            WebSettings webSettings = webView.Settings;
            webSettings.JavaScriptEnabled = true;

            webView.LoadUrl("https://megabet24.com/ru/Sport");
        }
    }

    internal class ExtendWebViewClient : WebViewClient
    {
        [System.Obsolete]
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }
    }
}