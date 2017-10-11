using System;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class MainPageCS : MasterDetailPage
	{
		MasterPageCS masterPage;

		public MainPageCS ()
		{
			masterPage = new MasterPageCS ();
			Master = masterPage;
          	Detail = new NavigationPage (new MyFormCS ());

           // Detail = new NavigationPage(new  ReminderPageCS());
            //	masterPage.ListView.ItemSelected += OnItemSelected;

          // NavigationPage.SetHasBackButton(this, false);

        //   NavigationPage.SetBackButtonTitle(this, "venus");

           // this.ToolbarItems.Add(this.cancelToolbarItem); nemishe :( 

            if (Device.RuntimePlatform == Device.Windows)
            {
                  MasterBehavior = MasterBehavior.Popover;
              //  MasterBehavior = MasterBehavior.Split;
            }
		}

        /*void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
            {
				Detail = new NavigationPage ((Page)Activator.CreateInstance (item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}*/

       /* void f_OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ReminderPage());

        }*/
    }
}
