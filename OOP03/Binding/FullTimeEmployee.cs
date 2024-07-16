using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
	internal class FullTimeEmployee : Employee
	{
		public decimal Salary { get; set; }

		public new void Func01()
		{
			Console.WriteLine(" i am FullTime Employee");
		}
		public override void Func02()
		{
			Console.WriteLine($" Id : {Id}\n Name : {Name}\n Age : {Age}\n Salary : {Salary}\n");
		}
	}
}
