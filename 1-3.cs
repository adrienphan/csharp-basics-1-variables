using System;
					
public class Program
{
	public static void Main()
	{
		int firstNumber;
		int secondNumber;
		//prompting user for numbers
		Console.WriteLine("Veuillez entrer un nombre");
		firstNumber = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Veuillez entrer un nouveau nombre");
		secondNumber = Convert.ToInt32(Console.ReadLine());
		int quotient = firstNumber / secondNumber;
		Console.WriteLine("le resultat de " + firstNumber + " : " + secondNumber + " est " + quotient);
	}
}