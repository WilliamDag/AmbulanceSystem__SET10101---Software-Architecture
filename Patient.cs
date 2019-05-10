using System;

[DataContract]
public class Patient
{
    [DataMember]
    public int patientNo { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }

    public Patient()
	{
    
	}
}
