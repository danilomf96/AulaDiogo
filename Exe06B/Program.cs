
Console.Clear();
//criar um vetor
int[] vetor = new int[100];
Random numAleatorio = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = numAleatorio.Next(100);
}

Console.WriteLine("Vetor original:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.WriteLine("\nVetor ordenado em ordem ascendente:");
foreach (int i in vetor)
{
    Console.Write(i + " ");
}

Array.Reverse(vetor);

Console.WriteLine("\nVetor ordenado em ordem decrescente:");
foreach (int i in vetor)
{
    Console.Write(i + " ");
}
