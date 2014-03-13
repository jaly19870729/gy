using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 售卡交费信息
	/// </summary>
	[Serializable]
	public partial class SellCastModel
	{
		public SellCastModel()
		{}
		#region Model
		private int _castid;
		private string _memberid;
		private decimal _priceamount;
		private decimal _paymentamount;
		private decimal _changeamount;
		private string _createtime;
		private string _addusername;
		private string _addtypename;
		private string _cardid;
		private string _typename;
		private string _peoples;
		private string _des;
		private string _prices;
		private string _custype;
		private string _cusnum;
		private string _cuscount= "1";
		private int? _cusstate;
		/// <summary>
		/// 售卡费用ID
		/// </summary>
		public int CastId
		{
			set{ _castid=value;}
			get{return _castid;}
		}
		/// <summary>
		/// 会员ID
		/// </summary>
		public string MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 单价金额
		/// </summary>
		public decimal PriceAmount
		{
			set{ _priceamount=value;}
			get{return _priceamount;}
		}
		/// <summary>
		/// 缴费金额
		/// </summary>
		public decimal PaymentAmount
		{
			set{ _paymentamount=value;}
			get{return _paymentamount;}
		}
		/// <summary>
		/// 找零金额
		/// </summary>
		public decimal ChangeAmount
		{
			set{ _changeamount=value;}
			get{return _changeamount;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public string CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 收银员姓名
		/// </summary>
		public string AddUserName
		{
			set{ _addusername=value;}
			get{return _addusername;}
		}
		/// <summary>
		/// 添加类型（售卡）
		/// </summary>
		public string AddTypeName
		{
			set{ _addtypename=value;}
			get{return _addtypename;}
		}
		/// <summary>
		/// 卡号
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 消费人数
		/// </summary>
		public string Peoples
		{
			set{ _peoples=value;}
			get{return _peoples;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Des
		{
			set{ _des=value;}
			get{return _des;}
		}
		/// <summary>
		/// 单价金额
		/// </summary>
		public string Prices
		{
			set{ _prices=value;}
			get{return _prices;}
		}
		/// <summary>
		/// 消费类别
		/// </summary>
		public string CusType
		{
			set{ _custype=value;}
			get{return _custype;}
		}
		/// <summary>
		/// 消费编号
		/// </summary>
		public string CusNum
		{
			set{ _cusnum=value;}
			get{return _cusnum;}
		}
		/// <summary>
		/// 项目数
		/// </summary>
		public string CusCount
		{
			set{ _cuscount=value;}
			get{return _cuscount;}
		}
		/// <summary>
		/// 单据状态
		/// </summary>
		public int? CusState
		{
			set{ _cusstate=value;}
			get{return _cusstate;}
		}
		#endregion Model

	}
}

