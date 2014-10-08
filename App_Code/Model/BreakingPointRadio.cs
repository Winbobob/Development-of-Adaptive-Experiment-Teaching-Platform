using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// BreakingPointRadio:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BreakingPointRadio
	{
		public BreakingPointRadio()
		{}
        public BreakingPointRadio(string stuId, string learningLevel, DateTime creatTime, int r1, string ra1, int r2, string ra2, int r3, string ra3, int r4, string ra4, int r5, string ra5)
        {
            this._stuid = stuId;
            this._learninglevel = learningLevel;
            this._createtime = creatTime; 
            this._r1= r1;
            this._ra1 = ra1;
            this._r2 = r2;
            this._ra2 = ra2;
            this._r3 = r3;
            this._ra3 = ra3;
            this._r4 = r4;
            this._ra4 = ra4;
            this._r5 = r5;
            this._ra5 = ra5;
        }
        public BreakingPointRadio(string stuId)
        {
            this._stuid = stuId;
        }
		#region Model
		private string _stuid;
		private string _learninglevel;
		private DateTime _createtime;
		private int _r1;
		private string _ra1;
		private int _r2;
		private string _ra2;
		private int _r3;
		private string _ra3;
		private int _r4;
		private string _ra4;
		private int _r5;
		private string _ra5;
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
		public int r1
		{
			set{ _r1=value;}
			get{return _r1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ra1
		{
			set{ _ra1=value;}
			get{return _ra1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int r2
		{
			set{ _r2=value;}
			get{return _r2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ra2
		{
			set{ _ra2=value;}
			get{return _ra2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int r3
		{
			set{ _r3=value;}
			get{return _r3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ra3
		{
			set{ _ra3=value;}
			get{return _ra3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int r4
		{
			set{ _r4=value;}
			get{return _r4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ra4
		{
			set{ _ra4=value;}
			get{return _ra4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int r5
		{
			set{ _r5=value;}
			get{return _r5;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string ra5
        {
            set { _ra5 = value; }
            get { return _ra5; }
        }
		#endregion Model

	}
}

