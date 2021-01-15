using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Student
/// </summary>
[DataContract]
public class Student
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Code { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public DateTime Birthday { get; set; }
    [DataMember]
    public StudentGender Gender { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Introduction { get; set; }
    public enum StudentGender
    {
        Male, Female, Other
    }
}

