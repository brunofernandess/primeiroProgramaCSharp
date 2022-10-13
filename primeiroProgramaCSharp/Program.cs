const string texto = "Olá, mundo! Este é o meu primeiro programa em C#! Feito por: ";
string nomeCompleto;
int idade;

Console.WriteLine("Qual é o seu nome completo?");
nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual é a sua idade?");
idade = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(texto + nomeCompleto + " que tem " + idade + " anos!");