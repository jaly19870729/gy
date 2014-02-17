using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using DAL;
namespace Gymnasium_APP.DAL
{
    //延期信息表
    public partial class ExtensionCardDal
    {

        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ExtensionCard");
            strSql.Append(" where ");
            strSql.Append(" Id = @Id  ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Gymnasium_APP.Model.ExtensionCard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ExtensionCard(");
            strSql.Append("MemberId,ExtensionStartTm,ExtensionEndTm,CreateTime");
            strSql.Append(") values (");
            strSql.Append("@MemberId,@ExtensionStartTm,@ExtensionEndTm,@CreateTime");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@MemberId", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExtensionStartTm", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExtensionEndTm", SqlDbType.DateTime) ,            
                        new SqlParameter("@CreateTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.MemberId;
            parameters[1].Value = model.ExtensionStartTm;
            parameters[2].Value = model.ExtensionEndTm;
            parameters[3].Value = model.CreateTime;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Gymnasium_APP.Model.ExtensionCard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ExtensionCard set ");

            strSql.Append(" MemberId = @MemberId , ");
            strSql.Append(" ExtensionStartTm = @ExtensionStartTm , ");
            strSql.Append(" ExtensionEndTm = @ExtensionEndTm , ");
            strSql.Append(" CreateTime = @CreateTime  ");
            strSql.Append(" where Id=@Id ");

            SqlParameter[] parameters = {
			            new SqlParameter("@Id", SqlDbType.Int,4) ,            
                        new SqlParameter("@MemberId", SqlDbType.Int,4) ,            
                        new SqlParameter("@ExtensionStartTm", SqlDbType.DateTime) ,            
                        new SqlParameter("@ExtensionEndTm", SqlDbType.DateTime) ,            
                        new SqlParameter("@CreateTime", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.Id;
            parameters[1].Value = model.MemberId;
            parameters[2].Value = model.ExtensionStartTm;
            parameters[3].Value = model.ExtensionEndTm;
            parameters[4].Value = model.CreateTime;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExtensionCard ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ExtensionCard ");
            strSql.Append(" where ID in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Gymnasium_APP.Model.ExtensionCard GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id, MemberId, ExtensionStartTm, ExtensionEndTm, CreateTime  ");
            strSql.Append("  from ExtensionCard ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;


            Gymnasium_APP.Model.ExtensionCard model = new Gymnasium_APP.Model.ExtensionCard();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MemberId"].ToString() != "")
                {
                    model.MemberId = int.Parse(ds.Tables[0].Rows[0]["MemberId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExtensionStartTm"].ToString() != "")
                {
                    model.ExtensionStartTm = DateTime.Parse(ds.Tables[0].Rows[0]["ExtensionStartTm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExtensionEndTm"].ToString() != "")
                {
                    model.ExtensionEndTm = DateTime.Parse(ds.Tables[0].Rows[0]["ExtensionEndTm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ExtensionCard ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM ExtensionCard ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

