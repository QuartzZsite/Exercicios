Console.WriteLine("Digite as 4 notas do aluno: ");

decimal nota1 = Convert.ToDecimal(Console.ReadLine());
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
decimal nota3 = Convert.ToDecimal(Console.ReadLine());
decimal nota4 = Convert.ToDecimal(Console.ReadLine());

decimal media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine($"A média é igual a {media}");

if (media >= 7)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
}