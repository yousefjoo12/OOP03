using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
	internal class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int? Age { get; set; }


		public void Func01()
		{
			Console.WriteLine(" i am employee");
		}
		public virtual void Func02()
		{
			Console.WriteLine($" Id : {Id}\n Name : {Name}\n Age : {Age}\n");
		}

	}


}
