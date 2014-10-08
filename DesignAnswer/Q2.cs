	Console.WriteLine("请输入第1个数：");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("请输入第2个数：");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("请输入第3个数：");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(Math.Max(a, b), c);
    int min = Math.Min(Math.Min(a, b), c);
    Console.WriteLine("max={0},min={1}",max,min);