/*
void Escreva(string msg)
{
    Console.WriteLine(msg);
}

void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade} anos");
}

MostrarIdade("Fulano", 16);
MostrarIdade("Sicrano", 14);


void Mensagem()
{
    Console.WriteLine("Ola mundo");
    return;
}

Mensagem();



int MaiorEntre(int a,int b)
{
    if(a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine(MaiorEntre(10,15));
Console.WriteLine(MaiorEntre(200,30));
Console.WriteLine(MaiorEntre(6,7));
Console.WriteLine(MaiorEntre(99, 99));

*/

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void subtracao(float a, float b){
    float resultado = a - b;
     Console.WriteLine($"{a} - {b} = {resultado}");
}

void multiplicacao(float a, float b){
    float resultado = a * b;
     Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a, float b){

    if(b == 0){
        Console.WriteLine("Erro de divisão por zero");
        return;
    }
    float resultado = a / b;
     Console.WriteLine($"{a} /  {b} = {resultado}");
}

//variaveis globais
float a;
float b;

void DigitarAeB(){
    Console.WriteLine("digite a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("digite b:");
    b = float.Parse(Console.ReadLine());
}

//Menu

Console.WriteLine("--- Calculadora ---");
Console.WriteLine("|1- Soma          |");
Console.WriteLine("|2- Subtração     |");
Console.WriteLine("|3- Multiplicação |");
Console.WriteLine("|4- Divisão       |");
Console.WriteLine("|5- Sair       |");
Console.WriteLine("------------------");
Console.WriteLine("Digite a opção desejada");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    Console.WriteLine("Soma");
    DigitarAeB();
    Soma(a,b);

}
else if(opcao == 2){
    Console.WriteLine("Subtração");
    DigitarAeB();
    subtracao(a,b);

}
else if(opcao == 3){
    Console.WriteLine("Multiplicação");
    DigitarAeB();
    multiplicacao(a,b);

}
else if(opcao == 4){
    Console.WriteLine("Divisão");
    DigitarAeB();
    Divisao(a,b);

}
else if(opcao == 5){
    Console.WriteLine("Saindo...");

}
else{
    Console.WriteLine("Opção invalida");
    
}