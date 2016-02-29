using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Tasky_list.Droid
{
	[Activity (Label = "Tasky List", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private Button btnShowList;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			this.SetTitle (Resource.String.main_activity_title);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.activity_main);

			btnShowList = FindViewById<Button> (Resource.Id.btn_show_list);
			btnShowList.Click += (sender, e) => {
				
				var intent = new Intent(this, typeof(ListTableActivity)); 
				intent.PutStringArrayListExtra("phone_numbers", MainClass.getTaskList()); 
				StartActivity(intent); 
			} ;


		}
	}
}


