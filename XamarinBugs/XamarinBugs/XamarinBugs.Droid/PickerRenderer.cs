using System;
using Xamarin.Forms;
using Paylocity.Client.Android.Renderers;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Widget;

[assembly: ExportRenderer (typeof(Picker), typeof(CustomPickerRenderer))]

namespace Paylocity.Client.Android.Renderers
{
	public class CustomPickerRenderer : PickerRenderer
	{
		public Picker FormsControl
		{
			get { return Element as Picker; }
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
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			NativeControl.SetBackgroundColor(Color.Transparent.ToAndroid ());

		}
	}
}

