using System;
namespace SelfAdaptivePlatform.Model.SelfAdaptivePlatform
{
    /// <summary>
    /// WrongTotal:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class WrongTotal
    {
        public WrongTotal()
        { }
        #region Model
        private string _stuid;
        private int _id;
        private string _state;
        private int _num;
        private string _grade;
        private string _type;
        /// <summary>
        /// 
        /// </summary>
        public string stuId
        {
            set { _stuid = value; }
            get { return _stuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string state
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int num
        {
            set { _num = value; }
            get { return _num; }
        }
        public string grade
        {
            set { _grade = value; }
            get { return _grade; }
        }
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model

    }
}


