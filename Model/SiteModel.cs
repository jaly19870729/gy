using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// SiteModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SiteModel
	{
		public SiteModel()
		{}
		#region Model
		private int _id;
		private string _timenow;
		private string _peoples;
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
		public string TimeNow
		{
			set{ _timenow=value;}
			get{return _timenow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Peoples
		{
			set{ _peoples=value;}
			get{return _peoples;}
		}
		#endregion Model

	}
}

