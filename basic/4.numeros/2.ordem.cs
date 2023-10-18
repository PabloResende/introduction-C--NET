// A linguagem C# define a precedência de operações matemáticas diferentes com regras consistentes às regras que você aprendeu em matemática. Multiplicação e divisão têm precedência sobre adição e subtração:

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

// A saída demonstra que a multiplicação é executada antes da adição

// Você pode forçar uma ordem diferente de operações, adicionando parênteses para delimitar a operação, ou operações, que você quer realizar primeiro:

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// o resultado será 25

// a divisão de inteiros sempre produz um resultado inteiro, mesmo quando você espera que o resultado inclua uma parte decimal ou fracionária

// portanto para ter o resto da divisão se usa %:

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

// resultado: 
// quotient: 3
// remainder: 2


