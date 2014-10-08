using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// TeacherInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TeacherInfo
	{
		public TeacherInfo()
		{}
		#region Model
		private string _teaid;
		private string _teaname;
		private string _password;
		private string _photo;
		private string _gender;
		private string _email;
		private string _telephone;
		/// <summary>
		/// 
		/// </summary>
		public string teaId
		{
			set{ _teaid=value;}
			get{return _teaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string teaName
		{
			set{ _teaname=value;}
			get{return _teaname;}
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
        public TeacherInfo(string teaId, string password)
        {
            this._teaid = teaId;
            this._password = password;
        }
        public TeacherInfo(string teaId, string teaName, string email, string photo, string gender, string telephone)
        {
            this._teaid = teaId;
            this._teaname = teaName;
            this._email = email;
            this._photo = photo;
            this._gender = gender;
            this._telephone = telephone;
        }
	}
}

