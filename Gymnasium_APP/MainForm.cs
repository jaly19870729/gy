using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gymnasium_APP.BLL;
using Gymnasium_APP.MemberForm;
using Model;
using Gymnasium_APP.Model;
using Gymnasium_APP.RoleForm;
using Gymnasium_APP.UserInfoForm;
using Gymnasium_APP.CardType;
using Gymnasium_APP.SellCard;
using Gymnasium_APP.ExtensionFrom;
using Gymnasium_APP.LossFrom;
using Gymnasium_APP.BackCardFrom;
using Gymnasium_APP.CunsumeFrom;
using Gymnasium_APP.SwipeCardFrom;

namespace Gymnasium_APP
{
    public partial class MainForm : Form
    {
        #region 构造
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
            notifyIcon1.Visible = true;
            string titleStr = AppConfigTools.GetAppValue("SystemName");
            this.Text = titleStr + "";
            label1.Text = AppConfigTools.GetAppValue("SystemName");
            tabc_SystemManager.Visible = false;
        }
        #endregion

        private MemberInfoManager memberInfoManager=new MemberInfoManager();

        public static string userName = string.Empty;
        private void MainForm_Load(object sender, EventArgs e)
        {
            uC_Page_SystemLog.OnPageChanged += new EventHandler(uC_Page_SystemLog_OnPageChanged);
            uC_Page_RoleManager.OnPageChanged += new EventHandler(uC_Page_RoleManager_OnPageChanged);
            uC_Page_CardTypeManager.OnPageChanged += new EventHandler(uC_Page_CardType_OnPageChanged);
            uC_Page_Statistics_Member.OnPageChanged += new EventHandler(uC_Page_Statistics_Member_OnPageChanged);
            uC_Page_Main_Member.OnPageChanged += new EventHandler(uC_Page_Main_Member_OnPageChanged);
            uC_Page_Main_SellCast.OnPageChanged += new EventHandler(uC_Page_Main_SellCast_OnPageChanged);
            tabc_SystemManager.Visible = false;
            tabc_Mian.Visible = true;
            tbc_Statistics.Visible = false;
            userName = lbl_login_name.Text.Trim().Split(':')[1];
            btn_MainPage_Click(sender, e);
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon1.Dispose();
        }

