using System;
using System.Collections;

namespace assgn3_NickIlkic
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Create a class of Student (id, name)
            ArrayList aL = new ArrayList();

            Student std1 = new Student(1, "Nick");
            Student std2 = new Student(2, "Nick2");
            Student std3 = new Student(3, "Nick3");
            Student std4 = new Student(4, "Nick4");
            Student std5 = new Student(5, "Nick5");

            aL.Add(std1);
            aL.Add(std2);
            aL.Add(std3);
            aL.Add(std4);
            aL.Add(std5);

            foreach(Student item in aL)
            {
                Console.WriteLine(item.StudentName);
            }


            //2- Create a Generic Class name it 'MyGenericClass' define generic method that prints the value of the parameter in the console.
            // call it with String and int values
            MyGenericClass<int> intGC = new MyGenericClass<int>(33);
            MyGenericClass<String> stringGC = new MyGenericClass<String>("Hello");

            intGC.PrintParam();
            stringGC.PrintParam();

            //3- Create a hashtable and add 5 dictionaries of (key, value) optional
            // iterate through them and print them out in the console.
            Hashtable ht = new Hashtable();

            SortedList sl1 = new SortedList();
            sl1.Add(1, "one");
            sl1.Add(2, "two");
            sl1.Add(3, "three");
            sl1.Add(4, "four");
            sl1.Add(5, "five");

            ht.Add(1, sl1);

            //4 -
            //Create a Constraint Generic Class name it 'MyconstraintGenericClass' that limits the caller to use only referenced type 



            //5- Give an example to show the difference of call by value and call by reference
            int i = 5;
            Console.WriteLine(i);
            static void PrintNumber(int i)
            {
                
                Console.WriteLine(i);
                i = i + 1;
                Console.WriteLine(i);
            }
            PrintNumber(i);
            //variable i does not change value
            Console.WriteLine(i);


            Student passByRef = new Student(4, "Ref");
            void PrintId(int i)
            {

                Console.WriteLine(passByRef.StudentId);
                passByRef.StudentId = i + 1;
                Console.WriteLine(passByRef.StudentId);
            }
            PrintId(passByRef.StudentId);
            //StudentId i does change value
            Console.WriteLine(passByRef.StudentId);




            //6 - Use Delegate in a class to calculate area, circumference, biggest side, ...


        }
    }
}
