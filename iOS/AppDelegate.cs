using Foundation;
using UIKit;
using Xamarin.Forms;

namespace vs2019.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            global::Xamarin.Forms.Forms.SetFlags("Visual_Experimental"); // ONLY if using a pre-release of Xamarin.Forms

            global::Xamarin.Forms.Forms.Init();
            FormsMaterial.Init();



            return true;
        }
    }
}

