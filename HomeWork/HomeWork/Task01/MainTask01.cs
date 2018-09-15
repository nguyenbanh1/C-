using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using MongoDB.Bson;
using Animal;



namespace HomeWork.Task01
{
    enum StudentOptions
    {

        MSSV,
        fullname
    }
    class MainTask01
    {



        public static void Main(String[] args)
        {
            
            Student s1 = CreateStudent(1610388,"AAA", "32321", "tangkhanhnguyen98@gmail.com");
            Student s2 = CreateStudent(1610399, "ABCD", "3232122", "tangkhanhnguyen22298@gmail.com");
            Student s3 = CreateStudent(1610385, "ABCDE", "323211122", "tangkhanhngufdsfdsyen22298@gmail.com");


            Student[] students = { s1, s2, s3 };

            Console.WriteLine("Before sort :");
            foreach(var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            sortStudens(students,StudentOptions.MSSV);


            Console.WriteLine("After sort :");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Before sort :");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            sortStudens(students, StudentOptions.fullname);


            Console.WriteLine("After sort :");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }


            Animal.Class1.hello();
            Animal.Class1.helloWorld();
            repository.Class1.helloWorld();
            TestOnUbuntu.ConnectDB();

            Console.ReadKey();


        }

        public static Student GetStudentByMSSV(Student[] students, int MSSV)
        {
            foreach (Student item in students)
            {
                if (item.Mssv == MSSV)
                {
                    return item;
                }
            }
            return null;
        }
        public static Student CreateStudent(int mssv, string fullname, string telephone, string mail)
        {
            if( (mssv < 1610000 || mssv > 1619999))
            {
                return null;
            }
            foreach(char item in telephone)
            {
                if (item < '0' || item > '9') return null;
            }

            Regex regex = new Regex(@"[0-9,a-z,A-Z]{5,}@gmail.com");
            if (!regex.IsMatch(mail)) return null;

           
            return new Student(mssv, telephone, fullname, mail);
        }

        public static void sortStudens(Student[] students,StudentOptions options) 
        {
            if (options == StudentOptions.MSSV)
            {
                Array.Sort(students);
            }else if( options == StudentOptions.fullname)
            {
                Array.Sort(students,Student.SortFullNameAscending());
            }
            

        }

    }
}
