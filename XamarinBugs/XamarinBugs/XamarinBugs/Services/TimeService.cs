using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinBugs.Models;

namespace XamarinBugs.Services
{
	public class TimeService
	{
		readonly HttpClient _httpClient;

		public TimeService ()
		{
			_httpClient = new HttpClient ();
		}
		public async Task<DateTime> GetTimeAsync()
		{
			var url = "http://api.timezonedb.com/?zone=Africa/Abidjan&key=RWM334X7VEOH&format=json";

			var resultAsJson = await _httpClient.GetStringAsync (url);
			var timeModel = JsonConvert.DeserializeObject<TimeModel>(resultAsJson);
			var utcDateTime = UnixTimeStampToDateTime(timeModel.timestamp);

			return utcDateTime;
		}


		private DateTime UnixTimeStampToDateTime( double unixTimeStamp )
		{
			var dtDateTime = new DateTime(1970,1,1,0,0,0,0,DateTimeKind.Utc);

			dtDateTime = dtDateTime.AddSeconds( unixTimeStamp );

			return dtDateTime;
		}
	}
}