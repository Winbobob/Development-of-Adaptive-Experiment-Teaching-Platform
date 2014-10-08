using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// BreakingPointBlank:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BreakingPointBlank
	{
		public BreakingPointBlank()
		{}
        public BreakingPointBlank(string stuId, string learningLevel, DateTime creatTime, int b1, string ba1, int b2, string ba2, int b3, string ba3)
        {
            this._stuid = stuId;
            this._learninglevel = learningLevel;
            this._createtime = creatTime;
            this._b1 = b1;
            this._ba1 = ba1;
            this._b2 = b2;
            this._ba2 = ba2;
            this._b3 = b3;
            this._ba3 = ba3;
        }
		#region Model
		private string _stuid;
		private string _learninglevel;
		private DateTime _createtime;
		private int _b1;
		private string _ba1;
		private int _b2;
		private string _ba2;
		private int _b3;
		private string _ba3;
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
		public string learningLevel
		{
			set{ _learninglevel=value;}
			get{return _learninglevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime createTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int b1
		{
			set{ _b1=value;}
			get{return _b1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ba1
		{
			set{ _ba1=value;}
			get{return _ba1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int b2
		{
			set{ _b2=value;}
			get{return _b2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ba2
		{
			set{ _ba2=value;}
			get{return _ba2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int b3
		{
			set{ _b3=value;}
			get{return _b3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ba3
		{
			set{ _ba3=value;}
			get{return _ba3;}
		}
		#endregion Model

	}
}

