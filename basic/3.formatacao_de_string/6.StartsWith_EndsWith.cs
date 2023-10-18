// Há dois métodos semelhantes, StartsWith e EndsWith que também procuram subcadeias de caracteres em uma cadeia de caracteres. Eles encontram uma subcadeia de caracteres no início ou no final da cadeia de caracteres. Tente modificar o exemplo anterior para usar StartsWith e EndsWith em vez de Contains

string songLyrics = "You say goodbye, and i say hello";

Console.WriteLine(songLyrics.StartsWith("you")); // false, a 'pergunta' aqui foi se começa com 'you', e não é verdade, poís começa com 'You'

// mesmo sendo a mesma palavra, para as linguagens não é, isso ocorre por causa do caseSensitive, que difere letras minúsculas de maiúsculas, portanto 'pablo' é diferente de 'Pablo'

Console.WriteLine(songLyrics.EndsWith("hello"));
// o resultado será um bool de valor True, pois a variável songLyrics termina com a string 'hello'
