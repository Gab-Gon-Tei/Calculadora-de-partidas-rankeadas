using Calculadora_de_partidas_rankeadas;
using static Calculadora_de_partidas_rankeadas.Herói;

Console.WriteLine("Olá, Herói! Bem vindos a sua calculadora de ranqueadas!");
Console.WriteLine("Primeiramente, digite o nome do seu personagem:");

var heroi = new Herói
{
    nome = Console.ReadLine()
};

Console.WriteLine($"Bem vindo, {heroi.nome}!");

heroi.vitorias = ObterValorNumerico("Agora, me informe quantas vitórias você teve:");
heroi.derrotas = ObterValorNumerico("Nem só de vitórias vive um herói, não é mesmo? Me conte quantas derrotas obteve:");

heroi.Calculadora();

string[] ranks = { "Ferro", "Bronze", "Prata", "Ouro", "Diamante", "Lendário", "Imortal" };
int[] limites = { 10, 20, 50, 80, 90, 101 };

heroi.rank = "Imortal"; // Atribui inicialmente "Imortal"

for (int i = 0; i < limites.Length; i++)
{
    if (heroi.vitorias < limites[i])
    {
        heroi.rank = ranks[i];
        break;
    }
}

Console.WriteLine($"Certo. Você tem {heroi.saldo} de saldo de vitórias. Você está fazendo progresso!");
Console.WriteLine();
Console.WriteLine($"O Herói de nome {heroi.nome} está no ranking de {heroi.rank}");

Console.ReadLine();

int ObterValorNumerico(string mensagem)
{
    while (true)
    {
        Console.WriteLine(mensagem);
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int valor) && valor >= 0)
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Digite um valor numérico válido");
        }
    }
}
