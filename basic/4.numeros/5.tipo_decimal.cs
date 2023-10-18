// Ainda há outro tipo: o tipo decimal. O tipo decimal tem um intervalo menor, mas precisão maior do que double. Vamos dar uma olhada:

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

// Observe que o cálculo usando o tipo decimal tem mais dígitos à direita da vírgula decimal. O sufixo M nos números é o modo como você indica que uma constante deve usar o tipo decimal. Caso contrário, o compilador assumirá o tipo double:

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);