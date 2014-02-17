using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace Gymnasium_APP.Model
{
    //延期信息表
    public class ExtensionCard
    {

        /// <summary>
        /// Id
        /// </summary>		
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 会员ID
        /// </summary>		
        private int _memberid;
        public int MemberId
        {
            get { return _memberid; }
            set { _memberid = value; }
        }
        /// <summary>
        /// 延期开始时间
        /// </summary>		
        private DateTime _extensionstarttm;
        public DateTime ExtensionStartTm
        {
            get { return _extensionstarttm; }
            set { _extensionstarttm = value; }
        }
        /// <summary>
        /// 延期结束时间
        /// </summary>		
        private DateTime _extensionendtm;
        public DateTime ExtensionEndTm
        {
            get { return _extensionendtm; }
            set { _extensionendtm = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        private DateTime _createtime;
        public DateTime CreateTime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }

    }
}