using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public class AnalyticsCS : ContentPage
    {
        public AnalyticsCS()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Analytics Forms!" }
                }
            };
        }
    }
}