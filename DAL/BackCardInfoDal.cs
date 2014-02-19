using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;//Please add references
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:BackCardInfoDal
	/// </summary>
	public partial class BackCardInfoDal
	{
		public BackCardInfoDal()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.BackCardInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BackCardInfo(");
			strSql.Append("Id,CardNumber,CardType,Name,IDCardType,IDCardNumber,AddTime,StartTime,EndTime,TotalDays,LeftDays,TotalTimes,LeftTimes,PaidAmount,ChangeAmount,PatchAmount,UsedAmount,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@Id,@CardNumber,@CardType,@Name,@IDCardType,@IDCardNumber,@AddTime,@StartTime,@EndTime,@TotalDays,@LeftDays,@TotalTimes,@LeftTimes,@PaidAmount,@ChangeAmount,@PatchAmount,@UsedAmount,@CreateTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@CardNumber", SqlDbType.VarChar,50),
					new SqlParameter("@CardType", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@IDCardType", SqlDbType.VarChar,50),
					new SqlParameter("@IDCardNumber", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@TotalDays", SqlDbType.Int,4),
					new SqlParameter("@LeftDays", SqlDbType.Int,4),
					new SqlParameter("@TotalTimes", SqlDbType.Int,4),
					new SqlParameter("@LeftTimes", SqlDbType.Int,4),
					new SqlParameter("@PaidAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PatchAmount", SqlDbType.Decimal,9),
					new SqlParameter("@UsedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.CardNumber;
			parameters[2].Value = model.CardType;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.IDCardType;
			parameters[5].Value = model.IDCardNumber;
			parameters[6].Value = model.AddTime;
			parameters[7].Value = model.StartTime;
			parameters[8].Value = model.EndTime;
			parameters[9].Value = model.TotalDays;
			parameters[10].Value = model.LeftDays;
			parameters[11].Value = model.TotalTimes;
			parameters[12].Value = model.LeftTimes;
			parameters[13].Value = model.PaidAmount;
			parameters[14].Value = model.ChangeAmount;
			parameters[15].Value = model.PatchAmount;
			parameters[16].Value = model.UsedAmount;
			parameters[17].Value = model.CreateTime;

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
		public bool Update(Gymnasium_APP.Model.BackCardInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BackCardInfo set ");
			strSql.Append("Id=@Id,");
			strSql.Append("CardNumber=@CardNumber,");
			strSql.Append("CardType=@CardType,");
			strSql.Append("Name=@Name,");
			strSql.Append("IDCardType=@IDCardType,");
			strSql.Append("IDCardNumber=@IDCardNumber,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("EndTime=@EndTime,");
			strSql.Append("TotalDays=@TotalDays,");
			strSql.Append("LeftDays=@LeftDays,");
			strSql.Append("TotalTimes=@TotalTimes,");
			strSql.Append("LeftTimes=@LeftTimes,");
			strSql.Append("PaidAmount=@PaidAmount,");
			strSql.Append("ChangeAmount=@ChangeAmount,");
			strSql.Append("PatchAmount=@PatchAmount,");
			strSql.Append("UsedAmount=@UsedAmount,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@CardNumber", SqlDbType.VarChar,50),
					new SqlParameter("@CardType", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@IDCardType", SqlDbType.VarChar,50),
					new SqlParameter("@IDCardNumber", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.DateTime),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@TotalDays", SqlDbType.Int,4),
					new SqlParameter("@LeftDays", SqlDbType.Int,4),
					new SqlParameter("@TotalTimes", SqlDbType.Int,4),
					new SqlParameter("@LeftTimes", SqlDbType.Int,4),
					new SqlParameter("@PaidAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PatchAmount", SqlDbType.Decimal,9),
					new SqlParameter("@UsedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.CardNumber;
			parameters[2].Value = model.CardType;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.IDCardType;
			parameters[5].Value = model.IDCardNumber;
			parameters[6].Value = model.AddTime;
			parameters[7].Value = model.StartTime;
			parameters[8].Value = model.EndTime;
			parameters[9].Value = model.TotalDays;
			parameters[10].Value = model.LeftDays;
			parameters[11].Value = model.TotalTimes;
			parameters[12].Value = model.LeftTimes;
			parameters[13].Value = model.PaidAmount;
			parameters[14].Value = model.ChangeAmount;
			parameters[15].Value = model.PatchAmount;
			parameters[16].Value = model.UsedAmount;
			parameters[17].Value = model.CreateTime;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BackCardInfo ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Gymnasium_APP.Model.BackCardInfoModel GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,CardNumber,CardType,Name,IDCardType,IDCardNumber,AddTime,StartTime,EndTime,TotalDays,LeftDays,TotalTimes,LeftTimes,PaidAmount,ChangeAmount,PatchAmount,UsedAmount,CreateTime from BackCardInfo ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Gymnasium_APP.Model.BackCardInfoModel model=new Gymnasium_APP.Model.BackCardInfoModel();
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
		public Gymnasium_APP.Model.BackCardInfoModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.BackCardInfoModel model=new Gymnasium_APP.Model.BackCardInfoModel();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["CardNumber"]!=null)
				{
					model.CardNumber=row["CardNumber"].ToString();
				}
				if(row["CardType"]!=null)
				{
					model.CardType=row["CardType"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["IDCardType"]!=null)
				{
					model.IDCardType=row["IDCardType"].ToString();
				}
				if(row["IDCardNumber"]!=null)
				{
					model.IDCardNumber=row["IDCardNumber"].ToString();
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["StartTime"]!=null && row["StartTime"].ToString()!="")
				{
					model.StartTime=DateTime.Parse(row["StartTime"].ToString());
				}
				if(row["EndTime"]!=null && row["EndTime"].ToString()!="")
				{
					model.EndTime=DateTime.Parse(row["EndTime"].ToString());
				}
				if(row["TotalDays"]!=null && row["TotalDays"].ToString()!="")
				{
					model.TotalDays=int.Parse(row["TotalDays"].ToString());
				}
				if(row["LeftDays"]!=null && row["LeftDays"].ToString()!="")
				{
					model.LeftDays=int.Parse(row["LeftDays"].ToString());
				}
				if(row["TotalTimes"]!=null && row["TotalTimes"].ToString()!="")
				{
					model.TotalTimes=int.Parse(row["TotalTimes"].ToString());
				}
				if(row["LeftTimes"]!=null && row["LeftTimes"].ToString()!="")
				{
					model.LeftTimes=int.Parse(row["LeftTimes"].ToString());
				}
				if(row["PaidAmount"]!=null && row["PaidAmount"].ToString()!="")
				{
					model.PaidAmount=decimal.Parse(row["PaidAmount"].ToString());
				}
				if(row["ChangeAmount"]!=null && row["ChangeAmount"].ToString()!="")
				{
					model.ChangeAmount=decimal.Parse(row["ChangeAmount"].ToString());
				}
				if(row["PatchAmount"]!=null && row["PatchAmount"].ToString()!="")
				{
					model.PatchAmount=decimal.Parse(row["PatchAmount"].ToString());
				}
				if(row["UsedAmount"]!=null && row["UsedAmount"].ToString()!="")
				{
					model.UsedAmount=decimal.Parse(row["UsedAmount"].ToString());
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
			strSql.Append("select Id,CardNumber,CardType,Name,IDCardType,IDCardNumber,AddTime,StartTime,EndTime,TotalDays,LeftDays,TotalTimes,LeftTimes,PaidAmount,ChangeAmount,PatchAmount,UsedAmount,CreateTime ");
			strSql.Append(" FROM BackCardInfo ");
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
			strSql.Append(" Id,CardNumber,CardType,Name,IDCardType,IDCardNumber,AddTime,StartTime,EndTime,TotalDays,LeftDays,TotalTimes,LeftTimes,PaidAmount,ChangeAmount,PatchAmount,UsedAmount,CreateTime ");
			strSql.Append(" FROM BackCardInfo ");
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
			strSql.Append("select count(1) FROM BackCardInfo ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from BackCardInfo T ");
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
			parameters[0].Value = "BackCardInfo";
			parameters[1].Value = "Id";
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

