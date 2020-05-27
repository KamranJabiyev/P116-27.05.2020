using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting,downcasting
            #region Upcasting,implicit,boxing
            //object eagle = new Eagle();
            //Animal shark = new Shark();
            //Animal eagle1 = new Eagle();
            //eagle1.Eat();
            //object[] arr = { shark, eagle1,eagle,1234,'a',"asasd" };
            //object a = 5;
            //object letter = 'a';
            //object word = "Hello";
            //ISee eagle2 = new Eagle();
            #endregion

            #region Downcasting,explicit,unboxing
            //Animal eagle = new Eagle();
            //Animal shark = new Shark();
            //Animal[] animals = {  shark,eagle };

            //tehlukeli yol(downcasting)
            //foreach (Animal item in animals)
            //{
            //    Shark shark1 = (Shark)item;
            //    shark1.See();
            //}

            //security way-1 (downcasting)
            //foreach (Animal item in animals)
            //{
            //    if(item is Shark)
            //    {
            //        Shark shark1 = (Shark)item;
            //        shark1.See();
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{item} Shark tipi deyil");
            //    }
            //}

            //security way-2 (downcasting)
            //foreach (Animal item in animals)
            //{
            //    Shark shark1 = item as Shark;
            //    if (shark1 != null)
            //    {
            //        shark1.See();
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{item} Shark tipi deyil");
            //    }
            //}
            #endregion
            #endregion

            #region Implicity,explicity
            //Console.WriteLine("Zehmet olmasa manat daxil edin:");
            //double azn;

            //while (true)
            //{
            //    try
            //    {
            //        azn = double.Parse(Console.ReadLine());
            //        Manat manat = new Manat { Azn = azn };
            //        Dollar dollar = (Dollar)manat;
            //        Console.WriteLine(dollar.Usd);
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Zehmet olmasa duzgun formatda manat daxil edin:");
            //    }
            //}
            #endregion

            #region Use operators in Custom type
            //Student stu1 = new Student("Elgun","Quluzade",27);
            //Student stu2 = new Student("Hasan", "Hasanbeyli",23);
            //Student stu3 = new Student("Hasan", "Hasanli", 20);
            //Console.WriteLine(stu1 == stu2);
            //Console.WriteLine(stu1 != stu2);
            //Console.WriteLine(stu3 > stu2);
            //Console.WriteLine(stu1+stu3);
            #endregion
        }
    }

    #region Implicity,explicity
    //class Manat
    //{
    //    public double Azn { get; set; }

    //    //public static implicit operator Dollar(Manat manat)
    //    //{
    //    //    return new Dollar { Usd = manat.Azn / 1.7 };
    //    //}

    //    public static explicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar { Usd = manat.Azn / 1.7 };
    //    }
    //}

    //class Dollar
    //{
    //    public double Usd { get; set; }
    //}
    #endregion

    #region Upcasting,downcasting
    //interface ISee
    //{
    //    void See();
    //}

    //abstract class Animal 
    //{
    //    public abstract void Eat();
    //}

    //class Eagle : Animal,ISee
    //{
    //    public string Types;
    //    public int Age { get; set; }
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Eagle");
    //    }

    //    public void See()
    //    {
    //        Console.WriteLine("See as Eagle");
    //    }
    //}

    //class Shark : Animal,ISee
    //{
    //    public int TeethCoutn { get; set; }
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Shark");
    //    }

    //    public void See()
    //    {
    //        Console.WriteLine("See as Shark");
    //    }
    //}
    #endregion

    #region Use operators in Custom type
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static bool operator >(Student s1,Student s2)
        {
            return s1.Age > s2.Age;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Age < s2.Age;
        }

        public static string operator +(Student s1, Student s2)
        {
            return s1.Name + s2.Name;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Age == s2.Age;
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return s1.Age != s2.Age;
        }
    }
    #endregion
}
