﻿//Snack 1
/*
Console.WriteLine("Inserisci il primo numero");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci il secondo numero");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b) Console.WriteLine("I numeri sono uguali");
else Console.WriteLine($"Il numero più grande è: {(a > b ? a : b)}");
*/

//Snack 2
/*
Console.WriteLine("Scrivi la prima parola");
string str1 = Console.ReadLine() ?? "";
Console.WriteLine("Scrivi la seconda parola");
string str2 = Console.ReadLine() ?? "";
if (str1.Length == str2.Length)
{
    Console.WriteLine("Le due parole hanno uguale lunghezza");
}
else if (str1.Length > str2.Length)
{
    Console.WriteLine($"Stringa piú lunga: {str1}");
    Console.WriteLine($"Stringa piú corta: {str2}");
}
else
{
    Console.WriteLine($"Stringa piú lunga: {str2}");
    Console.WriteLine($"Stringa piú corta: {str1}");
}
*/

//Snack 3
/*
int sum = 0;
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Scrivi il numero {i+1}");
    int num = Convert.ToInt32(Console.ReadLine());
    sum += num;
}
Console.WriteLine($"La somma finale é {sum}");
*/