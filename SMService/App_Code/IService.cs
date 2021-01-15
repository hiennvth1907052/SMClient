using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
	List<Student> GetStudents();
	[OperationContract]
	Student AddStudent(Student student);
	[OperationContract]
	Student Edit(int? id);
	[OperationContract]
	Student UpdateStudent(Student student);
}
