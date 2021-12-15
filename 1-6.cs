using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Nom : ");
		string name = Console.ReadLine();
		Console.WriteLine("Prénom : ");
		string surname = Console.ReadLine();
		Console.WriteLine("Année de naissance : ");
		int birthYear = Convert.ToInt32(Console.ReadLine());
		int today = DateTime.Now.Year;
		int age = today - birthYear;
		Console.WriteLine("Fiche de Renseignement : " + Environment.NewLine + "*Nom : " + name + Environment.NewLine + "*Prénom : " + surname + Environment.NewLine + "*Age : " + age);
	}
}