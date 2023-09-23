/* 
5
20
100
100 
100
20 
*/

int n = int.Parse(Console.ReadLine());
int volume = 0;

for (int i = 0; i < n; i++)
{
    int addedLiters = int.Parse(Console.ReadLine());
    volume += addedLiters;

    if (volume > 255)
    {
        volume -= addedLiters;
        Console.WriteLine("Insufficient capacity!");
    }
}

Console.WriteLine(volume);