
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tasky_list.Droid
{
	[Activity (Label = "Tasky List")]			
	public class ListTableActivity : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			this.SetTitle (Resource.String.list_activity_title);

			// Create your application here 
			var phoneNumbers = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0]; 
			this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, phoneNumbers); 
		}
	}
}

