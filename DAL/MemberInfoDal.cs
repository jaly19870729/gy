using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:MemberInfoDal
	/// </summary>
	public partial class MemberInfoDal
	{
		public MemberInfoDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MemberID", "MemberInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MemberID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MemberInfo");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4)
			};
			parameters[0].Value = MemberID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Gymnasium_APP.Model.MemberInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MemberInfo(");
			strSql.Append("CardID,Mail,CardType,IDCardType,Name,IDCard,Sex,StartTime,Birthday,EndTime,Phone,Count,Unit,AddTime,AddUserName,Photo,InfoType)");
			strSql.Append(" values (");
			strSql.Append("@CardID,@Mail,@CardType,@IDCardType,@Name,@IDCard,@Sex,@StartTime,@Birthday,@EndTime,@Phone,@Count,@Unit,@AddTime,@AddUserName,@Photo,@InfoType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@Mail", SqlDbType.VarChar,50),
					new SqlParameter("@CardType", SqlDbType.VarChar,50),
					new SqlParameter("@IDCardType", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@IDCard", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@StartTime", SqlDbType.VarChar,50),
					new SqlParameter("@Birthday", SqlDbType.VarChar,50),
					new SqlParameter("@EndTime", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Count", SqlDbType.VarChar,50),
					new SqlParameter("@Unit", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@Photo", SqlDbType.Image),
					new SqlParameter("@InfoType", SqlDbType.VarChar,50)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.Mail;
			parameters[2].Value = model.CardType;
			parameters[3].Value = model.IDCardType;
			parameters[4].Value = model.Name;
			parameters[5].Value = model.IDCard;
			parameters[6].Value = model.Sex;
			parameters[7].Value = model.StartTime;
			parameters[8].Value = model.Birthday;
			parameters[9].Value = model.EndTime;
			parameters[10].Value = model.Phone;
			parameters[11].Value = model.Count;
			parameters[12].Value = model.Unit;
			parameters[13].Value = model.AddTime;
			parameters[14].Value = model.AddUserName;
			parameters[15].Value = model.Photo;
			parameters[16].Value = model.InfoType;

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
		public bool Update(Gymnasium_APP.Model.MemberInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MemberInfo set ");
			strSql.Append("CardID=@CardID,");
			strSql.Append("Mail=@Mail,");
			strSql.Append("CardType=@CardType,");
			strSql.Append("IDCardType=@IDCardType,");
			strSql.Append("Name=@Name,");
			strSql.Append("IDCard=@IDCard,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("EndTime=@EndTime,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Count=@Count,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("AddTime=@AddTime,");
			strSql.Append("AddUserName=@AddUserName,");
			strSql.Append("Photo=@Photo,");
			strSql.Append("InfoType=@InfoType");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.VarChar,50),
					new SqlParameter("@Mail", SqlDbType.VarChar,50),
					new SqlParameter("@CardType", SqlDbType.VarChar,50),
					new SqlParameter("@IDCardType", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@IDCard", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@StartTime", SqlDbType.VarChar,50),
					new SqlParameter("@Birthday", SqlDbType.VarChar,50),
					new SqlParameter("@EndTime", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Count", SqlDbType.VarChar,50),
					new SqlParameter("@Unit", SqlDbType.VarChar,50),
					new SqlParameter("@AddTime", SqlDbType.VarChar,50),
					new SqlParameter("@AddUserName", SqlDbType.VarChar,50),
					new SqlParameter("@Photo", SqlDbType.Image),
					new SqlParameter("@InfoType", SqlDbType.VarChar,50),
					new SqlParameter("@MemberID", SqlDbType.Int,4)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.Mail;
			parameters[2].Value = model.CardType;
			parameters[3].Value = model.IDCardType;
			parameters[4].Value = model.Name;
			parameters[5].Value = model.IDCard;
			parameters[6].Value = model.Sex;
			parameters[7].Value = model.StartTime;
			parameters[8].Value = model.Birthday;
			parameters[9].Value = model.EndTime;
			parameters[10].Value = model.Phone;
			parameters[11].Value = model.Count;
			parameters[12].Value = model.Unit;
			parameters[13].Value = model.AddTime;
			parameters[14].Value = model.AddUserName;
			parameters[15].Value = model.Photo;
			parameters[16].Value = model.InfoType;
			parameters[17].Value = model.MemberID;

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
		public bool Delete(int MemberID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MemberInfo ");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4)
			};
			parameters[0].Value = MemberID;

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
		public bool DeleteList(string MemberIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MemberInfo ");
			strSql.Append(" where MemberID in ("+MemberIDlist + ")  ");
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
		public Gymnasium_APP.Model.MemberInfoModel GetModel(int MemberID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MemberID,CardID,Mail,CardType,IDCardType,Name,IDCard,Sex,StartTime,Birthday,EndTime,Phone,Count,Unit,AddTime,AddUserName,Photo,InfoType from MemberInfo ");
			strSql.Append(" where MemberID=@MemberID");
			SqlParameter[] parameters = {
					new SqlParameter("@MemberID", SqlDbType.Int,4)
			};
			parameters[0].Value = MemberID;

			Gymnasium_APP.Model.MemberInfoModel model=new Gymnasium_APP.Model.MemberInfoModel();
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
		public Gymnasium_APP.Model.MemberInfoModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.MemberInfoModel model=new Gymnasium_APP.Model.MemberInfoModel();
			if (row != null)
			{
				if(row["MemberID"]!=null && row["MemberID"].ToString()!="")
				{
					model.MemberID=int.Parse(row["MemberID"].ToString());
				}
				if(row["CardID"]!=null)
				{
					model.CardID=row["CardID"].ToString();
				}
				if(row["Mail"]!=null)
				{
					model.Mail=row["Mail"].ToString();
				}
				if(row["CardType"]!=null)
				{
					model.CardType=row["CardType"].ToString();
				}
				if(row["IDCardType"]!=null)
				{
					model.IDCardType=row["IDCardType"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["IDCard"]!=null)
				{
					model.IDCard=row["IDCard"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["StartTime"]!=null)
				{
					model.StartTime=row["StartTime"].ToString();
				}
				if(row["Birthday"]!=null)
				{
					model.Birthday=row["Birthday"].ToString();
				}
				if(row["EndTime"]!=null)
				{
					model.EndTime=row["EndTime"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Count"]!=null)
				{
					model.Count=row["Count"].ToString();
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["AddTime"]!=null)
				{
					model.AddTime=row["AddTime"].ToString();
				}
				if(row["AddUserName"]!=null)
				{
					model.AddUserName=row["AddUserName"].ToString();
				}
				if(row["Photo"]!=null && row["Photo"].ToString()!="")
				{
					model.Photo=(byte[])row["Photo"];
				}
				if(row["InfoType"]!=null)
				{
					model.InfoType=row["InfoType"].ToString();
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
			strSql.Append("select MemberID,CardID,Mail,CardType,IDCardType,Name,IDCard,Sex,StartTime,Birthday,EndTime,Phone,Count,Unit,AddTime,AddUserName,Photo,InfoType ");
			strSql.Append(" FROM MemberInfo ");
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
			strSql.Append(" MemberID,CardID,Mail,CardType,IDCardType,Name,IDCard,Sex,StartTime,Birthday,EndTime,Phone,Count,Unit,AddTime,AddUserName,Photo,InfoType ");
			strSql.Append(" FROM MemberInfo ");
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
			strSql.Append("select count(1) FROM MemberInfo ");
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
				strSql.Append("order by T.MemberID desc");
			}
			strSql.Append(")AS Row, T.*  from MemberInfo T ");
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
			parameters[0].Value = "MemberInfo";
			parameters[1].Value = "MemberID";
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

