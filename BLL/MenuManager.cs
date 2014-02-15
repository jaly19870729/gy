using System;
using System.Data;
using System.Collections.Generic;

using Gymnasium_APP.Model;
namespace Gymnasium_APP.BLL
{
	/// <summary>
	/// MenuManager
	/// </summary>
	public partial class MenuManager
	{
		private readonly Gymnasium_APP.DAL.MenuDal dal=new Gymnasium_APP.DAL.MenuDal();
		public MenuManager()
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
		public bool Exists(int RoleMenuId)
		{
			return dal.Exists(RoleMenuId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.MenuModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Gymnasium_APP.Model.MenuModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RoleMenuId)
		{
			
			return dal.Delete(RoleMenuId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string RoleMenuIdlist )
		{
			return dal.DeleteList(RoleMenuIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Gymnasium_APP.Model.MenuModel GetModel(int RoleMenuId)
		{
			
			return dal.GetModel(RoleMenuId);
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
		public List<Gymnasium_APP.Model.MenuModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Gymnasium_APP.Model.MenuModel> DataTableToList(DataTable dt)
		{
			List<Gymnasium_APP.Model.MenuModel> modelList = new List<Gymnasium_APP.Model.MenuModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Gymnasium_APP.Model.MenuModel model;
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

