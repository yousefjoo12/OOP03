using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Override
{
	internal class TypeA
	{
		public int A { get; set; }

		public TypeA(int _a)
		{
			A = _a;
		}
		public void Func01()
		{
			Console.WriteLine("I am a");
		}
		public virtual void Func02()
		{
			Console.WriteLine($"A ={A}");
		}
	}
	internal class TypeB : TypeA
	{
		public int B { get; set; }

		public TypeB(int _a, int _b) : base(_a)
		{
			B = _b;
		}
		public new void Func01()
		{
			Console.WriteLine("I am b");
		}


		public override void Func02()
		{
			Console.WriteLine($"B ={B}");
		}
	}
	internal class TypeC : TypeB
	{
		public int C { get; set; }

		public TypeC(int _a, int _b, int _C) : base(_a, _b)
		{
			C = _C;
		}
		public new void Func01()
		{
			Console.WriteLine("I am c");
		}


		public override void Func02()
		{
			Console.WriteLine($"C ={C}");
		}
	}
	internal class TypeD : TypeC
	{
		public int D { get; set; }

		public TypeD(int _a, int _b, int _C, int _D) : base(_a, _b, _C)
		{
			D = _D;
		}
		public new void Func01()
		{
			Console.WriteLine("I am D");
		}


		public new virtual void Func02()
		{
			base.Func02();
		}
	}
	internal class TypeE : TypeD
	{
		public int E { get; set; }

		public TypeE(int _a, int _b, int _C, int _D, int _E) : base(_a, _b, _C, _D)
		{
			E = _E;
		}
		public new void Func01()
		{
			Console.WriteLine("I am E");
		}


		public override void Func02()
		{
			Console.WriteLine($"E ={E}");
		}
	}
}



