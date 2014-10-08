using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// BreakingPointDesign:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BreakingPointDesign
	{
		public BreakingPointDesign()
		{}
        public BreakingPointDesign(string stuId, string learningLevel, DateTime creatTime, int d1)
        {
            this._stuid = stuId;
            this._learninglevel = learningLevel;
            this._createtime = creatTime;
            this._d1 = d1;
        }
		#region Model
		private string _stuid;
		private string _learninglevel;
		private DateTime _createtime;
		private int _d1;
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
		public int d1
		{
			set{ _d1=value;}
			get{return _d1;}
		}
		#endregion Model

	}
}

