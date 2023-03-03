using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace YodaApi.Responses
{
    public class ResponseWrapper<T>
    {
        [JsonPropertyName("contents")]
        [JsonProperty("contents")]
        public T Data { get; set; }
    }
}
