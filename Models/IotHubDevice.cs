using Newtonsoft.Json;

namespace IotEdgeConfigurationWASM.Models
{
    public class Authentication
    {
        [JsonProperty("symmetricKey", NullValueHandling = NullValueHandling.Ignore)]
        public SymmetricKey symmetricKey { get; set; }

        [JsonProperty("x509Thumbprint", NullValueHandling = NullValueHandling.Ignore)]
        public X509Thumbprint x509Thumbprint { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string type { get; set; }
    }

    public class IotHubDevice
    {
        [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string deviceId { get; set; }

        [JsonProperty("generationId", NullValueHandling = NullValueHandling.Ignore)]
        public string generationId { get; set; }

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string etag { get; set; }

        [JsonProperty("connectionState", NullValueHandling = NullValueHandling.Ignore)]
        public string connectionState { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string status { get; set; }

        [JsonProperty("statusReason", NullValueHandling = NullValueHandling.Ignore)]
        public object statusReason { get; set; }

        [JsonProperty("connectionStateUpdatedTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime connectionStateUpdatedTime { get; set; }

        [JsonProperty("statusUpdatedTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime statusUpdatedTime { get; set; }

        [JsonProperty("lastActivityTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime lastActivityTime { get; set; }

        [JsonProperty("cloudToDeviceMessageCount", NullValueHandling = NullValueHandling.Ignore)]
        public int cloudToDeviceMessageCount { get; set; }

        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public Authentication authentication { get; set; }

        [JsonProperty("parentScopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> parentScopes { get; set; }
    }

    public class SymmetricKey
    {
        [JsonProperty("primaryKey", NullValueHandling = NullValueHandling.Ignore)]
        public string primaryKey { get; set; }

        [JsonProperty("secondaryKey", NullValueHandling = NullValueHandling.Ignore)]
        public string secondaryKey { get; set; }
    }

    public class X509Thumbprint
    {
        [JsonProperty("primaryThumbprint", NullValueHandling = NullValueHandling.Ignore)]
        public object primaryThumbprint { get; set; }

        [JsonProperty("secondaryThumbprint", NullValueHandling = NullValueHandling.Ignore)]
        public object secondaryThumbprint { get; set; }
    }
}
