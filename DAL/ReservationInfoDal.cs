using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:ReservationInfoDal
	/// </summary>
	public partial class ReservationInfoDal
	{
		public ReservationInfoDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ReservationInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReservationInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Gymnasium_APP.Model.ReservationInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReservationInfo(");
			strSql.Append("ID,ReservationNum,TypeName,Position,Times,Money,Name,Peoples,Phone,PriceAmount,PaymentAmount,ChangeAmount,AddTime,AddUserName,Des,PayType,RState)");
			strSql.Append(" values (");
			strSql.Append("@ID,@ReservationNum,@TypeName,@Position,@Times,@Money,@Name,@Peoples,@Phone,@PriceAmount,@PaymentAmount,@ChangeAmount,@AddTime,@AddUserName,@Des,@PayType,@RState)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ReservationNum", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Position", SqlDbType.VarChar,50),
					new SqlParameter("@Times", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Peoples", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@PriceAmount", SqlDbType.VarChar,50),
					new SqlParameter("@PaymentAmount", SqlDbType.VarChar,50),
					new SqlParameter("@ChangeAmount", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@Des", SqlDbType.VarChar,500),
					new SqlParameter("@PayType", SqlDbType.VarChar,50),
					new SqlParameter("@RState", SqlDbType.NChar,10)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ReservationNum;
			parameters[2].Value = model.TypeName;
			parameters[3].Value = model.Position;
			parameters[4].Value = model.Times;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.Name;
			parameters[7].Value = model.Peoples;
			parameters[8].Value = model.Phone;
			parameters[9].Value = model.PriceAmount;
			parameters[10].Value = model.PaymentAmount;
			parameters[11].Value = model.ChangeAmount;
			parameters[12].Value = model.AddTime;
			parameters[13].Value = model.AddUserName;
			parameters[14].Value = model.Des;
			parameters[15].Value = model.PayType;
			parameters[16].Value = model.RState;

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
		public bool Update(Gymnasium_APP.Model.ReservationInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReservationInfo set ");
			strSql.Append("ReservationNum=@ReservationNum,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Position=@Position,");
			strSql.Append("Times=@Times,");
			strSql.Append("Money=@Money,");
			strSql.Append("Name=@Name,");
			strSql.Append("Peoples=@Peoples,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("PriceAmount=@PriceAmount,");
			strSql.Append("PaymentAmount=@PaymentAmount,");
			strSql.Append("ChangeAmount=@ChangeAmount,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("AddUserName=@AddUserName,");
			strSql.Append("Des=@Des,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("RState=@RState");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReservationNum", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Position", SqlDbType.VarChar,50),
					new SqlParameter("@Times", SqlDbType.VarChar,50),
					new SqlParameter("@Money", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Peoples", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@PriceAmount", SqlDbType.VarChar,50),
					new SqlParameter("@PaymentAmount", SqlDbType.VarChar,50),
					new SqlParameter("@ChangeAmount", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@Des", SqlDbType.VarChar,500),
					new SqlParameter("@PayType", SqlDbType.VarChar,50),
					new SqlParameter("@RState", SqlDbType.NChar,10),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ReservationNum;
			parameters[1].Value = model.TypeName;
			parameters[2].Value = model.Position;
			parameters[3].Value = model.Times;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.Name;
			parameters[6].Value = model.Peoples;
			parameters[7].Value = model.Phone;
			parameters[8].Value = model.PriceAmount;
			parameters[9].Value = model.PaymentAmount;
			parameters[10].Value = model.ChangeAmount;
			parameters[11].Value = model.AddTime;
			parameters[12].Value = model.AddUserName;
			parameters[13].Value = model.Des;
			parameters[14].Value = model.PayType;
			parameters[15].Value = model.RState;
			parameters[16].Value = model.ID;

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
			strSql.Append("delete from ReservationInfo ");
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
			strSql.Append("delete from ReservationInfo ");
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
		public Gymnasium_APP.Model.ReservationInfoModel GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ReservationNum,TypeName,Position,Times,Money,Name,Peoples,Phone,PriceAmount,PaymentAmount,ChangeAmount,AddTime,AddUserName,Des,PayType,RState from ReservationInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			Gymnasium_APP.Model.ReservationInfoModel model=new Gymnasium_APP.Model.ReservationInfoModel();
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
		public Gymnasium_APP.Model.ReservationInfoModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.ReservationInfoModel model=new Gymnasium_APP.Model.ReservationInfoModel();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["ReservationNum"]!=null)
				{
					model.ReservationNum=row["ReservationNum"].ToString();
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["Position"]!=null)
				{
					model.Position=row["Position"].ToString();
				}
				if(row["Times"]!=null)
				{
					model.Times=row["Times"].ToString();
				}
				if(row["Money"]!=null)
				{
					model.Money=row["Money"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Peoples"]!=null)
				{
					model.Peoples=row["Peoples"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["PriceAmount"]!=null)
				{
					model.PriceAmount=row["PriceAmount"].ToString();
				}
				if(row["PaymentAmount"]!=null)
				{
					model.PaymentAmount=row["PaymentAmount"].ToString();
				}
				if(row["ChangeAmount"]!=null)
				{
					model.ChangeAmount=row["ChangeAmount"].ToString();
				}
				if(row["AddTime"]!=null)
				{
					model.AddTime=row["AddTime"].ToString();
				}
				if(row["AddUserName"]!=null)
				{
					model.AddUserName=row["AddUserName"].ToString();
				}
				if(row["Des"]!=null)
				{
					model.Des=row["Des"].ToString();
				}
				if(row["PayType"]!=null)
				{
					model.PayType=row["PayType"].ToString();
				}
				if(row["RState"]!=null)
				{
					model.RState=row["RState"].ToString();
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
			strSql.Append("select ID,ReservationNum,TypeName,Position,Times,Money,Name,Peoples,Phone,PriceAmount,PaymentAmount,ChangeAmount,AddTime,AddUserName,Des,PayType,RState ");
			strSql.Append(" FROM ReservationInfo ");
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
			strSql.Append(" ID,ReservationNum,TypeName,Position,Times,Money,Name,Peoples,Phone,PriceAmount,PaymentAmount,ChangeAmount,AddTime,AddUserName,Des,PayType,RState ");
			strSql.Append(" FROM ReservationInfo ");
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
			strSql.Append("select count(1) FROM ReservationInfo ");
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
			strSql.Append(")AS Row, T.*  from ReservationInfo T ");
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
			parameters[0].Value = "ReservationInfo";
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

