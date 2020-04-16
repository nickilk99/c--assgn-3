using System;
using System.Collections.Generic;
using System.Text;

namespace assgn3_NickIlkic
{
    class MyGenericClass<T>
    {
        private T genericMember;

        public MyGenericClass(T value)
        {
            genericMember = value;
        }

        public void PrintParam()
        {
            Console.WriteLine(genericMember);
        }



    }
}
