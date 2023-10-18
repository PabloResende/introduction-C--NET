// O tipo de inteiro C# difere do inteiros matemáticos de outra forma: o tipo int tem limites mínimo e máximo

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
// resultado:
// The range of integers is -2147483648 to 2147483647

// Se um cálculo produzir um valor que excede esses limites, você terá uma condição de estouro negativo ou estouro. A resposta parece quebrar de um limite para o outro

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
// resultado
// An example of overflow: -2147483646

//Observe que a resposta é muito próxima do mínimo inteiro (negativo). É o mesmo que min + 2. A operação de adição estourou os valores permitidos para números inteiros. A resposta é um número negativo muito grande, pois um estouro "envolve" do maior valor de inteiro possível para o menor.

// Há outros tipos numéricos com limites e precisão diferentes que você usaria quando o tipo int não atendesse às suas necessidades.

// fonte: https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp?tutorial-step=3