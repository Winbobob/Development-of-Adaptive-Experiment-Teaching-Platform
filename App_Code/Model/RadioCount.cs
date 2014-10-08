using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// RadioLow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RadioCount
	{
        public RadioCount()
		{}
		#region Model
		private int _num;
		/// <summary>
		/// 
		/// </summary>
		public int Num
		{
            set { _num = value; }
            get { return _num; }
		}
		#endregion Model

	}
}

