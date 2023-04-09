using System;
namespace test2
{
	public class Person
	{
		private string name;
		private int age;
		public int Age { get; set; }
		public string Name { /*set;*/ get { return name; }}
		
		public void Print()
		{
			Console.WriteLine($"Имя {Name} возраст {Age}");
           // Console.WriteLine("Имя {0} возраст {1}",Name, Age);// то же самое 
        }
		public Person(string _name)
		{
			name = _name;
		}	
		
	}
	}


