using System;
namespace ConstructField{
	public class ConstructorTest{
		int x,y;
		public ConstructorTest(int a, int b){
			x = a;
			y = b;
		}
		public static void Main(string[] args){
			ConstructorTest n = new ConstructorTest(100, 200);
			
			Console.WriteLine("{0}", n.y);
			
		}
	}
}

