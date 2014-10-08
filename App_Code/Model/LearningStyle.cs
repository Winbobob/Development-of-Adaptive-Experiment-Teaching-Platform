using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// LearningStyle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LearningStyle
	{
		public LearningStyle()
		{}
		#region Model
		private int _id;
		private string _question;
		private string _a;
		private string _b;
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
		#endregion Model

	}
}

