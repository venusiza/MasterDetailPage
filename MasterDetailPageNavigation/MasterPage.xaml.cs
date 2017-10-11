using System.Collections.Generic;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public partial class MasterPage : ContentPage
    {




        //	public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            
            //   NavigationPage.SetHasBackButton(this, false);
            //   NavigationPage.SetBackButtonTitle(this, "");

            //------------------------------------form click-------------------------------------------------
            //----------------------------My Forms--------------------------------------------
            xaml_imgFrm1.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnImgFrmClicked1())));
            xaml_txtFrm.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnTxtFrmClicked())));
            //-----------------------create new offline form click--------------

            xaml_imgCrtFrm.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnImgOfflineClicked())));
            xaml_txtCrtFrm.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnTxtOfflineClicked())));
            //---------------------------------------------------------------------------------------

            //--------------------------Data Click--------------------------------------------------
            //----------------------------View Form Submissions--------------------------------------
            xaml_imgViewFrmSub.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnImgViewSubClicked())));
            xaml_txtViewFrmSub.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnTxtViewSubClicked())));
            //----------------------------view form Abandonments------------------------

          xaml_imgViewFrmAb.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnImgViewFrmAbClicked())));
          xaml_TxtViewFrmAb.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnTxtViewFrmAbClicked())));

            //-----------------------Analytics Click-------------------------------------
            xaml_imgAnal.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnImgAnalyticsClick())));
            xaml_txtAnal.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_OnTxtAnalyticsClicked())));
            //------------------------------------------------------------


            //-----------------------settings Click---handler----------------------------------
            xaml_imgSetting.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_onImgSettingClick())));
            xaml_txtSetting.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_onTxtSettingClick())));
            //
            //-----------------------Help Click-------handler------------------------------
            xaml_imgHelp.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_onImgHelpClick())));
            xaml_txtHelp.GestureRecognizers.Add((new TapGestureRecognizer((view) => f_onTxtHelpClick())));
            //

            //----------------------------System click---------------------------------
            /*      var masterPageItems = new List<MasterPageItem>();
                  //----------------------My Forms--------------------
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "My Forms",
                      IconSource = "myforms.png",
                      TargetType = typeof(ContactsPage)
                  });
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "Create New Offline Form",
                      IconSource = "createform.png",
                      TargetType = typeof(TodoListPage)
                  });
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "View Form Submissions",
                      IconSource = "view.png",
                      TargetType = typeof(ReminderPage)
                  });
                  //-------------------View Form Abandonments---------
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "View Form Abandonments",
                      IconSource = "formAbandon.png",
                      TargetType = typeof(TodoListPage)
                  });
                  //--------------------------------------------------
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "View Analytics",
                      IconSource = "analytics.png",
                      TargetType = typeof(TodoListPage)
                  });
                  //-------------Settings-----------------
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "Settings",
                      IconSource = "settings.png",
                      TargetType = typeof(TodoListPage)
                  });
                  //----------------------help--------
                  masterPageItems.Add(new MasterPageItem
                  {
                      Title = "help",
                      IconSource = "help.png",
                      TargetType = typeof(TodoListPage)

                  });
                  */


            //    listView.ItemsSource = masterPageItems;
        }
        //-------------------My Forms-----click-handler--------Go to my form page ----
        private void f_OnImgFrmClicked1()

        {
          
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushModalAsync(new MyFormCS());
          

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
            
        }
        private void f_OnTxtFrmClicked()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushModalAsync(new MyFormCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        //-------------------Create New Offline Form-----click-handler------------
        private void f_OnImgOfflineClicked()

        {
            (App.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new CreateOffFormCS());
         //   ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new CreateOffFormCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        private void f_OnTxtOfflineClicked()
         {
            (App.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new CreateOffFormCS());
         //   ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new CreateOffFormCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        //---------------------------View Form Submission-------click handler---------------------
        private void f_OnImgViewSubClicked()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new ViewFormSubmissionCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        private void f_OnTxtViewSubClicked()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new ViewFormSubmissionCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        //-------------------------View Form Abandonment---------click handler---------------------
        private void f_OnImgViewFrmAbClicked()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new ViewFormAbonCs());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        private void f_OnTxtViewFrmAbClicked()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new ViewFormAbonCs());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        //---------------------Analytics----------click handler---------------
        private void f_OnImgAnalyticsClick()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new AnalyticsCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        private void f_OnTxtAnalyticsClicked()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new AnalyticsCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
        //-----------------------setting-------click handler---------------

        private void f_onImgSettingClick()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new SettingsCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }

        private void f_onTxtSettingClick()
        {
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new SettingsCS());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }

        //---------------------help--click handler--------------------


        private void f_onImgHelpClick()
        {
            (App.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new HelpX());
            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new HelpX());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }

        private void f_onTxtHelpClick()
        {

            ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage).Navigation.PushAsync(new HelpX());

            (App.Current.MainPage as MasterDetailPage).IsPresented = false;//close masterpage navigation to left
        }
    }

}
