const int N = 5;
tp_no[] vetor = new tp_no[N];
tp_no[] vetor_linear = new tp_no[N];
tp_no[] vetor_encadeado = new tp_no[N];
//-------------------------
//Funções

int Hash(int chave)
{
   return (chave % N);
}

int Busca(int c)
{
   int pos = Hash(c);
   return pos;
}

void Insere(ref tp_no[] vetor, int idade, string nome, string whats)
{
   int pos = Hash(idade);
   vetor[pos] = new tp_no();
   vetor[pos].idade = idade;
   vetor[pos].nome = nome;
   vetor[pos].whats = whats;
}

void InsereLinear(ref tp_no[] vetor, int idade, string nome, string whats)
{
   int pos = Hash(idade);
   while (vetor[pos] != null)
   {
      pos++;
      pos = pos % N;
   }
   vetor[pos] = new tp_no();
   vetor[pos].idade = idade;
   vetor[pos].nome = nome;
   vetor[pos].whats = whats;
}

void InsereEncadeado(ref tp_no[] vetor, int idade, string nome, string whats)
{
   tp_no no = new tp_no();
   no.idade = idade;
   no.nome = nome;
   no.whats = whats;
   int pos = Hash(idade);
   if (vetor[pos] != null)
      no.prox = vetor[pos];
   vetor[pos] = no;
}

void Alterar(ref tp_no[] vetor, int num)
{
   int pos = Busca(num);
   if (vetor[pos] != null) //encontrou
   {
      Console.WriteLine("\nDados atuais ");
      Console.WriteLine("Nome: " + vetor[pos].nome);
      Console.WriteLine("Idade: " + vetor[pos].idade);
      Console.WriteLine("Whats: " + vetor[pos].whats);

      Console.WriteLine("\nDigite o novo nome: ");
      vetor[pos].nome = Console.ReadLine();
      Console.WriteLine("Nome: " + vetor[pos].nome);
      Console.WriteLine("Digite o novo whats: ");
      vetor[pos].whats = Console.ReadLine();
      Console.WriteLine("Whats: " + vetor[pos].whats);
      Console.WriteLine("\nDados alterados com sucesso!");
   }

   else
   {
      Console.WriteLine("Não encontrado");
   }
}

void Alterarlinear(ref tp_no[] vetor, int num)
{
   int pos = Busca(num);
   while (vetor[pos] != null && vetor[pos].idade != num)
   {
      pos++;
      pos = pos % N;
   }
   if (vetor[pos] != null) //encontrou
   {
        Console.WriteLine("\nDados atuais ");
        Console.WriteLine("Nome: " + vetor[pos].nome);
        Console.WriteLine("Idade: " + vetor[pos].idade);
        Console.WriteLine("Whats: " + vetor[pos].whats);

        Console.WriteLine("\nDigite o novo nome: ");
        vetor[pos].nome = Console.ReadLine();
        Console.WriteLine("Nome: " + vetor[pos].nome);
        Console.WriteLine("Digite o novo whats: ");
        vetor[pos].whats = Console.ReadLine();
        Console.WriteLine("Whats: " + vetor[pos].whats);
        Console.WriteLine("\nDados alterados com sucesso!");
    }

   else
   {
      Console.WriteLine("Não encontrado");
   }
}

void AlterarEncadeado(ref tp_no[] vetor, int num)
{
   int pos = Busca(num);
   if (vetor[pos] != null) //encontrou
   {
    tp_no atu = vetor[pos];
    while(atu != null && atu.idade != num)
    {
        atu = atu.prox;
    }
    Console.WriteLine("\nDados atuais ");
    Console.WriteLine("Nome: " + atu.nome);
    Console.WriteLine("Idade: " + atu.idade);
    Console.WriteLine("Whats: " + atu.whats);

    Console.WriteLine("\nDigite o novo nome: ");
    atu.nome = Console.ReadLine();
    Console.WriteLine("Nome: " + atu.nome);
    Console.WriteLine("Digite o novo whats: ");
    atu.whats = Console.ReadLine();
    Console.WriteLine("Whats: " + atu.whats);
    Console.WriteLine("\nDados alterados com sucesso!");
   }

   else
   {
      Console.WriteLine("Não encontrado");
   }
}

void Relatar(tp_no[] vetor)
{
   int i = 0;
   while(i < N)
   {
      if(vetor[i] != null)
      {
        Console.WriteLine("\nRegistro: " + i);
        Console.WriteLine("Nome: " + vetor[i].nome);
        Console.WriteLine("Idade: " + vetor[i].idade);
        Console.WriteLine("Whats: " + vetor[i].whats);
      }
      i = i + 1;
   }
}

