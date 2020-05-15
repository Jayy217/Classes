using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Colour colour1 = new Colour(21, 42, 84, "Goo");
            Colour colour2 = new Colour(76, 49, 24, "Crayon");

            Cookie c1 = new Cookie(52, "round", colour1);
            Cookie c2 = new Cookie(26, "square", colour1);
            Cookie c3 = new Cookie(72, "circle", colour2);
            Cookie c4 = new Cookie(12, "box", colour2);

            //Task2
            Random IdGenerator = new Random();

            Person p1 = new Person("Jason", "Statham", "30th August 1973", 182, IdGenerator.Next(1000, 10000));
            Person p2 = new Person("John", "Doe", "25th September 1984", 171, IdGenerator.Next(1000, 10000));
            Person p3 = new Person("Kathy", "Bourne", "2nd March 2001", 156, IdGenerator.Next(1000, 10000));

            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(p2.GetFullName());
            System.Console.WriteLine(p3.GetFullName());

            System.Console.WriteLine(p1.GetHeightDifference(p2));
            System.Console.WriteLine(p1.GetHeightDifference(p3));
            System.Console.WriteLine(p3.GetHeightDifference(p2));

            Person.Subject s1 = new Person.Subject("Mathematics",2020);
            Person.Subject s2 = new Person.Subject("English", 2018);

            p2.Subjects(s1);
            p2.Subjects(s2);
        }
        //Task1
        //-------------------------------------------------------
        class Colour
        {
            public int red;
            public int green;
            public int blue;
            public string name;

            public Colour(int r, int g, int b, string name)
            {
                this.red = r;
                this.green = g;
                this.blue = b;
                this.name = name;
            }
        }
        class Cookie
        {
            public int weight;
            public string shape;
            public Colour colour;

            public Cookie(int weight, string shape, Colour colour)
            {
                this.weight = weight;
                this.shape = shape;
                this.colour = colour;
            }
        }
        //Task2
        //-------------------------------------------------------
        class Person
        {
            public string firstName;
            public string surname;
            public string DOB;
            public int heightInCm;
            public int ID;
            public List<string> subjects;

            public Person(string firstName, string surname, string DOB, int height, int ID)
            {
                this.firstName = firstName;
                this.surname = surname;
                this.DOB = DOB;
                this.heightInCm = height;
                this.ID = ID;
                this.subjects = new List<string>();
            }

            public string GetFullName()
            {
                return this.firstName + " " + this.surname;
            }
            public int GetHeightDifference(Person other)
            {
                System.Console.Write("The difference in these two peoples' heights in cm is: ");
                int heightDiff = 0;

                if (this.heightInCm > other.heightInCm)
                {
                    heightDiff = this.heightInCm - other.heightInCm;
                }
                if (other.heightInCm > this.heightInCm)
                {
                    heightDiff = other.heightInCm - this.heightInCm;
                }
                return heightDiff;
            }
            public void Subjects(Person.Subject subject)
            {
                System.Console.WriteLine("This student is enrolled in:");
                this.subjects.Add(subject.name);

                for (int i = 0; i < this.subjects.Count; i++)
                {
                    System.Console.WriteLine(this.subjects[i]);
                }
            }
            public class Subject
            {
                public string name;
                public int yearOfDelivery;

                public Subject(string name, int yearOfDelivery)
                {
                    this.name = name;
                    this.yearOfDelivery = yearOfDelivery;
                }
            }
        }

    }
}
