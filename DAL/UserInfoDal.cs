﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
using IDAL;
namespace Gymnasium_APP.DAL
{
	/// <summary>
	/// 数据访问类:UserInfoDal
	/// </summary>
	public partial class UserInfoDal:IUserInfoDal
	{
		public UserInfoDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "UserInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfo");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Gymnasium_APP.Model.UserInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
			strSql.Append("UserName,RealName,RoleID,Phone,Sex,Mail,UserPass,State,DateTime,Mac)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@RealName,@RoleID,@Phone,@Sex,@Mail,@UserPass,@State,@DateTime,@Mac)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Mail", SqlDbType.VarChar,50),
					new SqlParameter("@UserPass", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.VarChar,50),
					new SqlParameter("@DateTime", SqlDbType.VarChar,50),
					new SqlParameter("@Mac", SqlDbType.VarChar,100)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.RealName;
			parameters[2].Value = model.RoleID;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Sex;
			parameters[5].Value = model.Mail;
			parameters[6].Value = model.UserPass;
			parameters[7].Value = model.State;
			parameters[8].Value = model.DateTime;
			parameters[9].Value = model.Mac;

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
		public bool Update(Gymnasium_APP.Model.UserInfoModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("RoleID=@RoleID,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Mail=@Mail,");
			strSql.Append("UserPass=@UserPass,");
			strSql.Append("State=@State,");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("Mac=@Mac");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@Mail", SqlDbType.VarChar,50),
					new SqlParameter("@UserPass", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.VarChar,50),
					new SqlParameter("@DateTime", SqlDbType.VarChar,50),
					new SqlParameter("@Mac", SqlDbType.VarChar,100),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.RealName;
			parameters[2].Value = model.RoleID;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Sex;
			parameters[5].Value = model.Mail;
			parameters[6].Value = model.UserPass;
			parameters[7].Value = model.State;
			parameters[8].Value = model.DateTime;
			parameters[9].Value = model.Mac;
			parameters[10].Value = model.UserID;

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
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public Gymnasium_APP.Model.UserInfoModel GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,UserName,RealName,RoleID,Phone,Sex,Mail,UserPass,State,DateTime,Mac from UserInfo ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			Gymnasium_APP.Model.UserInfoModel model=new Gymnasium_APP.Model.UserInfoModel();
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
		public Gymnasium_APP.Model.UserInfoModel DataRowToModel(DataRow row)
		{
			Gymnasium_APP.Model.UserInfoModel model=new Gymnasium_APP.Model.UserInfoModel();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["RealName"]!=null)
				{
					model.RealName=row["RealName"].ToString();
				}
				if(row["RoleID"]!=null && row["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(row["RoleID"].ToString());
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Mail"]!=null)
				{
					model.Mail=row["Mail"].ToString();
				}
				if(row["UserPass"]!=null)
				{
					model.UserPass=row["UserPass"].ToString();
				}
				if(row["State"]!=null)
				{
					model.State=row["State"].ToString();
				}
				if(row["DateTime"]!=null)
				{
					model.DateTime=row["DateTime"].ToString();
				}
				if(row["Mac"]!=null)
				{
					model.Mac=row["Mac"].ToString();
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
			strSql.Append("select UserID,UserName,RealName,RoleID,Phone,Sex,Mail,UserPass,State,DateTime,Mac ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append(" UserID,UserName,RealName,RoleID,Phone,Sex,Mail,UserPass,State,DateTime,Mac ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append("select count(1) FROM UserInfo ");
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
			strSql.Append(")AS Row, T.*  from UserInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

        
         ////<summary>
         ////分页获取数据列表
         ////</summary>
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
            parameters[0].Value = "UserInfo";
            parameters[1].Value = "UserID";
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

