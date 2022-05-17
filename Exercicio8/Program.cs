Console.WriteLine("Digite o primeiro valor: ");
decimal A = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
decimal B = Convert.ToDecimal(Console.ReadLine());

decimal total = A - B;

if (total >= 0)
{
    Console.WriteLine($"TOTAL POSITIVO: {total}");
}
else
{
    Console.WriteLine($"TOTAL NEGATIVO: {total}");
}