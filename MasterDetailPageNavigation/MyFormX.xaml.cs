﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_MyForm : MasterDetailPage
    {
     
        public C_MyForm()
        {
            InitializeComponent();
          //  NavigationPage.SetHasBackButton(this, false);
          //  NavigationPage.SetBackButtonTitle(this, "");
        }
    }
}