// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System;

namespace PersonNS;
 public class Person
{
	private string _firstName;
	public string FirstName
	{
		get
		{
			return _firstName;
		}
		set
		{
			if (value != null)
				_firstName = value;
			else
				throw new ArgumentNullException();
		}
	}

	private string _lastName;
	public string LastName
	{
		get
		{
			return _lastName;
		}
		set
		{
			if (value != null)
				_lastName = value;
			else
				throw new ArgumentNullException();
		}
	}
	private int _age;
	public int Age
	{
		get
		{
			return _age;
		}
		set
		{
			if (value > 0 && value < 120)
				_age = value;
			else
				throw new ArgumentException("Wrong input, only numbers");
		}
	}

	public Person Mom;
	public Person Dad;

	public Person (string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}

	public void PersonPrinter()
	{
		Console.WriteLine("Name: " + FirstName + " " + LastName + "; Age: " + Age);
	}

	public void PrintFamilyTree(Person person)
	{
		Console.WriteLine(person.FirstName);

		if(person.Mom != null)
			PrintFamilyTree(person.Mom);
		if (person.Dad != null)
			PrintFamilyTree(person.Dad);
	}
}