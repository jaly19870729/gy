using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
using IDAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:CardTypeInfoDal
	/// </summary>
	public partial class CardTypeInfoDal:ICardTypeInfoDal
	{
		public CardTypeInfoDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CardTypeID", "CardTypeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CardTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CardTypeInfo");
			strSql.Append(" where CardTypeID=@CardTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = CardTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.CardTypeInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CardTypeInfo(");
			strSql.Append("CardTypeID,CardTypeName,MonthsPrice,Months,DayPrice,DateTime,TypeName)");
			strSql.Append(" values (");
			strSql.Append("@CardTypeID,@CardTypeName,@MonthsPrice,@Months,@DayPrice,@DateTime,@TypeName)");
			SqlParameter[] parameters = {
					new SqlParameter("@CardTypeID", SqlDbType.Int,4),
					new SqlParameter("@CardTypeName", SqlDbType.VarChar,150),
					new SqlParameter("@MonthsPrice", SqlDbType.VarChar,150),
					new SqlParameter("@Months", SqlDbType.VarChar,150),
					new SqlParameter("@DayPrice", SqlDbType.VarChar,150),
					new SqlParameter("@DateTime", SqlDbType.VarChar,150),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.CardTypeID;
			parameters[1].Value = model.CardTypeName;
			parameters[2].Value = model.MonthsPrice;
			parameters[3].Value = model.Months;
			parameters[4].Value = model.DayPrice;
			parameters[5].Value = model.DateTime;
			parameters[6].Value = model.TypeName;

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
		public bool Update(Gymnasium_APP.Model.CardTypeInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CardTypeInfo set ");
			strSql.Append("CardTypeName=@CardTypeName,");
			strSql.Append("MonthsPrice=@MonthsPrice,");
			strSql.Append("Months=@Months,");
			strSql.Append("DayPrice=@DayPrice,");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("TypeName=@TypeName");
			strSql.Append(" where CardTypeID=@CardTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardTypeName", SqlDbType.VarChar,150),
					new SqlParameter("@MonthsPrice", SqlDbType.VarChar,150),
					new SqlParameter("@Months", SqlDbType.VarChar,150),
					new SqlParameter("@DayPrice", SqlDbType.VarChar,150),
					new SqlParameter("@DateTime", SqlDbType.VarChar,150),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@CardTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.CardTypeName;
			parameters[1].Value = model.MonthsPrice;
			parameters[2].Value = model.Months;
			parameters[3].Value = model.DayPrice;
			parameters[4].Value = model.DateTime;
			parameters[5].Value = model.TypeName;
			parameters[6].Value = model.CardTypeID;

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
		public bool Delete(int CardTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardTypeInfo ");
			strSql.Append(" where CardTypeID=@CardTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = CardTypeID;

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
		public bool DeleteList(string CardTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardTypeInfo ");
			strSql.Append(" where CardTypeID in ("+CardTypeIDlist + ")  ");
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
		public Gymnasium_APP.Model.CardTypeInfoModel GetModel(int CardTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CardTypeID,CardTypeName,MonthsPrice,Months,DayPrice,DateTime,TypeName from CardTypeInfo ");
			strSql.Append(" where CardTypeID=@CardTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = CardTypeID;

			Gymnasium_APP.Model.CardTypeInfoModel model=new Gymnasium_APP.Model.CardTypeInfoModel();
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
		public Gymnasium_APP.Model.CardTypeInfoModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.CardTypeInfoModel model=new Gymnasium_APP.Model.CardTypeInfoModel();
			if (row != null)
			{
				if(row["CardTypeID"]!=null && row["CardTypeID"].ToString()!="")
				{
					model.CardTypeID=int.Parse(row["CardTypeID"].ToString());
				}
				if(row["CardTypeName"]!=null)
				{
					model.CardTypeName=row["CardTypeName"].ToString();
				}
				if(row["MonthsPrice"]!=null)
				{
					model.MonthsPrice=row["MonthsPrice"].ToString();
				}
				if(row["Months"]!=null)
				{
					model.Months=row["Months"].ToString();
				}
				if(row["DayPrice"]!=null)
				{
					model.DayPrice=row["DayPrice"].ToString();
				}
				if(row["DateTime"]!=null)
				{
					model.DateTime=row["DateTime"].ToString();
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
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
			strSql.Append("select CardTypeID,CardTypeName,MonthsPrice,Months,DayPrice,DateTime,TypeName ");
			strSql.Append(" FROM CardTypeInfo ");
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
			strSql.Append(" CardTypeID,CardTypeName,MonthsPrice,Months,DayPrice,DateTime,TypeName ");
			strSql.Append(" FROM CardTypeInfo ");
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
			strSql.Append("select count(1) FROM CardTypeInfo ");
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
				strSql.Append("order by T.CardTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from CardTypeInfo T ");
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
			parameters[0].Value = "CardTypeInfo";
			parameters[1].Value = "CardTypeID";
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

