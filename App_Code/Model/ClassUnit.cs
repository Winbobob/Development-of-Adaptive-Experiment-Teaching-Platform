using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// ClassUnit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClassUnit
	{
		public ClassUnit()
		{}
		#region Model
		private string _stuid;
		private int _pretest;
		private int _low;
		private int _mid;
		private int _high;
		private int _designlow;
		private int _designmid;
		private int _designhigh;
		private int _totalscore;
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
		public int pretest
		{
			set{ _pretest=value;}
			get{return _pretest;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int low
		{
			set{ _low=value;}
			get{return _low;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mid
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int high
		{
			set{ _high=value;}
			get{return _high;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int designLow
		{
			set{ _designlow=value;}
			get{return _designlow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int designMid
		{
			set{ _designmid=value;}
			get{return _designmid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int designHigh
		{
			set{ _designhigh=value;}
			get{return _designhigh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int totalScore
		{
			set{ _totalscore=value;}
			get{return _totalscore;}
		}
		#endregion Model

	}
}

