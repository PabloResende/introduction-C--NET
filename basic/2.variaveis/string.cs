// Uma variável é um símbolo que você pode usar para executar o mesmo código com valores diferentes
// em C# existem algumas formas de declarar uma variável:

string aFriend = "Bill";

// string é o tipo de variável, que se refere á uma cadeia de caracteres, que nesse caso juntos se tornam um nome: 'Bill'
// já aFriend é o nome dessa variável, a qual é atribuído o valor 'Bill'


// é possível atribuir outros valores á variável, dessa forma:
aFriend = "Anna"; // não se pode declarar o tipo da variável, quando for atribuir outro valor a mesma

Console.WriteLine("hello" + " " + aFriend);

// é possível fazer uma concatenação entre a variável de tipo string mais uma string, através do método Writeline, para separar a palavra da variável pode se concatenar outra string, que nesse caso é apenas um espaço, o resultado é 'hello Bill

// Há um modo melhor. Você pode colocar uma variável entre caracteres { e } para informar ao C# para substituir esse texto com o valor da variável.
// Isso é chamado de Interpolação de cadeia de caracteres.
// Se adicionar um $ antes da abertura de aspas da cadeia de caracteres, você poderá incluir variáveis, tais como aFriend, dentro da cadeia de caracteres, entre chaves. Experimente:
Console.WriteLine($"Hello {aFriend}");

// OBS: sempre coloque ponto e vírgula no final
// OBS: priorize fazer os códigos em inglês
