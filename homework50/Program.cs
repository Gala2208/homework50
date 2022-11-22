try
{
    int[,] arr = new int[3, 3];
    Random rnd = new Random();

    for (int i = 0; i < 3; i++)
    {
        for (int k = 0; k < 3; k++)
        {
            arr[i, k] = rnd.Next(1, 100);
        }
    }

    int m = Convert.ToInt32(Console.ReadLine()),
        n = Convert.ToInt32(Console.ReadLine());


    if (m > 2 || n > 2 || n < 0 || m < 0) {
        Console.WriteLine("[{0},{1}] - такого элемента нет", m, n);
    }
    else { Console.WriteLine(arr[m, n]); }
}
catch (Exception err)
{
    Console.WriteLine(err);
}