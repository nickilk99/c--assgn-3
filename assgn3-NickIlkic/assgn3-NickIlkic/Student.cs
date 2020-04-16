using System;
using System.Collections.Generic;
using System.Text;

namespace assgn3_NickIlkic
{
    class Student
    {

        public int StudentId { get; set; }
        public String StudentName { get; set; }


        public Student(int std, String name)
        {
            StudentId = std;
            StudentName = name;
        }

       

    }
}
