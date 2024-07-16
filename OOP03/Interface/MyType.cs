using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interface
{
	internal class MyType : IMyType //implements
	{

        public int Age { get; set; }

        public void myfunc()
		{
			Console.WriteLine("Hello Route");
		}
	}
}
