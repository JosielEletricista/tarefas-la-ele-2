using System.Numerics;
using System.Xml;

Console.WriteLine("digite a nota1:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota2:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota3:");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota4:");
int nota4 = int.Parse(Console.ReadLine());

float  media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
Console.WriteLine("Média da disciplina: " + media);

if(media >= 60){
    Console.WriteLine("Aprovado");
    return;
}
else if (media < 20){
    Console.WriteLine("Reprovado");
    return;
}
else{ 
    Console.WriteLine("Recuperação");
}

Console.WriteLine("Digite o valor da provaFinal");
int provaFinal = int.Parse(Console.ReadLine());

float mediaFinal = (media + provaFinal) / 2f;
Console.WriteLine("média Final: " + mediaFinal);

if (mediaFinal >= 60){
    Console.WriteLine("aprovado");
}
else{
    Console.WriteLine("reprovado");
}