using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// RoleModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RoleModel
	{
		public RoleModel()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		private int? _rolemailroom;
		private string _rolesynopsis;
		private string _datatime;
		/// <summary>
		/// 
		/// </summary>
		public int RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleMailRoom
		{
			set{ _rolemailroom=value;}
			get{return _rolemailroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleSynopsis
		{
			set{ _rolesynopsis=value;}
			get{return _rolesynopsis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataTime
		{
			set{ _datatime=value;}
			get{return _datatime;}
		}
		#endregion Model

	}
}