void RelatarEncadeado(tp_no[] vetor)
{
   int i = 0;
   while(i < N)
   {
    tp_no atu = vetor[i];
    if(vetor[i] != null)
    {
      while(atu != null)
      {
        Console.WriteLine("Nome: " + atu.nome);
        Console.WriteLine("Idade: " + atu.idade);
        Console.WriteLine("Whats: " + atu.whats);
        atu = atu.prox;
        Console.WriteLine();
      }
    }
    i = i + 1;
   }
}

//-------------------------
//Funções do menu

void MenuPrincipal(ref int op)
{
   Console.WriteLine();
   Console.WriteLine("***MENU PRINCIPAL***");
   Console.WriteLine("1- Sem Tratamento de Colisão");
   Console.WriteLine("2- Tratamento de Colisão Linear");
   Console.WriteLine("3- Tratamento de Colisão com Lista Encadeada");
   Console.Write("Digite uma opção do menu e quando quiser parar, digite 4: ");
   op = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}

void MenuSecundario(ref int opc)
{
   Console.WriteLine();
   Console.WriteLine("***MENU SECUNDÁRIO***");
   Console.WriteLine("1- Inserir");
   Console.WriteLine("2- Alterar");
   Console.WriteLine("3- Relatar");
   Console.Write("Digite uma opção do menu e quando quiser parar, digite 4: ");
   opc = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}

//-------------------------
// MENU
int op = 0;
int opc = 0;
while (op != 4)
{
    MenuPrincipal(ref op);
    if (op == 1) //Sem Tratamento de Colisão
    {
        while (opc != 4)
        {
            MenuSecundario(ref opc);
            if(opc == 1) //Inserir
            {
                Console.WriteLine("***INSERIR***");
                Console.WriteLine("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string nome = Convert.ToString(Console.ReadLine());
                Console.Write("Digite o whats: ");
                string whats = Convert.ToString(Console.ReadLine());
                Insere(ref vetor,idade,nome,whats);
                Console.WriteLine("\nDados inseridos com sucesso!"); 
            }

            if(opc == 2) // Alterar
            {
                Console.WriteLine("***ALTERAR***");
                Console.WriteLine("Digite a idade: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Alterar(ref vetor, num);
            }

            if(opc == 3) //Relatar
            {
                Console.WriteLine("***RELATÓRIO***");
                Relatar(vetor);
            } 
        }
        opc = 0;
    }

    if (op == 2) //Tratamento de Colisão Linear
    {
        while (opc != 4)
        {
            MenuSecundario(ref opc);
            if(opc == 1) //Inserir
            {
                Console.WriteLine("***INSERIR***");
                Console.WriteLine("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string nome = Convert.ToString(Console.ReadLine());
                Console.Write("Digite o whats: ");
                string whats = Convert.ToString(Console.ReadLine());
                InsereLinear(ref vetor_linear,idade,nome,whats);
                Console.WriteLine("\nDados inseridos com sucesso!"); 
            }

            if(opc == 2) // Alterar
            {
                Console.WriteLine("***ALTERAR***");
                Console.WriteLine("Digite a idade: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Alterarlinear(ref vetor_linear, num);
            }

            if(opc == 3) //Relatar
            {
                Console.WriteLine("***RELATÓRIO***");
                Relatar(vetor_linear);
            } 
        }
        opc = 0;
    }

    if (op == 3) //Tratamento de Colisão Com Lista encadeada
    {
        while (opc != 4)
        {
            MenuSecundario(ref opc);
            if(opc == 1) //Inserir
            {
                Console.WriteLine("***INSERIR***");
                Console.WriteLine("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string nome = Convert.ToString(Console.ReadLine());
                Console.Write("Digite o whats: ");
                string whats = Convert.ToString(Console.ReadLine());
                InsereEncadeado(ref vetor_encadeado,idade,nome,whats);
                Console.WriteLine("\nDados inseridos com sucesso!"); 
            }

            if(opc == 2) // Alterar
            {
                Console.WriteLine("***ALTERAR***");
                Console.WriteLine("Digite a idade: ");
                int num = Convert.ToInt32(Console.ReadLine());
                AlterarEncadeado(ref vetor_encadeado, num);
            }

            if(opc == 3) //Relatar
            {
                Console.WriteLine("***RELATÓRIO***");
                RelatarEncadeado(vetor_encadeado);
            } 
        }
        opc = 0;
    }
} 

class tp_no
{
   public int idade;
   public string nome, whats;
   public tp_no prox;

}
