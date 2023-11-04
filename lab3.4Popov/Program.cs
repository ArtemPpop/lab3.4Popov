//высокий 6
Console.WriteLine("|    x   |   y    |");
for (double x = -3; x <= 2.5; x += 1.1) 
{ 
    for (int k = 1; k <= 8; k++)
    {
        {
            double y;
            if (x <= 0) y=Math.Tan(Math.Pow(Math.PI,Math.PI));
            else
            {
                double kFact = 1;
                for (int i = 1; i <= k; i++)
                {
                    kFact *= i;
                }
                y = Math.Pow(-1, k) * Math.Pow(x, k) / kFact;
            }
            Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
        }
    }
}