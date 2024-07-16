using OOP03.Binding;
using OOP03.Interface;
using OOP03.Override;
using System;

namespace OOP03
{
	internal class Program
	{
		#region overlodeing

		//public static int Sum(int x, int y)
		//{
		//	return x + y;
		//}
		//public static int Sum(int x, int y, int z)
		//{
		//	return x + y + z;
		//}
		//public static int Sum(int x, int y, int z, int c)
		//{
		//	return x + y + z + c;
		//}
		//public static int Sum(int x, int y, int z, int c, int v)
		//{
		//	return x + y + z + c + v;
		//} 
		#endregion

		public static void ProcessEmp(Employee employee)
		{
			if (employee != null)
			{
				employee.Func01();
				employee.Func02();

			}
		}
		static void Main(string[] args)
		{
			#region overlodeing

			//int result = Sum(1, 2, 3, 4, 5);
			//Console.WriteLine(result); 
			#endregion
			#region override

			//TypeA typeA = new TypeA(2);
			//typeA.Func01();
			//typeA.Func02();
			//Console.WriteLine("000000000000000000000");
			//TypeB typeB = new TypeB(1, 2);
			//typeB.Func01();
			//typeB.Func02();

			#endregion
			#region Binding
			//TypeA Ref = new TypeB(1, 2);
			//Ref.A = 100;//true
			//			//Ref.B = 100;//fales 
			//Ref.Func01();//بتاعت الاب
			//			 //static binded method
			//Ref.Func02(); // B = 2 اخر واحد اتعمل عليها تعديل في السلسله لانه شاف انه virtual
			//			  //dynamic binded method 
			//TypeA typeA = new TypeA(2);
			//TypeB typeB = (TypeB)typeA; //casting(un safe) عشان انا كد بعمل ريفرن من نوع ابن بيشاور علي اوبجيكت من نوع اب


			#endregion
			#region Employee
			//Employee employee = new Employee();    //ref [parent] => obj [parent]            
			//FullTimeEmployee employee1 = new FullTimeEmployee();//ref [child] => obj [child]            
			//PartTimeEmployee employee2 = new PartTimeEmployee(); //ref [child] => obj [child]  
			//Employee employee3 = new FullTimeEmployee();//ref [parent] => obj [child] Binding
			//Employee employee4 = new PartTimeEmployee();//ref [parent] => obj [child] Binding

			//FullTimeEmployee FullTime = new FullTimeEmployee()
			//{
			//	Id = 7,
			//	Name = "yousef",
			//	Age = 23,
			//	Salary = 3000
			//};
			//PartTimeEmployee PartTime = new PartTimeEmployee()
			//{
			//	Id = 7,
			//	Name = "yousef",
			//	Age = 23,
			//	HourRate = 16
			//};

			//ProcessEmp(FullTime);
			//Console.WriteLine("00000000000000000");
			//ProcessEmp(PartTime); 
			#endregion


			#region More Practise on Binding
			//TypeA typeA = new TypeC(1, 2, 3);//Binding
			//typeA.A = 1;
			////typeA.B = 1;//fales
			////typeA.C = 1;//fales

			//typeA.Func01();//I am a [static binded method]
			//typeA.Func02();//C =3 [dynamic binded method] 

			//TypeB typeB = new TypeC(1, 2, 3);//Binding
			//typeB.A = 1;
			//typeB.B = 1;
			////typeA.C = 1;//fales

			//typeB.Func01();//I am b [static binded method]
			//typeB.Func02();//C =3 [dynamic binded method] 

			//TypeA typeA = new TypeE(1, 2, 3, 4, 5);//Binding
			//TypeB typeB = new TypeE(1, 2, 3, 4, 5);//Binding
			//TypeC typeC = new TypeE(1, 2, 3, 4, 5);//Binding

			//typeA.Func02();//C =3 [dynamic binded method] 
			//typeB.Func02();//C =3 [dynamic binded method] 
			//typeC.Func02();//C =3 [dynamic binded method] 

			//TypeD typeD = new TypeE(1, 2, 3, 4, 5);//Binding

			//typeD.Func02();//E =5 [dynamic binded method] 
			//			   //عشان عملت سلسه جديده من DاليE
			#endregion
			#region Interface
			IMyType myType = new MyType();
			myType.myfunc();
			myType.Age=23;
			//myType.print();//علي حسب عامله بريفت ولا
			//لو عملت اي حاجه جو الكلاس وعايز استخدمها باخد ابجيكت منو عشان اقدر استخدمهاغير كد هو ملتزم بي اي حاجه جوا الانترفيس

			#endregion
		}
	}
}
