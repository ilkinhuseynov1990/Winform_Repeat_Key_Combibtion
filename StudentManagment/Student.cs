using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment
{
   public class Student
    {
        public Student()
        {
            Id ++;
            _Id = Id;
        }
        public static int Id = 0;
        public  int _Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return StudentName +" "+StudentSurname;
        }
    }
}
