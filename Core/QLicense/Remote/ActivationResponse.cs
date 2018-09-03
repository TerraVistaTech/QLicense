namespace Licensing.Remote
{
    public class ActivationResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ActivationKey { get; set; }
    }
}
