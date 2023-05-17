using Newtonsoft.Json;
namespace IotEdgeConfigurationWASM.Models
{
    public class OpcNode
    {
        public string? Id { get; set; }
        public string? DisplayName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DataSetFieldId { get; set; }
        public int? HeartbeatInterval { get; set; } = 0;
        public int? OpcSamplingInterval { get; set; } = 100;
        public int? OpcPublishingInterval { get; set; } = 100;
        public bool? SkipFirst { get; set; } = false;
    }
}

