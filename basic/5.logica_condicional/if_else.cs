// if e else são condições que podem ser usadas no código, para trazer ações alternativas na execução

int a = 5;
int b = 3;
if (a + b > 10) // se a mais b for maior que 10 if será True, portanto irá mostrar a mensagem do mesmo
    Console.WriteLine("The answer is greater than 10");
else // caso contrário o else será True, portando irá exibir sua respectiva mensagem
    Console.WriteLine("The answer is not greater than 10");

// A instrução após a palavra-chave else é executada somente quando a condição que estiver sendo testada for false. A combinação de if e else com condições boolianas fornece todos os recursos que você precisa

// Como o recuo não é significativo, você precisa usar { e } para indicar quando você quer que mais de uma instrução faça parte do bloco executado condicionalmente. Os programadores em C# normalmente usam essas chaves em todas as cláusulas if e else

int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

// outro exemplo:

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

