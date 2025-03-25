Console.Clear();

string palavra;
string letra;


Console.WriteLine("Bem vindo ao jogo da forca");
Console.Write("Digite sua palavra: ");
palavra = Console.ReadLine()!.ToLower();

Console.Write("Letra: ");
letra = Console.ReadLine()!.ToLower().Trim().Substring(0, 1);

bool sim = palavra.Contains(letra);

Console.WriteLine($"A letra {letra} existe na palavra? - {sim}"); //pq não retorna o resultado certo???




/*char[] palavraFinal = palavra.ToCharArray(); //usar "ToCharArray" somente com a var "char" que armazena um caractere, cabe emoji

foreach (char caractere in palavraFinal) //Foreach - le cada caractere individualmente e altera
{
    Console.WriteLine(caractere);
}*/

/*
﻿Console.WriteLine("--- Forca ---\n");

Console.Write("Qual a palavra secreta? ");
string palavraSecreta = Console.ReadLine()!;

Console.Write("Qual a letra? ");
string letra = Console.ReadLine()!
    .Trim()
    .Substring(0, 1)
    .ToLower();

bool letraExiste = palavraSecreta
    .ToLower()
    .Contains(letra);

Console.WriteLine($"\nA letra \"{letra}\" existe na palavra secreta => {letraExiste}"); */