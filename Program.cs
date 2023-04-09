using System;
using System.Collections.Generic;
namespace test2;



internal class Program
{
    static List<Person> Ask_N_Times(int n)
    {
        var ans = new List<Person>();
        for(int i = 0; i < n; i++)
        {
            ans.Add(CreatePerson());
        }
        return ans;
    }


    static Person CreatePerson()
    {
        string name;
        int age=0;
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
        do { 
        try
        {
            Console.WriteLine("Введите возраст");
            age = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Возраст введен не корректно");
        }


    } while (age <=0);
       
        var person = new Person(name);
        person.Age = age;
        return person;
    }

    static void Main(string[] args)
    {
        var PersonList = Ask_N_Times(3);
        PersonList.Sort(delegate (Person y, Person x) {
            return x.Age.CompareTo(y.Age);
        });   
        foreach(Person person in PersonList)
        {
            Console.WriteLine($"Имя {person.Name}," + $" Возраст{person.Age}");
        }

    }
}

