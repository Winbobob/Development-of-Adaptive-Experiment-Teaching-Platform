using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// StudentInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public  class StudentInfo
	{
		public StudentInfo()
		{}
        public StudentInfo(string stuId)
        {
            this._stuid = stuId;
        }
        public StudentInfo(string stuId, string password)
        {
            this._stuid = stuId;
            this._password = password;
        }
        public StudentInfo(string stuId, string learningStyle, string password)
        {
            this._stuid = stuId;
            this._learningstyle = learningStyle;
            this._password = password;
        }
        public StudentInfo(string stuId, string stuName, string className, string email, string photo, string gender, string telephone,DateTime birthday,string learningStyle)
        {
            this._stuid = stuId;
            this._stuname = stuName;
            this._photo = photo;
            this.gender = gender;
            this._email = email;
            this._classname = className;
            this._telephone = telephone;
            this._birthday = birthday;
            this._learningstyle = learningStyle;
        }
        public StudentInfo(string stuId, string stuName, string password,string learningStyle, string photo, string gender, string className, string telephone, string email, DateTime birthday)
        {
            this._stuid = stuId;
            this._stuname = stuName;
            this._password = password;
            this._learningstyle = learningStyle;
            this._photo = photo;
            this.gender = gender;
            this._classname = className;
            this._telephone = telephone;
            this._email = email;
            this._birthday = birthday;
        }
		#region Model
		private string _stuid;
		private string _stuname;
		private string _password;
		private string _learningstyle;
		private string _classname;
		private string _photo;
		private string _gender;
		private DateTime _birthday;
		private string _email;
		private string _telephone;
		/// <summary>
		/// 
		/// </summary>
		public string stuId
		{
			set{ _stuid=value;}
			get{return _stuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuName
		{
			set{ _stuname=value;}
			get{return _stuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string learningStyle
		{
			set{ _learningstyle=value;}
			get{return _learningstyle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string className
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gender
		{
			set{ _gender=value;}
			get{return _gender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		#endregion Model

	}
}

