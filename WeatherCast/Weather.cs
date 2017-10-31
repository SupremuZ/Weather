using System.Collections.Generic;
using Newtonsoft.Json;

namespace YourNamespace
{
    public class Currently
    {

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("precipIntensity")]
        public double PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public int WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }
    }

    public partial class Datum
    {

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("precipIntensity")]
        public int PrecipIntensity { get; set; }

        [JsonProperty("precipProbability")]
        public double PrecipProbability { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("apparentTemperature")]
        public double ApparentTemperature { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("windSpeed")]
        public double WindSpeed { get; set; }

        [JsonProperty("windGust")]
        public double WindGust { get; set; }

        [JsonProperty("windBearing")]
        public int WindBearing { get; set; }

        [JsonProperty("cloudCover")]
        public double CloudCover { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("ozone")]
        public double Ozone { get; set; }

        [JsonProperty("uvIndex")]
        public int UvIndex { get; set; }
    }

    public class Hourly
    {

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {

       

        [JsonProperty("sunriseTime")]
        public int SunriseTime { get; set; }

        [JsonProperty("sunsetTime")]
        public int SunsetTime { get; set; }

        [JsonProperty("moonPhase")]
        public double MoonPhase { get; set; }

        [JsonProperty("precipIntensityMax")]
        public double PrecipIntensityMax { get; set; }

        [JsonProperty("precipIntensityMaxTime")]
        public int PrecipIntensityMaxTime { get; set; }

        [JsonProperty("precipType")]
        public string PrecipType { get; set; }

        [JsonProperty("temperatureMin")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temperatureMinTime")]
        public int TemperatureMinTime { get; set; }

        [JsonProperty("temperatureMax")]
        public double TemperatureMax { get; set; }

        [JsonProperty("temperatureMaxTime")]
        public int TemperatureMaxTime { get; set; }

        [JsonProperty("apparentTemperatureMin")]
        public double ApparentTemperatureMin { get; set; }

        [JsonProperty("apparentTemperatureMinTime")]
        public int ApparentTemperatureMinTime { get; set; }

        [JsonProperty("apparentTemperatureMax")]
        public double ApparentTemperatureMax { get; set; }

        [JsonProperty("apparentTemperatureMaxTime")]
        public int ApparentTemperatureMaxTime { get; set; }

        [JsonProperty("windGustTime")]
        public int WindGustTime { get; set; }

        [JsonProperty("uvIndexTime")]
        public int UvIndexTime { get; set; }
    }

    public class Daily
    {

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    public class Flags
    {

        [JsonProperty("sources")]
        public List<string> Sources { get; set; }

        [JsonProperty("isd-stations")]
        public List<string> IsdStations { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Weather
    {

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("currently")]
        public Currently Currently { get; set; }

        [JsonProperty("hourly")]
        public Hourly Hourly { get; set; }

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }
    }


}