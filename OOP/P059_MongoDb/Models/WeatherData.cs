using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace P059_MongoDb.Models
{
    internal class WeatherData
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [JsonIgnore]
        [BsonElement("st")]
        public string St { get; set; }
        public string Ts { get; set; }
    }
}
