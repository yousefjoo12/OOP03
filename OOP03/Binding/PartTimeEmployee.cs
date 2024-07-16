using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
	internal class PartTimeEmployee : Employee
	{
		public decimal HourRate { get; set; }
		public new void Func01()
		{
			Console.WriteLine(" i am PartTime employee");
		}
		public override void Func02()
		{
			Console.WriteLine($" Id : {Id}\n Name : {Name}\n Age : {Age}\n HourRate : {HourRate}\n");
		}


	}
}
 