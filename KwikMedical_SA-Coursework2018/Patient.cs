using System;
using System.Runtime.Serialization;

namespace KwikMedical_SA_Coursework2018
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public int patientNo { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public string gender { get; set; }
        [DataMember]
        public DateTime dateOfBirth { get; set; }
        [DataMember]
        public string details { get; set; }
        [DataMember]
        public string houseNo { get; set; }
        [DataMember]
        public string streetName { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string postcode { get; set; }
        [DataMember]
        public string hospital { get; set; }
    }
}
