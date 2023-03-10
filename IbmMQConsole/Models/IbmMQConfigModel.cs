namespace IbmMQConsole.Models
{
    public class IbmMQConfigModel
    {
        public const string ConfigSection = "IbmMQ"; 
        public bool UseMock { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Channel { get; set; }
        public string User { get; set; }
        public string ManagerName { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
        public string TopicName { get; set; }
    }
}