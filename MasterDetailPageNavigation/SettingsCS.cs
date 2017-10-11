using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public class SettingsCS : ContentPage
    {
        public SettingsCS()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Setting Forms!" }
                }
            };
        }
    }
}