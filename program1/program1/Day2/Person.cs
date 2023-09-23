using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Program1.Day2
{
	internal class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Title { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string Region { get; set; } = string.Empty;
		public int PostalCode { get; set; } 
		public string Country { get; set; } = string.Empty;
		public long Phone { get; set; }

		public override string ToString()
		{
			return $"ID:{this.Id}, Name:{Title}, FirstName:{FirstName} {LastName},\n" +
					$"Address:{Address}, City:{City}, Region:{Region}, PostalCode:{PostalCode}, Country:{Country}";



		}
		internal class TestPerson
		{
			public static void TestOne()
			{
				Person firstPerson = new Person();
				firstPerson.Id = 1;
				firstPerson.FirstName = "Ayushi";
				firstPerson.LastName = "Vaishnav";
				firstPerson.Address = "SECTOR16";
				firstPerson.State = "UttarPradesh";
				firstPerson.City = "Bulandshahr";
				firstPerson.Country = "India";
				firstPerson.Phone = 9084648161L;
				firstPerson.PostalCode = 203396;
				firstPerson.Title = "Ms";
				string value = firstPerson.ToString();
				Console.WriteLine(value);
			}
		} } }

	

