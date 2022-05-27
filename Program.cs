int A = 0;
int B = 0;
int resultado = 0;
string nome = "";


Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();
Console.WriteLine(" ");

Console.WriteLine("Escreva o valor de (A)");
A = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Escreva o valor de (B)");
B = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(" ");



if (B == 0)
{
   Console.WriteLine("Não existe divisão por 0!"); 
}
else
{
    resultado =  A % B;
    Console.WriteLine($"O resto da divisão é de {resultado}");
}



