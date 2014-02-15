using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// Sys_FunctionSmallModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_FunctionSmallModel
	{
		public Sys_FunctionSmallModel()
		{}
		#region Model
		private int _functionsmallid;
		private int? _functionbigid;
		private string _functionsmallname;
		private string _functionlinktooltip;
		private string _functionurl;
		private int? _sortid;
		private int? _isblank;
		private int? _isshow;
		/// <summary>
		/// 
		/// </summary>
		public int FunctionSmallId
		{
			set{ _functionsmallid=value;}
			get{return _functionsmallid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FunctionBigId
		{
			set{ _functionbigid=value;}
			get{return _functionbigid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunctionSmallName
		{
			set{ _functionsmallname=value;}
			get{return _functionsmallname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunctionLinkToolTip
		{
			set{ _functionlinktooltip=value;}
			get{return _functionlinktooltip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunctionUrl
		{
			set{ _functionurl=value;}
			get{return _functionurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SortId
		{
			set{ _sortid=value;}
			get{return _sortid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsBlank
		{
			set{ _isblank=value;}
			get{return _isblank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		#endregion Model

	}
}

