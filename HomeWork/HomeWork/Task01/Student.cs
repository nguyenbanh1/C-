using System;
using System.Collections.Generic;
using System.Text;
namespace HomeWork.Task01
{
    class Student : IComparable
    {
        private int mssv;
        private string telephone;
        private string full_name;
        private string mail;

        public Student()
        {

        }

        public Student(int mssv, string telephone, string full_name, string mail)
        {
            this.mssv = mssv;
            this.telephone = telephone;
            this.full_name = full_name;
            this.mail = mail;
        }

        public int Mssv { get => mssv; set => mssv = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public string Mail { get => mail; set => mail = value; }

        public override string ToString()
        {
            return "Student { " +
                "\n\tMSSV : " + this.mssv +
                "\n\tTelephone : " + this.telephone +
                "\n\tFull Name : " + this.full_name +
                "\n\tMail : " + this.mail +
                "\n" +
                "}";
        }

        int IComparable.CompareTo(Object obj)
        {
            Student student = (Student)obj;

            if (this.mssv > student.mssv)
            {
                return 1;
            }else if( this.mssv < student.mssv)
            {
                return -1;
            }
            else
            {
                return 0;
            }


        }
        public static IComparer<Student> SortFullNameAscending()
        {
            return (IComparer<Student>)new SortFullNameAscendingHelper();
        }
        public static IComparer<Student> SortFullNameDescending()
        {
            return (IComparer<Student>)new SortFullNameDescendingHelper();
        }



        private class SortFullNameAscendingHelper : IComparer<Student>
        {
            int IComparer<Student>.Compare(Student x, Student y)
            {

                return String.Compare(x.Full_name, y.Full_name);

            }
        }
        private class SortFullNameDescendingHelper : IComparer<Student>
        {
            int IComparer<Student>.Compare(Student x, Student y)
            {
                return String.Compare(y.Full_name, x.Full_name);
            }
        }
    }
}