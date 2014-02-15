using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 会员信息表
	/// </summary>
	[Serializable]
	public partial class MemberInfoModel
	{
		public MemberInfoModel()
		{}
		#region Model
		private int _memberid;
		private string _cardid;
		private string _mail;
		private string _cardtype;
		private string _idcardtype;
		private string _name;
		private string _idcard;
		private string _sex;
		private string _starttime;
		private string _birthday;
		private string _endtime;
		private string _phone;
		private string _count;
		private string _unit;
		private string _addtime;
		private string _addusername;
		private byte[] _photo;
		private string _infotype;
		/// <summary>
		/// 会员ID
		/// </summary>
		public int MemberID
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 会员卡号
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 电子邮箱
		/// </summary>
		public string Mail
		{
			set{ _mail=value;}
			get{return _mail;}
		}
		/// <summary>
		/// 卡类别
		/// </summary>
		public string CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 身份证类型
		/// </summary>
		public string IDCardType
		{
			set{ _idcardtype=value;}
			get{return _idcardtype;}
		}
		/// <summary>
		/// 会员姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 证件号码
		/// </summary>
		public string IDCard
		{
			set{ _idcard=value;}
			get{return _idcard;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 生效时间
		/// </summary>
		public string StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 生日
		/// </summary>
		public string Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 失效时间
		/// </summary>
		public string EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 剩余次数
		/// </summary>
		public string Count
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 办理时间
		/// </summary>
		public string AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 办理人
		/// </summary>
		public string AddUserName
		{
			set{ _addusername=value;}
			get{return _addusername;}
		}
		/// <summary>
		/// 图像
		/// </summary>
		public byte[] Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InfoType
		{
			set{ _infotype=value;}
			get{return _infotype;}
		}
		#endregion Model

	}
}

