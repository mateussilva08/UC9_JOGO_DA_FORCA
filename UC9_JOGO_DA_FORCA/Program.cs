string[] palavra_secreta = new string[10];
string[] palavra_visivel = new string[10];
int jogador; 
string letra = "";
string jogador1 = "";
string jogador2 = "";
int i, tentativas;
int encontrado = 0;


// Cadastrar a palavra
for (i = 0; i <= 9; i++)
{
    Console.WriteLine((i + 1) + "ª Letra da palavra (maximo de 10 letras)");
    palavra_secreta[i] = Console.ReadLine();
}

for (i = 0; i <= 9; i++)
{
    Console.Write(palavra_secreta[i] + " ");
}
Console.WriteLine("");
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

Console.Clear();

// Informar o nome
Console.WriteLine("Qual o seu nome?");
jogador1 = Console.ReadLine();

Console.WriteLine("Qual o seu nome?");
jogador2 = Console.ReadLine();


tentativas = 0;


// Tentativas
while (tentativas < 10)
{

        for (i = 0; i <= 9; i++)
        {
            Console.Write(palavra_visivel[i] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Voce errou " + tentativas + " vezes");
        Console.WriteLine("");

        Console.WriteLine("Qual letra deseja tentar");
        letra = Console.ReadLine();

        // Pesquisa
        for (i = 0; i <= 9; i++)
        {
            if (letra == palavra_secreta[i])
            {
                palavra_visivel[i] = letra;
                encontrado = 1;
            }
        }
        // Palavra não encontrada
        if (encontrado == 0)
        {
            Console.WriteLine("LETRA não encontrada");
        }

        encontrado = 0;

    jogador = 1;


        Console.WriteLine("");
        Console.WriteLine("Pressione ENTER para continuar");
        Console.ReadLine();
    }