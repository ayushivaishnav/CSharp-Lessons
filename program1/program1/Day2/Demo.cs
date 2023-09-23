/*namespace program1.Day2
{
	internal class Demo
	{
		//GLOBAL DECLARATION
		int x = 123;
		static int y = 567;

		public static void FirstMethod()
		{
			//LOCAL VARIABLE
			int y = 5000;
			Console.WriteLine(x); //non static member can not be accessed.
			Console.WriteLine(y);// local variable
			Console.WriteLine(Demo.y);//global static variable

		}
		public void SecondMethod() //non static method
		{
			//local variables
			int y = 5000;
	        Console.WriteLine(x);
	        Console.WriteLine(y);
			Console.WriteLine(Demo.y);

		}
	}
}*/