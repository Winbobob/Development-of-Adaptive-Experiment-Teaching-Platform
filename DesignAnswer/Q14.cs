    class Student
    {
        private int stuId;
        private string name;
        private string sex;
        private DateTime birthday;
		
		public DateTime Birthday
		{
			get
			{
				return birthday;
			}
			set
			{
				birthday=value;
			}
		}

		public student(int stuId, string name, string sex, DateTime birthday)
		{
			this.stuId=stuId;
			this.name=name;
			this.sex=sex;
			this.birthday=birthday;
		}
		
        public int GetAge()
        {
            return DateTime.Now.Year - birthday.Year + 1;
        }
		
	}
	
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生编号：");
            int stuId = Convert.ToInt(Console.ReadLine());
			Console.WriteLine("请输入学生姓名：");
            string stuName = Convert.ToString(Console.ReadLine());
			Console.WriteLine("请输入学生性别：");
            string stuSex = Convert.ToString(Console.ReadLine());
			Console.WriteLine("请输入出生日期：");
            datetime stuBirthday = DateTime.Parse((Console.ReadLine());
			
            Student stu = new Student(stuId,stuName,stuSex,stuBirthday);
			Console.WriteLine("学生信息：学号-{0}   姓名-{1}   性别-{2}   年龄-{3}", stu.stuId, stu.name, stu.sex, stu.GetAge());
        }
    }