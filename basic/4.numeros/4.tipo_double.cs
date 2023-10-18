// O tipo numérico double representa um número de ponto flutuante de precisão dupla. Esses termos podem ser novidade para você. Um número de ponto flutuante é útil para representar números não integrais que podem ser muito grandes ou pequenos em magnitude. Precisão dupla é um termo relativo que descreve os números de dígitos binários usados para armazenar o valor. Os números de precisão dupla têm o dobro do número de dígitos binários do que os de precisão simples. Em computadores modernos, é mais comum usar precisão dupla que números de precisão única. Números de precisão simples são declarados usando a palavra-chave float

double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

// outro exemplo um pouco mais complicado:

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

// max e min com double:

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

// Esses valores são impressos em notação científica. O número à esquerda do E é o significando. O número à direita é o expoente, como uma potência de 10

// Assim como os números decimais em matemática, os duplos em C# podem ter erros de arredondamento

double third = 1.0 / 3.0;
Console.WriteLine(third);

// Você sabe que 0.3 é 3/10 e não exatamente o mesmo que 1/3. Da mesma forma, 0.33 é 33/100. Isso é mais próximo de 1/3, mas ainda não exato

// fonte: https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp?tutorial-step=4