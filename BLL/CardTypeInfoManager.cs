using System;
using System.Data;
using System.Collections.Generic;
using Gymnasium_APP.Model;
using DALFactory;
using IDAL;
namespace Gymnasium_APP.BLL
{
	/// <summary>
	/// 卡类型
	/// </summary>
	public partial class CardTypeInfoManager
    {
        private static CreatAFactory aFactory = CreatAFactory.CreateFactory(); // 放回实体工厂；
        private ICardTypeInfoDal dal = aFactory.CreateCardTypeInfoDal();　// 返回实体产品;
		public CardTypeInfoManager()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CardTypeID)
		{
			return dal.Exists(CardTypeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Gymnasium_APP.Model.CardTypeInfoModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Gymnasium_APP.Model.CardTypeInfoModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CardTypeID)
		{
			
			return dal.Delete(CardTypeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CardTypeIDlist )
		{
			return dal.DeleteList(CardTypeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Gymnasium_APP.Model.CardTypeInfoModel GetModel(int CardTypeID)
		{
			
			return dal.GetModel(CardTypeID);
		}

		

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Gymnasium_APP.Model.CardTypeInfoModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Gymnasium_APP.Model.CardTypeInfoModel> DataTableToList(DataTable dt)
		{
			List<Gymnasium_APP.Model.CardTypeInfoModel> modelList = new List<Gymnasium_APP.Model.CardTypeInfoModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Gymnasium_APP.Model.CardTypeInfoModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

