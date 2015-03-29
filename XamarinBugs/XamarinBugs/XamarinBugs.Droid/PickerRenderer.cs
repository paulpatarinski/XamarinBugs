using System;
using Xamarin.Forms;
using Paylocity.Client.Android.Renderers;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Widget;
using XamarinBugs;

[assembly: ExportRenderer (typeof(CustomPicker), typeof(CustomPickerRenderer))]

namespace Paylocity.Client.Android.Renderers
{
	public class CustomPickerRenderer : PickerRenderer
	{
		public CustomPicker FormsControl
		{
			get { return Element as CustomPicker; }
		}

		public EditText NativeControl
		{
			get { return Control; }
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged (e);

			if (e.OldElement != null) return;

			if (FormsControl != null)
			{
				NativeControl.SetBackgroundColor(Color.Transparent.ToAndroid ());
				NativeControl.SetTextColor (FormsControl.TextColor.ToAndroid());
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName.Equals (CustomPicker.BackgroundColorProperty.PropertyName)) {
				NativeControl.SetBackgroundColor (Color.Transparent.ToAndroid ());
			}

			if (e.PropertyName.Equals (CustomPicker.TextColorProperty.PropertyName)) {
				NativeControl.SetTextColor (FormsControl.TextColor.ToAndroid());
			}

		}
	}
}

