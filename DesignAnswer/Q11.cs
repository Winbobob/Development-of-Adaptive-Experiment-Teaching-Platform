            while (true)
            {
                Console.WriteLine("������a,b,c������:");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                double c = Convert.ToInt32(Console.ReadLine());
                double d = b * b - 4 * a * c;
                double x1 = (Math.Sqrt(d) - b) / (2 * a);
                double x2 = (-b - (Math.Sqrt(d))) / (2 * a);
                if (b * b - 4 * a * c < 0)
                {
                    Console.WriteLine("�÷���û�и�");
                }
                else if (x1==x2)
                {
                    Console.WriteLine("�÷��̵ĸ��ǣ�x1=x2={0}", x1);
                }
                else
                    Console.WriteLine("�÷��̵ĸ��ǣ�x1={0},x2={1}", x1, x2);
            }