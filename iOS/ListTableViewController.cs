using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace Tasky.iOS
{
	public partial class ListTableViewController : UITableViewController
	{
		public List<String> PhoneNumbers { get; set; } static NSString listTableViewControllerId = new NSString ("ListTableViewController"); 
		public ListTableViewController (IntPtr handle) : base (handle)
		{
			TableView.RegisterClassForCellReuse (typeof(UITableViewCell), listTableViewControllerId); 
			TableView.Source = new ListDataSource (this); 
			PhoneNumbers = new List<string> ();
		}

		class ListDataSource : UITableViewSource 
		{ 
			ListTableViewController controller; 
			public ListDataSource (ListTableViewController controller) { 
				this.controller = controller; 
			} // Returns the number of rows in each section of the table 

			public override nint RowsInSection (UITableView tableView, nint section) 
			{ 
				return controller.PhoneNumbers.Count; 
			} 

			// 
			// Returns a table cell for the row indicated by row property of the NSIndexPath 
			// This method is called multiple times to populate each row of the table. 
			// The method automatically uses cells that have scrolled off the screen or creates new ones as necessary. 
			// 
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath) 
			{ 
				var cell = tableView.DequeueReusableCell (ListTableViewController.listTableViewControllerId); 
				int row = indexPath.Row; 

				cell.TextLabel.Text = controller.PhoneNumbers [row]; 

				return cell; 
			} 
		}
	}
}
