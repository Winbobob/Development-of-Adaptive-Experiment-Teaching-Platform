	class Circle
    {
        public double sq(double r)
        {
            return Math.PI * r * r;
        }
        public double zc(double r)
        {
            return 2 * Math.PI * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            Console.WriteLine("sq={0},zc={1}",cir.sq(3),cir.zc(3));
        }
    }