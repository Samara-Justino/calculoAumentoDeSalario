// See https://aka.ms/new-console-template for more information
Console.Write("Qual o salário do funcionário? ");
double salario = double.Parse(Console.ReadLine());
Console.Write("Qual a porcentagem para o reajuste? ");
double porcentagem = double.Parse(Console.ReadLine());
double novoSalario = salario + (salario * (porcentagem / 100));
Console.WriteLine("Novo salário é R$ " + novoSalario.ToString("F2"));