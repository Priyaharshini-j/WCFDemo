using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Demo.Models;

namespace WCF_Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        void AddStudent(StudentDB obj);
        [OperationContract]
        List<StudentDB> GetStudent();

        [OperationContract]
        void UpdateStudent(StudentDB obj);

        [OperationContract]
        int DeptStudents(string Dept);

        [OperationContract]
        StudentDB GetStudentbyId(int id);

        [OperationContract]
        void DeleteStudent(int id);

    }
}
