using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// BlankLow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlankLow
	{
		public BlankLow()
		{}
		#region Model
		private int _id;
		private string _qfront;
		private string _qback;
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
		public string qFront
		{
			set{ _qfront=value;}
			get{return _qfront;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qBack
		{
			set{ _qback=value;}
			get{return _qback;}
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

