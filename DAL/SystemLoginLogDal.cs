using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;//Please add references
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:SystemLoginLogDal
	/// </summary>
	public partial class SystemLoginLogDal
	{
		public SystemLoginLogDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("LoginLogId", "SystemLoginLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int LoginLogId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SystemLoginLog");
			strSql.Append(" where LoginLogId=@LoginLogId ");
			SqlParameter[] parameters = {
					new SqlParameter("@LoginLogId", SqlDbType.Int,4)			};
			parameters[0].Value = LoginLogId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.SystemLoginLogModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SystemLoginLog(");
			strSql.Append("LoginLogId,UserId,LoginIP,LoginAddress,LoginDate,LoginType,LoginCont)");
			strSql.Append(" values (");
			strSql.Append("@LoginLogId,@UserId,@LoginIP,@LoginAddress,@LoginDate,@LoginType,@LoginCont)");
			SqlParameter[] parameters = {
					new SqlParameter("@LoginLogId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,200),
					new SqlParameter("@LoginAddress", SqlDbType.VarChar,200),
					new SqlParameter("@LoginDate", SqlDbType.VarChar,100),
					new SqlParameter("@LoginType", SqlDbType.VarChar,100),
					new SqlParameter("@LoginCont", SqlDbType.VarChar,100)};
			parameters[0].Value = model.LoginLogId;
			parameters[1].Value = model.UserId;
			parameters[2].Value = model.LoginIP;
			parameters[3].Value = model.LoginAddress;
			parameters[4].Value = model.LoginDate;
			parameters[5].Value = model.LoginType;
			parameters[6].Value = model.LoginCont;

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
		public bool Update(Gymnasium_APP.Model.SystemLoginLogModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SystemLoginLog set ");
			strSql.Append("UserId=@UserId,");
			strSql.Append("LoginIP=@LoginIP,");
			strSql.Append("LoginAddress=@LoginAddress,");
			strSql.Append("LoginDate=@LoginDate,");
			strSql.Append("LoginType=@LoginType,");
			strSql.Append("LoginCont=@LoginCont");
			strSql.Append(" where LoginLogId=@LoginLogId ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,200),
					new SqlParameter("@LoginAddress", SqlDbType.VarChar,200),
					new SqlParameter("@LoginDate", SqlDbType.VarChar,100),
					new SqlParameter("@LoginType", SqlDbType.VarChar,100),
					new SqlParameter("@LoginCont", SqlDbType.VarChar,100),
					new SqlParameter("@LoginLogId", SqlDbType.Int,4)};
			parameters[0].Value = model.UserId;
			parameters[1].Value = model.LoginIP;
			parameters[2].Value = model.LoginAddress;
			parameters[3].Value = model.LoginDate;
			parameters[4].Value = model.LoginType;
			parameters[5].Value = model.LoginCont;
			parameters[6].Value = model.LoginLogId;

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
		public bool Delete(int LoginLogId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SystemLoginLog ");
			strSql.Append(" where LoginLogId=@LoginLogId ");
			SqlParameter[] parameters = {
					new SqlParameter("@LoginLogId", SqlDbType.Int,4)			};
			parameters[0].Value = LoginLogId;

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
		public bool DeleteList(string LoginLogIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SystemLoginLog ");
			strSql.Append(" where LoginLogId in ("+LoginLogIdlist + ")  ");
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
		public Gymnasium_APP.Model.SystemLoginLogModel GetModel(int LoginLogId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LoginLogId,UserId,LoginIP,LoginAddress,LoginDate,LoginType,LoginCont from SystemLoginLog ");
			strSql.Append(" where LoginLogId=@LoginLogId ");
			SqlParameter[] parameters = {
					new SqlParameter("@LoginLogId", SqlDbType.Int,4)			};
			parameters[0].Value = LoginLogId;

			Gymnasium_APP.Model.SystemLoginLogModel model=new Gymnasium_APP.Model.SystemLoginLogModel();
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
		public Gymnasium_APP.Model.SystemLoginLogModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.SystemLoginLogModel model=new Gymnasium_APP.Model.SystemLoginLogModel();
			if (row != null)
			{
				if(row["LoginLogId"]!=null && row["LoginLogId"].ToString()!="")
				{
					model.LoginLogId=int.Parse(row["LoginLogId"].ToString());
				}
				if(row["UserId"]!=null && row["UserId"].ToString()!="")
				{
					model.UserId=int.Parse(row["UserId"].ToString());
				}
				if(row["LoginIP"]!=null)
				{
					model.LoginIP=row["LoginIP"].ToString();
				}
				if(row["LoginAddress"]!=null)
				{
					model.LoginAddress=row["LoginAddress"].ToString();
				}
				if(row["LoginDate"]!=null)
				{
					model.LoginDate=row["LoginDate"].ToString();
				}
				if(row["LoginType"]!=null)
				{
					model.LoginType=row["LoginType"].ToString();
				}
				if(row["LoginCont"]!=null)
				{
					model.LoginCont=row["LoginCont"].ToString();
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
			strSql.Append("select LoginLogId,UserId,LoginIP,LoginAddress,LoginDate,LoginType,LoginCont ");
			strSql.Append(" FROM SystemLoginLog ");
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
			strSql.Append(" LoginLogId,UserId,LoginIP,LoginAddress,LoginDate,LoginType,LoginCont ");
			strSql.Append(" FROM SystemLoginLog ");
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
			strSql.Append("select count(1) FROM SystemLoginLog ");
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
				strSql.Append("order by T.LoginLogId desc");
			}
			strSql.Append(")AS Row, T.*  from SystemLoginLog T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		
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
			parameters[0].Value = "SystemLoginLog";
			parameters[1].Value = "LoginLogId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 1;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

