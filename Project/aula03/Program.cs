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

bool troca = false;

do{
     troca = false;
    for(int i = 0; i < vetor.Length - 1; i++){
        if(vetor[i] > vetor[i + 1]){
            troca = true;
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
        }
    }

}while(troca == true);


Console.Write("\n");
//Imprimir o vetor com valores aleatórios
Console.Write("ordenou o maior numero: \n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}


