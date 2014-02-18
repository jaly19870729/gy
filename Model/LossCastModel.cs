using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 挂失费用表
	/// </summary>
	[Serializable]
	public partial class LossCastModel
	{
		public LossCastModel()
		{}
		#region Model
		private int _id;
		private int _losscardid;
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
		public int LossCardId
		{
			set{ _losscardid=value;}
			get{return _losscardid;}
		}
		/// <summary>
		/// 应交费用
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

