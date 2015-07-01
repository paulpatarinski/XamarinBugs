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
			LoadTimeFromServer ();
		}

		readonly TimeService _timeService;

		private DateTime _utcFromServer;

		public DateTime UTCFromServer{ 
			get{ return _utcFromServer;
			} set{
				_utcFromServer = value;
				OnPropertyChanged ("UTCFromServer");
			}
		}
			

		public DateTime UTCFromClient{
			get{
				return DateTime.UtcNow;
			}
		}

		private async Task LoadTimeFromServer()
		{
			var time = await _timeService.GetTimeAsync ();
			UTCFromServer = time;
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

