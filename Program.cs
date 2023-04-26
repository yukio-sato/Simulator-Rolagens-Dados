void loop()
{
void frase(string txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);
        Thread.Sleep(45);
    }
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
frase("Quantos dados serão jogados: ");
Console.ForegroundColor = ConsoleColor.White;
int qtdDados = int.Parse(Console.ReadLine()!);
Console.ForegroundColor = ConsoleColor.DarkGreen;
frase("Quantas faces/lados o dado possue: ");
Console.ForegroundColor = ConsoleColor.White;
int faces = int.Parse(Console.ReadLine()!);
Console.ForegroundColor = ConsoleColor.Yellow;
frase("Qual é o valor do bônus do resultado: ");
Console.ForegroundColor = ConsoleColor.White;
int bns = int.Parse(Console.ReadLine()!);
Console.ForegroundColor = ConsoleColor.DarkCyan;
frase("Qual é o tipo do dado:\n");
Console.ForegroundColor = ConsoleColor.Green;
frase("1 - Pega o melhor valor.\n");
Console.ForegroundColor = ConsoleColor.White;
frase("2 - Soma todos os valores.\n");
Console.ForegroundColor = ConsoleColor.Red;
frase("3 - Pega o pior valor.\n");
Console.ForegroundColor = ConsoleColor.Gray;
frase("4 - Nenhuma das opções.\n");
Console.ForegroundColor = ConsoleColor.White;
int tipoDado = int.Parse(Console.ReadLine()!.Substring(0,1));
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
if (bns > 0)
{
frase($"Sua rolagem ficou assim: {qtdDados}D{faces}+{bns}\n");
}
else if (bns == 0)
{
frase($"Sua rolagem ficou assim: {qtdDados}D{faces}\n");
}
else if (bns < 0)
{
frase($"Sua rolagem ficou assim: {qtdDados}D{faces}{bns}\n");
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
frase("Pressione qualquer tecla para continuar");
Console.ReadKey();
Console.Clear();
List<string> tb_resultado = new List<string>();
for (int i = 0; i < qtdDados; i++)
{
int resultado = new Random().Next(1,faces+1);
tb_resultado.Add(resultado.ToString());
}
int substitute = 0;
int vl_maior = 0;
int vl_menor = faces;
int total = 0;
void updt(int c)
{
    if (vl_maior < c)
    {
    vl_maior = c;
    }
    if (c < vl_menor)
    {
    vl_menor = c;
    }
    total += c;
}
Console.ForegroundColor = ConsoleColor.White;
Console.Write(@"Resultados: (");
foreach (var c in tb_resultado)
{
    substitute++;
    if (substitute < tb_resultado.Count())
    {
    Console.Write(c+",");
    updt(Convert.ToInt32(c));
    }
    else
    {
    Console.Write(c+@")");
    updt(Convert.ToInt32(c));
    }
}
if (bns > 0)
{
Console.Write($" +{bns}");
}
else if (bns < 0)
{
Console.Write($" {bns}");
}
void dsgn()
{
Console.Write(" > ");
Console.ForegroundColor = ConsoleColor.Green;
}
if (tipoDado == 1)
{
dsgn();
Console.WriteLine(vl_maior+bns);
}
else if (tipoDado == 2)
{
dsgn();
Console.WriteLine(total+bns);
}
else if (tipoDado == 3)
{
dsgn();
Console.WriteLine(vl_menor+bns);
}
else
{
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Yellow;
frase("Pressione qualquer tecla para finalizar");
Console.ReadKey();
void pergunta()
{
Console.Clear();
Console.ForegroundColor = ConsoleColor.Gray;
frase("Fazer outra rolagem? [S/N]\n");
string resposta = Console.ReadLine()!;
if (resposta.Substring(0,1).ToLower() == "s")
{
loop();
}
else if (resposta.Substring(0,1).ToLower() == "n")
{
Console.Clear();
}
else
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Erro! Digite Sim ou Não.");
Console.ReadKey();
pergunta();
}
}
pergunta();
}
loop();
Console.ResetColor();