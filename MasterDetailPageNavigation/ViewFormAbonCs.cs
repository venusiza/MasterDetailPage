using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public class ViewFormAbonCs : ContentPage
    {
        public ViewFormAbonCs()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to create form abandonment Forms!" }
                }
            };
        }
    }
}