string a = Convert.ToString(Console.ReadLine());
char b = char.Parse(a);
if (b >= 'a' && b <= 'z')
{
	Console.WriteLine(a.ToUpper());
}
else
{
	Console.WriteLine(a.ToLower());
}