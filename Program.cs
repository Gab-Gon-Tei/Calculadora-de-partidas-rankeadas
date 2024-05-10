using Calculadora_de_partidas_rankeadas;
using static Calculadora_de_partidas_rankeadas.Herói;


//Boas vindas ao usuário, acrescentando a característica "Nome" ao Objeto "Herói"


Console.WriteLine("Olá, Herói! Bem vindos a sua calculadora de ranqueadas!");
Console.WriteLine("Primeiramente, digite o nome do seu personagem:");

 var heroi = new Herói();    

 heroi.nome = Console.ReadLine();

Console.WriteLine($"Bem vindo, {heroi.nome}!");


bool validaçãoW = false;

while (!validaçãoW)
{
    Console.WriteLine("Agora, me informe quantas vitórias você teve:");
    string vitorias = Console.ReadLine();

    if (vitorias == "")
    {
        Console.WriteLine("Digite um valor numérico");
    }
    else if (int.TryParse(vitorias, out int lvlconv))
    {
        heroi.vitorias = lvlconv;
        validaçãoW = true;
    }
    else
    {
        Console.WriteLine("Digite um valor numérico válido");
    }
}


bool validaçãoL = false;

while (!validaçãoL)
{
    Console.WriteLine("Nem só de vitórias vive um herói, não é mesmo? Me conte quantas derrotas obteve:");
    string derrotas = Console.ReadLine();

    if (derrotas == "")
    {
        Console.WriteLine("Digite um valor numérico");
    }
    else if (int.TryParse(derrotas, out int lvlconv))
    {
        heroi.derrotas = lvlconv;
        validaçãoL = true;
    }
    else
    {
        Console.WriteLine("Digite um valor numérico válido");
    }
}

heroi.Calculadora();


//Algoritmo de classificação do rank 

if (heroi.saldo <= 10)
{
    heroi.rank = "Ferro";
}
else if (heroi.saldo <= 20)
{
    heroi.rank = "Bronze";
}
else if (heroi.saldo <= 50)
{
    heroi.rank = "Prata";
}
else if (heroi.saldo <= 80)
{
    heroi.rank = "Ouro";
}
else if (heroi.saldo <= 90)
{
    heroi.rank = "Diamante";
}
else if (heroi.saldo <= 100)
{
    heroi.rank = "Lendário";
}
else if (heroi.saldo >= 101)
{
    heroi.rank = "Imortal";
}


Console.WriteLine($"Certo. Você tem {heroi.saldo} de saldo de vitórias. Você está fazendo progresso!");
Console.WriteLine();
Console.WriteLine($"O Herói de nome {heroi.nome} está no ranking de {heroi.rank}");

// Ferramenta para não fechar o terminal após a conclusão do processamento.
Console.ReadLine();
