using System;

using Xamarin.Forms;

namespace XamarinBugs
{
	public class CustomPicker : Picker
	{
		public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(CustomPicker), Color.White);

		public Color TextColor
		{
			get { return (Color)GetValue(TextColorProperty); }
			set { SetValue(TextColorProperty, value); }
		}
	}
}


