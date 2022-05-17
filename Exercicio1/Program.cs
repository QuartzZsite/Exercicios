Console.WriteLine("Idade do mais novo: ");
int youngest = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Idade do mais velho: ");
int oldest = Convert.ToInt32(Console.ReadLine());

int media = (youngest + oldest) / 2;

Console.WriteLine($"Media é igual a {media}");