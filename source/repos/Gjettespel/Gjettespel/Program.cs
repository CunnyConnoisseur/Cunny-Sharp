Random rand = new Random();
int number = rand.Next(0, 100);

int i = 0;

Console.WriteLine("Gjett tallet: ");
int gjett = Convert.ToInt32(Console.ReadLine());
while (gjett != number)
{
    if (gjett < number) { Console.WriteLine("Høgare"); }
    else if (gjett > number) { Console.WriteLine("Lavare"); }

    i++;

    Console.WriteLine("Gjett tallet: ");
    gjett = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Du vant på: " + i + " forsøk!");
