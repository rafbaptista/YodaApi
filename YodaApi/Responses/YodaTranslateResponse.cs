using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace YodaApi.Responses
{
    public class YodaTranslateResponse
    {
        [JsonPropertyName("text")]
        [JsonProperty("text")]
        public string OriginalText { get; set; }

        [JsonPropertyName("translated")]
        [JsonProperty("translated")]
        public string TranslatedText { get; set; }
    }
}
