using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;//Please add references
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:RoleDal
	/// </summary>
	public partial class RoleDal
	{
		public RoleDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("RoleId", "Role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RoleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Role");
			strSql.Append(" where RoleId=@RoleId ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleId", SqlDbType.Int,4)			};
			parameters[0].Value = RoleId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.RoleModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Role(");
			strSql.Append("RoleId,RoleName,RoleMailRoom,RoleSynopsis,DataTime)");
			strSql.Append(" values (");
			strSql.Append("@RoleId,@RoleName,@RoleMailRoom,@RoleSynopsis,@DataTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleId", SqlDbType.Int,4),
					new SqlParameter("@RoleName", SqlDbType.VarChar,100),
					new SqlParameter("@RoleMailRoom", SqlDbType.Int,4),
					new SqlParameter("@RoleSynopsis", SqlDbType.Text),
					new SqlParameter("@DataTime", SqlDbType.VarChar,100)};
			parameters[0].Value = model.RoleId;
			parameters[1].Value = model.RoleName;
			parameters[2].Value = model.RoleMailRoom;
			parameters[3].Value = model.RoleSynopsis;
			parameters[4].Value = model.DataTime;

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
		public bool Update(Gymnasium_APP.Model.RoleModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Role set ");
			strSql.Append("RoleName=@RoleName,");
			strSql.Append("RoleMailRoom=@RoleMailRoom,");
			strSql.Append("RoleSynopsis=@RoleSynopsis,");
			strSql.Append("DataTime=@DataTime");
			strSql.Append(" where RoleId=@RoleId ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleName", SqlDbType.VarChar,100),
					new SqlParameter("@RoleMailRoom", SqlDbType.Int,4),
					new SqlParameter("@RoleSynopsis", SqlDbType.Text),
					new SqlParameter("@DataTime", SqlDbType.VarChar,100),
					new SqlParameter("@RoleId", SqlDbType.Int,4)};
			parameters[0].Value = model.RoleName;
			parameters[1].Value = model.RoleMailRoom;
			parameters[2].Value = model.RoleSynopsis;
			parameters[3].Value = model.DataTime;
			parameters[4].Value = model.RoleId;

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
		public bool Delete(int RoleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Role ");
			strSql.Append(" where RoleId=@RoleId ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleId", SqlDbType.Int,4)			};
			parameters[0].Value = RoleId;

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
		public bool DeleteList(string RoleIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Role ");
			strSql.Append(" where RoleId in ("+RoleIdlist + ")  ");
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
		public Gymnasium_APP.Model.RoleModel GetModel(int RoleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 RoleId,RoleName,RoleMailRoom,RoleSynopsis,DataTime from Role ");
			strSql.Append(" where RoleId=@RoleId ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleId", SqlDbType.Int,4)			};
			parameters[0].Value = RoleId;

			Gymnasium_APP.Model.RoleModel model=new Gymnasium_APP.Model.RoleModel();
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
		public Gymnasium_APP.Model.RoleModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.RoleModel model=new Gymnasium_APP.Model.RoleModel();
			if (row != null)
			{
				if(row["RoleId"]!=null && row["RoleId"].ToString()!="")
				{
					model.RoleId=int.Parse(row["RoleId"].ToString());
				}
				if(row["RoleName"]!=null)
				{
					model.RoleName=row["RoleName"].ToString();
				}
				if(row["RoleMailRoom"]!=null && row["RoleMailRoom"].ToString()!="")
				{
					model.RoleMailRoom=int.Parse(row["RoleMailRoom"].ToString());
				}
				if(row["RoleSynopsis"]!=null)
				{
					model.RoleSynopsis=row["RoleSynopsis"].ToString();
				}
				if(row["DataTime"]!=null)
				{
					model.DataTime=row["DataTime"].ToString();
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
			strSql.Append("select RoleId,RoleName,RoleMailRoom,RoleSynopsis,DataTime ");
			strSql.Append(" FROM Role ");
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
			strSql.Append(" RoleId,RoleName,RoleMailRoom,RoleSynopsis,DataTime ");
			strSql.Append(" FROM Role ");
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
			strSql.Append("select count(1) FROM Role ");
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
				strSql.Append("order by T.RoleId desc");
			}
			strSql.Append(")AS Row, T.*  from Role T ");
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
			parameters[0].Value = "Role";
			parameters[1].Value = "RoleId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

