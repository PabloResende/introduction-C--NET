// A outra parte de uma operação de pesquisa e substituição serve para localizar texto em uma cadeia de caracteres. Você pode usar o método Contains para pesquisar. Indica se uma cadeia de caracteres contém uma subcadeia de caracteres dentro dela

string songLyrics = "You say goodbye, and i say hello";
Console.WriteLine(songLyrics.Contains("goodbye")); // basicamente é como se você perguntasse, 'têm a palavra goodbye na string songLyrics?' e o programa te responde com um bool (True ou False)
Console.WriteLine(songLyrics.Contains("greetings")); // não têm essa string na variável songLyrics então o resultado será false

// OBS: um booliano(bool) armazena um valor true ou false. Quando exibidos como saída de texto, eles estão em letras maiúsculas: True e False

// fonte: https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=5
