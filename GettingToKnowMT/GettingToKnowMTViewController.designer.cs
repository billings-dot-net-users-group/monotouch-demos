// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace GettingToKnowMT
{
	[Register ("GettingToKnowMTViewController")]
	partial class GettingToKnowMTViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel Message { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton tapButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Message != null) {
				Message.Dispose ();
				Message = null;
			}

			if (tapButton != null) {
				tapButton.Dispose ();
				tapButton = null;
			}
		}
	}
}
