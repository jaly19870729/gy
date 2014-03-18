using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 位置预订信息
	/// </summary>
	[Serializable]
	public partial class PositionReservationInfoModel
	{
		public PositionReservationInfoModel()
		{}
		#region Model
		private int _id;
		private string _positionname;
		private string _dtime;
		private string _name;
		private string _phone;
		private string _state;
		private string _reservationnum;
		private string _typename;
		private string _htime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 场地名称
		/// </summary>
		public string PositionName
		{
			set{ _positionname=value;}
			get{return _positionname;}
		}
		/// <summary>
		/// 预订时间
		/// </summary>
		public string DTime
		{
			set{ _dtime=value;}
			get{return _dtime;}
		}
		/// <summary>
		/// 预订人姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		/// 状态
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 预订单号
		/// </summary>
		public string ReservationNum
		{
			set{ _reservationnum=value;}
			get{return _reservationnum;}
		}
		/// <summary>
		/// 位置类型
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HTime
		{
			set{ _htime=value;}
			get{return _htime;}
		}
		#endregion Model

	}
}

