using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinBugs.ViewModels;

namespace XamarinBugs.Pages
{
  public partial class LandingPage : ContentPage
  {
    public LandingPage()
    {
      InitializeComponent();

      BindingContext = new LandingPageViewModel(Navigation);

      pagesListview.ItemSelected += (sender, args) =>
      {
        var listview = sender as ListView;

        listview.SelectedItem = null;
      };
    }
  }
}
