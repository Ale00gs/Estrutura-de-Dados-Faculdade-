const int MAX = 4;
int op = 0;
int ini = 0;
int fim = 0;
int[] fila = new int[MAX];

while(op != 6)
{
    Console.WriteLine("\r\n_________________________________________________________");
    Console.WriteLine("\r\nMENU INICIAL");
    Console.WriteLine("1- Adicionar um avião à fila de espera ");
    Console.WriteLine("2- Consultar a quantidade de aviões aguardando na fila ");
    Console.WriteLine("3- Autorizar a decolagem de um avião ");
    Console.WriteLine("4- Listar os números de todos os aviões da fila ");
    Console.WriteLine("5- Consultar o número do primeiro avião da fila ");
    Console.WriteLine("6- Sair");
    Console.WriteLine("_________________________________________________________\r\n");
    Console.Write("Digite uma opção do menu (Quando quiser parar digite 6): ");
    op = Convert.ToInt32(Console.ReadLine());

        
    if(op == 1)
    {
        while(EstaCheia(fim) != true)
        {
            Console.Write("Digite os números de identificação dos aviões: ");
            int valor = Convert.ToInt16(Console.ReadLine());
            Insere(fila, ref fim, valor);
            Console.WriteLine("Avião adicionado com sucesso. ");
        }
    }

    if(op == 2)
    {
        int consulta = fim - ini;
        Console.Write("Quantidade de aviões aguardando na fila: "+consulta);
    }

    if(op == 3)
    {
        if(EstaVazia(ini,fim) == false)
        {
            Remove(fila,ref ini);
            Console.WriteLine("Avião removido com sucesso! ");
        }
    }

    if(op == 4)
    {
        ListarAvioes(fila,ini,fim);
    }

    if(op == 5)
    {
        Console.Write("Número do primeiro avião da fila: "+fila[ini]);
    }
}


void Insere(int[] q, ref int f, int v)
{
    q[f] = v;
    f = f + 1;
}

int Remove(int[] q, ref int i)
{
    int v = q[i];
    i = i + 1;
    return (v);
}

bool EstaVazia(int i, int f)
{
    if (i == f)
        return true;
    else
        return false;
}

bool EstaCheia(int f)
{
    if (f == MAX)
        return true;
    else
        return false;
}

void ListarAvioes(int[] fila, int ini, int fim)
{
    int i = ini;
    while(i < fim)
    {
        Console.WriteLine("Número do avião na fila: " +fila[i]);
        i++;
    }
    
}
