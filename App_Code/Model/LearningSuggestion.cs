using System;
namespace SelfAdaptivePlatform.Model
{

	/// <summary>
	/// LearningSuggestion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LearningSuggestion
	{
		public LearningSuggestion()
		{}
		#region Model
		private int _sugid;
		private string _sugname;
		private string _txtlearning;
		private string _piclearning;
		private string _catlearning;
		private string _vdolearning;
		/// <summary>
		/// 
		/// </summary>
		public int sugId
		{
			set{ _sugid=value;}
			get{return _sugid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sugName
		{
			set{ _sugname=value;}
			get{return _sugname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string txtLearning
		{
			set{ _txtlearning=value;}
			get{return _txtlearning;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picLearning
		{
			set{ _piclearning=value;}
			get{return _piclearning;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string catLearning
		{
			set{ _catlearning=value;}
			get{return _catlearning;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vdoLearning
		{
			set{ _vdolearning=value;}
			get{return _vdolearning;}
		}
		#endregion Model

	}
}

