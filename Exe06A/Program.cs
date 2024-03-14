Console.Clear();
//criar um vetor
int[] vetor = new int[100];
Random numAleatorio = new Random();

// Preencher vetor com valores aleatorios
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = numAleatorio.Next(100);
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

bool troca = false;
do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        if (vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        }
    }
} while (troca == true);

Console.WriteLine("\n");

//Bubble sort
//Imprimir o vetor
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}