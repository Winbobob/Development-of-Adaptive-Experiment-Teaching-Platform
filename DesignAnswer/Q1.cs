Console.WriteLine("������һ����ݣ�");
int i = Convert.ToInt32(Console.ReadLine());
bool judge = DateTime.IsLeapYear(i);
if (judge == true)
{
	Console.WriteLine("����Ϊ����");
}
else
{
	Console.WriteLine("����Ϊƽ��");
}