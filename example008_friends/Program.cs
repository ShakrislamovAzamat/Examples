int count = 0, distance = 10000, time = 0,
    fFSpeed = 1, sFSpeed = 2,
    dogSpeed = 5, friend = 2;
while (distance > 10)
{
    if (friend == 1)
        {
        friend = 2;
        time = distance / (fFSpeed + dogSpeed);
        }
    else
        {
        friend = 1;
        time = distance / (sFSpeed + dogSpeed);
        }
    distance = distance - (fFSpeed + sFSpeed) * time;
    count++;
}
Console.WriteLine($"Собака пробежит {count} раз");
