using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using Gymnasium_APP.DAL;

namespace DALFactory
{
    public class SqlFactory : CreatAFactory　// 实体工厂　继承　抽象工厂
    {

        public override IUserInfoDal CreateUserInfoDal()
        {
            return new UserInfoDal();　// 实体工厂创建实体产品
        }

        public override ICardTypeInfoDal CreateCardTypeInfoDal()
        {
            return new CardTypeInfoDal();　// 实体工厂创建实体产品
        }
    }
}
