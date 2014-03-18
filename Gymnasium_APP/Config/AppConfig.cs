using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Gymnasium_APP.Config
{
    /// <summary>
    /// 程序配置
    /// </summary>
    public static class AppConfig
    {
        #region 验证模块
        /// <summary>
        /// 卡号验证
        /// </summary>
        public static String CardNumberRegex = @"^\w{8}$";
        /// <summary>
        /// 卡号验证错误信息
        /// </summary>
        public static String CardNumberRegexError = "卡号为8位数字";
        /// <summary>
        /// 身份证验证15
        /// </summary>
        private static String IDCardNumber15Regex = @"^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$";
        /// <summary>
        /// 身份证验证18
        /// </summary>
        private static String IDCardNumber18Regex = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{4}$";
        /// <summary>
        /// 身份证验证失败信息
        /// </summary>
        public static String IDCardNumberRegexError = "身份证号为15或18位";
        /// <summary>
        /// 手机验证
        /// </summary>
        private static String CellPhoneRegex = @"^(1(([35][0-9])|(47)|[8][01236789]))\d{8}$";
        /// <summary>
        /// 座机验证
        /// </summary>
        private static String TelePhoneRegex = @"^0\d{2,3}(\-)?\d{7,8}$";
        /// <summary>
        /// 电话号码验证失败错误信息
        /// </summary>
        public static String PhoneRegexError = "电话号码输入失败";
        /// <summary>
        /// 金额验证错误信息
        /// </summary>
        public static String AmountRegexError = "金额输入错误";
        /// <summary>
        /// 内容信息
        /// </summary>
        public static String ContentError = "不能为空";
        /// <summary>
        /// 数字验证错误信息
        /// </summary>
        public static String IntRegexError = "请输入数字";
        /// <summary>
        /// 名称验证
        /// </summary>
        public static String NameRegex = @"^[^\s]*$";
        /// <summary>
        /// 姓名验证
        /// </summary>
        private static String XingMingRegex = @"^[\u4e00-\u9fa5]{1,10}[·.]{0,1}[\u4e00-\u9fa5]{1,10}$";
        /// <summary>
        /// 姓名验证错误信息
        /// </summary>
        public static String XingMingError = "姓名输入错误";
        /// <summary>
        /// 学生卡号验证错误
        /// </summary>
        public static String StudentRegexError = "学生卡输入错误";
        /// <summary>
        /// 教师卡验证错误
        /// </summary>
        public static string TeacherRegexError = "教师卡输入错误";
        /// <summary>
        /// 验证姓名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool ValidateName(string name)
        {
            Regex regex = new Regex(NameRegex);
            return regex.IsMatch(name);
        }
        /// <summary>
        /// 验证姓名
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool ValidateXingMing(string name)
        {
            Regex regex=new Regex(XingMingRegex);
            return regex.IsMatch(name);
        }
        /// <summary>
        /// 验证卡号
        /// </summary>
        /// <param name="carNumber"></param>
        /// <returns></returns>
        public static bool ValidateCardNumber(string carNumber)
        {
            //bool istrue = true;
            //if (carNumber.Length != 8)
            //{
            //    istrue = false;
            //}
            //try
            //{
            //    Convert.ToInt64(carNumber);
            //}
            //catch (Exception)
            //{
            //    istrue = false;
            //    return istrue;
            //}
            //return istrue;
            Regex regex = new Regex(CardNumberRegex);
            return regex.IsMatch(carNumber);
        }
        /// <summary>
        /// 验证金额
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool ValidateAmount(String amount)
        {
            decimal tmp = 0;
            return decimal.TryParse(amount, out tmp);
        }
        /// <summary>
        /// 验证数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ValidateInt(String str)
        {
            int tmp = 0;
            return int.TryParse(str, out tmp);
        }
        /// <summary>
        /// 验证身份证
        /// </summary>
        /// <param name="idNumber"></param>
        /// <returns></returns>
        public static bool ValidateID(String idNumber)
        {
            Regex regex1=new Regex(IDCardNumber15Regex);
            Regex regex2=new Regex(IDCardNumber18Regex);
            return regex1.IsMatch(idNumber) || regex2.IsMatch(idNumber);
        }
        /// <summary>
        /// 验证手机号码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static bool ValidatePhone(String phone)
        {
            Regex regex1=new Regex(CellPhoneRegex);
            Regex regex2=new Regex(TelePhoneRegex);
            return regex1.IsMatch(phone) || regex2.IsMatch(phone);
        }
        /// <summary>
        /// 验证学生号
        /// todo:验证学生卡号
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static bool ValidateStudentCard(String student)
        {
            return true;
        }
        /// <summary>
        /// todo:验证教师卡号
        /// 
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public static bool ValidateTeacher(String teacher)
        {
            return true;
        }
        #endregion

        #region 初始数据
        /// <summary>
        /// 单次消费金额
        /// </summary>
        public static int CunsumePriceAmount = 10;

        #endregion
    }
}
