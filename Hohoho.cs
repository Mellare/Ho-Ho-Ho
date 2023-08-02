int x = int.Parse(Console.ReadLine());

char a = 'H';
char b = 'o';

string charConcat = string.Concat(a, b);

for(int i = 2; i <= x; i++)
{
    Console.Write(charConcat.TrimEnd() + " ");
}
Console.WriteLine(charConcat + "!");
