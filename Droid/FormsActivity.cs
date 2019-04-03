
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using vs2019.Views;
using Xamarin.Forms.Platform.Android;

namespace vs2019.Droid
{
    [Activity(Label = "FormsActivity")]
    public class FormsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.FormsActivity);
            var fragment = this.FindViewById<FrameLayout>(Resource.Id.fragment_frame_layout);
            fragment.Visibility = Android.Views.ViewStates.Visible;
            var callHistoryPage = new MyMaterialPage().CreateSupportFragment(this);
            SupportFragmentManager
                .BeginTransaction()
                .AddToBackStack(null)
                .Replace(Resource.Id.fragment_frame_layout, callHistoryPage)
                .Commit();
        }
    }
}
