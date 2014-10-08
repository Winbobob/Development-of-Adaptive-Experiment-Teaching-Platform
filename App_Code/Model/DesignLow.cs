using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// DesignLow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DesignLow
	{
		public DesignLow()
		{}
		#region Model
		private int _id;
		private string _question;
		private string _answer;
		private int _suggestion;
		private string _q1;
		private string _a1;
		private string _b1;
		private string _c1;
		private string _d1;
		private string _answer1;
		private string _q2;
		private string _a2;
		private string _b2;
		private string _c2;
		private string _d2;
		private string _answer2;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string question
		{
			set{ _question=value;}
			get{return _question;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string answer
		{
			set{ _answer=value;}
			get{return _answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int suggestion
		{
			set{ _suggestion=value;}
			get{return _suggestion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Q1
		{
			set{ _q1=value;}
			get{return _q1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string A1
		{
			set{ _a1=value;}
			get{return _a1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string B1
		{
			set{ _b1=value;}
			get{return _b1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C1
		{
			set{ _c1=value;}
			get{return _c1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string D1
		{
			set{ _d1=value;}
			get{return _d1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string answer1
		{
			set{ _answer1=value;}
			get{return _answer1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Q2
		{
			set{ _q2=value;}
			get{return _q2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string A2
		{
			set{ _a2=value;}
			get{return _a2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string B2
		{
			set{ _b2=value;}
			get{return _b2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C2
		{
			set{ _c2=value;}
			get{return _c2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string D2
		{
			set{ _d2=value;}
			get{return _d2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string answer2
		{
			set{ _answer2=value;}
			get{return _answer2;}
		}
		#endregion Model

	}
}

