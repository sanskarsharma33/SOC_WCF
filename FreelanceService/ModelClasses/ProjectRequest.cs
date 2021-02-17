using System;
using System.Runtime.Serialization;

namespace FreelanceService.ModelClasses
{
    [DataContract]
    public class ProjectRequest
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int FreelancerId { get; set; }

        [DataMember]
        public int ProjectId { get; set; }

        [DataMember]
        public DateTime Deadline { get; set; }

        [DataMember]
        public int Bid { get; set; }

        [DataMember]
        public string Note { get; set; }
    }
}