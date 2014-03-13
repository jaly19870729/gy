using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.Runtime.InteropServices;
using System.Management;
using Gymnasium_APP.BLL;
using Gymnasium_APP.Model;
using System.Security.Cryptography;
using System.Web.Security;
using Gymnasium_APP.Config;
namespace Gymnasium_APP
{
    public partial class LoginForm : Form
    {
        //下面一种方法可以获取远程的MAC地址
        [DllImport("Iphlpapi.dll")]
        static extern int SendARP(Int32 DestIP, Int32 SrcIP, ref Int64 MacAddr, ref Int32 PhyAddrLen);
        [DllImport("Ws2_32.dll")]
        static extern Int32 inet_addr(string ipaddr); 
        public int CurSkinIndex = 0;
        
        public LoginForm()
        {
            
            InitializeComponent();
            skinEngine1.ApplyAdditionalBuiltInSkins(Convert.ToInt32(AppConfigTools.GetAppValue("CurSkinIndex")));
            this.notifyIcon1.Visible = true;
            label1.Text = AppConfigTools.GetAppValue("SystemName");
            this.Text = label1.Text + "";
            MainForm.CusType = AppConfigTools.GetAppValue("CusType");
            txt_username.Focus();
            AppConfig.CardNumberRegex = @"^\w{" + AppConfigTools.GetAppValue("CardLength") + "}$"; ;
            AppConfig.CardNumberRegexError = "卡号为" + AppConfigTools.GetAppValue("CardLength") + "位数字";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (CurSkinIndex > 15)
            {
                CurSkinIndex = 0;
            }
            if (CurSkinIndex == 15)
            {
                skinEngine1.Active = false;
            }
            else
            {
                skinEngine1.ApplyAdditionalBuiltInSkins(CurSkinIndex);
                if (skinEngine1.Active == false)
                    skinEngine1.Active = true;
            }
            AppConfigTools.SetAppValue("CurSkinIndex", CurSkinIndex.ToString());
            CurSkinIndex++;
        }
        SystemLoginLogManager systemLoginLogManager = new SystemLoginLogManager();
        SystemLoginLogModel systemLoginLogModel = new SystemLoginLogModel();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //获取Mac
            GetMacByIP();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region 获取状态
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            const int SC_MINIMIZE = 0xF020;
            //const int SC_MAXIMIZE = 0xF030;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                // User clicked close button
                Application.Exit();
                return;
            }
            if (m.WParam.ToInt32() == SC_MINIMIZE)
            {
                this.Visible = false;
                return;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region 登录
        public static string logion_TrueName = string.Empty;
        private void GetLogin()
        {
            if (DateTime.Now > Convert.ToDateTime("2014-03-20"))
            {
                return;
            }
            this.progressBar1.Visible = true ;
            if (txt_pwd.Text.Trim() == "" || txt_username.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_pwd, "请输入用户名或密码！");
                return;
            }
            errorProvider1.Clear();
            UserInfoManager userManager = new UserInfoManager();
            List<UserInfoModel> userModel_List = userManager.GetModelList(" UserName='" + txt_username.Text.Trim() + "'");
            CommTools.RunBar(this.progressBar1, 20, 30);
            if (userModel_List!=null&&userModel_List.Count > 0)
            {
                UserInfoModel userModel = userModel_List[0];
                CommTools.UserID = userModel.UserID;
                string passMd5_ = FormsAuthentication.HashPasswordForStoringInConfigFile(this.txt_pwd.Text.Trim(), "MD5");
                if (!userModel.UserPass.Equals(passMd5_))
                {
                    errorProvider1.SetError(txt_pwd, "用户名或密码错误！");
                    this.progressBar1.Visible = false;
                    return;
                }
                if (!"正常".Equals(userModel.State))
                {
                    errorProvider1.SetError(txt_pwd, "用户状态未开启！");
                    this.progressBar1.Visible = false;
                    return;
                }
                CommTools.RunBar(this.progressBar1, 30, 40);
                logion_TrueName=userModel.RealName;
                int count = 0;
                string[] macStr = userModel.Mac.Split(',');
                if (macStr.Length > 0)
                {
                    for (int i = 0; i < macStr.Length; i++)
                    {
                        foreach (var item in dic_mac)
                        {
                            if (macStr[i].Equals(item.Value))
                            {
                                count += 1;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        this.progressBar1.Visible = false;
                        errorProvider1.SetError(txt_pwd, "抱歉你现在使用的机器未注册，请联系管理员！该账户注册的机器Mac：" + userModel.Mac);
                        //return;
                    }
                }
                systemLoginLogModel.LoginLogId = systemLoginLogManager.GetMaxId();
                systemLoginLogModel.LoginIP = LoginIp;
                systemLoginLogModel.LoginAddress = LoginMac;
                systemLoginLogModel.UserId = userModel.UserID;
                systemLoginLogModel.LoginType = "登录";
                systemLoginLogModel.LoginCont = txt_username.Text.Trim() + " 登录系统";
                systemLoginLogModel.LoginDate = CommTools.GetDateFormatStrot2(DateTime.Now);
                systemLoginLogManager.Add(systemLoginLogModel);
                CommTools.RunBar(this.progressBar1,40, 50);
            }
            else
            {
                errorProvider1.SetError(txt_pwd, "用户名或密码错误！");
                this.progressBar1.Visible = false;
                return;
            }
            this.progressBar1.Visible = false;
            this.Hide();
            errorProvider1.Clear();
            this.notifyIcon1.Dispose();
            MainForm mf = new MainForm();
            mf.lbl_login_name.Text = "用户名:" + logion_TrueName;
            mf.Show();
          
        }
        #endregion

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            GetLogin();
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确认要退出系统吗?", "提示", MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.notifyIcon1.Dispose();
                Application.Exit();
            }
        }
        #region 获取Mac

