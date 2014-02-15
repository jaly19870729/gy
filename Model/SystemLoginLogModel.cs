using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// SystemLoginLogModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SystemLoginLogModel
	{
		public SystemLoginLogModel()
		{}
		#region Model
		private int _loginlogid;
		private int? _userid;
		private string _loginip;
		private string _loginaddress;
		private string _logindate;
		private string _logintype;
		private string _logincont;
		/// <summary>
		/// 
		/// </summary>
		public int LoginLogId
		{
			set{ _loginlogid=value;}
			get{return _loginlogid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginIP
		{
			set{ _loginip=value;}
			get{return _loginip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginAddress
		{
			set{ _loginaddress=value;}
			get{return _loginaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginDate
		{
			set{ _logindate=value;}
			get{return _logindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginType
		{
			set{ _logintype=value;}
			get{return _logintype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginCont
		{
			set{ _logincont=value;}
			get{return _logincont;}
		}
		#endregion Model

	}
}

