using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// JudgeLow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JudgeLow
	{
		public JudgeLow()
		{}
		#region Model
		private int _id;
		private string _question;
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

