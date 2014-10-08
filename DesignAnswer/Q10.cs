bool b = true;
while (b)
{
    Console.Write("输入字符串：");
    string str = Convert.ToString(Console.ReadLine());
    if (str.Contains("."))
    {
        Console.WriteLine(str.Replace('.','*'));//此处用到了替换，直接将‘.’替换为'*';
    }
    else
        Console.WriteLine(str);
}