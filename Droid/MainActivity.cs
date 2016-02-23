using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Tasky.Droid
{
	[Activity (Label = "Tasky", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private Button btnShowList;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

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


