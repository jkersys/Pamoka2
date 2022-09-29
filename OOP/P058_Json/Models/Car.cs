using Newtonsoft.Json;

namespace P058_Json.Models
{
    public class Car
    {
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("year")]
        public string Year { get; set; }
    }
}