using System;
namespace Gymnasium_APP.Model
{
	/// <summary>
	/// 挂失信息表
	/// </summary>
	[Serializable]
	public partial class LossCardModel
	{
		public LossCardModel()
		{}
		#region Model
		private int _id;
		private int _memberid;
		private string _patchcardno;
		private DateTime _patchtime;
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
		/// 会员ID
		/// </summary>
		public int MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 领补卡号
		/// </summary>
		public string PatchCardNo
		{
			set{ _patchcardno=value;}
			get{return _patchcardno;}
		}
		/// <summary>
		/// 领补时间
		/// </summary>
		public DateTime PatchTime
		{
			set{ _patchtime=value;}
			get{return _patchtime;}
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

