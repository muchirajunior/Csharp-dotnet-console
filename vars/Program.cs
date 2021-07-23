using System;
					
public class Program
{
	public static void Main()
	{
		char b=(char)98;
		Console.WriteLine(b);
		int a ='a';
		Console.WriteLine(a);
		Console.WriteLine(b);
		char[] letters={'j','u','n','i','o','r'};
		string name=new string(letters);
		Console.WriteLine(name);
		//interpolation
		string statement=$"my name is {name}";
		Console.WriteLine(statement);
	}
}