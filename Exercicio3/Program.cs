Console.WriteLine("Digite o valor total das vendas: ");
int vendas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor da comissão em %: ");
decimal comissao = Convert.ToDecimal(Console.ReadLine());

comissao = comissao / 100m;

decimal valorRecebido = vendas * comissao;

Console.WriteLine($"O vendedor receberá R${valorRecebido} de comissão");