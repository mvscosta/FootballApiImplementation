using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace Football.Connector.FootballDataApi
{
    public class FootballDataApi
    {
        public static string BaseUrl = "https://api.football-data.org/v1/competitions";
        public static string Token = null;// "e93a4f7c5ad14abcadd8dc77af7254a3";

        public static async Task<T> Get<T>(string url) where T : class, new()
        {
            T result = null;
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("X-Auth-Token", Token);
                }

                var res = await client.GetAsync($"{BaseUrl}/{url}");
                var resJson = await res.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<T>(resJson, Converter.Settings);
            }
            return result;
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
