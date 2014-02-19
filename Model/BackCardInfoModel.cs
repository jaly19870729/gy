using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// BackCardInfoModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BackCardInfoModel
	{
		public BackCardInfoModel()
		{}
		#region Model
		private int _id;
		private string _cardnumber;
		private string _cardtype;
		private string _name;
		private string _idcardtype;
		private string _idcardnumber;
		private DateTime? _addtime;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private int? _totaldays;
		private int? _leftdays;
		private int? _totaltimes;
		private int? _lefttimes;
		private decimal? _paidamount;
		private decimal? _changeamount;
		private decimal? _patchamount;
		private decimal? _usedamount;
		private DateTime? _createtime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 卡号
		/// </summary>
		public string CardNumber
		{
			set{ _cardnumber=value;}
			get{return _cardnumber;}
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
		/// 姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 证件类型
		/// </summary>
		public string IDCardType
		{
			set{ _idcardtype=value;}
			get{return _idcardtype;}
		}
		/// <summary>
		/// 证件号码
		/// </summary>
		public string IDCardNumber
		{
			set{ _idcardnumber=value;}
			get{return _idcardnumber;}
		}
		/// <summary>
		/// 办理时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 生效时间
		/// </summary>
		public DateTime? StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 失效时间
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 总天数
		/// </summary>
		public int? TotalDays
		{
			set{ _totaldays=value;}
			get{return _totaldays;}
		}
		/// <summary>
		/// 剩余天数
		/// </summary>
		public int? LeftDays
		{
			set{ _leftdays=value;}
			get{return _leftdays;}
		}
		/// <summary>
		/// 总次数
		/// </summary>
		public int? TotalTimes
		{
			set{ _totaltimes=value;}
			get{return _totaltimes;}
		}
		/// <summary>
		/// 剩余次数
		/// </summary>
		public int? LeftTimes
		{
			set{ _lefttimes=value;}
			get{return _lefttimes;}
		}
		/// <summary>
		/// 已交费用
		/// </summary>
		public decimal? PaidAmount
		{
			set{ _paidamount=value;}
			get{return _paidamount;}
		}
		/// <summary>
		/// 退还费用
		/// </summary>
		public decimal? ChangeAmount
		{
			set{ _changeamount=value;}
			get{return _changeamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PatchAmount
		{
			set{ _patchamount=value;}
			get{return _patchamount;}
		}
		/// <summary>
		/// 已用费用
		/// </summary>
		public decimal? UsedAmount
		{
			set{ _usedamount=value;}
			get{return _usedamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

