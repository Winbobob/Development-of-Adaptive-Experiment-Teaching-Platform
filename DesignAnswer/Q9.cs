string url = "www.zjnu.edu.cn";
string[] str = url.Split('.');
Console.WriteLine("{0}\0{1}\0{2}\0{3}",str[0],str[1],str[2],str[3]);