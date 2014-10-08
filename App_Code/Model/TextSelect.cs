using System;
namespace SelfAdaptivePlatform.Model.SelfAdaptivePlatform
{
	/// <summary>
	/// TextSelect:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TextSelect
	{
		public TextSelect()
		{}
		#region Model
		private int _txtid;
		private int? _radionum;
		private int? _radioscore;
		private int? _judgenum;
		private int? _judgescore;
		private int? _blanknum;
		private int? _blankscore;
		private int? _designnum;
		private int? _designscore;
		private int _num;
		private int _score;
		/// <summary>
		/// 
		/// </summary>
		public int txtId
		{
			set{ _txtid=value;}
			get{return _txtid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? radioNum
		{
			set{ _radionum=value;}
			get{return _radionum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? radioScore
		{
			set{ _radioscore=value;}
			get{return _radioscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? judgeNum
		{
			set{ _judgenum=value;}
			get{return _judgenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? judgeScore
		{
			set{ _judgescore=value;}
			get{return _judgescore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blankNum
		{
			set{ _blanknum=value;}
			get{return _blanknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? blankScore
		{
			set{ _blankscore=value;}
			get{return _blankscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? designNum
		{
			set{ _designnum=value;}
			get{return _designnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? designScore
		{
			set{ _designscore=value;}
			get{return _designscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model

	}
}

