using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:Sys_FunctionBigDal
	/// </summary>
	public partial class Sys_FunctionBigDal
	{
		public Sys_FunctionBigDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FunctionBigId", "Sys_FunctionBig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FunctionBigId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_FunctionBig");
			strSql.Append(" where FunctionBigId=@FunctionBigId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4)			};
			parameters[0].Value = FunctionBigId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.Sys_FunctionBigModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_FunctionBig(");
			strSql.Append("FunctionBigId,FunctionBigName,FunctionChildCount,FunctionSortId)");
			strSql.Append(" values (");
			strSql.Append("@FunctionBigId,@FunctionBigName,@FunctionChildCount,@FunctionSortId)");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4),
					new SqlParameter("@FunctionBigName", SqlDbType.VarChar,200),
					new SqlParameter("@FunctionChildCount", SqlDbType.Int,4),
					new SqlParameter("@FunctionSortId", SqlDbType.Int,4)};
			parameters[0].Value = model.FunctionBigId;
			parameters[1].Value = model.FunctionBigName;
			parameters[2].Value = model.FunctionChildCount;
			parameters[3].Value = model.FunctionSortId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Gymnasium_APP.Model.Sys_FunctionBigModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_FunctionBig set ");
			strSql.Append("FunctionBigName=@FunctionBigName,");
			strSql.Append("FunctionChildCount=@FunctionChildCount,");
			strSql.Append("FunctionSortId=@FunctionSortId");
			strSql.Append(" where FunctionBigId=@FunctionBigId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionBigName", SqlDbType.VarChar,200),
					new SqlParameter("@FunctionChildCount", SqlDbType.Int,4),
					new SqlParameter("@FunctionSortId", SqlDbType.Int,4),
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4)};
			parameters[0].Value = model.FunctionBigName;
			parameters[1].Value = model.FunctionChildCount;
			parameters[2].Value = model.FunctionSortId;
			parameters[3].Value = model.FunctionBigId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int FunctionBigId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_FunctionBig ");
			strSql.Append(" where FunctionBigId=@FunctionBigId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4)			};
			parameters[0].Value = FunctionBigId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string FunctionBigIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_FunctionBig ");
			strSql.Append(" where FunctionBigId in ("+FunctionBigIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Gymnasium_APP.Model.Sys_FunctionBigModel GetModel(int FunctionBigId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FunctionBigId,FunctionBigName,FunctionChildCount,FunctionSortId from Sys_FunctionBig ");
			strSql.Append(" where FunctionBigId=@FunctionBigId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4)			};
			parameters[0].Value = FunctionBigId;

			Gymnasium_APP.Model.Sys_FunctionBigModel model=new Gymnasium_APP.Model.Sys_FunctionBigModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Gymnasium_APP.Model.Sys_FunctionBigModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.Sys_FunctionBigModel model=new Gymnasium_APP.Model.Sys_FunctionBigModel();
			if (row != null)
			{
				if(row["FunctionBigId"]!=null && row["FunctionBigId"].ToString()!="")
				{
					model.FunctionBigId=int.Parse(row["FunctionBigId"].ToString());
				}
				if(row["FunctionBigName"]!=null)
				{
					model.FunctionBigName=row["FunctionBigName"].ToString();
				}
				if(row["FunctionChildCount"]!=null && row["FunctionChildCount"].ToString()!="")
				{
					model.FunctionChildCount=int.Parse(row["FunctionChildCount"].ToString());
				}
				if(row["FunctionSortId"]!=null && row["FunctionSortId"].ToString()!="")
				{
					model.FunctionSortId=int.Parse(row["FunctionSortId"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FunctionBigId,FunctionBigName,FunctionChildCount,FunctionSortId ");
			strSql.Append(" FROM Sys_FunctionBig ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" FunctionBigId,FunctionBigName,FunctionChildCount,FunctionSortId ");
			strSql.Append(" FROM Sys_FunctionBig ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Sys_FunctionBig ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.FunctionBigId desc");
			}
			strSql.Append(")AS Row, T.*  from Sys_FunctionBig T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Sys_FunctionBig";
			parameters[1].Value = "FunctionBigId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