        /// <summary>
        /// SendArp获取MAC地址
        /// </summary>
        /// <param name="RemoteIP">目标机器的IP地址如(192.168.1.1)</param>
        /// <returns>目标机器的mac 地址</returns>
        public static string getMacAddr_Remote(string RemoteIP)
        {
            StringBuilder macAddress = new StringBuilder();
            try
            {
                Int32 remote = inet_addr(RemoteIP);
                Int64 macInfo = new Int64();
                Int32 length = 6;
                SendARP(remote, 0, ref macInfo, ref length);
                string temp = Convert.ToString(macInfo, 16).PadLeft(12, '0').ToUpper();
                int x = 12;
                for (int i = 0; i < 6; i++)
                {
                    if (i == 5)
                    {
                        macAddress.Append(temp.Substring(x - 2, 2));
                    }
                    else
                    {
                        macAddress.Append(temp.Substring(x - 2, 2) + "-");
                    }
                    x -= 2;
                }
                return macAddress.ToString();
            }
            catch
            {
                return macAddress.ToString();
            }
        }
        Dictionary<string, string> dic_mac = new Dictionary<string, string>();
        private string LoginIp = string.Empty;
        private string LoginMac = string.Empty;
        private void GetMacByIP()
        {
            string s = "", mac = "";
            string hostInfo = Dns.GetHostName();
            System.Net.IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            for (int i = 0; i < addressList.Length; i++)
            {
                s += addressList[i].ToString() + ",";
            }
            string[] ipStrings = s.Split(',');
            
            for (int i = 0; i < ipStrings.Length; i++)
            {
                if (ipStrings[i].Length > 0)
                {
                    mac = getMacAddr_Remote(ipStrings[i]);
                    dic_mac.Add(ipStrings[i], mac);
                }
            }
            label2.Text = string.Empty;
            foreach (var item in dic_mac)
            {
                label2.Text += "Mac:" + item.Value + " ";
                LoginIp +="IP:" + item.Key  + " ";
                LoginMac += "Mac:" + item.Value + " ";
            }
        }
        #endregion
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon1.Dispose();
        }

        private void txt_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetLogin();
            }
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

   
    }
}
