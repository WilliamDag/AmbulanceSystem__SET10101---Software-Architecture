using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace KwikMedical_SA_Coursework2018
{
    [DataContract]
    public class Call
    {
        [DataMember]
        public int patientNo { get; set; }
        [DataMember]
        public string callDetails { get; set; }
        [DataMember]
        public int callLength { get; set; }
    }
}