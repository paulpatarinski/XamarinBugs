using System;
using XamarinBugs.Services;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;

namespace XamarinBugs.ViewModels
{
	public class TimeMismatchViewModel : INotifyPropertyChanged
	{
		

		public TimeMismatchViewModel ()
		{
			_timeService = new TimeService ();
			LoadTimeFromServerAsync ();
		}

		readonly TimeService _timeService;

		private string _utcFromServer;

		public string UTCFromServer{ 
			get{ return _utcFromServer;
			} set{
				_utcFromServer = value;
				OnPropertyChanged ("UTCFromServer");
			}
		}
			

		public string UTCFromClient{
			get{
				return DateTime.UtcNow.ToString ();
			}
		}

		private async Task LoadTimeFromServerAsync()
		{
			UTCFromServer = "Loading Time from TimezoneDB...";

			var time = await _timeService.GetTimeAsync ();

			UTCFromServer = time.ToString ();
		}

		#region INotifyPropertyChanged implementation

		// boiler-plate
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
		protected bool SetField<T>(ref T field, T value, string propertyName)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}
		#endregion



	}
}

