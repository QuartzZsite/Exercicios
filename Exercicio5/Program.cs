Console.WriteLine("Digite a temperature em Fahrenheit: ");
decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());

decimal celsius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"A temperatura em Celsius é de {celsius}°C");