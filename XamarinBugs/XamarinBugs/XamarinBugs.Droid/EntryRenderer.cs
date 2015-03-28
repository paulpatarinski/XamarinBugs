using System;
using Xamarin.Forms;
using Paylocity.Client.Android.Renderers;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(Entry), typeof(CustomEntryRenderer))]

namespace Paylocity.Client.Android.Renderers
{
	public class CustomEntryRenderer : EntryRenderer
	{
		public Entry FormsControl
		{
			get { return Element as Entry; }
		}

		public EntryEditText NativeControl
		{
			get { return Control; }
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
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

