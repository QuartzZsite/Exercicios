Console.WriteLine("Digite a temperatura em Celsius: ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());

decimal fahrenheit = (9 * celsius + 160) / 5;

Console.WriteLine($"A temperatura em Fahrenheit é de {fahrenheit}°F");