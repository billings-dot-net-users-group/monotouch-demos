using System;
using System.Collections.Generic;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SimpleTable
{
	public partial class SimpleTableViewController : UIViewController
	{
		IList<string> names;
		
		public SimpleTableViewController () : base ("SimpleTableViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{			
			base.DidReceiveMemoryWarning ();
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			names = new[]{ "Dirk Diggler", "Jack Horner" };
			
			this.NamesTable.DataSource = new NamesTableViewDataSource(names);
			this.NamesTable.Delegate = new NamesTableViewDelegate(names);
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		class NamesTableViewDataSource : UITableViewDataSource
		{
			private string cellId = "cellid";
			IList<string> names;
			
			public NamesTableViewDataSource (IList<string> names)
			{
				this.names = names;	
			}
			public override int RowsInSection (UITableView tableView, int section)
			{
				return names.Count;	
			}
			
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell(cellId) as UITableViewCell;
        	if (cell == null)
            {
        		cell = new UITableViewCell(UITableViewCellStyle.Default, cellId);
        	}
        	
			cell.TextLabel.Text = names[indexPath.Row];
            return cell;
			}
		}

		class NamesTableViewDelegate : UITableViewDelegate
		{
			IList<string> names;
				
			public NamesTableViewDelegate (IList<string> names)
			{
				this.names = names;
			}
			
			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
	        {
				var name = names[indexPath.Row];
				
				using(UIAlertView alert = new UIAlertView("you clicked", name, null, "OK", null)){
					alert.Show();
				} 
			}
		}
	}
}

