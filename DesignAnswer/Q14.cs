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
            Console.WriteLine("������ѧ����ţ�");
            int stuId = Convert.ToInt(Console.ReadLine());
			Console.WriteLine("������ѧ��������");
            string stuName = Convert.ToString(Console.ReadLine());
			Console.WriteLine("������ѧ���Ա�");
            string stuSex = Convert.ToString(Console.ReadLine());
			Console.WriteLine("������������ڣ�");
            datetime stuBirthday = DateTime.Parse((Console.ReadLine());
			
            Student stu = new Student(stuId,stuName,stuSex,stuBirthday);
			Console.WriteLine("ѧ����Ϣ��ѧ��-{0}   ����-{1}   �Ա�-{2}   ����-{3}", stu.stuId, stu.name, stu.sex, stu.GetAge());
        }
    }