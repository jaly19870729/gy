using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// SwipingInfoModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SwipingInfoModel
	{
		public SwipingInfoModel()
		{}
		#region Model
		private int _id;
		private string _swipingtype;
		private string _cardid;
		private string _cardtype;
		private string _swipingpeople;
		private string _addtime;
		private string _addusername;
		private string _name;
		private string _desc;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 消费类型
		/// </summary>
		public string SwipingType
		{
			set{ _swipingtype=value;}
			get{return _swipingtype;}
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
		/// 卡类别
		/// </summary>
		public string CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 进场人数
		/// </summary>
		public string SwipingPeople
		{
			set{ _swipingpeople=value;}
			get{return _swipingpeople;}
		}
		/// <summary>
		/// 时期
		/// </summary>
		public string AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 操作员
		/// </summary>
		public string AddUserName
		{
			set{ _addusername=value;}
			get{return _addusername;}
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
		/// 
		/// </summary>
		public string Desc
		{
			set{ _desc=value;}
			get{return _desc;}
		}
		#endregion Model

	}
}

