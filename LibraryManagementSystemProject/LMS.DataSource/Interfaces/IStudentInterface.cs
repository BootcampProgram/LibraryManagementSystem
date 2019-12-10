using LMS.DataSource.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.DataSource.Interfaces
{
    public interface IStudentInterface
    {
        ICollection<Student>GetAllStudents();

        Student GetStudentByID(int ID);

        Student GetStudentByAttribute(int ID);

        ICollection<Borrowing> GetBorrowingsByStudentId(int ID);

        ICollection<Payment> GetPaymentsByStudentId(int ID);

        int BlockStudent(int id, Student studentObject);

        int ResetPassword(int id, Student studentObject);

    }
}
