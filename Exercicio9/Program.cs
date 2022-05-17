Console.WriteLine("Digite o primeiro valor: ");
decimal A = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
decimal B = Convert.ToDecimal(Console.ReadLine());

if (B == 0)
{
    Console.WriteLine("Não é possivel dividir por ZERO.");
}
else
{
    var resto = A % B;
    Console.WriteLine($"O resto de {A} dividido por {B} é {resto}");
}