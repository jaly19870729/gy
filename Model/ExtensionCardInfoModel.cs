using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 延期信息表
	/// </summary>
	[Serializable]
	public partial class ExtensionCardInfoModel
	{
		public ExtensionCardInfoModel()
		{}
		#region Model
		private int _id;
		private int _memberid;
		private DateTime _extensionstarttm;
		private DateTime _extensionendtm;
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
		/// 
		/// </summary>
		public int MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ExtensionStartTm
		{
			set{ _extensionstarttm=value;}
			get{return _extensionstarttm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ExtensionEndTm
		{
			set{ _extensionendtm=value;}
			get{return _extensionendtm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

