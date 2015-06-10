using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinBugs.Codes;
using XamarinBugs.Pages;

namespace XamarinBugs.ViewModels
{
  public class LandingPageViewModel
  {
    private readonly INavigation _navigation;

    public LandingPageViewModel(INavigation navigation)
    {
      _navigation = navigation;
    }

    private string _selectedPage;

    public List<string> Pages
    {
      get
      {
        return new List<string>
        {
					PageTitle.TriggerStyles,
          PageTitle.KeyboardOverlap
        };
      }
    }

    public string SelectedPage
    {
      get { return _selectedPage; }
      set
      {
        _selectedPage = value;

        if (string.IsNullOrWhiteSpace(value)) return;
        
        switch (value)
        {
          case PageTitle.TriggerStyles:
            {
                _navigation.PushAsync(new TriggerStylesPage());
              break;
            }
				case PageTitle.KeyboardOverlap:
					{
						_navigation.PushAsync(new KeyboardOverlap());
						break;
					}

          default:
            {
                _navigation.PushAsync(new TriggerStylesPage());
              break;
            }
        }
      }
    }
  }
}
