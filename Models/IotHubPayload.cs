using System.Collections.Generic;
using Newtonsoft.Json;
namespace IotEdgeConfigurationWASM.Models
{
    public class IotHubPayload
    {
        public string EndpointUrl { get; set; } = "";
        public bool UseSecurity { get; set; } = false;
        public OpcAuthenticationMode OpcAuthenticationMode { get; set; } = OpcAuthenticationMode.Anonymous;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Password { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DataSetWriterGroup { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DataSetWriterId { get; set; }
        public List<OpcNode> OpcNodes { get; set; } = new();
    }
}

