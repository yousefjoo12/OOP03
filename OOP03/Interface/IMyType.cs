using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface
{
	internal interface IMyType
	{
		//-1
		//signatuer for property
		public int Age { get; set; }


		//-2
		//signatuer for method
		public void myfunc();
		//-3
		//Default implemented method
		private void print()
		{
			Console.WriteLine("Default implemented method");
		}

	}
}
