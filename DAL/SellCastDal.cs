using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;

namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:SellCastDal
	/// </summary>
	public partial class SellCastDal
	{
		public SellCastDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CastId", "SellCast"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CastId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SellCast");
			strSql.Append(" where CastId=@CastId");
			SqlParameter[] parameters = {
					new SqlParameter("@CastId", SqlDbType.Int,4)
			};
			parameters[0].Value = CastId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Gymnasium_APP.Model.SellCastModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SellCast(");
			strSql.Append("MemberId,PriceAmount,PaymentAmount,ChangeAmount,CreateTime,AddUserName,AddTypeName,CardID,TypeName,Peoples,Des,Prices,CusType,CusNum)");
			strSql.Append(" values (");
			strSql.Append("@MemberId,@PriceAmount,@PaymentAmount,@ChangeAmount,@CreateTime,@AddUserName,@AddTypeName,@CardID,@TypeName,@Peoples,@Des,@Prices,@CusType,@CusNum)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberId", SqlDbType.VarChar,50),
					new SqlParameter("@PriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PaymentAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@AddTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Peoples", SqlDbType.VarChar,50),
					new SqlParameter("@Des", SqlDbType.VarChar,500),
					new SqlParameter("@Prices", SqlDbType.VarChar,50),
					new SqlParameter("@CusType", SqlDbType.VarChar,50),
					new SqlParameter("@CusNum", SqlDbType.VarChar,50)};
			parameters[0].Value = model.MemberId;
			parameters[1].Value = model.PriceAmount;
			parameters[2].Value = model.PaymentAmount;
			parameters[3].Value = model.ChangeAmount;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.AddUserName;
			parameters[6].Value = model.AddTypeName;
			parameters[7].Value = model.CardID;
			parameters[8].Value = model.TypeName;
			parameters[9].Value = model.Peoples;
			parameters[10].Value = model.Des;
			parameters[11].Value = model.Prices;
			parameters[12].Value = model.CusType;
			parameters[13].Value = model.CusNum;

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
		public bool Update(Gymnasium_APP.Model.SellCastModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SellCast set ");
			strSql.Append("MemberId=@MemberId,");
			strSql.Append("PriceAmount=@PriceAmount,");
			strSql.Append("PaymentAmount=@PaymentAmount,");
			strSql.Append("ChangeAmount=@ChangeAmount,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("AddUserName=@AddUserName,");
			strSql.Append("AddTypeName=@AddTypeName,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Peoples=@Peoples,");
			strSql.Append("Des=@Des,");
			strSql.Append("Prices=@Prices,");
			strSql.Append("CusType=@CusType,");
			strSql.Append("CusNum=@CusNum");
			strSql.Append(" where CastId=@CastId");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberId", SqlDbType.VarChar,50),
					new SqlParameter("@PriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PaymentAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@AddTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Peoples", SqlDbType.VarChar,50),
					new SqlParameter("@Des", SqlDbType.VarChar,500),
					new SqlParameter("@Prices", SqlDbType.VarChar,50),
					new SqlParameter("@CusType", SqlDbType.VarChar,50),
					new SqlParameter("@CusNum", SqlDbType.VarChar,50),
					new SqlParameter("@CastId", SqlDbType.Int,4)};
			parameters[0].Value = model.MemberId;
			parameters[1].Value = model.PriceAmount;
			parameters[2].Value = model.PaymentAmount;
			parameters[3].Value = model.ChangeAmount;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.AddUserName;
			parameters[6].Value = model.AddTypeName;
			parameters[7].Value = model.CardID;
			parameters[8].Value = model.TypeName;
			parameters[9].Value = model.Peoples;
			parameters[10].Value = model.Des;
			parameters[11].Value = model.Prices;
			parameters[12].Value = model.CusType;
			parameters[13].Value = model.CusNum;
			parameters[14].Value = model.CastId;

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
		public bool Delete(int CastId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SellCast ");
			strSql.Append(" where CastId=@CastId");
			SqlParameter[] parameters = {
					new SqlParameter("@CastId", SqlDbType.Int,4)
			};
			parameters[0].Value = CastId;

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
		public bool DeleteList(string CastIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SellCast ");
			strSql.Append(" where CastId in ("+CastIdlist + ")  ");
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
		public Gymnasium_APP.Model.SellCastModel GetModel(int CastId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CastId,MemberId,PriceAmount,PaymentAmount,ChangeAmount,CreateTime,AddUserName,AddTypeName,CardID,TypeName,Peoples,Des,Prices,CusType,CusNum from SellCast ");
			strSql.Append(" where CastId=@CastId");
			SqlParameter[] parameters = {
					new SqlParameter("@CastId", SqlDbType.Int,4)
			};
			parameters[0].Value = CastId;

			Gymnasium_APP.Model.SellCastModel model=new Gymnasium_APP.Model.SellCastModel();
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
		public Gymnasium_APP.Model.SellCastModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.SellCastModel model=new Gymnasium_APP.Model.SellCastModel();
			if (row != null)
			{
				if(row["CastId"]!=null && row["CastId"].ToString()!="")
				{
					model.CastId=int.Parse(row["CastId"].ToString());
				}
				if(row["MemberId"]!=null)
				{
					model.MemberId=row["MemberId"].ToString();
				}
				if(row["PriceAmount"]!=null && row["PriceAmount"].ToString()!="")
				{
					model.PriceAmount=decimal.Parse(row["PriceAmount"].ToString());
				}
				if(row["PaymentAmount"]!=null && row["PaymentAmount"].ToString()!="")
				{
					model.PaymentAmount=decimal.Parse(row["PaymentAmount"].ToString());
				}
				if(row["ChangeAmount"]!=null && row["ChangeAmount"].ToString()!="")
				{
					model.ChangeAmount=decimal.Parse(row["ChangeAmount"].ToString());
				}
				if(row["CreateTime"]!=null)
				{
					model.CreateTime=row["CreateTime"].ToString();
				}
				if(row["AddUserName"]!=null)
				{
					model.AddUserName=row["AddUserName"].ToString();
				}
				if(row["AddTypeName"]!=null)
				{
					model.AddTypeName=row["AddTypeName"].ToString();
				}
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["Peoples"]!=null)
				{
					model.Peoples=row["Peoples"].ToString();
				}
				if(row["Des"]!=null)
				{
					model.Des=row["Des"].ToString();
				}
				if(row["Prices"]!=null)
				{
					model.Prices=row["Prices"].ToString();
				}
				if(row["CusType"]!=null)
				{
					model.CusType=row["CusType"].ToString();
				}
				if(row["CusNum"]!=null)
				{
					model.CusNum=row["CusNum"].ToString();
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
			strSql.Append("select CastId,MemberId,PriceAmount,PaymentAmount,ChangeAmount,CreateTime,AddUserName,AddTypeName,CardID,TypeName,Peoples,Des,Prices,CusType,CusNum ");
			strSql.Append(" FROM SellCast ");
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
			strSql.Append(" CastId,MemberId,PriceAmount,PaymentAmount,ChangeAmount,CreateTime,AddUserName,AddTypeName,CardID,TypeName,Peoples,Des,Prices,CusType,CusNum ");
			strSql.Append(" FROM SellCast ");
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
			strSql.Append("select count(1) FROM SellCast ");
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
				strSql.Append("order by T.CastId desc");
			}
			strSql.Append(")AS Row, T.*  from SellCast T ");
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
			parameters[0].Value = "SellCast";
			parameters[1].Value = "CastId";
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

