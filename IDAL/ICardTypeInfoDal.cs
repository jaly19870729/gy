using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace IDAL
{
    public interface ICardTypeInfoDal
    {
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int CardTypeID);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        bool Add(Gymnasium_APP.Model.CardTypeInfoModel model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(Gymnasium_APP.Model.CardTypeInfoModel model);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int CardTypeID);

        /// <summary>
        /// 批量删除数据
        /// </summary>
        bool DeleteList(string CardTypeIDlist);


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Gymnasium_APP.Model.CardTypeInfoModel GetModel(int CardTypeID);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Gymnasium_APP.Model.CardTypeInfoModel DataRowToModel(DataRow row);

        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);

        /// <summary>
        /// 获取记录总数
        /// </summary>
        int GetRecordCount(string strWhere);
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

        ////<summary>
        ////分页获取数据列表
        ////</summary>
        DataSet GetList(int PageSize, int PageIndex, string strWhere);

        #endregion  Method
    }
}
