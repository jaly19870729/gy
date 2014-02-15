using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// Sys_FunctionBigModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_FunctionBigModel
	{
		public Sys_FunctionBigModel()
		{}
		#region Model
		private int _functionbigid;
		private string _functionbigname;
		private int? _functionchildcount;
		private int? _functionsortid;
		/// <summary>
		/// 
		/// </summary>
		public int FunctionBigId
		{
			set{ _functionbigid=value;}
			get{return _functionbigid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FunctionBigName
		{
			set{ _functionbigname=value;}
			get{return _functionbigname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FunctionChildCount
		{
			set{ _functionchildcount=value;}
			get{return _functionchildcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FunctionSortId
		{
			set{ _functionsortid=value;}
			get{return _functionsortid;}
		}
		#endregion Model

	}
}

