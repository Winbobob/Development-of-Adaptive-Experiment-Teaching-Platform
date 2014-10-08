    class Employ
    {
        public int Getyearmoney(int monthmoney)
        {
            return 12 * monthmoney;
        }
	}
	class Program
	{
        static void Main(string[] args)
        {
            Employ employ = new Employ();
            Console.Write("请输入月工资：");
            int monthmoney = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("年工资为：{0}",employ.Getyearmoney(monthmoney));
        }
    }