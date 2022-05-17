Console.WriteLine("Digite sua altura: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal pesoIdeal = (72.7m * altura) - 58;

Console.WriteLine($"Seu peso ideal é de {pesoIdeal}Kg");