using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;//Please add references
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:LossCastDal
	/// </summary>
	public partial class LossCastDal
	{
		public LossCastDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "LossCast"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LossCast");
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
		public int Add(Gymnasium_APP.Model.LossCastModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LossCast(");
			strSql.Append("LossCardId,PayableAmount,PaymentAmount,ChangeAmount,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@LossCardId,@PayableAmount,@PaymentAmount,@ChangeAmount,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@LossCardId", SqlDbType.Int,4),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PaymentAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.LossCardId;
			parameters[1].Value = model.PayableAmount;
			parameters[2].Value = model.PaymentAmount;
			parameters[3].Value = model.ChangeAmount;
			parameters[4].Value = model.CreateTime;

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
		public bool Update(Gymnasium_APP.Model.LossCastModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LossCast set ");
			strSql.Append("LossCardId=@LossCardId,");
			strSql.Append("PayableAmount=@PayableAmount,");
			strSql.Append("PaymentAmount=@PaymentAmount,");
			strSql.Append("ChangeAmount=@ChangeAmount,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@LossCardId", SqlDbType.Int,4),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PaymentAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.LossCardId;
			parameters[1].Value = model.PayableAmount;
			parameters[2].Value = model.PaymentAmount;
			parameters[3].Value = model.ChangeAmount;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.Id;

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
			strSql.Append("delete from LossCast ");
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
			strSql.Append("delete from LossCast ");
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
		public Gymnasium_APP.Model.LossCastModel GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,LossCardId,PayableAmount,PaymentAmount,ChangeAmount,CreateTime from LossCast ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Gymnasium_APP.Model.LossCastModel model=new Gymnasium_APP.Model.LossCastModel();
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
		public Gymnasium_APP.Model.LossCastModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.LossCastModel model=new Gymnasium_APP.Model.LossCastModel();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["LossCardId"]!=null && row["LossCardId"].ToString()!="")
				{
					model.LossCardId=int.Parse(row["LossCardId"].ToString());
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
			strSql.Append("select Id,LossCardId,PayableAmount,PaymentAmount,ChangeAmount,CreateTime ");
			strSql.Append(" FROM LossCast ");
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
			strSql.Append(" Id,LossCardId,PayableAmount,PaymentAmount,ChangeAmount,CreateTime ");
			strSql.Append(" FROM LossCast ");
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
			strSql.Append("select count(1) FROM LossCast ");
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
			strSql.Append(")AS Row, T.*  from LossCast T ");
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
			parameters[0].Value = "LossCast";
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

