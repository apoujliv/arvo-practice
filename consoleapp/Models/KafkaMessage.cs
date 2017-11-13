using System.Runtime.Serialization;

namespace consoleapp.Models
{
    [DataContract(Name = "KafkaMessage")]
    class KafkaMessage
    {
        [DataMember(Name = "productName")]
        public string ProductName { get; set; }
        [DataMember(Name = "productCount")]
        public int ProductCount { get; set; }
    }
}

