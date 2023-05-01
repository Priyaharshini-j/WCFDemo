using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using WCF_Demo.Models;

namespace WCF_Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        PracticeEntities1 entity = new PracticeEntities1();

        public void AddStudent(StudentDB obj)
        {
            entity.StudentDBs.Add(obj);
            entity.SaveChanges();

        }

        public List<StudentDB> GetStudent () { 
            List<StudentDB> slist = entity.StudentDBs.ToList();
            return slist;
        }

        public void UpdateStudent(StudentDB obj)
        {
            entity.StudentDBs.AddOrUpdate(obj);
            entity.SaveChanges();
        }

        public int DeptStudents(string Dept)
        { 
            return entity.StudentDBs.Where(x=> (x.Dept == Dept)).ToList().Count;
        }

        public StudentDB GetStudentbyId (int id)
        {
            return entity.StudentDBs.Find(id);
        }

        public void DeleteStudent(int id)
        {
            entity.StudentDBs.Remove(GetStudentbyId(id));
            entity.SaveChanges() ;
        }

    }
}
