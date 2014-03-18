using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// PositionInfoModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PositionInfoModel
	{
		public PositionInfoModel()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _price;
		private string _des;
		private string _typename;
		private string _pstate;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Price
		{
			set{ _price=value;}
			get{return _price;}
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
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PState
		{
			set{ _pstate=value;}
			get{return _pstate;}
		}
		#endregion Model

	}
}

