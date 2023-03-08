int ucs = 0;
int i = 0;
int j = 0;

string voltar = "s";
double horas = 0;
double dias = 0;
int pesquisar = 0;


Console.WriteLine("Qual a quantidade de UCs?");
ucs = int.Parse(Console.ReadLine());
string[,] curso = new string[ucs, 4];
Console.WriteLine("Agora vamos cadastrar!!\n\n\n\n                                                                Pressione ENTER para CONTINUAR.");
for (i = 0; i<ucs;i++)
{
    Console.Clear();
    j = 0;
    Console.WriteLine("Qual a UC?");
    curso[i,j++] = Console.ReadLine();
    Console.WriteLine("Descrição da UC?");
    curso[i, j++] = Console.ReadLine();
    Console.WriteLine("qual a carga horaria? (em horas)");
    curso[i, j++] = Console.ReadLine();
    Console.WriteLine("qual a duração da sua aula diaria? (em horas)");
    curso[i, j++] = Console.ReadLine();

}

while (voltar == "s" || voltar == "S")
{
    Console.Clear();
    
    Console.WriteLine("por qual UC deseja pesquisar?");
    pesquisar = int.Parse(Console.ReadLine());

    for (i = 0; i < ucs; i++)
    {
        if (int.Parse(curso[i, 0]) == pesquisar)
        {

            Console.WriteLine("A UC: " + curso[i,0]+", "+curso[i,1]+", Com a carga horária de: "+curso[i,2]);

            horas = ((double.Parse(curso[i, 2]) * 25 / 100));
            dias = (double.Parse(curso[i, 2]) * 25 / 100) / double.Parse(curso[i, 3]);

            Console.WriteLine("\n\nVocê tem: "+horas.ToString("N0")+"h de oportunidades de falta.\nOque dá: "+dias.ToString("N0")+" dias de falta.");

        }

    }
    Console.WriteLine("\n\n\n\nDeseja continuar pesquisando ? 'S' || 'N'. ");
    voltar = Console.ReadLine();
}
