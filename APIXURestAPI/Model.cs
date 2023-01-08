using System.Collections.Generic;

using Newtonsoft.Json;

namespace APIXURestClient
{
    public class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lon")]
        public double Longitude { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("iso2")]
        public string Iso2 { get; set; }
        [JsonProperty("admin_name")]
        public string Admin_name { get; set; }
        [JsonProperty("capital")]
        public string Capital { get; set; }
        [JsonProperty("population")]
        public double Population { get; set; }
        [JsonProperty("population_proper")]
        public double Population_proper { get; set; }
    }

    public class Current
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("generationtime_ms")]
        public double Generationtime_ms { get; set; }
        [JsonProperty("utc_offset_seconds")]
        public double Utc_offset_seconds { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("timezone_abbreviation")]
        public string Timezone_abbreviation { get; set; }
        [JsonProperty("current_weather")]
        public Current_weather Current_weather { get; set; }
    }

    public class Current_weather
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
        [JsonProperty("windspeed")]
        public double Windspeed { get; set; }
        [JsonProperty("winddirection")]
        public double Winddirection { get; set; }
        [JsonProperty("weathercode")]
        public double Weathercode { get; set; }
        [JsonProperty("time")]
        public dateTime Time { get; set; }
    }
}