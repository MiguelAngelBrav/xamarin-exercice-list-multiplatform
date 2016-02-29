// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Tasky_list.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton ShowList { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ShowList != null) {
				ShowList.Dispose ();
				ShowList = null;
			}
		}
	}
}
