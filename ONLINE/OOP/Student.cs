using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        private int StudentNum;
        public string FullName;
        private int CourseCredits;
        private int Midterm;
        private int Final;
        private int MakeUpExam;



        public int OgrenciNo
        {
            get { return StudentNum; }
            set 
            {
                if (value >= 1000 && value <= 9999)
                {
                    StudentNum = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }
        }
        
        // Ad zaten public tanımlandı.

        public int DersKredisi
        {
            get { return CourseCredits;  }
            set
            {
                if(value >= 4 && value <= 12)
                {
                    CourseCredits = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }
        }

        public int VizeNotu
        {
            get { return Midterm; }
            set
            {
                if (value >= 20 && value <= 100)
                {
                    Midterm = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }
        }

        public int FinalNotu
        {
            get { return Final; }
            set
            {
                if (value >= 30 && value <= 100)
                {
                    Midterm = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }
        }

        public int ButunlemeNotu
        {
            get { return MakeUpExam; }
            set
            {
                if (ButunlemeNotu > 50)
                {
                    MakeUpExam = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }
        }





    }
}
