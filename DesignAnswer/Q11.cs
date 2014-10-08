            while (true)
            {
                Console.WriteLine("请输入a,b,c三个数:");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                double c = Convert.ToInt32(Console.ReadLine());
                double d = b * b - 4 * a * c;
                double x1 = (Math.Sqrt(d) - b) / (2 * a);
                double x2 = (-b - (Math.Sqrt(d))) / (2 * a);
                if (b * b - 4 * a * c < 0)
                {
                    Console.WriteLine("该方程没有根");
                }
                else if (x1==x2)
                {
                    Console.WriteLine("该方程的根是：x1=x2={0}", x1);
                }
                else
                    Console.WriteLine("该方程的根是：x1={0},x2={1}", x1, x2);
            }