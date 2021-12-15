using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Nom : ");
		string name = Console.ReadLine();
		Console.WriteLine("Prénom : ");
		string surname = Console.ReadLine();
		string today = DateTime.Now.ToString("dddd dd MMM");
		Console.WriteLine("Bonjour " + surname + " " + name + ", nous sommes le " + today);
	}
}