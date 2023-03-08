int ucs = 0;
int i = 0;
int j = 0;
string[,] curso = new string[ucs, 3];

Console.WriteLine("Qual a quantidade de UCs?");
ucs = int.Parse(Console.ReadLine());

Console.WriteLine("Agora vamos cadastrar!!\n\n\n\n                                                                Pressione ENTER para CONTINUAR.");
for (i = 0; i<=ucs;i++)
{
    j = 0;
    Console.WriteLine("Qual a UC?");
    curso[i,j++]= Console.ReadLine();
    Console.WriteLine("Descrição da UC?");
    curso[i, j++] = Console.ReadLine();
    Console.WriteLine("qual a carga horaria? (em horas)");
    curso[i, j++] = Console.ReadLine();

}

