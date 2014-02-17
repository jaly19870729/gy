using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Gymnasium_APP.Model;
namespace Gymnasium_APP.BLL
{
    //延期信息表
    public partial class ExtensionCardManager
    {

        private readonly Gymnasium_APP.DAL.ExtensionCardDal dal = new Gymnasium_APP.DAL.ExtensionCardDal();
        public ExtensionCardManager()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Gymnasium_APP.Model.ExtensionCard model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Gymnasium_APP.Model.ExtensionCard model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            return dal.Delete(Id);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Gymnasium_APP.Model.ExtensionCard GetModel(int Id)
        {

            return dal.GetModel(Id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Gymnasium_APP.Model.ExtensionCard> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Gymnasium_APP.Model.ExtensionCard> DataTableToList(DataTable dt)
        {
            List<Gymnasium_APP.Model.ExtensionCard> modelList = new List<Gymnasium_APP.Model.ExtensionCard>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Gymnasium_APP.Model.ExtensionCard model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Gymnasium_APP.Model.ExtensionCard();
                    if (dt.Rows[n]["Id"].ToString() != "")
                    {
                        model.Id = int.Parse(dt.Rows[n]["Id"].ToString());
                    }
                    if (dt.Rows[n]["MemberId"].ToString() != "")
                    {
                        model.MemberId = int.Parse(dt.Rows[n]["MemberId"].ToString());
                    }
                    if (dt.Rows[n]["ExtensionStartTm"].ToString() != "")
                    {
                        model.ExtensionStartTm = DateTime.Parse(dt.Rows[n]["ExtensionStartTm"].ToString());
                    }
                    if (dt.Rows[n]["ExtensionEndTm"].ToString() != "")
                    {
                        model.ExtensionEndTm = DateTime.Parse(dt.Rows[n]["ExtensionEndTm"].ToString());
                    }
                    if (dt.Rows[n]["CreateTime"].ToString() != "")
                    {
                        model.CreateTime = DateTime.Parse(dt.Rows[n]["CreateTime"].ToString());
                    }


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion

    }
}