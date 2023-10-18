// O símbolo == testa a igualdade

// O && representa "e". Isso significa que as duas condições devem ser verdadeiras para executar a instrução no branch verdadeiro

// Você também pode usar || para representar "ou", quer dizer que pelo uma das condições deve ser verdadeira

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

