using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentDBContext
/// </summary>
public class StudentDBContext : DbContext
{
    public StudentDBContext() : base ("MyContext")
    {
       
    }
    public DbSet<Student> Students { get; set; }
}