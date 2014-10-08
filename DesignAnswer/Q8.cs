while (true)
{
    Console.WriteLine("ÊäÈëÕûÊı:");
    int a = Convert.ToInt32(Console.ReadLine());
    int length = a.ToString().Length;
 
    int[] b = new int[length];
 
    for (int i = 0; i <= length - 1; i++)
    {
        int num = length - i;
        int num1 = Convert.ToInt32(Math.Pow(10, num));
        int num2 = Convert.ToInt32(Math.Pow(10, num - 1));
        int cout1 = a % num1;
        b[i] = cout1 / num2;  
        //Console.Write(b[num - 1]);
    }
}