// O método Replace procura uma subcadeia de caracteres e a substitui por outro texto. O método Replace utiliza dois parâmetros. Essas são as cadeias de caracteres entre parênteses. A primeira cadeia de caracteres é o texto a ser pesquisado. A segunda cadeia de caracteres é o texto para substituição

string sayHello = "hello world!"; // aqui é a frase original
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("hello", "greetings"); // como a explicação acima descreveu, 'hello' é o primeiro parâmetro e 'greetings' o segundo que irá substituir o primeiro
Console.WriteLine(sayHello);

// resultado:
// hello greetings
