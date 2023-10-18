// Uma variável é um símbolo que você pode usar para executar o mesmo código com valores diferentes
// em C# existem algumas formas de declarar uma variável:

string aFriend = "Bill";
// string é o tipo de variável, que se refere á uma cadeia de caracteres, que nesse caso juntos se tornam um nome: 'Bill'
// já aFriend é o nome dessa variável, a qual é atribuído o valor 'Bill'


// é possível atribuir outros valores á variável, dessa forma:
aFriend = "Anna"; // não se pode declarar o tipo da variável, quando for atribuir outro valor a mesma

Console.WriteLine("hello" + " " + aFriend);
// é possível fazer uma concatenação entre a variável de tipo string mais uma string, através do método Writeline, para separar a palavra da variável pode se concatenar outra string, que nesse caso é apenas um espaço, o resultado é 'hello Bill

Console.WriteLine($"Hello {aFriend}");
// outra forma de mostrar a mensagem em uma string, assim não há necessidade de concatenar



 // OBS: sempre coloque ponto e vírgula no final