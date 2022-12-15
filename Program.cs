int opc = 0; //Menu

while(opc != 6)
{
    Console.WriteLine("\r\n______________________________________________________________________");
    Console.WriteLine("MENU INICIAL");
    Console.WriteLine("1- Calcular Potência");
    Console.WriteLine("2- Calcular o Cubo");
    Console.WriteLine("3- Calcular o MDC");
    Console.WriteLine("4- Cálculo Fibonacci");
    Console.WriteLine("5- Converter inteiro para binário");
    Console.WriteLine("6- Sair");
    Console.WriteLine("______________________________________________________________________\r\n");
    Console.WriteLine("Digite uma opção do menu e quando quiser parar, digite 6: ");
    opc = Convert.ToInt32(Console.ReadLine());

    if(opc == 1) // Potência
    {
        int num1 = 0;
        int num2 = 0;

        Console.Write("Digite um número para X: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um número para Y: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Resultado: " + potencia(num1,num2));

    }

    if(opc == 2)//Cubo
    {
        int n = 0;

        Console.Write("Digite um número: ");
        n = Convert.ToInt32(Console.ReadLine());
        cubos(n);
      
    }

    if(opc == 3)//MDC
    {  
        int n1,n2 = 0; 
           
        Console.Write("Digite um número para X: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um número para Y: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Resultado: " + mdc(n1,n2));
    
    }

    if(opc == 4)//Fibonacci
    {
        int n = 0;

        Console.WriteLine("Digite o valor de N: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Resultado: "+fibonacci(n));

    }

    if(opc == 5)//Binário
    {
        int numerob = 0;

        Console.WriteLine("Digite um número inteiro para realizar a conversão para binário: ");
        numerob = Convert.ToInt32(Console.ReadLine());
        binario(numerob);
    }
    Console.ReadKey(); //Deixar em espera 
}

// Função 1 Potência

int potencia(int x, int y)
{
    if(y > 0)
    {
         
        return x * potencia(x , y-1);
    }

    else
    {
        return 1;
    }
}

// Função 2 Cubo

void cubos(int n)
    { 
        if(n >= 1)
        {
            cubos(n - 1); 
            if(n != 0)
            {
            Console.WriteLine(n * n * n);
            }
        }
    }

// Função 3 MDC

int mdc(int x, int y)
{

    if(x == y)
    {
        return x;
    }

    else if(x < y)
    {
        return mdc(y,x);
    }

    else 
    {
        return mdc(x-y,y);

    }
}

// Função 4 Fibonacci

int fibonacci(int n)
{
    if(n == 0 || n == 1)
    {
        
        return n;
    }
    else
    {
        return fibonacci(n-1) + fibonacci(n-2);
    }
}

// Função 5 Binário

void binario(int numerob)
{
    if(numerob == 1 || numerob == 0)
    {
        Console.Write(numerob);
    }

    else
    {
        if(numerob / 2 > 0)
        {
            binario(numerob / 2);
            Console.Write(numerob % 2);
        }

        else 
        {
            Console.Write(numerob);
        }
    }
   
}