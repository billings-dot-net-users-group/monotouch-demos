using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.Dialog;
using MonoTouch.UIKit;

namespace MTDialogDemo
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			var rootElement = new RootElement("names"){
				new Section("other names"){
					from x in Enumerable.Range(1, 20)
						select (Element) new StringElement(x.ToString(), () => { new UIAlertView("you clicked", x.ToString(), null, "OK", null).Show();})
				}
			};
			var dialogviewController = new DialogViewController(rootElement);
			window.RootViewController = dialogviewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

