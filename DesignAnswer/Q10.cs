bool b = true;
while (b)
{
    Console.Write("�����ַ�����");
    string str = Convert.ToString(Console.ReadLine());
    if (str.Contains("."))
    {
        Console.WriteLine(str.Replace('.','*'));//�˴��õ����滻��ֱ�ӽ���.���滻Ϊ'*';
    }
    else
        Console.WriteLine(str);
}