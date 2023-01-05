using System;
using System.Collections.Generic;

class Program
{
  public static void Main(string[] args)
  {







    #region LEITOR DE ALTURA E MATRICULA DE 10 ALUNOS MOSTRANDO A MATRÍCULA DO ALUNO MAIS ALTO E DO MAIS BAIXO.

    #endregion












    #region CALCULA E EXIBE O SALÁRIO REAJUSTADO DE DEZ FUNCIONÁRIOS DE ACORDO COM: SALÁRIO  300 - REAJUSTE DE 50%; SALÁRIO > 300, reajuste de 30%.

    #endregion

















    #region LER IDADE DE 10 PESSOAS E MOSTRA QUANTAS POSUEM MAIS DE 18 ANOS.

    Console.Clear();

    string[] pessoas = { "primera", "segunda", "terceira", "quanta", "quinta", "sexta", "sétima", "outava", "nova", "décima" };
    int[] idade = { };


    for (int i = 0; i < pessoas.Length; i++)
    {
      for (int j = 0; j < idade.Length; j++)
      {
        Console.Write($"Informe a idade da {pessoas} pessoa: ");
        idade[j] = int.Parse(Console.ReadLine());
      }
    }


    // foreach (string pessoa in pessoas)
    // {
    //   Console.Write($"Informe a idade da {pessoa} pessoa: ");

    //   for (int i = 0; i < idade.Length; i++)
    //   {
    //     idade[i] = int.Parse(Console.ReadLine());
    //   }
    //   }

    #endregion















    #region VERIFICA SE O NÚMERO INFORMADO É PAR OU IMPAR

    // int par_impar;

    // Console.Clear();
    // Console.Write("Digite um número: ");
    // par_impar = int.Parse(Console.ReadLine());

    // if (par_impar % 2 == 0) Console.Write("Você infomou um número par.");
    // else Console.Write("Você informou um número ímpar.\n");

    #endregion










    #region CALCULA IDADE MÉDIA DE 5 ALUNOS
    // decimal aluno1, aluno2, aluno3, aluno4, aluno5;

    // Console.Clear();
    // Console.Write("Informe a idade do primeiro aluno: ");
    // aluno1 = int.Parse(Console.ReadLine());
    // Console.Write("Informe a idade do segundo aluno: ");
    // aluno2 = int.Parse(Console.ReadLine());
    // Console.Write("Informe a idade do terceiro aluno: ");
    // aluno3 = int.Parse(Console.ReadLine());
    // Console.Write("Informe a idade do quarto aluno: ");
    // aluno4 = int.Parse(Console.ReadLine());
    // Console.Write("Informe a idade do quinto aluno: ");
    // aluno5 = int.Parse(Console.ReadLine());

    // Console.Write($"A média das idades é : {(aluno1 + aluno2 + aluno3 + aluno4 + aluno5) / 5}");
    #endregion








    #region CALCULADORA
    // CALCULADORA
    // https://www.youtube.com/watch?v=oTivhgjbhIg

    //     int operation_choice;
    //     decimal v1, v2;

    //     Console.Clear();
    //     Console.WriteLine($"Qual operação você gostaria de realizar sobre a operação?\n(1) SOMA\n(2) SUBTRAÇÃO\n(3) MULTIPLICAÇÃO\n(4) DIVISÃO");
    //     operation_choice = Convert.ToInt32(Console.ReadLine());

    //     Console.Clear();
    //     Console.Write("Informe um valor: ");
    //     v1 = Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Informe o segundo valor: ");
    //     v2 = Convert.ToInt32(Console.ReadLine());

    //     if (operation_choice == 1)
    //     {
    //       Console.Write($"O resultado é: {v1 + v2}.");
    //     }
    //     else if (operation_choice == 2)
    //     {
    //       Console.Write($"O resultado é: {v1 - v2}.");
    //     }
    //     else if (operation_choice == 3)
    //     {
    //       Console.Write($"O resultado é: {v1 * v2}.");
    //     }
    //     else Console.Write($"O resultado é: {v1 / v2}.");

    //     // Console.WriteLine("Id............:{0,10}", id_produto);
    //     // Console.WriteLine("Produto.......:{0,10}", produto);
    //     // Console.WriteLine("Custo.........:{0,10:c}", custo);
    //     // Console.WriteLine("Venda.........:{0,10:c}", venda);
    //     // Console.WriteLine("Estoque.......:{0,10:p2}", estoque);

    //     Console.Clear();

    #endregion



  }
}