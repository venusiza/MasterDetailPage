using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public class ViewFormSubmissionCS : ContentPage
    {
        public ViewFormSubmissionCS()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to View form submission!" }
                }
            };
        }
    }
}