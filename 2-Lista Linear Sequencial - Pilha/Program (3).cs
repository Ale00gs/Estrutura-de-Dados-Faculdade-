const int MAX = 100;

void Insere(char[] p, ref int t, char v)
{
    p[t] = v;
    t = t + 1;
}

char Remove(char[] p, ref int t)
{
    t = t - 1;
    return (p[t]);
}

bool EstaVazia(int t)
{
    if (t == 0)
        return true;
    else
        return false;
}

bool EstaCheia(int t)
{
    if (t == MAX)
        return true;
    else
        return false;
}

char[] pilha = new char[MAX];
int topo = 0;
string frase;
int x = 0;

Console.Write("Escreva a frase: ");
frase = Console.ReadLine();


while(x < frase.Length)
{
    if(frase[x] != ' ')
    {
        Insere(pilha, ref topo, frase[x]);
    }

    if (frase[x] == ' ' || x == frase.Length - 1)
    {
        while(!EstaVazia(topo))
        {
            Console.Write(Remove(pilha, ref topo));
        }
        Console.Write(' ');
    }
    x++;        
}