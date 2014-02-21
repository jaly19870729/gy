using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:CunsumeCastDal
	/// </summary>
	public partial class CunsumeCastDal
	{
		public CunsumeCastDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "CunsumeCast"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CunsumeCast");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Gymnasium_APP.Model.CunsumeCastModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CunsumeCast(");
			strSql.Append("MemberId,CusType,TransactDate,PriceAmount,Count,PayableAmount,PaymentAmount,ChangeAmount,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@MemberId,@CusType,@TransactDate,@PriceAmount,@Count,@PayableAmount,@PaymentAmount,@ChangeAmount,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberId", SqlDbType.Int,4),
					new SqlParameter("@CusType", SqlDbType.VarChar,50),
					new SqlParameter("@TransactDate", SqlDbType.DateTime),
					new SqlParameter("@PriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Count", SqlDbType.Int,4),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PaymentAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.MemberId;
			parameters[1].Value = model.CusType;
			parameters[2].Value = model.TransactDate;
			parameters[3].Value = model.PriceAmount;
			parameters[4].Value = model.Count;
			parameters[5].Value = model.PayableAmount;
			parameters[6].Value = model.PaymentAmount;
			parameters[7].Value = model.ChangeAmount;
			parameters[8].Value = model.CreateTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Gymnasium_APP.Model.CunsumeCastModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CunsumeCast set ");
			strSql.Append("MemberId=@MemberId,");
			strSql.Append("CusType=@CusType,");
			strSql.Append("TransactDate=@TransactDate,");
			strSql.Append("PriceAmount=@PriceAmount,");
			strSql.Append("Count=@Count,");
			strSql.Append("PayableAmount=@PayableAmount,");
			strSql.Append("PaymentAmount=@PaymentAmount,");
			strSql.Append("ChangeAmount=@ChangeAmount,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberId", SqlDbType.Int,4),
					new SqlParameter("@CusType", SqlDbType.VarChar,50),
					new SqlParameter("@TransactDate", SqlDbType.DateTime),
					new SqlParameter("@PriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Count", SqlDbType.Int,4),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PaymentAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.MemberId;
			parameters[1].Value = model.CusType;
			parameters[2].Value = model.TransactDate;
			parameters[3].Value = model.PriceAmount;
			parameters[4].Value = model.Count;
			parameters[5].Value = model.PayableAmount;
			parameters[6].Value = model.PaymentAmount;
			parameters[7].Value = model.ChangeAmount;
			parameters[8].Value = model.CreateTime;
			parameters[9].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CunsumeCast ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CunsumeCast ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public Gymnasium_APP.Model.CunsumeCastModel GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,MemberId,CusType,TransactDate,PriceAmount,Count,PayableAmount,PaymentAmount,ChangeAmount,CreateTime from CunsumeCast ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Gymnasium_APP.Model.CunsumeCastModel model=new Gymnasium_APP.Model.CunsumeCastModel();
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
		public Gymnasium_APP.Model.CunsumeCastModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.CunsumeCastModel model=new Gymnasium_APP.Model.CunsumeCastModel();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["MemberId"]!=null && row["MemberId"].ToString()!="")
				{
					model.MemberId=int.Parse(row["MemberId"].ToString());
				}
				if(row["CusType"]!=null)
				{
					model.CusType=row["CusType"].ToString();
				}
				if(row["TransactDate"]!=null && row["TransactDate"].ToString()!="")
				{
					model.TransactDate=DateTime.Parse(row["TransactDate"].ToString());
				}
				if(row["PriceAmount"]!=null && row["PriceAmount"].ToString()!="")
				{
					model.PriceAmount=decimal.Parse(row["PriceAmount"].ToString());
				}
				if(row["Count"]!=null && row["Count"].ToString()!="")
				{
					model.Count=int.Parse(row["Count"].ToString());
				}
				if(row["PayableAmount"]!=null && row["PayableAmount"].ToString()!="")
				{
					model.PayableAmount=decimal.Parse(row["PayableAmount"].ToString());
				}
				if(row["PaymentAmount"]!=null && row["PaymentAmount"].ToString()!="")
				{
					model.PaymentAmount=decimal.Parse(row["PaymentAmount"].ToString());
				}
				if(row["ChangeAmount"]!=null && row["ChangeAmount"].ToString()!="")
				{
					model.ChangeAmount=decimal.Parse(row["ChangeAmount"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
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
			strSql.Append("select Id,MemberId,CusType,TransactDate,PriceAmount,Count,PayableAmount,PaymentAmount,ChangeAmount,CreateTime ");
			strSql.Append(" FROM CunsumeCast ");
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
			strSql.Append(" Id,MemberId,CusType,TransactDate,PriceAmount,Count,PayableAmount,PaymentAmount,ChangeAmount,CreateTime ");
			strSql.Append(" FROM CunsumeCast ");
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
			strSql.Append("select count(1) FROM CunsumeCast ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from CunsumeCast T ");
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
			parameters[0].Value = "CunsumeCast";
			parameters[1].Value = "Id";
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

