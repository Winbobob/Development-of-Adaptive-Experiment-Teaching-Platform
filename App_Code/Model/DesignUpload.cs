using System;
namespace SelfAdaptivePlatform.Model
{
	/// <summary>
	/// DesignMid:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
  public partial class DesignUpload
  {
	public DesignUpload()
	{
	}
    private string _stuid;
    private string _learninglevel;
    private DateTime _createtime;
    private string _urlupload;
    private string _filename;
    public string stuId
    {
        set { _stuid = value; }
        get { return _stuid; }
    }
    public string learningLevel
    {
        set { _learninglevel = value; }
        get { return _learninglevel; }
    }
    public DateTime createTime
    {
        set { _createtime = value; }
        get { return _createtime; }
    }

    public string urlUpload
    {
        set { _urlupload = value; }
        get { return _urlupload; }
    }
    public string fileName
    {
        set { _filename = value; }
        get { return _filename; }
    }
  }
}