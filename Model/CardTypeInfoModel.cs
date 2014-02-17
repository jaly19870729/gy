using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 卡类型
	/// </summary>
	[Serializable]
	public partial class CardTypeInfoModel
	{
		public CardTypeInfoModel()
		{}
		#region Model
		private int _cardtypeid;
		private string _cardtypename;
		private string _monthsprice;
		private string _months;
		private string _dayprice;
		private string _datetime;
		private string _typename;
		private string _cardcount;
		/// <summary>
		/// 主键
		/// </summary>
		public int CardTypeID
		{
			set{ _cardtypeid=value;}
			get{return _cardtypeid;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string CardTypeName
		{
			set{ _cardtypename=value;}
			get{return _cardtypename;}
		}
		/// <summary>
		/// 总价格
		/// </summary>
		public string MonthsPrice
		{
			set{ _monthsprice=value;}
			get{return _monthsprice;}
		}
		/// <summary>
		/// 时长/月
		/// </summary>
		public string Months
		{
			set{ _months=value;}
			get{return _months;}
		}
		/// <summary>
		/// 单价/日
		/// </summary>
		public string DayPrice
		{
			set{ _dayprice=value;}
			get{return _dayprice;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public string DateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 卡次数
		/// </summary>
		public string CardCount
		{
			set{ _cardcount=value;}
			get{return _cardcount;}
		}
		#endregion Model

	}
}

