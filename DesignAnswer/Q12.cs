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
            Console.Write("�������¹��ʣ�");
            int monthmoney = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("�깤��Ϊ��{0}",employ.Getyearmoney(monthmoney));
        }
    }