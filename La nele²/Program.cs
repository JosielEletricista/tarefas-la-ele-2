bool resposta()
{
        inicioPergunta:
        string resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Não entendi, responda com s/n");
        goto inicioPergunta;
    }
}

Console.WriteLine("Quer jogar um jogo? s/n?");
if (resposta() == false)
{
    goto finalJogo;
}

InicioJogo:

int menor = 0;
int maior = 100;
int numtentativas = 10;
bool jogoRodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"Pensei em um número entre {menor} e {maior}. Tente adivinhar!");

while (jogoRodando)
{
        Console.Write($"Tentativas {numtentativas}: ");
        int numDigitado = int.Parse(Console.ReadLine());
        if (numDigitado < sorteado)

        {
            Console.WriteLine("Muito baixo. Tente novamente");
            numtentativas--;
        }
        else if(numDigitado > sorteado)
        {
            Console.WriteLine("Muito alto. Tente novamente.");
            numtentativas--;
        }
        else
        {
            Console.WriteLine("Parabéns! Você acertou!");
            jogoRodando = false;
        }
        if (numtentativas == 0)
        {
            Console.WriteLine($"Acabaram suas tentativas. o numero que pensei era {sorteado}. ");
            jogoRodando = false;
        }
}

Console.WriteLine("Quer jogar de novo? s/n");
if (resposta() == true)
{
    goto InicioJogo;
}

finalJogo:
Console.WriteLine("Então até a proxima");
