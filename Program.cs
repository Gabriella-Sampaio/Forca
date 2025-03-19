Console.Clear();

string palavra;
string letra;


Console.WriteLine("Bem vindo ao jogo da forca");
Console.Write("Digite sua palavra: ");
palavra = Console.ReadLine()!;

Console.Write("Letra: ");
letra = Console.ReadLine()!.ToUpper().Trim().Substring(0, 1);

bool sim = palavra.Contains(letra);

Console.WriteLine($"A letra {letra} existe na palavra? - {sim}"); //pq não retorna o resultado certo???




/*char[] palavraFinal = palavra.ToCharArray(); //usar "ToCharArray" somente com a var "char" que armazena um caractere, cabe emoji

foreach (char caractere in palavraFinal) //Foreach - le cada caractere individualmente e altera
{
    Console.WriteLine(caractere);
}*/