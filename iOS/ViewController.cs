using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Tasky.iOS
{
	public partial class ViewController : UIViewController
	{
		
		public ViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

//			ShowList.TouchUpInside += (object sender, EventArgs e) => 
//			{ 
//				// Launches a new instance of CallHistoryController 
//				ListTableViewController listTableViewController = this.Storyboard.InstantiateViewController ("ListTableViewController") as ListTableViewController; 
//				if (listTableViewController != null) 
//				{ 
//					listTableViewController.PhoneNumbers = PhoneNumbers; 
//					this.NavigationController.PushViewController (listTableViewController, true); 
//				} 
//			};
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender) 
		{ 
			base.PrepareForSegue (segue, sender); 

			// set the View Controller that's powering the screen we're 
			// transitioning to 
			var listTableViewController = segue.DestinationViewController as ListTableViewController; 

			//set the Table View Controller's list of phone numbers to the 
			// list of dialed phone numbers 
			if (listTableViewController != null) { 
				listTableViewController.PhoneNumbers = MainClass.getTaskList(); 
			} 
		}

		public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
