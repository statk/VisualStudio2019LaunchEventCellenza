using Android.App;
using Android.OS;
using Xamarin.Forms;
using Android.Support.V7.App;
using vs2019.Views;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using System;
using Android.Graphics.Drawables;
using Java.IO;
using Java.Net;
using System.IO;
using Square.Picasso;
using Android.Content;

namespace vs2019.Droid
{
    [Activity(Label = "vs-2019", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        private Android.Widget.Button _button;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.SetFlags("Visual_Experimental"); // ONLY if using a pre-release of Xamarin.Forms
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            global::Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);


            SetContentView(Resource.Layout.Main);
            _button = FindViewById<Android.Widget.Button>(Resource.Id.myButton);
            var vsImage = FindViewById<ImageView>(Resource.Id.vs_image_view);
            Picasso.With(this).Load(Android.Net.Uri.Parse("https://visualstudio.microsoft.com/wp-content/uploads/2018/11/vsplogo.png")).Into(vsImage);

            _button.Click +=  OnButtonClick;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            _button.Click -= OnButtonClick;
        }

        private void OnButtonClick(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(FormsActivity));
            StartActivity(intent);
        }
    }
}

