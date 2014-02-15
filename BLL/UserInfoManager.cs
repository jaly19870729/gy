using System;
using System.Data;
using System.Collections.Generic;

using Gymnasium_APP.Model;
using DALFactory;
using IDAL;
namespace Gymnasium_APP.BLL
{
	/// <summary>
	/// UserInfoManager
	/// </summary>
	public partial class UserInfoManager
	{
        private static CreatAFactory aFactory = CreatAFactory.CreateFactory(); // 放回实体工厂；
        private  IUserInfoDal iUserInfoDal = aFactory.CreateUserInfoDal();　// 返回实体产品;
		public UserInfoManager()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
            return iUserInfoDal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
            return iUserInfoDal.Exists(UserID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Gymnasium_APP.Model.UserInfoModel model)
		{
            return iUserInfoDal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Gymnasium_APP.Model.UserInfoModel model)
		{
            return iUserInfoDal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserID)
		{

            return iUserInfoDal.Delete(UserID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
            return iUserInfoDal.DeleteList(UserIDlist);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Gymnasium_APP.Model.UserInfoModel GetModel(int UserID)
		{

            return iUserInfoDal.GetModel(UserID);
		}

	
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            return iUserInfoDal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
            return iUserInfoDal.GetList(Top, strWhere, filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<Gymnasium_APP.Model.UserInfoModel> GetModelList(string strWhere)
        {
            DataSet ds = iUserInfoDal.GetList(strWhere);
            if (ds != null)
            {
                return DataTableToList(ds.Tables[0]);
            }
            return null;
        }
        
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Gymnasium_APP.Model.UserInfoModel> DataTableToList(DataTable dt)
		{
			List<Gymnasium_APP.Model.UserInfoModel> modelList = new List<Gymnasium_APP.Model.UserInfoModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Gymnasium_APP.Model.UserInfoModel model;
				for (int n = 0; n < rowsCount; n++)
				{
                    model = iUserInfoDal.DataRowToModel(dt.Rows[n]);
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
            return iUserInfoDal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
            return iUserInfoDal.GetListByPage(strWhere, orderby, startIndex, endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return iUserInfoDal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

