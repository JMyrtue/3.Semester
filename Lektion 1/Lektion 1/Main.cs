using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNS;

namespace Opg1;

class Program
{
	static void Main()
	{
		Person me = new Person() {
			FirstName = "Jonathan",
			LastName = "Myrtue Jensen",
			Age = 29,
			Mom = new Person()
			{
				FirstName = "Tina",
				LastName = "Myrtue",
				Age = 54,
				Mom = new Person()
				{
					FirstName = "Lilian",
					LastName = "Myrthue",
					Age = 81,
				},
				Dad = new Person()
				{
					FirstName = "Kresten",
					LastName = "Myrthue",
					Age = 90,
				},
			},
			Dad = new Person()
			{
				FirstName = "Torben",
				LastName = "Jensen",
				Age = 58,
				Mom = new Person()
				{
					FirstName = "Margit",
					LastName = "Jensen",
					Age = 84,
				},
				Dad = new Person()
				{
					FirstName = "Jørgen",
					LastName = "Jensen",
					Age = 86,
				},
			}
		};

		me.PrintFamilyTree(me);
			
	}
}
