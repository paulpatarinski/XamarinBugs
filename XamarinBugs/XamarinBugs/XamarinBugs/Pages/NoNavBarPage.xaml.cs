using Xamarin.Forms;

namespace XamarinBugs.Pages
{
  public partial class NoNavBarPage : ContentPage
  {
    public NoNavBarPage()
    {
      InitializeComponent();

      NavigationPage.SetHasNavigationBar(this, false);
    }
  }
}
