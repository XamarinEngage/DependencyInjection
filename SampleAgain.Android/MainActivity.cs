using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SampleAgain.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(MainActivity))]
namespace SampleAgain.Droid
{
    [Activity(Label = "SampleAgain", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ISample
    {
        public string doProjectStuff()
        {
            //Contex

            Toast.MakeText(Android.App.Application.Context, "Toast from android", ToastLength.Short).Show();
            return "android app";
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}