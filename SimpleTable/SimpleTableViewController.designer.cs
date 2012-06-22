// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SimpleTable
{
	[Register ("SimpleTableViewController")]
	partial class SimpleTableViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITableView NamesTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NamesTable != null) {
				NamesTable.Dispose ();
				NamesTable = null;
			}
		}
	}
}
