using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// RadioLow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RadioLow
	{
		public RadioLow()
		{}
		#region Model
		private int _id;
		private string _question;
		private string _a;
		private string _b;
		private string _c;
		private string _d;
		private string _answer;
		private string _explain;
		private int _suggestion;
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
		public string A
		{
			set{ _a=value;}
			get{return _a;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string B
		{
			set{ _b=value;}
			get{return _b;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C
		{
			set{ _c=value;}
			get{return _c;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string D
		{
			set{ _d=value;}
			get{return _d;}
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
		public string explain
		{
			set{ _explain=value;}
			get{return _explain;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int suggestion
		{
			set{ _suggestion=value;}
			get{return _suggestion;}
		}
		#endregion Model

	}
}

