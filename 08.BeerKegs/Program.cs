string biggestKegModel = "";
decimal MaxKegVol = 0;

int kegsNum = int.Parse(Console.ReadLine());

for (int i = 0; i < kegsNum; i++)
{
    string kegModel = Console.ReadLine();
    decimal kegRadius = decimal.Parse(Console.ReadLine());
    decimal kegHeight = decimal.Parse(Console.ReadLine());

    decimal kegVolume = (decimal)Math.PI * (kegRadius * kegRadius) * kegHeight;

    if (MaxKegVol < kegVolume)
    {
        MaxKegVol = kegVolume;
        biggestKegModel = kegModel;
    }
}

Console.WriteLine(biggestKegModel);