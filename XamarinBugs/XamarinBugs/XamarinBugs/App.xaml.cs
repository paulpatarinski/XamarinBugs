﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinBugs.Pages;

namespace XamarinBugs
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();


      //PROPERLY HIDES
      //MainPage = new NavigationPage(new NoNavBarPage());
    
      ////DOES NOT HIDE
      MainPage = new MasterDetailPage
      {
        Master = new ContentPage { Title = "Master" },
        Detail = new NavigationPage(new NoNavBarPage())
      };

    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
