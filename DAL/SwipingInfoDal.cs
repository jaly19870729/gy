using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:SwipingInfoDal
	/// </summary>
	public partial class SwipingInfoDal
	{
		public SwipingInfoDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SwipingInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SwipingInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.SwipingInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SwipingInfo(");
			strSql.Append("ID,SwipingType,CardID,CardType,SwipingPeople,AddTime,AddUserName,Name,Desc)");
			strSql.Append(" values (");
			strSql.Append("@ID,@SwipingType,@CardID,@CardType,@SwipingPeople,@AddTime,@AddUserName,@Name,@Desc)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SwipingType", SqlDbType.VarChar,50),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@CardType", SqlDbType.VarChar,50),
					new SqlParameter("@SwipingPeople", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Desc", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SwipingType;
			parameters[2].Value = model.CardID;
			parameters[3].Value = model.CardType;
			parameters[4].Value = model.SwipingPeople;
			parameters[5].Value = model.AddTime;
			parameters[6].Value = model.AddUserName;
			parameters[7].Value = model.Name;
			parameters[8].Value = model.Desc;

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
		public bool Update(Gymnasium_APP.Model.SwipingInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SwipingInfo set ");
			strSql.Append("SwipingType=@SwipingType,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("CardType=@CardType,");
			strSql.Append("SwipingPeople=@SwipingPeople,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("AddUserName=@AddUserName,");
			strSql.Append("Name=@Name,");
			strSql.Append("Desc=@Desc");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SwipingType", SqlDbType.VarChar,50),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@CardType", SqlDbType.VarChar,50),
					new SqlParameter("@SwipingPeople", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Desc", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.SwipingType;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.CardType;
			parameters[3].Value = model.SwipingPeople;
			parameters[4].Value = model.AddTime;
			parameters[5].Value = model.AddUserName;
			parameters[6].Value = model.Name;
			parameters[7].Value = model.Desc;
			parameters[8].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SwipingInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SwipingInfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Gymnasium_APP.Model.SwipingInfoModel GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SwipingType,CardID,CardType,SwipingPeople,AddTime,AddUserName,Name,Desc from SwipingInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			Gymnasium_APP.Model.SwipingInfoModel model=new Gymnasium_APP.Model.SwipingInfoModel();
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
		public Gymnasium_APP.Model.SwipingInfoModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.SwipingInfoModel model=new Gymnasium_APP.Model.SwipingInfoModel();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["SwipingType"]!=null)
				{
					model.SwipingType=row["SwipingType"].ToString();
				}
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["CardType"]!=null)
				{
					model.CardType=row["CardType"].ToString();
				}
				if(row["SwipingPeople"]!=null)
				{
					model.SwipingPeople=row["SwipingPeople"].ToString();
				}
				if(row["AddTime"]!=null)
				{
					model.AddTime=row["AddTime"].ToString();
				}
				if(row["AddUserName"]!=null)
				{
					model.AddUserName=row["AddUserName"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Desc"]!=null)
				{
					model.Desc=row["Desc"].ToString();
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
			strSql.Append("select ID,SwipingType,CardID,CardType,SwipingPeople,AddTime,AddUserName,Name,Desc ");
			strSql.Append(" FROM SwipingInfo ");
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
			strSql.Append(" ID,SwipingType,CardID,CardType,SwipingPeople,AddTime,AddUserName,Name,Desc ");
			strSql.Append(" FROM SwipingInfo ");
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
			strSql.Append("select count(1) FROM SwipingInfo ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from SwipingInfo T ");
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
			parameters[0].Value = "SwipingInfo";
			parameters[1].Value = "ID";
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

