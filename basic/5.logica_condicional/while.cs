// Outro conceito importante para criar programas maiores são os loops. Você usará loops para repetir as instruções que deseja executar mais de uma vez

int counter = 0;
while (counter < 10) // enquanto 'counter' for menor que 10...
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++; // counter ganhar +1, e se repete até não ser menor que 10
}

// A instrução while verifica uma condição e executa a instrução após while. Ela repetirá a verificação da condição e executará essas instruções até que a condição seja false

// O loop while testa a condição antes de executar o código seguindo while. O loop do ... while executa o código primeiro e, em seguida, verifica a condição

int counter = 0;
do // do é executado primeiro
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);