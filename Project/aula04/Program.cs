//Criar um vetor de valores inteiros
using System.Reflection.Metadata;

int tamanho = 10;
int[] vetor = new int[tamanho];

//Percorrer o vetor com um laço
Random random = new Random();
for(int i = 0; i < vetor.Length; i++)
{
    //Gerar um valor aleatório em C#
    vetor[i] = random.Next(100);
}

//Imprimir o vetor com valores aleatórios
    Console.Write("valores genericos: \n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.Write("\n");
//Imprimir o vetor com valores aleatórios
Console.Write("ordenou o maior numero: \n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}


