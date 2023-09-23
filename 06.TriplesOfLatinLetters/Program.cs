int n = int.Parse(Console.ReadLine());

int firstLetter = 97;
int endLetter = firstLetter + n;

for (int i = firstLetter; i < endLetter; i++)
{
    for (int j = firstLetter; j < endLetter; j++)
    {
        for (int k = firstLetter; k < endLetter; k++)
        {
            Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
        }
    }
}