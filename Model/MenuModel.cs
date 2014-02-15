using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// MenuModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MenuModel
	{
		public MenuModel()
		{}
		#region Model
		private int _rolemenuid;
		private int? _roleid;
		private int? _rolemenubigfunctionid;
		private int? _rolemenufunctionid;
		private int? _isadd;
		private int? _isdelete;
		private int? _ismodify;
		private int? _islist;
		private int? _isspecial;
		/// <summary>
		/// 
		/// </summary>
		public int RoleMenuId
		{
			set{ _rolemenuid=value;}
			get{return _rolemenuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleMenuBigFunctionId
		{
			set{ _rolemenubigfunctionid=value;}
			get{return _rolemenubigfunctionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleMenuFunctionId
		{
			set{ _rolemenufunctionid=value;}
			get{return _rolemenufunctionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsAdd
		{
			set{ _isadd=value;}
			get{return _isadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsModify
		{
			set{ _ismodify=value;}
			get{return _ismodify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsList
		{
			set{ _islist=value;}
			get{return _islist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsSpecial
		{
			set{ _isspecial=value;}
			get{return _isspecial;}
		}
		#endregion Model

	}
}

