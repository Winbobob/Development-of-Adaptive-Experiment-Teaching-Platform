	class Point
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public int Cal(int x1,int y1,int x2,int y2)
        {
            int z = Convert.ToInt32(Math.Sqrt(Convert.ToInt32((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))));
            return z;
        }
	}
	class Program
	{
        static void Main(string[] args)
        {
			Console.Write("第一个点的横坐标：");
            int x1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("第一个点的纵坐标：");
            int y1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("第二个点的横坐标：");
            int x2 =Convert.ToInt32(Console.ReadLine());
            Console.Write("第二个点的纵坐标：");
            int y2 =Convert.ToInt32(Console.ReadLine());
            
			Point poi = new Point();
			Console.WriteLine("这两个点之间的距离是:{0}",poi.Cal(x1, y1, x2, y2));
			
         }        
    }