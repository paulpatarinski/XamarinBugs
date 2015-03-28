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

		samplePicker.Items.Add ("2013");
		samplePicker.Items.Add ("2014");
		samplePicker.Items.Add ("2015");

		samplePicker.SelectedIndex = 0;

      toggleBtn.Clicked += (sender, args) =>
      {
				sampleEntry.IsEnabled = !sampleEntry.IsEnabled;
				sampleButton.IsEnabled = !sampleButton.IsEnabled;
				samplePicker.IsEnabled = !samplePicker.IsEnabled;
				sampleDatePicker.IsEnabled = !sampleDatePicker.IsEnabled;
				sampleTimePicker.IsEnabled = !sampleTimePicker.IsEnabled;
      };
    }
  }
}
