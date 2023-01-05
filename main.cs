// https://www.youtube.com/watch?v=oTivhgjbhIg

using System;
using System.Globalization;

class Program {
  public static void Main (string[] args) {

		int choice, operation_choice, v1, v2;
		var textinfo = new CultureInfo("pr-BR", false).TextInfo;
		var textInfo = CultureInfo.CurrentCulture.TextInfo;
		string name;
		
		Console.Clear();
		Console.WriteLine("Qual o seu nome?");
		name = Console.ReadLine();
		
		Console.Clear();
		Console.WriteLine($"Olá {name}, você gostaria de usar a calculadora?\n(1)SIM (2)NÃO");
		choice = Convert.ToInt32(Console.ReadLine());
		
		if (choice == 1){

			Console.Clear();
			Console.WriteLine($"Que ótimo {name}! E qual operação você gostaria de realizar?\n(1) SOMA\n(2) SUBTRAÇÃO\n(3) MULTIPLICAÇÃO\n(4) DIVISÃO");
			operation_choice = Convert.ToInt32(Console.ReadLine());
			
			Console.Write($"Qual o primeiro número {name}: ");
			v1 = Convert.ToInt32(Console.ReadLine());
			Console.Write($"Qual o segundo número {name}: ");
			v2 = Convert.ToInt32(Console.ReadLine());
		
			if(operation_choice == 1) Console.Write($"O resultado é: {v1 + v2}.");
			else if (operation_choice == 2) Console.Write($"O resultado é: {v1 - v2}.");
			else if (operation_choice == 3) Console.Write($"O resultado é: {v1 * v2}.");
			else Console.Write($"O resultado é: {v1 / v2}.");	
		}
		else Console.Write("Há... Que pena!\nEntão até mais!");
  }
}