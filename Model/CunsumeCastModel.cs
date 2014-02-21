using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 单次消费表
	/// </summary>
	[Serializable]
	public partial class CunsumeCastModel
	{
		public CunsumeCastModel()
		{}
		#region Model
		private int _id;
		private int _memberid;
		private string _custype;
		private DateTime _transactdate;
		private decimal _priceamount;
		private int _count;
		private decimal _payableamount;
		private decimal _paymentamount;
		private decimal _changeamount;
		private DateTime _createtime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 会员ID
		/// </summary>
		public int MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 消费类型
		/// </summary>
		public string CusType
		{
			set{ _custype=value;}
			get{return _custype;}
		}
		/// <summary>
		/// 办理时间
		/// </summary>
		public DateTime TransactDate
		{
			set{ _transactdate=value;}
			get{return _transactdate;}
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
		/// 消费人数
		/// </summary>
		public int Count
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 应付金额
		/// </summary>
		public decimal PayableAmount
		{
			set{ _payableamount=value;}
			get{return _payableamount;}
		}
		/// <summary>
		/// 交费金额
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
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

