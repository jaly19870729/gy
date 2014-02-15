using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using IDAL;

namespace DALFactory
{
    public abstract class CreatAFactory // 抽象工厂
    {
        private static readonly string type = ConfigurationManager.AppSettings["DBType"];
        private static CreatAFactory aFactory;
        public static CreatAFactory CreateFactory()
        {
            switch (type.ToLower())
            {
                case "access":
                    //aFactory = new AccessFactory();
                    break;
                case "sql":
                    aFactory = new SqlFactory();
                    break;
                default :
                    aFactory = null;
                    break;
            }
            return aFactory;
        }
        public abstract IUserInfoDal CreateUserInfoDal();　 // 抽象工厂创建抽象产品

        public abstract ICardTypeInfoDal CreateCardTypeInfoDal();　 // 抽象工厂创建抽象产品
    }
}
