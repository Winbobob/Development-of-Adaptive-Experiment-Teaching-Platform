Console.WriteLine("������һ�������ַ��");
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