using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /*分页的辅助类*/
    public class TurnPage
    {
        public TurnPage() { }

        public TurnPage(int currentPage)
        {
            this.currentPage = currentPage;
        }

        public TurnPage(int currentPage, int count)
        {
            this.currentPage = currentPage;
            this.count = count;
        }

        public TurnPage(int currentPage, int nextPage,
            int beforePage, int firstPage, int endPage, int dataTotalCount, int pageTotalCount, int count)
        {
            this.currentPage = currentPage;
            this.nextPage = nextPage;
            this.beforePage = beforePage;
            this.endPage = endPage;
            this.dataTotalCount = dataTotalCount;
            this.pageTotalCount = pageTotalCount;
            this.count = count;
        }

        private int currentPage = 1;// 当前页数

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }
        private int nextPage; //下一页


        public int NextPage
        {
            get
            {
                if (currentPage == pageTotalCount)
                {
                    nextPage = pageTotalCount; //如果当前页是最后一页
                }
                else
                {
                    nextPage = currentPage + 1;//如果当前页不是最后一页
                }
                currentPage = nextPage;
                return nextPage;
            }
            set { nextPage = value; }
        }
        private int beforePage; //上一页

        public int BeforePage
        {
            get
            {
                if (CurrentPage > 1)
                {
                    beforePage = CurrentPage - 1; //如果当前页不是第一页
                }
                else
                {
                    beforePage = CurrentPage; //如果当前页是第一页
                }
                return beforePage;
            }
            set { beforePage = value; }
        }
        private int firstPage = 1;  //首页

        public int FirstPage
        {
            get { return firstPage; }
            set { firstPage = value; }
        }
        private int endPage;//尾页

        public int EndPage
        {
            get { return pageTotalCount == 0 ? 1 : pageTotalCount; }
            set { endPage = value; }
        }
        private int dataTotalCount;//数据总数

        public int DataTotalCount
        {
            get { return dataTotalCount; }
            set { dataTotalCount = value; }
        }
        private int pageTotalCount;//分页总页数

        public int PageTotalCount
        {
            get
            {
                if (dataTotalCount != 0)
                {
                    if (dataTotalCount % count == 0)
                    {
                        pageTotalCount = dataTotalCount / count;
                    }
                    else
                    {
                        pageTotalCount = dataTotalCount / count + 1;
                    }
                }
                else
                {
                    pageTotalCount = 1;
                }
                return pageTotalCount;
            }
            set { pageTotalCount = value; }
        }
        private int count = 20; //每页显示多少条

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string sql;

        public string Sql
        {
            get { return sql; }
            set { sql = value; }
        }

        //首页是否可用
        private bool firstPageState;

        public bool FirstPageState
        {
            get
            {
                if (this.CurrentPage == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            set { firstPageState = value; }
        }

        //上一页是否可用
        private bool boforePageState;

        public bool BoforePageState
        {
            get
            {
                if (this.CurrentPage > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { boforePageState = value; }
        }
        //下一页是否可用
        private bool nextPageState;

        public bool NextPageState
        {
            get
            {
                if (this.CurrentPage < this.PageTotalCount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { nextPageState = value; }
        }
        //尾页是否可用
        private bool endPageState;

        public bool EndPageState
        {
            get
            {
                if (this.CurrentPage < this.PageTotalCount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set { endPageState = value; }
        }
    }
}
