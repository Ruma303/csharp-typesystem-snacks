//Snack 1
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

//Snack 4
/*
int sum = 0;
for(int i = 2; i < 11; i++) sum += i;
Console.WriteLine($"La somma finale é {sum}");
Console.WriteLine($"La media é {sum / 2}");
*/

//Snack 5
/*
Console.WriteLine("Scrivi un numero: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{(num % 2 == 0 ? $"Numero pari: {num}" : $"Numero successivo: {num+1}")}");
*/

//Snack 6
/*
string[] invitati = new string[] {"Tizio", "Caio", "Sempronio", "Mevio"};
string[] clonedArray = invitati.Select(s => s.ToLower()).ToArray();
Console.WriteLine("Inserire il nome prego: ");
string nome  = Console.ReadLine().ToLower() ?? "";
Console.WriteLine($"{(clonedArray.Contains(nome) ? "Prego, si accomdi."
    : "Lei non é tra gli invitati!")}");
*/

//Snack 7
/*
int[] numbers = new int[6];
foreach (int n in numbers)
{
    Console.WriteLine("Scrivi un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num % 2 != 0) numbers[n] = num;
}
*/

//Snack 8
/*
int[] numbers = new int[10] {1,2,3,4,5,6,7,8,9,10};
int sum = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0) sum += number;
}
Console.WriteLine("La somma di tutti i numeri pari nell'array é: " + sum);
*/

//Snack 9
/*
int[] array = new int[100];
int i = 0;
int sum = 0;
while (sum < 50)
{
    Console.WriteLine("Inserisci un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hai inserito il numero: {num}");
    array[i] = num;
    i++;
    sum += num;
}

Console.WriteLine($"Hai raggiunto una somma {sum}");
Console.WriteLine("Ecco gli elementi dell'array: ");

for (int j = 0; j < i; j++)
{
    Console.Write($"{array[j]} ");
}
*/

//Snack 10
/*
Console.WriteLine("Inserisci un numero: ");
int N = Convert.ToInt32(Console.ReadLine());
var random = new Random();

for (int i = 0; i < N; i++)
{
    var nums = new int[10];
    for (int j = 0; j < 10; j++)
        nums[j] = random.Next(1, 100);

    foreach (var num in nums)
        Console.Write($"{num}; ");
}
*/

//Snack 11
//Console.WriteLine("Inserisci un numero: ");
//string str1 = Console.ReadLine() ?? "";