// Desenvolva um programa para inserir, pesquisar, 
// remover e exibir os valores de uma árvore binária.

tp_no raiz = null;

// Funções
void Insere(ref tp_no r, int x) //Inserir
{
   if (r == null)
   {
      r = new tp_no();
      r.valor = x;
   }
   else if (x < r.valor)
   {
        Insere(ref r.esq, x);
   }
     
   else
   {
        Insere(ref r.dir, x);  
   }
      
}

tp_no Busca(tp_no r, int x) //Pesquisar
{

   if (r == null)
   {
        return null;
   }

   else if (x == r.valor)
   {
        return r;
   }
      
   else if (x < r.valor)
   {
        return Busca(r.esq, x);
   }
      
   else
   {
        return Busca(r.dir, x);
   }
      
}

tp_no RetornaMaior(ref tp_no r)
{
   if (r.dir == null)
   {
      tp_no p = r;
      r = r.esq;
      return p;
   }
   else
      return RetornaMaior(ref r.dir);
}

tp_no Remove(ref tp_no r, int x) //Remover
{
   if (r == null)
   { 
        return null; 
   }
          
   else if (x == r.valor)
   {       
      tp_no p = r;
      if (r.esq == null)        // nao tem filho esquerdo
         r = r.dir;
      else if (r.dir == null)  // nao tem filho direito
         r = r.esq;
      else                          // tem ambos os filhos
      {
         p = RetornaMaior(ref r.esq);
         r.valor = p.valor;
      }
      return p;
   }
   else if (x < r.valor)
   {
      return Remove(ref r.esq, x); 
   }
      
   else
   {
        return Remove(ref r.dir, x);
   }
      
}

void EmOrdem(tp_no r) //Exibir
{
   if (r != null)
   {
      EmOrdem(r.esq);
      Console.WriteLine(r.valor);
      EmOrdem(r.dir);
   }
}

void PreOrdem(tp_no r) //Exibir
{
   if (r != null)
   {
      Console.WriteLine(r.valor);
      PreOrdem(r.esq);
      PreOrdem(r.dir);
   }
}

void PosOrdem(tp_no r) //Exibir
{
   if (r != null)
   {
      PosOrdem(r.esq);
      PosOrdem(r.dir);
      Console.WriteLine(r.valor);
   }
}

// Menu
int op = 0;
while(op != 5)
{
    Console.WriteLine();
    Console.WriteLine("***MENU INICIAL***");
    Console.WriteLine("1- Inserir");
    Console.WriteLine("2- Pesquisar");
    Console.WriteLine("3- Remover");
    Console.WriteLine("4- Exibir ");
    Console.Write("Digite uma opção do menu e quando quiser parar, digite 5: ");
    op = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if(op == 1) //Inserir
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Insere(ref raiz, numero);
        Console.WriteLine("\nNúmero inserido com sucesso!"); 
    }

    if(op == 2) //Pesquisar
    {
        Console.Write("Digite um número para realizar a busca: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Busca(raiz, num);

        if(Busca(raiz,num) == null )
        {
            Console.WriteLine("\nNúmero não encontrado!");
         }
        else
        {
            Console.WriteLine("\nNúmero encontrado!");
        } 
    }

    if(op == 3) //Remover
    {
      Console.Write("Digite um número para remover: ");
      int remove_num = Convert.ToInt32(Console.ReadLine());
      if(Remove(ref raiz, remove_num) == null)
      {
         Console.WriteLine("\nNão foi possível remover pois o número não foi encontrado!");  
      }
      else
      {
         Console.WriteLine("\nO Número foi removido com sucesso!");
      }
    }

    if(op == 4) //Exibir
    {
        Console.WriteLine("Deseja exibir os valores: ");
        Console.WriteLine("1- Em ordem");
        Console.WriteLine("2- Pré ordem");
        Console.WriteLine("3- Pós ordem");
        Console.Write("Digite uma opção: ");
        int opc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if(opc == 1)
        {
            EmOrdem(raiz);
        }
        
        if(opc == 2)
        {
            PreOrdem(raiz);
        }

        if(opc == 3)
        {
            PosOrdem(raiz);
        }
    }
}

class tp_no
{
   public tp_no esq;
   public int valor;
   public tp_no dir;
}