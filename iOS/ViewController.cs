using System;
using Foundation;
using UIKit;
using vs2019.Views;
using Xamarin.Forms;

namespace vs2019.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += Button_TouchUpInside;

            VsImageView.Image = FromUrl("https://visualstudio.microsoft.com/wp-content/uploads/2018/11/vsplogo.png");
        }

        private void Button_TouchUpInside(object sender, EventArgs e)
        {
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes
            {
                TextColor = UIColor.Black
            });

            var mainPage = new MyMaterialPage().CreateViewController();
            //mainPage.Title = "Forms page";
            NavigationController.PushViewController(mainPage, true);
        }

        static UIImage FromUrl(string uri)
        {
            using (var url = new NSUrl(uri))
            using (var data = NSData.FromUrl(url))
                return UIImage.LoadFromData(data);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        public override void ViewWillUnload()
        {
            base.ViewWillUnload();

            Button.TouchUpInside -= Button_TouchUpInside;
        }
    }
}
