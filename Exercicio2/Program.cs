decimal real = 5.25m;

Console.WriteLine("Quantos Euros você quer comprar");
decimal qntEuro = Convert.ToDecimal(Console.ReadLine());

decimal custo = real * qntEuro;

Console.WriteLine($"O custo de comprar {qntEuro} Euros é de {custo} Reais");