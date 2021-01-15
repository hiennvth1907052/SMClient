using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private StudentDBContext db = new StudentDBContext();
    public List<Student> GetStudents()
    {
        return db.Students.ToList();
    }

    public Student AddStudent(Student student)
    {
        db.Students.Add(student);
        db.SaveChanges();
        return student;
    }
    public Student Edit(int? id)
    {
        return db.Students.Find(id);
    }
    public Student UpdateStudent(Student student)
    {
        db.Entry(student).State = EntityState.Modified;
        db.SaveChanges();
        return student;
    }
}
