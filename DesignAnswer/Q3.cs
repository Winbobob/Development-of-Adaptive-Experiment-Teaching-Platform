	int[] num = new int[3];
    Console.WriteLine("请输入第1个数");
    num[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("请输入第2个数");
    num[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("请输入第3个数");
    num[2]= Convert.ToInt32(Console.ReadLine());
    //int min = num[0] < num[1] ? (num[0] < num[2] ? num[0] : num[2]) : (num[1] < num[2] ? num[1] : num[2]);
    int min =Math.Min(Math.Min(num[0],num[1]),num[2]);
    int max = Math.Max(Math.Max(num[0],num[1]),num[2]);
    for (int i = 0; i < 3; i++)
    {
        if (num[i]<max&&num[i]>min)
        {
            Console.WriteLine("{0},{1},{2}",min,num[i],max);
        }
    }