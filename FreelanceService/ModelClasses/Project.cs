using System;
using System.Runtime.Serialization;

namespace FreelanceService.ModelClasses
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int OwnerId { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Details { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public DateTime Deadline { get; set; }

        [DataMember]
        public int Budget { get; set; }

        [DataMember]
        public bool IsOpen { get; set; }
    }
}