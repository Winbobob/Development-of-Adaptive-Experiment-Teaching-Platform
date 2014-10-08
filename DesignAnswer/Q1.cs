Console.WriteLine("请输入一个年份：");
int i = Convert.ToInt32(Console.ReadLine());
bool judge = DateTime.IsLeapYear(i);
if (judge == true)
{
	Console.WriteLine("该年为闰年");
}
else
{
	Console.WriteLine("该年为平年");
}