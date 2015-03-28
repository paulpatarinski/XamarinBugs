using System;
using Xamarin.Forms;
using Paylocity.Client.Android.Renderers;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Widget;

[assembly: ExportRenderer (typeof(Xamarin.Forms.DatePicker), typeof(CustomDatePickerRenderer))]

namespace Paylocity.Client.Android.Renderers
{
	public class CustomDatePickerRenderer : DatePickerRenderer
	{
		public Xamarin.Forms.DatePicker FormsControl
		{
			get { return Element as Xamarin.Forms.DatePicker; }
		}

		public EditText NativeControl
		{
			get { return Control; }
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
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

