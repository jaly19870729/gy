using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:Sys_FunctionSmallDal
	/// </summary>
	public partial class Sys_FunctionSmallDal
	{
		public Sys_FunctionSmallDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FunctionSmallId", "Sys_FunctionSmall"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FunctionSmallId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_FunctionSmall");
			strSql.Append(" where FunctionSmallId=@FunctionSmallId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionSmallId", SqlDbType.Int,4)			};
			parameters[0].Value = FunctionSmallId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.Sys_FunctionSmallModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_FunctionSmall(");
			strSql.Append("FunctionSmallId,FunctionBigId,FunctionSmallName,FunctionLinkToolTip,FunctionUrl,SortId,IsBlank,IsShow)");
			strSql.Append(" values (");
			strSql.Append("@FunctionSmallId,@FunctionBigId,@FunctionSmallName,@FunctionLinkToolTip,@FunctionUrl,@SortId,@IsBlank,@IsShow)");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionSmallId", SqlDbType.Int,4),
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4),
					new SqlParameter("@FunctionSmallName", SqlDbType.VarChar,200),
					new SqlParameter("@FunctionLinkToolTip", SqlDbType.VarChar,100),
					new SqlParameter("@FunctionUrl", SqlDbType.VarChar,300),
					new SqlParameter("@SortId", SqlDbType.Int,4),
					new SqlParameter("@IsBlank", SqlDbType.Int,4),
					new SqlParameter("@IsShow", SqlDbType.Int,4)};
			parameters[0].Value = model.FunctionSmallId;
			parameters[1].Value = model.FunctionBigId;
			parameters[2].Value = model.FunctionSmallName;
			parameters[3].Value = model.FunctionLinkToolTip;
			parameters[4].Value = model.FunctionUrl;
			parameters[5].Value = model.SortId;
			parameters[6].Value = model.IsBlank;
			parameters[7].Value = model.IsShow;

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
		public bool Update(Gymnasium_APP.Model.Sys_FunctionSmallModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_FunctionSmall set ");
			strSql.Append("FunctionBigId=@FunctionBigId,");
			strSql.Append("FunctionSmallName=@FunctionSmallName,");
			strSql.Append("FunctionLinkToolTip=@FunctionLinkToolTip,");
			strSql.Append("FunctionUrl=@FunctionUrl,");
			strSql.Append("SortId=@SortId,");
			strSql.Append("IsBlank=@IsBlank,");
			strSql.Append("IsShow=@IsShow");
			strSql.Append(" where FunctionSmallId=@FunctionSmallId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionBigId", SqlDbType.Int,4),
					new SqlParameter("@FunctionSmallName", SqlDbType.VarChar,200),
					new SqlParameter("@FunctionLinkToolTip", SqlDbType.VarChar,100),
					new SqlParameter("@FunctionUrl", SqlDbType.VarChar,300),
					new SqlParameter("@SortId", SqlDbType.Int,4),
					new SqlParameter("@IsBlank", SqlDbType.Int,4),
					new SqlParameter("@IsShow", SqlDbType.Int,4),
					new SqlParameter("@FunctionSmallId", SqlDbType.Int,4)};
			parameters[0].Value = model.FunctionBigId;
			parameters[1].Value = model.FunctionSmallName;
			parameters[2].Value = model.FunctionLinkToolTip;
			parameters[3].Value = model.FunctionUrl;
			parameters[4].Value = model.SortId;
			parameters[5].Value = model.IsBlank;
			parameters[6].Value = model.IsShow;
			parameters[7].Value = model.FunctionSmallId;

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
		public bool Delete(int FunctionSmallId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_FunctionSmall ");
			strSql.Append(" where FunctionSmallId=@FunctionSmallId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionSmallId", SqlDbType.Int,4)			};
			parameters[0].Value = FunctionSmallId;

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
		public bool DeleteList(string FunctionSmallIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_FunctionSmall ");
			strSql.Append(" where FunctionSmallId in ("+FunctionSmallIdlist + ")  ");
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
		public Gymnasium_APP.Model.Sys_FunctionSmallModel GetModel(int FunctionSmallId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FunctionSmallId,FunctionBigId,FunctionSmallName,FunctionLinkToolTip,FunctionUrl,SortId,IsBlank,IsShow from Sys_FunctionSmall ");
			strSql.Append(" where FunctionSmallId=@FunctionSmallId ");
			SqlParameter[] parameters = {
					new SqlParameter("@FunctionSmallId", SqlDbType.Int,4)			};
			parameters[0].Value = FunctionSmallId;

			Gymnasium_APP.Model.Sys_FunctionSmallModel model=new Gymnasium_APP.Model.Sys_FunctionSmallModel();
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
		public Gymnasium_APP.Model.Sys_FunctionSmallModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.Sys_FunctionSmallModel model=new Gymnasium_APP.Model.Sys_FunctionSmallModel();
			if (row != null)
			{
				if(row["FunctionSmallId"]!=null && row["FunctionSmallId"].ToString()!="")
				{
					model.FunctionSmallId=int.Parse(row["FunctionSmallId"].ToString());
				}
				if(row["FunctionBigId"]!=null && row["FunctionBigId"].ToString()!="")
				{
					model.FunctionBigId=int.Parse(row["FunctionBigId"].ToString());
				}
				if(row["FunctionSmallName"]!=null)
				{
					model.FunctionSmallName=row["FunctionSmallName"].ToString();
				}
				if(row["FunctionLinkToolTip"]!=null)
				{
					model.FunctionLinkToolTip=row["FunctionLinkToolTip"].ToString();
				}
				if(row["FunctionUrl"]!=null)
				{
					model.FunctionUrl=row["FunctionUrl"].ToString();
				}
				if(row["SortId"]!=null && row["SortId"].ToString()!="")
				{
					model.SortId=int.Parse(row["SortId"].ToString());
				}
				if(row["IsBlank"]!=null && row["IsBlank"].ToString()!="")
				{
					model.IsBlank=int.Parse(row["IsBlank"].ToString());
				}
				if(row["IsShow"]!=null && row["IsShow"].ToString()!="")
				{
					model.IsShow=int.Parse(row["IsShow"].ToString());
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
			strSql.Append("select FunctionSmallId,FunctionBigId,FunctionSmallName,FunctionLinkToolTip,FunctionUrl,SortId,IsBlank,IsShow ");
			strSql.Append(" FROM Sys_FunctionSmall ");
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
			strSql.Append(" FunctionSmallId,FunctionBigId,FunctionSmallName,FunctionLinkToolTip,FunctionUrl,SortId,IsBlank,IsShow ");
			strSql.Append(" FROM Sys_FunctionSmall ");
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
			strSql.Append("select count(1) FROM Sys_FunctionSmall ");
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
				strSql.Append("order by T.FunctionSmallId desc");
			}
			strSql.Append(")AS Row, T.*  from Sys_FunctionSmall T ");
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
			parameters[0].Value = "Sys_FunctionSmall";
			parameters[1].Value = "FunctionSmallId";
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

