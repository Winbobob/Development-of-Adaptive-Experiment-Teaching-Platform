	Console.WriteLine("�������1������");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("�������2������");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("�������3������");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(Math.Max(a, b), c);
    int min = Math.Min(Math.Min(a, b), c);
    Console.WriteLine("max={0},min={1}",max,min);