        #region 退出

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确认要退出系统吗?", "提示", MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.notifyIcon1.Dispose();
                Application.Exit();
            }
        }

        #endregion

        #region 系统管理
        private void btn_SystemManager_Click(object sender, EventArgs e)
        {
           // tabc_SystemManager.Location = pl_Mind.Location;
            tabc_SystemManager.Visible = true;
            tabc_Mian.Visible = false;
            tbc_Statistics.Visible = false;
            ////int tabCount = tabControl1.TabCount;
            ////MessageBox.Show(tabCount.ToString());
            //tp_MemberManager.Parent = null;
            //tp_ConsumeManager.Parent = null;
            //tp_AreaManager.Parent = null;
            //tp_UserManager.Parent = this.tabc_SystemManager;
            //tp_PrivilegeManager.Parent = this.tabc_SystemManager;//权限
            //tp_RoleManager.Parent = this.tabc_SystemManager;//角色管理
            //tp_SystemLog.Parent = this.tabc_SystemManager;//系统日志

            GetUserInfoDataList();

        }
        #endregion

        #region 首页
        private void tabc_Mian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabc_Mian.SelectedIndex == 1)
            {
                
                GetMainCellCastList();
            }
            if (tabc_Mian.SelectedIndex == 0)
            {
                GetMain_MemberList();
            }
        }
        #region 会员刷卡信息
        private void btn_MainPage_Click(object sender, EventArgs e)
        { 
            tabc_Mian.Visible = true;
            tabc_SystemManager.Visible = false;
            tbc_Statistics.Visible = false;
            
            GetMain_MemberList();
        }

   
        private SwipingInfoManager swipManager = new SwipingInfoManager();

        private string Main_MemberNamager_TiaoJian = " 1=1 and AddTime like '%" + CommTools.GetDateFormatStrot(DateTime.Now)+ "%'";
        private void GetMain_MemberList()
        {
            this.dgv_Main_Member_Manager.Rows.Clear();
            uC_Page_Main_Member.tp.DataTotalCount = swipManager.GetRecordCount(Main_MemberNamager_TiaoJian);
            DataSet ds_List = swipManager.GetList(uC_Page_Main_Member.tp.Count,
                                                                 uC_Page_Main_Member.tp.CurrentPage, Main_MemberNamager_TiaoJian);
            if (ds_List != null && ds_List.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_List.Tables[0].Rows.Count; i++)
                {
                    if (ds_List.Tables[0].Rows[i] != null)
                        this.dgv_Main_Member_Manager.Rows.Add();
                    this.dgv_Main_Member_Manager.Rows[i].Cells["dgv_Main_Member_ID"].Value =
                        (uC_Page_Main_Member.tp.CurrentPage * uC_Page_Main_Member.tp.Count) - uC_Page_Main_Member.tp.Count + i +
                        1; //序号
                    this.dgv_Main_Member_Manager.Rows[i].Cells["dgv_Main_Member_CardID"].Value =
                        ds_List.Tables[0].Rows[i]["CardID"].ToString();
                    this.dgv_Main_Member_Manager.Rows[i].Cells["dgv_Main_Member_MemberName"].Value =
                        ds_List.Tables[0].Rows[i]["Name"].ToString();
                    this.dgv_Main_Member_Manager.Rows[i].Cells["dgv_Main_Member_MemberCardType"].Value =
                     ds_List.Tables[0].Rows[i]["CardType"].ToString();
                    this.dgv_Main_Member_Manager.Rows[i].Cells["dgv_Main_Member_Desc"].Value =
          ds_List.Tables[0].Rows[i]["Desc"].ToString();
                    this.dgv_Main_Member_Manager.Rows[i].Cells["dgv_Main_Member_MemberAddTime"].Value =
         ds_List.Tables[0].Rows[i]["AddTime"].ToString();
                }

            }
            uC_Page_Main_Member.lbl_Count.Text = uC_Page_Main_Member.tp.DataTotalCount.ToString();
            uC_Page_Main_Member.lbl_Page.Text = uC_Page_Main_Member.tp.CurrentPage + "/" +
                                              uC_Page_Main_Member.tp.PageTotalCount + "页";
        }
        void uC_Page_Main_Member_OnPageChanged(object sender, EventArgs e)
        {
            GetMain_MemberList();
        }
        #endregion

        #region 消费信息
        void uC_Page_Main_SellCast_OnPageChanged(object sender, EventArgs e)
        {
            GetMainCellCastList();
        }

        private string Main_SellCast_TiaoJian = " 1=1 and CreateTime like '%" + CommTools.GetDateFormatStrot(DateTime.Now) + "%'";
        private SellCastManager sellCastManager = new SellCastManager();
        private void GetMainCellCastList()
        {
            this.dgv_Main_SellCast_Manager.Rows.Clear();
            uC_Page_Main_SellCast.tp.DataTotalCount = sellCastManager.GetRecordCount(Main_SellCast_TiaoJian);
            DataSet ds_List = sellCastManager.GetList(uC_Page_Main_SellCast.tp.Count,
                                                                 uC_Page_Main_SellCast.tp.CurrentPage, Main_SellCast_TiaoJian);
            if (ds_List != null && ds_List.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_List.Tables[0].Rows.Count; i++)
                {
                    if (ds_List.Tables[0].Rows[i] != null)
                        this.dgv_Main_SellCast_Manager.Rows.Add();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_ID"].Value =
                        (uC_Page_Main_SellCast.tp.CurrentPage * uC_Page_Main_SellCast.tp.Count) - uC_Page_Main_SellCast.tp.Count + i +
                        1; //序号
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_CastID"].Value =
                        ds_List.Tables[0].Rows[i]["CastID"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_TypeName"].Value =
                        ds_List.Tables[0].Rows[i]["TypeName"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_Prices"].Value =
                     ds_List.Tables[0].Rows[i]["Prices"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_Peoples"].Value =
          ds_List.Tables[0].Rows[i]["Peoples"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_PriceAmount"].Value =
         ds_List.Tables[0].Rows[i]["PriceAmount"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_PaymentAmount"].Value =
         ds_List.Tables[0].Rows[i]["PaymentAmount"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_ChangeAmount"].Value =
         ds_List.Tables[0].Rows[i]["ChangeAmount"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_Desc"].Value =
         ds_List.Tables[0].Rows[i]["Des"].ToString();
                    this.dgv_Main_SellCast_Manager.Rows[i].Cells["dgv_Main_SellCast_AddTime"].Value =
ds_List.Tables[0].Rows[i]["CreateTime"].ToString();
                }

            }
            uC_Page_Main_SellCast.lbl_Count.Text = uC_Page_Main_SellCast.tp.DataTotalCount.ToString();
            uC_Page_Main_SellCast.lbl_Page.Text = uC_Page_Main_SellCast.tp.CurrentPage + "/" +
                                              uC_Page_Main_SellCast.tp.PageTotalCount + "页";
        }

       
        #endregion

        #endregion

        #region 用户管理
        private string UserNamager_TiaoJian = " 1=1";
        private TurnPage userManager_tp = new TurnPage();
        private UserInfoManager userManager = new UserInfoManager();
        private void btn_UserManager_Select_Click(object sender, EventArgs e)
        {
            UserNamager_TiaoJian = " 1=1";
            if (txt_UserManager_UserName.Text.Trim() != "")
            {
                UserNamager_TiaoJian += " and UserName like '%" + txt_UserManager_UserName.Text.Trim() + "%'";
            }
            if (cmb_UserManager_State.Text.Trim() != "" && cmb_UserManager_State.Text.Trim() != "全部")
            {
                UserNamager_TiaoJian += " and State = '" + cmb_UserManager_State.Text.Trim() + "'";
            }
            if (cmb_UserManager_Sex.Text.Trim() != "" && cmb_UserManager_Sex.Text.Trim() != "全部")
            {
                UserNamager_TiaoJian += " and Sex = '" + cmb_UserManager_Sex.Text.Trim() + "'";
            }
            userManager_tp.CurrentPage = 1;
            GetUserInfoDataList();
        }
        public void GetUserInfoDataList()
        {
            this.dgv_UserManager.Rows.Clear();
            //用户管理
            userManager_tp.DataTotalCount = userManager.GetRecordCount(UserNamager_TiaoJian);
            DataSet ds_userList = userManager.GetList(userManager_tp.Count, userManager_tp.CurrentPage, UserNamager_TiaoJian);
            if (ds_userList != null && ds_userList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_userList.Tables[0].Rows.Count; i++)
                {
                    if (ds_userList.Tables[0].Rows[i] != null)
                        this.dgv_UserManager.Rows.Add();
                    this.dgv_UserManager.Rows[i].Cells["ID"].Value = (userManager_tp.CurrentPage * userManager_tp.Count) - userManager_tp.Count + i + 1;//序号
                    this.dgv_UserManager.Rows[i].Cells["UserID"].Value = ds_userList.Tables[0].Rows[i]["UserID"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["dgv_UserName"].Value = ds_userList.Tables[0].Rows[i]["UserName"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["RealName"].Value = ds_userList.Tables[0].Rows[i]["RealName"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["RoleID"].Value = ds_userList.Tables[0].Rows[i]["RoleID"].ToString();
                    RoleModel roleModel=roleManager.GetModel(Convert.ToInt32(ds_userList.Tables[0].Rows[i]["RoleID"]));
                    if (roleModel != null)
                    {
                        this.dgv_UserManager.Rows[i].Cells["RoleID"].Value = roleModel.RoleName;
                    }
                    this.dgv_UserManager.Rows[i].Cells["Phone"].Value = ds_userList.Tables[0].Rows[i]["Phone"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["Sex"].Value = ds_userList.Tables[0].Rows[i]["Sex"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["Mail"].Value = ds_userList.Tables[0].Rows[i]["Mail"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["State"].Value = ds_userList.Tables[0].Rows[i]["State"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["dgv_DateTime"].Value = ds_userList.Tables[0].Rows[i]["DateTime"].ToString();
                    this.dgv_UserManager.Rows[i].Cells["Mac"].Value = ds_userList.Tables[0].Rows[i]["Mac"].ToString();
                }
            }
            lblCount.Text = userManager_tp.DataTotalCount.ToString();
            this.lblPage.Text = userManager_tp.CurrentPage + "/" + userManager_tp.PageTotalCount + "页";
        }
        private void btn_UserManager_Add_Click(object sender, EventArgs e)
        {
            AddUserInfoForm auif = new AddUserInfoForm();
            auif.Owner = this;
            auif.ShowDialog();
        }

        private void btn_UserManager_Delete_Click(object sender, EventArgs e)
        {
            string str = this.dgv_UserManager.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确认要删除第" + this.dgv_UserManager.SelectedCells[1].Value.ToString() + "条数据吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {

                    bool isDelete = userManager.Delete(Convert.ToInt32(str));
                    GetUserInfoDataList();
                    MessageBox.Show("      删除数据" + (isDelete == true ? "成功！" : "失败！     "));
                    CommTools.AddSystemLog("删除", "删除用户数据" + (isDelete == true ? "成功！" : "失败！"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
            else
            {
                return;
            }
           
        }

        private void btn_UserManager_Update_Click(object sender, EventArgs e)
        {
            string str = this.dgv_UserManager.SelectedCells[0].Value.ToString();
            UpdateUserInfoForm uuf = new UpdateUserInfoForm(Convert.ToInt32(str));
            uuf.Owner = this;
            uuf.ShowDialog();
        }
        private void cmb_UserManager_page_SelectedIndexChanged(object sender, EventArgs e)
        {
            userManager_tp.Count = Convert.ToInt32(cmb_UserManager_page.Text);
            userManager_tp.CurrentPage = 1;
            GetUserInfoDataList();
        }

        private void linkFirstPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userManager_tp.CurrentPage = userManager_tp.FirstPage;
            GetUserInfoDataList();
        }

        private void linkBeforePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userManager_tp.CurrentPage = userManager_tp.BeforePage;
            GetUserInfoDataList();
        }

        private void linkNextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userManager_tp.CurrentPage = userManager_tp.NextPage;
            GetUserInfoDataList();
        }

        private void linkEndPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userManager_tp.CurrentPage = userManager_tp.EndPage;
            GetUserInfoDataList();
        }
        #endregion

        #region 系统日志
        private SystemLoginLogManager systemLongManager = new SystemLoginLogManager();
        private string SystemLog_TiaoJian = " 1=1";
         private void tp_SystemLog_Click(object sender, EventArgs e)
        {
         
        }

        private void GetSystemLogList()
        {
            this.dgv_SystemLogManager.Rows.Clear();
            uC_Page_SystemLog.tp.DataTotalCount = systemLongManager.GetRecordCount(SystemLog_TiaoJian);
            DataSet ds_SystemLogList = systemLongManager.GetList(uC_Page_SystemLog.tp.Count,
                                                                 uC_Page_SystemLog.tp.CurrentPage, SystemLog_TiaoJian);
            if (ds_SystemLogList != null && ds_SystemLogList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_SystemLogList.Tables[0].Rows.Count; i++)
                {
                    if (ds_SystemLogList.Tables[0].Rows[i] != null)
                        this.dgv_SystemLogManager.Rows.Add();
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_ID"].Value =
                        (uC_Page_SystemLog.tp.CurrentPage*uC_Page_SystemLog.tp.Count) - uC_Page_SystemLog.tp.Count + i +
                        1; //序号
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_UserID"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["UserId"].ToString();
                    UserInfoModel userModel =
                        userManager.GetModel(Convert.ToInt32(ds_SystemLogList.Tables[0].Rows[i]["UserId"]));
                    if (userModel != null)
                    {
                        this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_UserName"].Value = userModel.UserName;
                        this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_RealName"].Value = userModel.RealName;
                    }
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_LoginID"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["LoginLogId"].ToString();
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_LoginIP"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["LoginIP"].ToString();
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_LoginAddress"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["LoginAddress"].ToString();
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_DateTime"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["LoginDate"].ToString();
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_Type"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["LoginType"].ToString();
                    this.dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_Cont"].Value =
                        ds_SystemLogList.Tables[0].Rows[i]["LoginCont"].ToString();
                }

            }
            uC_Page_SystemLog.lbl_Count.Text = uC_Page_SystemLog.tp.DataTotalCount.ToString();
            uC_Page_SystemLog.lbl_Page.Text = uC_Page_SystemLog.tp.CurrentPage + "/" +
                                              uC_Page_SystemLog.tp.PageTotalCount + "页";
        }

        private void uC_Page_SystemLog_OnPageChanged(object sender, EventArgs e)
        {
            GetSystemLogList();
        }
        private void btn_SystemLogManager_Select_Click(object sender, EventArgs e)
        {
            if (dt_SystemLogManager_BeginTime.Value > dt_SystemLogManager_StopTime.Value)
            {
                MessageBox.Show("起始时间不得大于截止时间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dt_SystemLogManager_BeginTime.Value = StartTime;
                return;
            }
            if (dt_SystemLogManager_StopTime.Value < dt_SystemLogManager_BeginTime.Value)
            {
                MessageBox.Show("截止时间不得小于起始时间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dtStopTime.Value = StopTime;
                return;
            }
            SystemLog_TiaoJian = " 1=1";
            if (txt_SystemLogManager_UserName.Text.Trim() != "")
            {
                List<UserInfoModel> userModel_List = userManager.GetModelList(" UserName='" + txt_SystemLogManager_UserName.Text.Trim() + "'");
                if (userModel_List != null && userModel_List.Count > 0)
                {
                    SystemLog_TiaoJian += " and UserId="+userModel_List[0].UserID+"";
                }
            }
            if (cmb_SystemLogManager_State.Text.Trim() != "" && cmb_SystemLogManager_State.Text.Trim() != "全部")
            {
                SystemLog_TiaoJian += " and LoginType='" + cmb_SystemLogManager_State.Text.Trim() + "'";
            }
            SystemLog_TiaoJian += " and (LoginDate > '" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dt_SystemLogManager_BeginTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "' and  LoginDate<'" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dt_SystemLogManager_StopTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "')";
            ///SystemLog_TiaoJian += " order by LoginDate desc";
            uC_Page_SystemLog.tp.CurrentPage = 1;
            GetSystemLogList();
        }
        private void cb_SystemLog_CheckedChanged(object sender, EventArgs e)
        {
            CommTools.CheckBoxSelect(dgv_SystemLogManager,cb_SystemLog);
        }
        private void btn_SystemLogManager_Delete_Click(object sender, EventArgs e)
        {
            int deleteCount = 0;
            for (int i = 0; i < dgv_SystemLogManager.Rows.Count; i++)
            {
                string _selectValue=dgv_SystemLogManager.Rows[i].Cells["cbox"].EditedFormattedValue.ToString();
                if ("True".Equals(_selectValue))
                {
                    //MessageBox.Show(dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_LoginID"].EditedFormattedValue.ToString());
                    deleteCount+= systemLongManager.Delete(Convert.ToInt32(dgv_SystemLogManager.Rows[i].Cells["dgv_SystemLog_LoginID"].EditedFormattedValue))==true?1:0;
                }
            }
            uC_Page_SystemLog.tp.CurrentPage = 1;
            GetSystemLogList();
            //CommTools.AddSystemLog("删除", "成功删除" + deleteCount.ToString() + "条日志数据数据！");
            MessageBox.Show("成功删除"+deleteCount.ToString()+"条数据！");
            cb_SystemLog.Checked = false;
        }
        #endregion

        #region 角色管理
        private string Role_TiaoJian = " 1=1";
        private RoleManager roleManager = new RoleManager();

        public void GetRoleManagerList()
        {
            this.dgv_RoleManager.Rows.Clear();
            uC_Page_RoleManager.tp.DataTotalCount = roleManager.GetRecordCount(Role_TiaoJian);
            DataSet ds_RoleManagerList = roleManager.GetList(uC_Page_RoleManager.tp.Count,
                                                             uC_Page_RoleManager.tp.CurrentPage, Role_TiaoJian);
            if (ds_RoleManagerList != null && ds_RoleManagerList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_RoleManagerList.Tables[0].Rows.Count; i++)
                {
                    if (ds_RoleManagerList.Tables[0].Rows[i] != null)
                        this.dgv_RoleManager.Rows.Add();
                    this.dgv_RoleManager.Rows[i].Cells["dgv_RoleManager_ID"].Value =
                        (uC_Page_RoleManager.tp.CurrentPage*uC_Page_RoleManager.tp.Count) - uC_Page_RoleManager.tp.Count +
                        i + 1; //序号
                    this.dgv_RoleManager.Rows[i].Cells["dgv_RoleManager_RoleId"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["RoleId"].ToString();
                    this.dgv_RoleManager.Rows[i].Cells["dgv_RoleManager_DateTime"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["DataTime"].ToString();
                    this.dgv_RoleManager.Rows[i].Cells["dgv_RoleManager_RoleSynopsis"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["RoleSynopsis"].ToString();
                    this.dgv_RoleManager.Rows[i].Cells["dgv_RoleManager_RoleName"].Value =
                        ds_RoleManagerList.Tables[0].Rows[i]["RoleName"].ToString();
                }

            }
            uC_Page_RoleManager.lbl_Count.Text = uC_Page_RoleManager.tp.DataTotalCount.ToString();
            uC_Page_RoleManager.lbl_Page.Text = uC_Page_RoleManager.tp.CurrentPage + "/" +
                                                uC_Page_RoleManager.tp.PageTotalCount + "页";
        }

        void uC_Page_RoleManager_OnPageChanged(object sender, EventArgs e)
        {
            GetRoleManagerList();
        }

        private void btn_RoleManager_Delete_Click(object sender, EventArgs e)
        {
            string str = this.dgv_RoleManager.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确认要删除第" + this.dgv_RoleManager.SelectedCells[1].Value.ToString() + "条数据吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {
                   
                    bool isDelete=roleManager.Delete(Convert.ToInt32(str));
                    GetRoleManagerList();
                    MessageBox.Show("      删除数据" + (isDelete == true ? "成功！" : "失败！     "));
                    CommTools.AddSystemLog("删除", "删除角色数据" + (isDelete == true ? "成功！" : "失败！"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        private void btn_RoleManager_Add_Click(object sender, EventArgs e)
        {
            AddRoleInfoForm arf = new AddRoleInfoForm();
            arf.Owner = this;
            arf.ShowDialog();
        }

        private void btn_RoleManager_Update_Click(object sender, EventArgs e)
        {
            string str = this.dgv_RoleManager.SelectedCells[0].Value.ToString();
            UpdateRoleInfoForm urf = new UpdateRoleInfoForm(Convert.ToInt32(str));
            urf.Owner = this;
            urf.ShowDialog();
        }
        #endregion

        #region 卡类型管理
        private string CardType_TiaoJian = " 1=1";
        private CardTypeInfoManager cardTypeManager = new CardTypeInfoManager();
        public void GetCardTypeDataList()
        {
            this.dgv_CardTypeManager.Rows.Clear();
            uC_Page_CardTypeManager.tp.DataTotalCount = cardTypeManager.GetRecordCount(CardType_TiaoJian);
            DataSet ds_CardTypeManagerList = cardTypeManager.GetList(uC_Page_CardTypeManager.tp.Count, uC_Page_CardTypeManager.tp.CurrentPage, CardType_TiaoJian);
            if (ds_CardTypeManagerList != null && ds_CardTypeManagerList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_CardTypeManagerList.Tables[0].Rows.Count; i++)
                {
                    if (ds_CardTypeManagerList.Tables[0].Rows[i] != null)
                        this.dgv_CardTypeManager.Rows.Add();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_ID"].Value = (uC_Page_CardTypeManager.tp.CurrentPage * uC_Page_CardTypeManager.tp.Count) - uC_Page_CardTypeManager.tp.Count + i + 1;//序号
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_CardTypeID"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["CardTypeID"].ToString();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_CardTypeName"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["CardTypeName"].ToString();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_MonthsPrice"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["MonthsPrice"].ToString();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_Months"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["Months"].ToString();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_DayPrice"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["DayPrice"].ToString();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_DateTime"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["DateTime"].ToString();
                    this.dgv_CardTypeManager.Rows[i].Cells["dgv_CardTypeManager_TypeName"].Value = ds_CardTypeManagerList.Tables[0].Rows[i]["TypeName"].ToString();
                    
                }
                
            }
            uC_Page_CardTypeManager.lbl_Count.Text = uC_Page_CardTypeManager.tp.DataTotalCount.ToString();
            uC_Page_CardTypeManager.lbl_Page.Text = uC_Page_CardTypeManager.tp.CurrentPage + "/" + uC_Page_CardTypeManager.tp.PageTotalCount + "页";
        }
        private void uC_Page_CardType_OnPageChanged(object sender, EventArgs e)
        {
            GetCardTypeDataList();
        }

        private void btn_Delete_CardTypeManager_Click(object sender, EventArgs e)
        {
            string str = this.dgv_CardTypeManager.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确认要删除第" + this.dgv_CardTypeManager.SelectedCells[1].Value.ToString() + "条数据吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {

                    bool isDelete = cardTypeManager.Delete(Convert.ToInt32(str));
                    GetCardTypeDataList();
                    MessageBox.Show("      删除数据" + (isDelete == true ? "成功！" : "失败！     "));
                    CommTools.AddSystemLog("删除", "删除消费型产品信息数据" + (isDelete == true ? "成功！" : "失败！"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        private void btn_Add_CardTypeManager_Click(object sender, EventArgs e)
        {
            AddCardTypeInfoForm actf = new AddCardTypeInfoForm();
            actf.Owner = this;
            actf.ShowDialog();
        }

        private void btn_Update_CardTypeManager_Click(object sender, EventArgs e)
        {
            string str = this.dgv_CardTypeManager.SelectedCells[0].Value.ToString();
            UpdateCardTypeInfoForm uctf = new UpdateCardTypeInfoForm(Convert.ToInt32(str));
            uctf.Owner = this;
            uctf.ShowDialog();

        }
        #endregion
        private void tabc_SystemManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _Index = tabc_SystemManager.SelectedIndex;
            if (tabc_SystemManager.TabPages[_Index].Text.Equals("系统日志"))
            {
                dt_SystemLogManager_StopTime.Text = System.DateTime.Now.AddHours(1).ToString();
                GetSystemLogList();

            }
            if (tabc_SystemManager.TabPages[_Index].Text.Equals("角色管理"))
            {
                GetRoleManagerList();
            }
            if (tabc_SystemManager.TabPages[_Index].Text.Equals("消费型产品理"))
            {
                GetCardTypeDataList();
            }
        }

        #region 售卡
        private void btn_Sell_Click(object sender, EventArgs e)
        {
            AddAndUpdateSellCardForm sellCardForm = new AddAndUpdateSellCardForm("ADD", MemberBusinessType.SellCardType);
            sellCardForm.SetBusinessType(MemberBusinessType.SellCardType);
            sellCardForm.Owner = this;
            sellCardForm.Show();
            //MemberEditFrm memberEditFrm=new MemberEditFrm();
            //memberEditFrm.SetTitle("售卡");
            //memberEditFrm.SetBusinessType(MemberBusinessType.SellCardType);
            //memberEditFrm.Owner = this;
            //memberEditFrm.Show();
        }
        #endregion

        #region 统计
        private void btn_Statistics_Member_Delete_Click(object sender, EventArgs e)
        {
            string str = this.dgv_Statistics_MemberManager.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确认要删除第" + this.dgv_Statistics_MemberManager.SelectedCells[1].Value.ToString() + "条数据吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {

                    bool isDelete = memberManager.Delete(Convert.ToInt32(str));
                    GetStatisticsMemberList();
                    MessageBox.Show("      删除数据" + (isDelete == true ? "成功！" : "失败！     "));
                    CommTools.AddSystemLog("删除", "删除会员信息数据" + (isDelete == true ? "成功！" : "失败！"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        private void btn_Statistics_Member_Select_Click(object sender, EventArgs e)
        {
            if (dtp_Statistics_Member_StartTime.Value > dtp__Statistics_Member_EndTime.Value)
            {
                MessageBox.Show("起始时间不得大于截止时间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dt_SystemLogManager_BeginTime.Value = StartTime;
                return;
            }
            if (dtp__Statistics_Member_EndTime.Value < dtp_Statistics_Member_StartTime.Value)
            {
                MessageBox.Show("截止时间不得小于起始时间！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dtStopTime.Value = StopTime;
                return;
            }
            MemberNamager_TiaoJian = " 1=1";

            if (txt_Statistics_Member_Name.Text.Trim() != "")
            {

                MemberNamager_TiaoJian += " and (CardID  like '%" + txt_Statistics_Member_Name.Text.Trim() + "%' or Name like '%" + txt_Statistics_Member_Name.Text.Trim() + "%' or Phone like '%" + txt_Statistics_Member_Name.Text.Trim() + "%' )";
                
            }

            if (cmb_Statistics_Member_Type.Text.Trim() != "" && cmb_Statistics_Member_Type.Text.Trim() != "全部")
            {
                MemberNamager_TiaoJian += " and CardType='" + cmb_Statistics_Member_Type.Text.Trim() + "'";
            }
            MemberNamager_TiaoJian += " and (AddTime > '" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp_Statistics_Member_StartTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "' and  AddTime<'" + CommTools.GetDateFormatStrot2(Convert.ToDateTime(dtp__Statistics_Member_EndTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))) + "')";
            uC_Page_Statistics_Member.tp.CurrentPage = 1;
            GetStatisticsMemberList();
        }
      
        private void btn_Statistics_Member_Update_Click(object sender, EventArgs e)
        {

        }
        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            tbc_Statistics.Visible = true;
            tabc_Mian.Visible = false;
            tabc_SystemManager.Visible = false;
            dtp_Statistics_Member_StartTime.Text = DateTime.Now.AddDays(-1).ToString();
            GetStatisticsMemberList();
            List<CardTypeInfoModel> cardTypeInfoList = cardTypeManager.GetModelList(" 1=1");
            if (cardTypeInfoList != null)
            {
                CardTypeInfoModel model = new CardTypeInfoModel();
                model.CardTypeName = "全部";
                model.CardTypeID = 0;
                cardTypeInfoList.Add(model);

                cmb_Statistics_Member_Type.DataSource = cardTypeInfoList;
                cmb_Statistics_Member_Type.DisplayMember = "CardTypeName";
                cmb_Statistics_Member_Type.ValueMember = "CardTypeID";
                cmb_Statistics_Member_Type.SelectedIndex = 0;
            }
            cmb_Statistics_Member_Type.SelectedIndex = cardTypeInfoList.Count-1;
            
        }

        #region 会员管理
        private string MemberNamager_TiaoJian = " 1=1";
        private MemberInfoManager memberManager = new MemberInfoManager();
        private void GetStatisticsMemberList()
        {
            this.dgv_Statistics_MemberManager.Rows.Clear();
            uC_Page_Statistics_Member.tp.DataTotalCount = memberManager.GetRecordCount(MemberNamager_TiaoJian);
            DataSet ds_StatisticsMemberList = memberManager.GetList(uC_Page_Statistics_Member.tp.Count,
                                                                 uC_Page_Statistics_Member.tp.CurrentPage, MemberNamager_TiaoJian);
            if (ds_StatisticsMemberList != null && ds_StatisticsMemberList.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds_StatisticsMemberList.Tables[0].Rows.Count; i++)
                {
                    if (ds_StatisticsMemberList.Tables[0].Rows[i] != null)
                        this.dgv_Statistics_MemberManager.Rows.Add();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_ID"].Value =
                        (uC_Page_Statistics_Member.tp.CurrentPage * uC_Page_Statistics_Member.tp.Count) - uC_Page_Statistics_Member.tp.Count + i +
                        1; //序号
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberID"].Value =
                        ds_StatisticsMemberList.Tables[0].Rows[i]["MemberID"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_CardID"].Value =
                  ds_StatisticsMemberList.Tables[0].Rows[i]["CardID"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberName"].Value =
                        ds_StatisticsMemberList.Tables[0].Rows[i]["Name"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberPhone"].Value =
                       ds_StatisticsMemberList.Tables[0].Rows[i]["Phone"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberSex"].Value =
                       ds_StatisticsMemberList.Tables[0].Rows[i]["Sex"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberCardType"].Value =
                     ds_StatisticsMemberList.Tables[0].Rows[i]["CardType"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberStartTime"].Value =
                  ds_StatisticsMemberList.Tables[0].Rows[i]["StartTime"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberEndTime"].Value =
               ds_StatisticsMemberList.Tables[0].Rows[i]["EndTime"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberCount"].Value =
               ds_StatisticsMemberList.Tables[0].Rows[i]["Count"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberAddUserName"].Value =
          ds_StatisticsMemberList.Tables[0].Rows[i]["AddUserName"].ToString();
                    this.dgv_Statistics_MemberManager.Rows[i].Cells["dgv_StatisticsMember_MemberAddTime"].Value =
         ds_StatisticsMemberList.Tables[0].Rows[i]["AddTime"].ToString();
                }

            }
            uC_Page_Statistics_Member.lbl_Count.Text = uC_Page_Statistics_Member.tp.DataTotalCount.ToString();
            uC_Page_Statistics_Member.lbl_Page.Text = uC_Page_Statistics_Member.tp.CurrentPage + "/" +
                                              uC_Page_Statistics_Member.tp.PageTotalCount + "页";
        }
        void uC_Page_Statistics_Member_OnPageChanged(object sender, EventArgs e)
        {
            GetStatisticsMemberList();
        }
        #endregion

        private void btn_Statistics_Member_Add_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region 续卡
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            AddAndUpdateSellCardForm sellCardForm = new AddAndUpdateSellCardForm("CONTINUED", MemberBusinessType.ContinuedCardType);
            sellCardForm.SetBusinessType(MemberBusinessType.ContinuedCardType);
            sellCardForm.Owner = this;
            sellCardForm.Show();

        }
        #endregion

        #region 延期

        private void btn_Postpone_Click(object sender, EventArgs e)
        {

            new ExtensionDialog().Show();
        }
        #endregion

        #region 挂失
        private void btn_Lose_Click(object sender, EventArgs e)
        {
            new LossFrm().Show();
        }
        #endregion

        #region 退卡
        private void btn_Return_Click(object sender, EventArgs e)
        {
            new BackCardDg().Show();
        }
        #endregion 

        #region 读卡
        private void btn_Read_Click(object sender, EventArgs e)
        {
            new MemberEditFrm().Show();
        }
        #endregion

        #region 消费
        private void btn_Consume_Click(object sender, EventArgs e)
        {
            new CunsumeFrm().Show();
        }
        #endregion


        #region 刷卡
        private void btn_Swiping_Click(object sender, EventArgs e)
        {
            new SwipeCardFrm().Show();
        }
        #endregion

        private void dgv_Main_Member_Manager_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object id = this.dgv_Main_Member_Manager.Rows[e.RowIndex].Cells["dgv_Main_Member_CardID"].Value;
            
            DataSet dataSet=memberInfoManager.GetList("CardID='"+id+"'");
            AddAndUpdateSellCardForm addAndUpdateSellCardForm = new AddAndUpdateSellCardForm("查看会员详情", MemberBusinessType.SellCardType);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count>0)
            {
                MemberInfoModel memberInfoModel=memberInfoManager.GetModel(Convert.ToInt32(dataSet.Tables[0].Rows[0]["MemberID"].ToString()));
                addAndUpdateSellCardForm.DetialModel(memberInfoModel);
                addAndUpdateSellCardForm.Show();
            }
            

        }

        private void dgv_Statistics_MemberManager_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object id = this.dgv_Statistics_MemberManager.Rows[e.RowIndex].Cells["dgv_StatisticsMember_CardID"].Value;

            DataSet dataSet = memberInfoManager.GetList("CardID='" + id + "'");
            AddAndUpdateSellCardForm addAndUpdateSellCardForm = new AddAndUpdateSellCardForm("查看会员详情", MemberBusinessType.ContinuedCardType);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                MemberInfoModel memberInfoModel = memberInfoManager.GetModel(Convert.ToInt32(dataSet.Tables[0].Rows[0]["MemberID"].ToString()));
                addAndUpdateSellCardForm.DetialModel(memberInfoModel);
                addAndUpdateSellCardForm.Show();
            }
        }

     

       

    

       

      

    }
}
