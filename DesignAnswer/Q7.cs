Console.WriteLine("请输入一个邮箱地址：");
bool b = true;
while (b)
{
    string str = Convert.ToString(Console.ReadLine());
    if (str.Contains("@") && str.Contains(".com"))
    {
        Console.WriteLine("Success");
    }
    else
        Console.WriteLine("Error");
}