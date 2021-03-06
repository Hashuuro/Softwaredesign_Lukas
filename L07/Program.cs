﻿using System;
using System.Collections.Generic;
namespace L07
{

    
        public class Person
    {
        public string Name;
        public int Age;
        private int Id;

       public static List<Person> personen = new List<Person>();
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.Id = IDGenerator.GetInstance().GibMirNeId();
            personen.Add(this);
        }

        public override string ToString()
        {
            return "Name:" + Name + ", Age: " + Age + ", " + "Id: " + Id;
        }
        
        
    }

    /*
    class GlobalVariables
    {
        // public static int letzteID = 1;
        public static IDGenerator DerIdMacher = new IDGenerator();
    }
    */

    public class IDGenerator
    {
        private IDGenerator()
        {
            letzteID = 1;
        }

        private static IDGenerator _instance;

        public static IDGenerator GetInstance()
        {
            if (_instance == null)
                _instance = new IDGenerator();
            return _instance;
        }

        private int letzteID;
        public int GibMirNeId()
        {
            return letzteID++;
        }

    } 

    class Program
    {

        static void Main(string[] args)
        {
            

            

            // Eine Stelle, an der Personen angelegt werden
            new Person("Dieter", 44);
            new Person("Horst",45);
            new Person("Walter", 33);
            new Person( "Karl-Heinz", 22);


            // Eine ANDERE Stelle, an der Personen angelegt werden
            new Person("Brunhilde", 56);
            new Person("Maria", 75);
            new Person("Kunigunde", 22);
            new Person("Tusnelda", 12);
             
             //protected-----> super und sub klassen haben Zugriff
             //constructor----> methode mit gleichem namen wie klasse 

            

            foreach (var person in Person.personen)
             Console.WriteLine(person);

            Console.WriteLine("Hello World!");
        }
    }
}
