// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("para executar esse 'Hello, World!', é preciso executar o arquivo 'hello_world.csproj");

// o que está por trás dessa linha?

using System;

class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}
// O programa "Hello, World" começa com uma diretiva using que faz referência ao namespace System. Namespaces fornecem um meio hierárquico de organizar bibliotecas e programas em C#. Os namespaces contêm tipos e outros namespaces — por exemplo, o namespace System contém uma quantidade de tipos, como a classe Console referenciada no programa e diversos outros namespaces, como IO e Collections. A diretiva using que faz referência a um determinado namespace permite o uso não qualificado dos tipos que são membros desse namespace. Devido à diretiva using, o programa pode usar Console.WriteLine como um atalho para System.Console.WriteLine.

// A classe Hello declarada pelo programa "Hello, World" tem um único membro, o método chamado Main. O método Main é declarado com o modificador static. Embora os métodos de instância possam fazer referência a uma determinada instância de objeto delimitador usando a palavra-chave this, métodos estáticos operam sem referência a um objeto específico. Por convenção, um método estático denominado Main serve como ponto de entrada de um programa C#.

// A saída do programa é produzida pelo método WriteLine da classe Console no namespace System. Essa classe é fornecida pelas bibliotecas de classe padrão, que, por padrão, são referenciadas automaticamente pelo compilador.