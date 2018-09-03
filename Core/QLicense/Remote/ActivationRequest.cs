using Newtonsoft.Json;

namespace Licensing.Remote
{
    public class ActivationRequest
    {
        [JsonProperty("c", Required = Required.Always)]
        public int CustomerId { get; set; }
        [JsonProperty("l", Required = Required.Always)]
        public int LicenseId { get; set; }
    }
}
