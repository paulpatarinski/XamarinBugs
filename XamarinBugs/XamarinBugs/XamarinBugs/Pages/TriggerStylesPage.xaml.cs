using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinBugs.Pages
{
  public partial class TriggerStylesPage : ContentPage
  {
    public TriggerStylesPage()
    {
      InitializeComponent();

      toggleBtn.Clicked += (sender, args) =>
      {
        sampleEntry.IsEnabled = !sampleEntry.IsEnabled;
      };
    }
  }
}
