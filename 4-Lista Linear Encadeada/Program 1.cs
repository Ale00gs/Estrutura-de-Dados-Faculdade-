
//Declaração Funções
void Incluir(ref tp_no l, string nome, string idade, string whats)
{
    
    tp_no no = new tp_no();
    no.nome = nome;
    no.idade = idade;
    no.whats = whats;
    if (l != null)
        no.prox = l;
    l = no;
    Console.WriteLine("\nIncluído com sucesso!");
}

void consultar(tp_no l,string np,ref tp_no ant, ref tp_no atu)
{
    ant = null;
    atu = l;
    while(atu != null && atu.nome != np)
    {
        ant = atu;
        atu = atu.prox;
    }
}

void alterar(tp_no l)
{
    tp_no anterior = null, atual = null;
    string np;
    Console.WriteLine("Nome procurado:  ");
    np = Console.ReadLine();
    consultar(l, np, ref anterior, ref atual);
    if(atual != null) //Encontrou
    {
        Console.WriteLine("\nDados atuais ");
        Console.WriteLine("Nome: " + atual.nome);
        Console.WriteLine("Idade: " + atual.idade);
        Console.WriteLine("Whats: " + atual.whats);
        Console.WriteLine("\nDigite o novo nome: ");
        atual.nome = Console.ReadLine();
        Console.WriteLine("Nome: " + atual.nome);
        Console.WriteLine("Digite a nova idade: ");
        atual.idade = Console.ReadLine();
        Console.WriteLine("Idade: " + atual.idade);
        Console.WriteLine("Digite o novo whats: ");
        atual.whats = Console.ReadLine();
        Console.WriteLine("Whats: " + atual.whats);
        Console.WriteLine();
        Console.WriteLine("\nDados alterados com sucesso!");
    
    }
    else
    {
        Console.WriteLine("Não encontrado");
    }
    
}

void excluir(ref tp_no l)
{
    tp_no anterior = null, atual = null;
    string np;
    Console.WriteLine("Nome procurado");
    np = Console.ReadLine();
    consultar(l, np, ref anterior, ref atual);
    if(atual != null)
    {
        if(l == atual) //1 nó
        {
            l = atual.prox;
            atual.prox = null;
        }
        else if(atual.prox == null)
        {
            anterior.prox = null;
        }
        else
        {
            anterior.prox = atual.prox;
            atual.prox = null;
        }
        Console.WriteLine("\nExcluído com sucesso!");
    }
    else
    {
        Console.WriteLine("Não encontrado");
    }
}

void exibir(tp_no l)
{
    Console.WriteLine("Relatório");
    tp_no aux = l;
    int i = 1;
    while(aux != null)
    {
        Console.WriteLine("\nRegistro: " + i);
        Console.WriteLine("Nome: " + aux.nome);
        Console.WriteLine("Idade: " + aux.idade);
        Console.WriteLine("Whats: " + aux.whats);
        i = i +1;
        aux = aux.prox;
    }
}


// principal
tp_no lista = null;

// menu
int op = 0;
while(op != 5)
{
    Console.WriteLine();
    Console.WriteLine("***MENU INICIAL***");
    Console.WriteLine("1- Incluir");
    Console.WriteLine("2- Alterar");
    Console.WriteLine("3- Excluir");
    Console.WriteLine("4- Exibir ");
    Console.Write("Digite uma opção do menu e quando quiser parar, digite 5: ");
    op = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if(op == 1)//Incluir
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite sua idade: ");
        string idade = Console.ReadLine();
        Console.Write("Digite seu whatsapp: ");
        string whats = Console.ReadLine();
        Incluir(ref lista, nome,  idade, whats);
       
    }
    
    if(op == 2)//Alterar
    {
        alterar(lista);
        
    }

    if(op == 3)//Excluir
    {
        excluir(ref lista);
       
    }

    if(op == 4)//Exibir
    {
        exibir(lista);
    }
}

class tp_no
{
    public string nome,idade,whats;
    public tp_no prox;
    public int atu,ant;

}


