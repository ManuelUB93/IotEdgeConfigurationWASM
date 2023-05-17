using Newtonsoft.Json;
namespace IotEdgeConfigurationWASM.Models
{
    public class AzurePayload
    {
        public string? PublicAPIKey { get; set; }
        public string? CoreAPIKey { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? MachineName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? InstallName { get; set; }
    }
}

