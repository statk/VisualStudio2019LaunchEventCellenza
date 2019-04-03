// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace vs2019.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		UIKit.UIImageView VsImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (VsImageView != null) {
				VsImageView.Dispose ();
				VsImageView = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}
		}
	}
}
