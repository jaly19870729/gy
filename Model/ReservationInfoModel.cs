using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 预定信息
	/// </summary>
	[Serializable]
	public partial class ReservationInfoModel
	{
		public ReservationInfoModel()
		{}
		#region Model
		private int _id;
		private string _reservationnum;
		private string _typename;
		private string _position;
		private string _times;
		private string _money;
		private string _name;
		private string _peoples;
		private string _phone;
		private string _priceamount;
		private string _paymentamount;
		private string _changeamount;
		private string _addtime;
		private string _addusername;
		private string _des;
		private string _paytype;
		private string _rstate;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 消费单号
		/// </summary>
		public string ReservationNum
		{
			set{ _reservationnum=value;}
			get{return _reservationnum;}
		}
		/// <summary>
		/// 消费类型
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 位置
		/// </summary>
		public string Position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 时间数
		/// </summary>
		public string Times
		{
			set{ _times=value;}
			get{return _times;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 预定人姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 人数
		/// </summary>
		public string Peoples
		{
			set{ _peoples=value;}
			get{return _peoples;}
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
		/// 单价金额
		/// </summary>
		public string PriceAmount
		{
			set{ _priceamount=value;}
			get{return _priceamount;}
		}
		/// <summary>
		/// 支付金额
		/// </summary>
		public string PaymentAmount
		{
			set{ _paymentamount=value;}
			get{return _paymentamount;}
		}
		/// <summary>
		/// 找零金额
		/// </summary>
		public string ChangeAmount
		{
			set{ _changeamount=value;}
			get{return _changeamount;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public string AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 收银员
		/// </summary>
		public string AddUserName
		{
			set{ _addusername=value;}
			get{return _addusername;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Des
		{
			set{ _des=value;}
			get{return _des;}
		}
		/// <summary>
		/// 支付类型
		/// </summary>
		public string PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public string RState
		{
			set{ _rstate=value;}
			get{return _rstate;}
		}
		#endregion Model

	}
}

