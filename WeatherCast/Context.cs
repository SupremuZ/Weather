using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNamespace;
using System.ComponentModel;
using RestSharp;

namespace WeatherCast
{
    class Context: INotifyPropertyChanged
    {
        Weather weather;
        double latitude;
        double longitude;
        public event PropertyChangedEventHandler PropertyChanged; // Событие, которое нужно вызывать при изменении

        // Для удобства обернем событие в метод с единственным параметром - имя изменяемого свойства
        public void RaisePropertyChanged(string propertyName)
        {
            // Если кто-то на него подписан, то вызывем его
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public double Latitude
        {
            get { return latitude; }
            set 
            {
                if (latitude != value)
                {
                    latitude = value;
                    RaisePropertyChanged("Latitude");
                }
            }
        }
        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (longitude != value)
                {
                    longitude = value;
                    RaisePropertyChanged("Longitude");
                }
            }
        }
        public string Temperature
        {
            get 
            {
                if (weather != null)
                    return weather.Currently.Temperature.ToString() + "\u00B0C";
                else return "Нажмите кнопку";
            }
        }

        public void LoadWeather()
        {
            string baseUrl = @"https://api.darksky.net/"; // базовая урла

            RestClient client = new RestClient(baseUrl);

            RestRequest request = new RestRequest(@"forecast/28fbc306f3a60996dd81478c7c2986c2/" + latitude + "," + longitude); // запрос 
            request.AddParameter("units", "si"); // параметр отображения погоды в цельсиях

            var result = client.Execute<Weather>(request); // выполнение запроса
            weather = result.Data;
            RaisePropertyChanged("Temperature");
        }
    }
}
