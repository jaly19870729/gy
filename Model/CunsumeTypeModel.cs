using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// CunsumeTypeModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CunsumeTypeModel
	{
		public CunsumeTypeModel()
		{}
		#region Model
		private int _id;
		private string _custype;
		private decimal _cusprice;
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
		/// 消费类型
		/// </summary>
		public string CusType
		{
			set{ _custype=value;}
			get{return _custype;}
		}
		/// <summary>
		/// 消费单价
		/// </summary>
		public decimal CusPrice
		{
			set{ _cusprice=value;}
			get{return _cusprice;}
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

