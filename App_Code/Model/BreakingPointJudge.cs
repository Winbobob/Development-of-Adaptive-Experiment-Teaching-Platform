using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// BreakingPointJudge:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BreakingPointJudge
	{
		public BreakingPointJudge()
		{}
        public BreakingPointJudge(string stuId, string learningLevel, DateTime creatTime, int j1, string ja1, int j2, string ja2, int j3, string ja3, int j4, string ja4)
        {
            this._stuid = stuId;
            this._learninglevel = learningLevel;
            this._createtime = creatTime;
            this._j1 = j1;
            this._ja1 = ja1;
            this._j2 = j2;
            this._ja2 = ja2;
            this._j3 = j3;
            this._ja3 = ja3;
            this._j4 = j4;
            this._ja4 = ja4;
        }
		#region Model
		private string _stuid;
		private string _learninglevel;
		private DateTime _createtime;
		private int _j1;
		private string _ja1;
		private int _j2;
		private string _ja2;
		private int _j3;
		private string _ja3;
		private int _j4;
		private string _ja4;
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
		public int j1
		{
			set{ _j1=value;}
			get{return _j1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ja1
		{
			set{ _ja1=value;}
			get{return _ja1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int j2
		{
			set{ _j2=value;}
			get{return _j2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ja2
		{
			set{ _ja2=value;}
			get{return _ja2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int j3
		{
			set{ _j3=value;}
			get{return _j3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ja3
		{
			set{ _ja3=value;}
			get{return _ja3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int j4
		{
			set{ _j4=value;}
			get{return _j4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ja4
		{
			set{ _ja4=value;}
			get{return _ja4;}
		}
		/// <summary>
		/// 
		/// </summary>
		#endregion Model

	}
}

