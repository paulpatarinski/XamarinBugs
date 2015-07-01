using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinBugs.ViewModels;

namespace XamarinBugs.Pages
{
	public partial class TimeMismatch : ContentPage
	{
		public TimeMismatch ()
		{
			InitializeComponent ();
			BindingContext = new TimeMismatchViewModel ();
		}
	}
}

