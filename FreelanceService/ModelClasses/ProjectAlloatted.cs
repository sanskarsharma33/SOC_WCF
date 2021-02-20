using System;
using System.Runtime.Serialization;

namespace FreelanceService.ModelClasses
{
    [DataContract]
    public class ProjectAlloatted
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ProjectId { get; set; }

        [DataMember]
        public int FreelancerId { get; set; }

        [DataMember]
        public bool IsSubmitted { get; set; }
    }
}