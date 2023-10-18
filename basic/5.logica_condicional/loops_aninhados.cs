// Um loop while, do ou for pode ser aninhado dentro de outro loop para criar uma matriz usando a combinação de cada item no loop externo com cada item no loop interno

// Um loop for pode gerar as linhas:

Copiar
for (int row = 1; row < 11; row++)
{
  Console.WriteLine($"The row is {row}");
}

// Outro loop pode gerar as colunas:

Copiar
for (char column = 'a'; column < 'k'; column++)
{
  Console.WriteLine($"The column is {column}");
}

// Você pode aninhar um loop dentro do outro para formar pares:

Copiar
for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}

