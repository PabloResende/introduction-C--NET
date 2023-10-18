// Suponha que suas cadeias de caracteres têm espaços à esquerda ou à direita que você não deseja exibir. Você deseja cortar os espaços das cadeias de caracteres. O método Trim e os métodos relacionados TrimStart e TrimEnd fazem isso funcionar. Você pode apenas usar esses métodos para remover espaços à esquerda e à direita


string greeting = "    hello world!     ";
Console.WriteLine($"[{greeting}]"); 
// [    hello world!     ]

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
// [hello world!     ]

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
// [    hello world!]

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
// [hello world!]

// os [] servem para visualizar melhor a ação do método trim
// resumindo trim remove espaços, seja do ínicio, fim ou ambos

// fonte: https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=4