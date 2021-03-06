USE [master]
GO
/****** Object:  Database [Gymnasium]    Script Date: 02/18/2014 00:47:34 ******/
CREATE DATABASE [Gymnasium] ON  PRIMARY 
( NAME = N'Gymnasium', FILENAME = N'D:\健身房\20140214\20140214\Gymnasium.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gymnasium_log', FILENAME = N'D:\健身房\20140214\20140214\Gymnasium_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gymnasium] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gymnasium].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gymnasium] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Gymnasium] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Gymnasium] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Gymnasium] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Gymnasium] SET ARITHABORT OFF
GO
ALTER DATABASE [Gymnasium] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Gymnasium] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Gymnasium] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Gymnasium] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Gymnasium] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Gymnasium] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Gymnasium] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Gymnasium] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Gymnasium] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Gymnasium] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Gymnasium] SET  DISABLE_BROKER
GO
ALTER DATABASE [Gymnasium] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Gymnasium] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Gymnasium] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Gymnasium] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Gymnasium] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Gymnasium] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Gymnasium] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Gymnasium] SET  READ_WRITE
GO
ALTER DATABASE [Gymnasium] SET RECOVERY FULL
GO
ALTER DATABASE [Gymnasium] SET  MULTI_USER
GO
ALTER DATABASE [Gymnasium] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Gymnasium] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gymnasium', N'ON'
GO
USE [Gymnasium]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 02/18/2014 00:47:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[RealName] [varchar](50) NULL,
	[RoleID] [int] NULL,
	[Phone] [varchar](50) NULL,
	[Sex] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[UserPass] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[DateTime] [varchar](50) NULL,
	[Mac] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'RealName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID，外键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'Mail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'UserPass'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'机器Mac地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo', @level2type=N'COLUMN',@level2name=N'Mac'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfo'
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON
INSERT [dbo].[UserInfo] ([UserID], [UserName], [RealName], [RoleID], [Phone], [Sex], [Mail], [UserPass], [State], [DateTime], [Mac]) VALUES (1, N'admin', N'赵武男', 1, N'18629075037', N'男', N'Analy@163.com', N'21232F297A57A5A743894A0E4A801FC3', N'正常', N'2014-2-10 21:52:10', N'E0-94-67-05-28-3A,E0-94-67-05-28-3B')
INSERT [dbo].[UserInfo] ([UserID], [UserName], [RealName], [RoleID], [Phone], [Sex], [Mail], [UserPass], [State], [DateTime], [Mac]) VALUES (26, N'jinhao', N'金浩', 1, N'18629075037', N'男', N'327549286@qq.com', N'F74680162ACCD40CEDDF8F272DE8227E', N'正常', N'2014-1-21 15:11:24', N'E0-94-67-05-28-3A')
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
/****** Object:  StoredProcedure [dbo].[UP_GetRecordByPage]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GetRecordByPage]
    @tblName      varchar(255),       -- 表名
    @fldName      varchar(255),       -- 主键字段名
    @PageSize     int = 10,           -- 页尺寸
    @PageIndex    int = 1,            -- 页码
    @IsReCount    bit = 0,            -- 返回记录总数, 非 0 值则返回
    @OrderType    bit = 0,            -- 设置排序类型, 非 0 值则降序
    @strWhere     varchar(6000) = '' -- 查询条件 (注意: 不要加 where)
AS

declare @strSQL   varchar(6000)       -- 主语句
declare @strTmp   varchar(1000)        -- 临时变量(查询条件过长时可能会出错，可修改100为1000)
declare @strOrder varchar(400)        -- 排序类型

if @OrderType != 0
begin
    set @strTmp = '<(select min'
    set @strOrder = ' order by [' + @fldName +'] desc'
end
else
begin
    set @strTmp = '>(select max'
    set @strOrder = ' order by [' + @fldName +'] asc'
end

set @strSQL = 'select top ' + str(@PageSize) + ' * from ['
    + @tblName + '] where [' + @fldName + ']' + @strTmp + '(['
    + @fldName + ']) from (select top ' + str((@PageIndex-1)*@PageSize) + ' ['
    + @fldName + '] from [' + @tblName + ']' + @strOrder + ') as tblTmp)'
    + @strOrder
 -- INSERT INTO test (SqlStr) VALUES(@strSQL); 
if @strWhere != ''
    set @strSQL = 'select top ' + str(@PageSize) + ' * from ['
        + @tblName + '] where [' + @fldName + ']' + @strTmp + '(['
        + @fldName + ']) from (select top ' + str((@PageIndex-1)*@PageSize) + ' ['
        + @fldName + '] from [' + @tblName + '] where ' + @strWhere + ' '
        + @strOrder + ') as tblTmp) and ' + @strWhere + ' ' + @strOrder
 -- INSERT INTO test (SqlStr) VALUES(@strSQL); 
if @PageIndex = 1
begin
    set @strTmp =''
    if @strWhere != ''
        set @strTmp = ' where ' + @strWhere

    set @strSQL = 'select top ' + str(@PageSize) + ' * from ['
        + @tblName + ']' + @strTmp + ' ' + @strOrder
end

if @IsReCount != 0
    set @strSQL = 'select count(*) as Total from [' + @tblName + ']'+' where ' + @strWhere
 -- INSERT INTO test (SqlStr) VALUES(@strSQL); 
exec (@strSQL)
GO
/****** Object:  Table [dbo].[SystemLoginLog]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SystemLoginLog](
	[LoginLogId] [int] NOT NULL,
	[UserId] [int] NULL,
	[LoginIP] [varchar](200) NULL,
	[LoginAddress] [varchar](200) NULL,
	[LoginDate] [varchar](100) NULL,
	[LoginType] [varchar](100) NULL,
	[LoginCont] [varchar](100) NULL,
 CONSTRAINT [PK__SystemLo__D42E7AED32E0915F] PRIMARY KEY NONCLUSTERED 
(
	[LoginLogId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (1, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 22:41:27', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (2, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 22:43:27', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (3, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 22:56:54', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (4, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 22:57:8', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (5, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 22:58:30', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (6, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:2:57', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (7, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:4:3', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (8, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:5:25', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (9, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:6:35', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (10, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:7:41', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (11, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:7:56', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (12, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:8:25', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (13, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:9:17', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (14, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:10:33', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (15, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-10 23:25:26', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (16, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 9:11:39', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (17, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 9:13:15', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (18, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 9:58:3', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (20, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:2:20', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (21, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:4:37', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (22, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:5:51', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (23, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:7:9', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (24, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:10:59', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (25, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:11:44', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (26, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:12:59', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (27, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 10:16:7', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (28, 1, N'', N'', N'2014-2-11 10:16:35', N'添加', N'会员：1424 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (29, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:10:11', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (30, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:10:31', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (31, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:14:1', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (33, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:52:8', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (34, 1, N'', N'', N'2014-2-11 11:53:15', N'添加', N'会员：金浩 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (35, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:56:49', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (36, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:57:27', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (37, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 12::5', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (38, 1, N'IP:192.168.1.7 ', N'Mac:84-4B-F5-74-B7-F3 ', N'2014-2-12 21:44:43', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (39, 1, N'IP:192.168.1.7 ', N'Mac:84-4B-F5-74-B7-F3 ', N'2014-2-12 21:53:40', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (19, 1, N'', N'', N'2014-2-11 10::29', N'添加', N'会员：王五 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (32, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-11 11:51:36', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (40, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 15:45:5', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (41, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 15:46:56', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (44, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:29:3', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (45, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:38:17', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (46, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:39:7', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (47, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:39:18', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (48, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:43:14', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (52, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 14:47:51', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (53, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 14:57:16', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (54, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 14:57:44', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (55, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 14:58:18', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (56, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:3:39', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (57, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:5:4', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (58, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:7:51', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (59, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:12:5', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (61, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:36:38', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (62, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:38:36', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (63, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:40:49', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (64, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:42:6', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (65, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:52:3', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (66, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:52:30', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (67, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:53:5', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (68, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:58:45', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (69, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:2:8', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (70, 1, N'', N'', N'2014-2-15 16:2:21', N'添加', N'会员：qwe 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (71, 1, N'', N'', N'2014-2-15 16:2:40', N'添加', N'会员：123123 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (87, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 17:24:4', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (88, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 17:27:20', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (89, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 17:28:16', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (90, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 17:30:28', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (91, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:9:13', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (92, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:9:55', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (93, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:10:18', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (94, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:10:39', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (95, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:11:14', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (96, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:11:43', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (97, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:13:7', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (98, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:18:20', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (42, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 15:52:52', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (43, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:13:59', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (49, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:48:57', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (50, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:50:52', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (51, 1, N'IP:10.161.2.210 ', N'Mac:90-2B-34-69-52-06 ', N'2014-2-14 16:51:13', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (60, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 15:13:8', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (99, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:19:11', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (100, 1, N'', N'', N'2014-2-15 18:19:57', N'修改', N'消费型产品：包年卡 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (101, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:30:44', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (102, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:32:55', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (103, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:35:5', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (104, 1, N'', N'', N'2014-2-15 18:35:13', N'删除', N'删除会员信息数据成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (105, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:36:12', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (106, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:37:45', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (107, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:39:48', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (108, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:40:40', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (109, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:42:9', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (110, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:48:41', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (111, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:54:8', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (112, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 18:56:3', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (113, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:13:17', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (114, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:15:3', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (115, 1, N'', N'', N'2014-2-15 19:15:55', N'删除', N'删除消费型产品信息数据成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (116, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:25:58', N'登录', N'admin 登录系统')
GO
print 'Processed 100 total records'
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (117, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:28:50', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (118, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:38:33', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (119, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:40:28', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (120, 1, N'', N'', N'2014-2-15 19:41:18', N'添加', N'会员：王琦 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (121, 1, N'', N'', N'2014-2-15 19:41:26', N'添加', N'会员：王琦 消费信息 包年卡添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (122, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:50:21', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (123, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:51:10', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (124, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 19:51:54', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (125, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-16 13:18:2', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (126, 1, N'IP:192.168.0.110 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-16 16:9:37', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (127, 1, N'IP:192.168.0.110 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-16 16:9:58', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (128, 1, N'IP:192.168.0.110 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-16 16:13:58', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (129, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-17 22:55:57', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (130, 1, N'', N'', N'2014-02-17 23:02:35', N'修改', N'消费型产品：20次贵宾卡 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (131, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-17 23:11:07', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (132, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-17 23:17:24', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (133, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-17 23:41:15', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (134, 1, N'', N'', N'2014-02-17 23:41:29', N'修改', N'消费型产品：10次体验卡 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (135, 1, N'', N'', N'2014-02-17 23:41:36', N'修改', N'消费型产品：20次贵宾卡 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (136, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-17 23:57:23', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (137, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:04:17', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (138, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:04:40', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (139, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:05:54', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (140, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:09:50', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (141, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:15:41', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (142, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:16:24', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (143, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:18:15', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (144, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:19:59', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (145, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:21:22', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (146, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:28:43', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (147, 1, N'', N'', N'2014-02-18 0:29:03', N'添加', N'会员：1111 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (148, 1, N'', N'', N'2014-02-18 0:29:07', N'添加', N'会员：1111 消费信息 季度卡添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (149, 1, N'', N'', N'2014-02-18 0:29:28', N'修改', N'会员：1111 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (150, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:31:47', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (151, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:33:20', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (152, 1, N'', N'', N'2014-02-18 0:33:41', N'修改', N'会员：金浩 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (153, 1, N'', N'', N'2014-02-18 0:33:50', N'修改', N'会员：qwe 修改成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (154, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:35:40', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (155, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:40:37', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (72, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:34:47', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (73, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:36:6', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (74, 1, N'', N'', N'2014-2-15 16:36:15', N'添加', N'会员：123 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (75, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:37:39', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (76, 1, N'', N'', N'2014-2-15 16:37:48', N'添加', N'会员：qwe 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (77, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:45:41', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (78, 1, N'', N'', N'2014-2-15 16:45:55', N'添加', N'会员：asdf 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (79, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:48:16', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (80, 1, N'', N'', N'2014-2-15 16:48:25', N'添加', N'会员：213 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (81, 1, N'', N'', N'2014-2-15 16:48:29', N'添加', N'会员：213 消费信息 工本费添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (82, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 16:50:38', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (83, 1, N'', N'', N'2014-2-15 16:50:53', N'添加', N'会员：123 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (84, 1, N'', N'', N'2014-2-15 16:50:57', N'添加', N'会员：123 消费信息 工本费添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (85, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 17:17:10', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (86, 1, N'IP:192.168.1.102 ', N'Mac:E0-94-67-05-28-3A ', N'2014-2-15 17:18:6', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (156, 1, N'', N'', N'2014-02-18 0:40:50', N'添加', N'会员：23q23 添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (157, 1, N'', N'', N'2014-02-18 0:41:02', N'添加', N'会员：23q23 消费信息 补卡费添加成功！')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (158, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:41:53', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (159, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:45:22', N'登录', N'admin 登录系统')
INSERT [dbo].[SystemLoginLog] ([LoginLogId], [UserId], [LoginIP], [LoginAddress], [LoginDate], [LoginType], [LoginCont]) VALUES (160, 1, N'IP:192.168.1.104 ', N'Mac:E0-94-67-05-28-3A ', N'2014-02-18 0:45:35', N'登录', N'admin 登录系统')
/****** Object:  Table [dbo].[Sys_FunctionSmall]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_FunctionSmall](
	[FunctionSmallId] [int] IDENTITY(1,1) NOT NULL,
	[FunctionBigId] [int] NULL,
	[FunctionSmallName] [varchar](200) NULL,
	[FunctionLinkToolTip] [varchar](100) NULL,
	[FunctionUrl] [varchar](300) NULL,
	[SortId] [int] NULL,
	[IsBlank] [int] NULL,
	[IsShow] [int] NULL,
 CONSTRAINT [PK__Sys_Func__186F61882D27B809] PRIMARY KEY NONCLUSTERED 
(
	[FunctionSmallId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sys_FunctionBig]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sys_FunctionBig](
	[FunctionBigId] [int] IDENTITY(1,1) NOT NULL,
	[FunctionBigName] [varchar](200) NULL,
	[FunctionChildCount] [int] NULL,
	[FunctionSortId] [int] NULL,
 CONSTRAINT [PK__Sys_Func__0549D375300424B4] PRIMARY KEY NONCLUSTERED 
(
	[FunctionBigId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SwipingInfo]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SwipingInfo](
	[ID] [int] NOT NULL,
	[SwipingType] [varchar](50) NULL,
	[CardID] [varchar](50) NULL,
	[CardType] [varchar](50) NULL,
	[SwipingPeople] [varchar](50) NULL,
	[AddTime] [varchar](50) NULL,
	[AddUserName] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Desc] [varchar](50) NULL,
 CONSTRAINT [PK_SwipingInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'SwipingType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'CardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'CardType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'进场人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'SwipingPeople'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'AddUserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SwipingInfo', @level2type=N'COLUMN',@level2name=N'Name'
GO
INSERT [dbo].[SwipingInfo] ([ID], [SwipingType], [CardID], [CardType], [SwipingPeople], [AddTime], [AddUserName], [Name], [Desc]) VALUES (1, N'会员刷卡', N'123456', N'包年卡', N'', N'2014-2-11 11:52:11', N'张越', N'张越', N'入场刷卡')
/****** Object:  Table [dbo].[SellCast]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SellCast](
	[CastId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [varchar](50) NOT NULL,
	[PriceAmount] [decimal](18, 0) NOT NULL,
	[PaymentAmount] [decimal](18, 0) NOT NULL,
	[ChangeAmount] [decimal](18, 0) NOT NULL,
	[CreateTime] [varchar](50) NOT NULL,
	[AddUserName] [varchar](50) NULL,
	[AddTypeName] [varchar](50) NULL,
	[CardID] [varchar](50) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Peoples] [varchar](50) NULL,
	[Des] [varchar](500) NULL,
	[Prices] [varchar](50) NULL,
 CONSTRAINT [PK__SellCast__68A1293C1920BF5C] PRIMARY KEY CLUSTERED 
(
	[CastId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'售卡费用ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'CastId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'PriceAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'缴费金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'PaymentAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'找零金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'ChangeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收银员姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'AddUserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加类型（售卡）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'AddTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'CardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'TypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'Peoples'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast', @level2type=N'COLUMN',@level2name=N'Prices'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'售卡交费信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SellCast'
GO
SET IDENTITY_INSERT [dbo].[SellCast] ON
INSERT [dbo].[SellCast] ([CastId], [MemberId], [PriceAmount], [PaymentAmount], [ChangeAmount], [CreateTime], [AddUserName], [AddTypeName], [CardID], [TypeName], [Peoples], [Des], [Prices]) VALUES (1, N'7', CAST(10 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'2014-02-15 19:40:39', N'赵武男', N'工本费', N'12', N'现金消费', NULL, N'售卡', NULL)
INSERT [dbo].[SellCast] ([CastId], [MemberId], [PriceAmount], [PaymentAmount], [ChangeAmount], [CreateTime], [AddUserName], [AddTypeName], [CardID], [TypeName], [Peoples], [Des], [Prices]) VALUES (2, N'8', CAST(10 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'2014-02-15 19:40:39', N'赵武男', N'工本费', N'2123', N'现金消费', NULL, N'售卡', NULL)
INSERT [dbo].[SellCast] ([CastId], [MemberId], [PriceAmount], [PaymentAmount], [ChangeAmount], [CreateTime], [AddUserName], [AddTypeName], [CardID], [TypeName], [Peoples], [Des], [Prices]) VALUES (3, N'3', CAST(1000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'2014-02-15 19:40:39', N'赵武男', N'包年卡', N'123457', N'现金消费', NULL, N'售卡', NULL)
INSERT [dbo].[SellCast] ([CastId], [MemberId], [PriceAmount], [PaymentAmount], [ChangeAmount], [CreateTime], [AddUserName], [AddTypeName], [CardID], [TypeName], [Peoples], [Des], [Prices]) VALUES (4, N'10', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'2014-02-18 19:40:39', N'赵武男', N'季度卡', N'1111', N'现金消费', NULL, N'售卡', NULL)
INSERT [dbo].[SellCast] ([CastId], [MemberId], [PriceAmount], [PaymentAmount], [ChangeAmount], [CreateTime], [AddUserName], [AddTypeName], [CardID], [TypeName], [Peoples], [Des], [Prices]) VALUES (5, N'11', CAST(10 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'2014-02-18 0:41:01', N'赵武男', N'补卡费', N'23q2', N'现金消费', NULL, N'售卡', NULL)
SET IDENTITY_INSERT [dbo].[SellCast] OFF
/****** Object:  Table [dbo].[Role]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](100) NULL,
	[RoleMailRoom] [int] NULL,
	[RoleSynopsis] [text] NULL,
	[DataTime] [varchar](100) NULL,
 CONSTRAINT [PK__Role__8AFACE1B24927208] PRIMARY KEY NONCLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Role', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Role', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'说明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Role', @level2type=N'COLUMN',@level2name=N'RoleSynopsis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Role', @level2type=N'COLUMN',@level2name=N'DataTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Role'
GO
SET IDENTITY_INSERT [dbo].[Role] ON
INSERT [dbo].[Role] ([RoleId], [RoleName], [RoleMailRoom], [RoleSynopsis], [DataTime]) VALUES (1, N'系统管理员', NULL, N'系统管理员', N'2014-1-20 13:51:36')
INSERT [dbo].[Role] ([RoleId], [RoleName], [RoleMailRoom], [RoleSynopsis], [DataTime]) VALUES (2, N'收银员', NULL, N'收银员..', N'2014-1-20 23:45:')
SET IDENTITY_INSERT [dbo].[Role] OFF
/****** Object:  Table [dbo].[Menu]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[RoleMenuId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NULL,
	[RoleMenuBigFunctionId] [int] NULL,
	[RoleMenuFunctionId] [int] NULL,
	[IsAdd] [int] NULL,
	[IsDelete] [int] NULL,
	[IsModify] [int] NULL,
	[IsList] [int] NULL,
	[IsSpecial] [int] NULL,
 CONSTRAINT [PK__Menu__F86287B72A4B4B5E] PRIMARY KEY NONCLUSTERED 
(
	[RoleMenuId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberInfo]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberInfo](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[CardID] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[CardType] [varchar](50) NULL,
	[IDCardType] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[IDCard] [varchar](50) NULL,
	[Sex] [varchar](50) NULL,
	[StartTime] [varchar](50) NULL,
	[Birthday] [varchar](50) NULL,
	[EndTime] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Count] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[AddTime] [varchar](50) NULL,
	[AddUserName] [varchar](50) NULL,
	[Photo] [image] NULL,
	[InfoType] [varchar](50) NULL,
 CONSTRAINT [PK__MemberIn__0CF04B381BFD2C07] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'MemberID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'CardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电子邮箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Mail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'CardType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'IDCardType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'证件号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'IDCard'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生效时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生日' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Birthday'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'失效时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'剩余次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'办理时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'办理人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'AddUserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'Photo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'正常，挂失，过期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo', @level2type=N'COLUMN',@level2name=N'InfoType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MemberInfo'
GO
SET IDENTITY_INSERT [dbo].[MemberInfo] ON
INSERT [dbo].[MemberInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [Photo], [InfoType]) VALUES (1, N'123456', N'327549286@qq.com', N'补卡费', N'身份证', N'金浩', N'612422198802265210', N'男', N'2014-02-11 11:52:11', N'1988-02-11 0:0:0', N'2014-02-11 11:52:11', N'金浩', N'10', N'', N'2014-02-18 0:33:41', N'赵武男', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080067004803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F6A120FBAC703D6A4FB428E0738ACB1382327B54D0CCA4963D0F6AD2C6299A0B3B11C74A733B8C726A185D4F18AB023DC79A4591CF2F97034849C01DBA9AF2FF00891ACEA569A49B099638A1BCFE143BA4DA083D7EB8AF509C318F0003C8EB5E3DF1196E2F6FDE49318854A0D8B8DB8C1CFE67AFB5388D227F8631C3A7E872EA124477DE4E20181D978C9FC49AF4AD262B44D32DE6B650CB24618363B62B98F0CDC59D9F84965B268DADF61947987680C79209FA9C57516EE96BA65BAA205511AED51D863A54A77654D5922CBC4AF82490739A29A18B90DD38A2A8C8C1B69C3E43727A63F1AB913A938E3A2E31F415836C597041C296FF00D98D6ADB60E7AF0ABD7E829B2626D40D9518ABB1E6A9590DCA335A6898152CD911915E63E36881F39D630C1B976CF1E9FD6BD4644F94E2B2A5B44F2678D914863F36475CF5A13B0D2386F0ED9DCD968BA644F17EEAE54C6EAC4AECC925587E04576738F319426768E9F4AC6595E3F0F412A8124B6808284F5DA718FAE2B6AD6ED248A364C1474DEAD4968D84EED22589B6B05607A5150BDD0624E73E807AD155632B9856D0B3306EBC9FFD0AAF449B5CFA855CFE550C60AA0C00003C81FEF7AD594930C48403E55CFE42993136ACC7CAA474AD21D2B36CB80B8E845698E959B365B0845675F9091CCC4E0000935A47A565EAA375ADCAFAC47FAD2296E79CA6B171677926C8C4D0C8F930B1C64FB1EC6BA9B688C0B15BA80163854100E704718AC4D02C05CEA125ECC316F6BC827A17FF00EB75FCAB6348D406A562F7C23016695F61F540768FE59FC6B47672D096DA8938F9240C4670738A29647F6A2AEC6172379D49D90A823232C470391D28498A3B03DD5707F01503CF1A1299392410AA324F229A92F9924AACBB4ED5E09CFF0008A91C59D05948485CF4AD7439515836926C0109FA1AD7865E00A868D913B1C0ACBBE70EFE59E03A15357659302B17559B62C72138504827F0FF00EB52B6852DCA1AC246BA4BE9B66CB02B260B019C03D7F13CD58B2B44B2D32D6D5082B144AB90319E3AD7386F24B979E5FF00966BD09AE8A2951E04092A9DAA149CE704538315556412267A514C772A48241F7073456BA9CFA1463B4291B38FBC0A9C0F7239269372319304128ABC839E768A4C4B32092E4E554AE231C0CE571C7F8D5771E5CD2BAE0121323B1F9454891B704BB9467835A704C4AF3D6B063606356079CFE55A30CC64886787143354CBF24BBC819C1ACED6C23692F0A1DCD23019F4EF5389372E3F88706B1B57BD4B1780CBC4649C924000F18E4F1EBD4FFF005D34EDA149FBDA90B69EB1E99B58ED0304FBD47E1BB0F2EDEEA4797E4B8999A260074079FAE79FCA992EA716B3BACACE50095396521B1C138E09C138EF8FC6A3F01EA2352D0259A64C2DB4EF1A21FE118047F335318B5AB2AA4EEAC6A4DB5256556DCA0F068AB53DBA4EC0420061F7D8F4E9456AA48E669998D70CCC1635E38E5FA7F0F6FF001AA53C8F1B4AD236F0427CD8C63E515719047B7CC3B38E84727A76AA534D1C8661F302027CAE307EEAF38A484581290CACA7BE3EB5AB04DBD548C861FA1AE74CA619547DE4EB8F4AD88E4076491E33EB432932E09C82DC61B3C8AE33C75AC5C595F58BDBB956F29C103041191C107823D8D7566753B9B2030C707B579AFC479D9353B1E700C2483FF0235505A8EE6659789AF0F88EC26925DA21972A00088A4F60AA3009E0741EF5D5FC369E5B3D32F8342FB1DE365620ED3C1079AE47C1904179E29804D18912206450C38DC3A1C7E39AF652FE5C8A1300347C0C71C52A934A5CA5C60DC798B4842C400032FD71F4A2B3EE2EA4F9D00FBDC8C1E831454D88B8D923400B2925F2327F2FF0AC8BD84349203D73190476E168A2844322493FD202498271F2B63AD5F3BA150E9F8AD145302D452248AB263208E41AE4BC6DA0A6BD2D898E4FB3BA874048C82383823B51452936A3746B4D272B323F0DF87934086FE46984F323C04384C60166040FCC7E55D8B4997B3C9C65F693F518A28AC5B6DA6CE9B249A5FD683A5261B82426F5E9C9A28A2B74719FFFD9, N'正常')
INSERT [dbo].[MemberInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [Photo], [InfoType]) VALUES (2, N'123341', N'12312', N'补卡费', N'身份证', N'qwe', N'2132', N'男', N'2014-02-15 16:02:14', N'2014-02-15 0:0:0', N'2014-08-15 16:02:14', N'qwe', N'', N'123', N'2014-02-18 0:33:49', N'赵武男', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080067004803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F6A120FBAC703D6A4FB428E0738ACB1382327B54D0CCA4963D0F6AD2C6299A0B3B11C74A733B8C726A185D4F18AB023DC79A4591CF2F97034849C01DBA9AF2FF00891ACEA569A49B099638A1BCFE143BA4DA083D7EB8AF509C318F0003C8EB5E3DF1196E2F6FDE49318854A0D8B8DB8C1CFE67AFB5388D227F8631C3A7E872EA124477DE4E20181D978C9FC49AF4AD262B44D32DE6B650CB24618363B62B98F0CDC59D9F84965B268DADF61947987680C79209FA9C57516EE96BA65BAA205511AED51D863A54A77654D5922CBC4AF82490739A29A18B90DD38A2A8C8C1B69C3E43727A63F1AB913A938E3A2E31F415836C597041C296FF00D98D6ADB60E7AF0ABD7E829B2626D40D9518ABB1E6A9590DCA335A6898152CD911915E63E36881F39D630C1B976CF1E9FD6BD4644F94E2B2A5B44F2678D914863F36475CF5A13B0D2386F0ED9DCD968BA644F17EEAE54C6EAC4AECC925587E04576738F319426768E9F4AC6595E3F0F412A8124B6808284F5DA718FAE2B6AD6ED248A364C1474DEAD4968D84EED22589B6B05607A5150BDD0624E73E807AD155632B9856D0B3306EBC9FFD0AAF449B5CFA855CFE550C60AA0C00003C81FEF7AD594930C48403E55CFE42993136ACC7CAA474AD21D2B36CB80B8E845698E959B365B0845675F9091CCC4E0000935A47A565EAA375ADCAFAC47FAD2296E79CA6B171677926C8C4D0C8F930B1C64FB1EC6BA9B688C0B15BA80163854100E704718AC4D02C05CEA125ECC316F6BC827A17FF00EB75FCAB6348D406A562F7C23016695F61F540768FE59FC6B47672D096DA8938F9240C4670738A29647F6A2AEC6172379D49D90A823232C470391D28498A3B03DD5707F01503CF1A1299392410AA324F229A92F9924AACBB4ED5E09CFF0008A91C59D05948485CF4AD7439515836926C0109FA1AD7865E00A868D913B1C0ACBBE70EFE59E03A15357659302B17559B62C72138504827F0FF00EB52B6852DCA1AC246BA4BE9B66CB02B260B019C03D7F13CD58B2B44B2D32D6D5082B144AB90319E3AD7386F24B979E5FF00966BD09AE8A2951E04092A9DAA149CE704538315556412267A514C772A48241F7073456BA9CFA1463B4291B38FBC0A9C0F7239269372319304128ABC839E768A4C4B32092E4E554AE231C0CE571C7F8D5771E5CD2BAE0121323B1F9454891B704BB9467835A704C4AF3D6B063606356079CFE55A30CC64886787143354CBF24BBC819C1ACED6C23692F0A1DCD23019F4EF5389372E3F88706B1B57BD4B1780CBC4649C924000F18E4F1EBD4FFF005D34EDA149FBDA90B69EB1E99B58ED0304FBD47E1BB0F2EDEEA4797E4B8999A260074079FAE79FCA992EA716B3BACACE50095396521B1C138E09C138EF8FC6A3F01EA2352D0259A64C2DB4EF1A21FE118047F335318B5AB2AA4EEAC6A4DB5256556DCA0F068AB53DBA4EC0420061F7D8F4E9456AA48E669998D70CCC1635E38E5FA7F0F6FF001AA53C8F1B4AD236F0427CD8C63E515719047B7CC3B38E84727A76AA534D1C8661F302027CAE307EEAF38A484581290CACA7BE3EB5AB04DBD548C861FA1AE74CA619547DE4EB8F4AD88E4076491E33EB432932E09C82DC61B3C8AE33C75AC5C595F58BDBB956F29C103041191C107823D8D7566753B9B2030C707B579AFC479D9353B1E700C2483FF0235505A8EE6659789AF0F88EC26925DA21972A00088A4F60AA3009E0741EF5D5FC369E5B3D32F8342FB1DE365620ED3C1079AE47C1904179E29804D18912206450C38DC3A1C7E39AF652FE5C8A1300347C0C71C52A934A5CA5C60DC798B4842C400032FD71F4A2B3EE2EA4F9D00FBDC8C1E831454D88B8D923400B2925F2327F2FF0AC8BD84349203D73190476E168A2844322493FD202498271F2B63AD5F3BA150E9F8AD145302D452248AB263208E41AE4BC6DA0A6BD2D898E4FB3BA874048C82383823B51452936A3746B4D272B323F0DF87934086FE46984F323C04384C60166040FCC7E55D8B4997B3C9C65F693F518A28AC5B6DA6CE9B249A5FD683A5261B82426F5E9C9A28A2B74719FFFD9, N'正常')
INSERT [dbo].[MemberInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [Photo], [InfoType]) VALUES (9, N'123457', N'15672938213@193.com', N'包年卡', N'身份证', N'王琦', N'612432188982983217', N'男', N'2014-02-15 19:40:39', N'2014-2-15 19:40:32', N'2015-02-15 19:40:39', N'15672938213', N'', N'', N'2014-02-15 19:41:17', N'赵武男', NULL, N'正常')
INSERT [dbo].[MemberInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [Photo], [InfoType]) VALUES (10, N'1111', N'11', N'补卡费', N'身份证', N'1111', N'111', N'男', N'2014-02-18 0:28:59', N'2014-02-18 0:0:0', N'2014-05-18 0:28:59', N'1111', N'', N'111', N'2014-02-18 0:29:27', N'赵武男', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080067004803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F6A120FBAC703D6A4FB428E0738ACB1382327B54D0CCA4963D0F6AD2C6299A0B3B11C74A733B8C726A185D4F18AB023DC79A4591CF2F97034849C01DBA9AF2FF00891ACEA569A49B099638A1BCFE143BA4DA083D7EB8AF509C318F0003C8EB5E3DF1196E2F6FDE49318854A0D8B8DB8C1CFE67AFB5388D227F8631C3A7E872EA124477DE4E20181D978C9FC49AF4AD262B44D32DE6B650CB24618363B62B98F0CDC59D9F84965B268DADF61947987680C79209FA9C57516EE96BA65BAA205511AED51D863A54A77654D5922CBC4AF82490739A29A18B90DD38A2A8C8C1B69C3E43727A63F1AB913A938E3A2E31F415836C597041C296FF00D98D6ADB60E7AF0ABD7E829B2626D40D9518ABB1E6A9590DCA335A6898152CD911915E63E36881F39D630C1B976CF1E9FD6BD4644F94E2B2A5B44F2678D914863F36475CF5A13B0D2386F0ED9DCD968BA644F17EEAE54C6EAC4AECC925587E04576738F319426768E9F4AC6595E3F0F412A8124B6808284F5DA718FAE2B6AD6ED248A364C1474DEAD4968D84EED22589B6B05607A5150BDD0624E73E807AD155632B9856D0B3306EBC9FFD0AAF449B5CFA855CFE550C60AA0C00003C81FEF7AD594930C48403E55CFE42993136ACC7CAA474AD21D2B36CB80B8E845698E959B365B0845675F9091CCC4E0000935A47A565EAA375ADCAFAC47FAD2296E79CA6B171677926C8C4D0C8F930B1C64FB1EC6BA9B688C0B15BA80163854100E704718AC4D02C05CEA125ECC316F6BC827A17FF00EB75FCAB6348D406A562F7C23016695F61F540768FE59FC6B47672D096DA8938F9240C4670738A29647F6A2AEC6172379D49D90A823232C470391D28498A3B03DD5707F01503CF1A1299392410AA324F229A92F9924AACBB4ED5E09CFF0008A91C59D05948485CF4AD7439515836926C0109FA1AD7865E00A868D913B1C0ACBBE70EFE59E03A15357659302B17559B62C72138504827F0FF00EB52B6852DCA1AC246BA4BE9B66CB02B260B019C03D7F13CD58B2B44B2D32D6D5082B144AB90319E3AD7386F24B979E5FF00966BD09AE8A2951E04092A9DAA149CE704538315556412267A514C772A48241F7073456BA9CFA1463B4291B38FBC0A9C0F7239269372319304128ABC839E768A4C4B32092E4E554AE231C0CE571C7F8D5771E5CD2BAE0121323B1F9454891B704BB9467835A704C4AF3D6B063606356079CFE55A30CC64886787143354CBF24BBC819C1ACED6C23692F0A1DCD23019F4EF5389372E3F88706B1B57BD4B1780CBC4649C924000F18E4F1EBD4FFF005D34EDA149FBDA90B69EB1E99B58ED0304FBD47E1BB0F2EDEEA4797E4B8999A260074079FAE79FCA992EA716B3BACACE50095396521B1C138E09C138EF8FC6A3F01EA2352D0259A64C2DB4EF1A21FE118047F335318B5AB2AA4EEAC6A4DB5256556DCA0F068AB53DBA4EC0420061F7D8F4E9456AA48E669998D70CCC1635E38E5FA7F0F6FF001AA53C8F1B4AD236F0427CD8C63E515719047B7CC3B38E84727A76AA534D1C8661F302027CAE307EEAF38A484581290CACA7BE3EB5AB04DBD548C861FA1AE74CA619547DE4EB8F4AD88E4076491E33EB432932E09C82DC61B3C8AE33C75AC5C595F58BDBB956F29C103041191C107823D8D7566753B9B2030C707B579AFC479D9353B1E700C2483FF0235505A8EE6659789AF0F88EC26925DA21972A00088A4F60AA3009E0741EF5D5FC369E5B3D32F8342FB1DE365620ED3C1079AE47C1904179E29804D18912206450C38DC3A1C7E39AF652FE5C8A1300347C0C71C52A934A5CA5C60DC798B4842C400032FD71F4A2B3EE2EA4F9D00FBDC8C1E831454D88B8D923400B2925F2327F2FF0AC8BD84349203D73190476E168A2844322493FD202498271F2B63AD5F3BA150E9F8AD145302D452248AB263208E41AE4BC6DA0A6BD2D898E4FB3BA874048C82383823B51452936A3746B4D272B323F0DF87934086FE46984F323C04384C60166040FCC7E55D8B4997B3C9C65F693F518A28AC5B6DA6CE9B249A5FD683A5261B82426F5E9C9A28A2B74719FFFD9, N'正常')
INSERT [dbo].[MemberInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [Photo], [InfoType]) VALUES (11, N'23q2', N'32q3', N'补卡费', N'身份证', N'23q23', N'q23q2', N'男', N'2014-02-18 0:40:42', N'2014-02-18 0:0:0', N'2014-02-18 0:40:42', N'q23', N'', N'23q', N'2014-02-18 0:40:49', N'赵武男', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800FD00F903012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00EDA8A4A2BD73CC168A4A280168A4A280168A4A280168A4A280168A4A280168A4A28016BABAE4EBACAC2BF436A5D428A28AC0D828A28A0028A28A0028A28A0028A28A0028A28A0028A28A002B7AB06B7AB2A9D0B81E6B452515EA1C02D14945002D14945002D14945002D14945002D14945002D14945002D7599AE4ABACAE7AFD0D6975173466928AC0D85CD19A4A280173466928A005CD19A4A280173466928A005CD19A4A280173466928A005CD6F56056FD6553A1A533CCE8A4A2BD43CF168A4A280168A4A280168A4A280168A4A28016A582DE6B99447046CEE7B015774AD1A6D49B79263801E5FD7D857564D8689645D9A3B7817EF331EA7FA9AC2A57517CAB566D0A4E5ABD118B69E157601AEE6D9FEC47C9FCEB5E0D0B4E8318B70E7D643BBF4E95CA6A9E3F66263D3200ABD3CE94649FA2FF8FE55CBDDEAFA85FB1373793480FF000EEC2FE438A4A8D7A9AC9D8A75294348AB9EB25B4DB63B09B588FA12AB4F5BAB198ED49ADDC9EC1D4D78C8A5A7F52FEF0BEB5E47B3BDA40FFF002CC03EDC556934EC731BE7D9ABCB2D354BFB120DB5DCD181FC21B8FCBA574FA678EE54223D4A1122FF00CF588608FA8E87F0C5672C2D48EB1772E35E12DD58DF78DE36DAEA41F7A6D6A5BDD5A6A96A2582449A23DC763FD0D53B9B5683E61F327AFA562A5AD9EE68E3D515E8A28AA2428A28A0028A28A0028A28A0028A28A002B7EB02B7EB2A9D0D20799514668CD7AA79E14519A33400514668CD0014519A33400568E8FA636A37586C8813976FE82A8468D2CA91A0CB390A07B9AEE6DE28347D2CEF60B1C485E47F538E4D615EA722B2DD9B528733BBD90CD5755B3D034D12CA005036C512F058FA0FF1AF2CD5B5ABCD66E8CD7527CA3EE463EEA0F61FD69BAEEB536B7A93DCBE5631F2C51FF757FC7D6B381ADB0F8754D5E5B99D6ACE6ECB625069C0D440D381AE93026069735106A706A4324CD19A6669734017B4DD56EB49BA13DAC854FF00129FBAE3D08AF4ED1B59B6D6ECBCD8BE571C4B11392A7FC3DEBC8B357B49D526D23504BA84E40E1D33C3AF715CD5F0EAA2BADCDA8D670767B1E99756FE43E57EE1E9EDED55F35A70CD0EA3629344DBA2954329FF003DEB3594A3153D41C1AF3E2EFA3DCEC92EA84CD19A28AB24334668A2800CD19A28A00334668A2800CD7415CFD7415954E8694CF31A2928AF50F3C5A2928A005A2928A005A2928A00DBF0D5A896FDA761F2C2BC7D4F4FEB507C43D58C165069B1B61A73BE4C7F741E07E27F956D786A2F2F4D693BC8E4FE038FF1AF38F18DE1BBF145E1CFCB111128F4DA39FD735CF4A3ED31177D0DE6F928E9D4C6069E1AA10D4A1ABD33889C35286A843538352B01306A706A8435286A5619306A5DD5106A5DD4AC04BBA9334CDD46EA00EF3C03A99649F4D76FBBFBD8FE9D187F23F89AE9EF93122B8FE21835E61E1BBC367E21B293380D208DBE8DC7F5AF55BC5DD013E8735E5E263C956EBA9DF425CD4EDD8CEA28A2A0A0A28A2800A28A2800A28A2800AE82B9FAE82B2A9D0D299E61452515EA9E70B45251400B45251400B45251401DC68C36E916C07F749FD4D78CEA9219757BD909E5A7727FEFA35EC5A23EFD220F6041FCCD78F6B511835CBF88FF000DC38FFC78D6184FE24CDF11F044A99A5CD479A5CD7A1739090353835439A70345C44A1A9C1AA1069734C098353B7541BA9775004FBA8DD50EEA5DD4AC05AB790C773138EAAE08FCEBDAE7E607FA578958A19EFEDE21C9795547E240AF6B9CE217FA579D8EF8A276E136919D45145731A851451400514514005145140057415CFD74159D4E8694CF2FA28CD19AF54F3828A33466800A28CD19A0028A33466803A7F0D4FBAD25849E51F23E87FF00D55C0F8F2C8DA78964940C25CA2C83EBD0FEA33F8D751A25D8B5D45431C249F21FE9FAD59F1C68E753D17CF89775C5A92EA0752BFC43FAFE15CA9FB2C45DECCE9B73D1B754793E697349457A4718E06941A68A70A0438528A68A514C42E6973494A2980B9A334940A00E87C1B666F3C496E7194833337B63A7EA457A95D362303D4D735E06D24D8E94D792AE26BAC119EC83A7E7D7F2ADEB87DD260745E2BC7C44FDA56D3647A3463C94F5EA459A33494548C5CD19A4A280173466928A005CD19A4A2801735D0573D5D0D6553A1A533CBA8A28AF54F3828A28A0028A28A0028A28A002BAFD235017B6815CFEF9061F3DFDEB90A9AD2EA4B3B859A33C8EA3B11E958D6A5ED236EA694AA724BC8C4F187869B49BC3776C87EC3336463FE59B7F77E9E95CC62BDBA396D757B16464592271B648DB9C7B1AF3CF117832E34D67B9B1569ED3A95032F1FD7D47BD3C3E22FEE54D1955A8FDA86C72829C28C518AED394514A2814A29882968C52E298098AE87C2DE1D7D62F04B32916511CB9FEF9FEE8FEB52E81E11B9D51967BA0D059F5C918671FEC8F4F7AF4882182C2D52082358E2418555AE1C4E2945724373AA8506FDE96C492388A301401C6140ED54E9CEE5DB269B5C318D91D5277614514551214514500145145001451450015D0D73D5D0D6553A1A533CB68A28AF54F3828A28A0028A28A0028A28A0028A28A009ADAEA6B494490B9561D7D0FD6BA6B1D6A0BB012422297D09E0FD0D615A6917577860BE5A1FE27E3F215B36FA05AC58329695BDCE07E42B92BBA4F7DFC8E9A2AA2DB62BEABE11D2F546690C66DE73C9921E327DC743FCEB95BCF87FA8C249B59A1B85EC09D8DF91E3F5AEF2E2FAC34C840B9BA82D900E048E17F2CD44FADD8A8C894BFFBAA6B2A55AB47E1D51A54A749FC5A33CD64F0A6B71121B4F90E3FBA437F23447E15D6E4202E9F20CFF7885FE66BD2175DB33D7CC1F55A0EBB663A7987E8B5D1F5AAFF00CA63EC297F31C5DA780B529883732C36EBDF9DEDF90E3F5AEA34BF08699A6912321B9987F1CBC807D874FE75A11EB364FF00F2D0A9FF00694D4B6BA8595FAE6D6EA19C77F2DC363EB5CF56BD792F7B446D4E9525B6A4EF284E3A9AAECE5CE49A99A153D38A89A365ED91ED594394B9730CA28CD19AD480A28CD19A0028A33466800A28CD19A0028A33466800AE86B9ECD7435954E8694CF2CA28A2BD53CE0A28A2800A28A2800A28AB563632DF4FB13851F798F40293692BB1A4DBB222B7B796EA511C28598FE9F5AE96C34586D407940965F53D07D054C05968D60F248EB0C318CBC8E7AFD6BCDFC4BE3BB9D48BDAE9A5EDED3A171C3C9FE03DBFFD55CBCD52BBE58688E8B428ABCF56765AE78D74BD14B441CDD5D0FF0096511E87FDA6E83F53ED5E7DAAF8EF5BD48B2C73FD8E13D120E0FE2DD7F2C57378A315D74B0B4E1D2ECE6A9889CFC90D76791CBBB1663C9663926BD2EC275BAB08265390E80FE3DEBCD715B7A0EBBFD9C4DBDC64DB31C8239287D7E95B4E375A1941D9EA77140A6433473C4B2C4E1E36190C3A1A5925486369247088A32598E00AE7360B8996DADA499CFCB1A9635E6A8ECAE1D58AB039041C106B6F5ED785F0FB2DB67ECE0E598F1BCFF85618ADE11B2D4CA72BBD0E974BF1B6B3A715579FED508FE09FE63F8375AEF345F19E9BAB95899BECB727FE59CA7827D9BA1FD0D7908A70AC6AE1A9CFA599A53C44E1E68F7A7883723835032953822BCEBC3BE35B9D34ADB5F97B8B4E8189CBC7F4F51ED5E936F716F7F6A93DBC8B2C2E32AEA6BCF9C2745DA5B1DB09C6AABC7722A29CE850E0F4A6D09DC028A28A60145145001451450015D1573B5D156553A1A533CAE8A4A2BD53CE168A4A280168A4A28027B5B67BBB84863EAC793E83D6BAAFF44D174E79247114112EE776EFEFF5A8F48B01656DB9C7EFA4196CF6F6AF35F1BF89FF00B5EFBEC56AFF00E856EDD41FF58FEBF41DBF3AE377C454E45B23A55A8C399EECA5E26F13DC7882ECF2D1D9C67F75167FF1E6F53FCAB06933466BD38414172C7638252727762D06933466A8421A5552EEAAA32CC70052135A7E1FB6FB56B500232B19F31BF0E9FAE293764095D9DD5A402D6D21817A46817EB8A5BA805D5A4D0374910AFE952D15CC741E6054A395618607047BD28357F5FB6FB2EB338030B21F317F1EBFAE6B381AE95AAB9CED5992834F151034F06901256D7877C4571A0DD82097B573FBD8B3FA8F435860D2E6A6515256638C9C5DD1EEB6D7306A1691DC5BC824864195614C60558835E69E0EF119D22F7ECB72FF00E853B724FF00CB36FEF7D3D7FF00AD5EA522875C8EA3A5793529BA33E57B1E9C26AAC6EB72B668CD145300CD19A28A00334668A2800CD7475CE57475954E8694FA9E559A3349457AA79C2E68CD251400B9AD3D12D3ED37BBD86638BE63EE7B565D75BA2DBFD9F4E4247CD27CE7F1E9FA561889F2C34EA6B461CD3313C7BAF1D2747FB2C0F8BABBCA020F2A9FC47FA7E3ED5E420D6CF8B7573AC788AE6756CC319F2A2F4DABDFF1393F8D6266BA70D4BD9D34BAB31AF539E7E43F34B9A6668CD6E623F3499A6E68CD003B35D6783ADF11DC5D11F7888D4FD393FD2B90CD7A26896DF64D1EDA3230C577B7D4F3515362A0B534F3466999A33581B1CDF8C2DF31DBDD01D098DBF1E47F5AE50357A06B76DF6BD1EE23032C177AFD4735E760D6F4F6319EE4E1A9E1AAB86A786AA249C1A766A10D4E068024CD7A9F81B5B3A96946D266CDC5A80B927964EC7F0E9F9579566B5FC33AA9D275EB6B82D8898F972FFBA7AFE5C1FC2B9F114BDA536BA9B50A9C93BF43D8255DAD9EC6A3AB128DC87DB9AAF9AF320EE8F424ACC28A33466AC90A28CD19A002BA4AE6F35D256553A1A53EA79451499A335EA9E70B452668CD00490C6669E38875760BF9D74BE24BEFECAF0CDEDCA1DAC916C8C8ECC7E51FA9158DA2C7E66A9167A2E5BF4AAFF13AE8C5E1FB7B707066B819F70013FCF15CB5573D68C0E8A6F9694A4794669734DCD19AF50F3C7669734DCD1400ECD266928CD005AD3EDBED9A8DBDBF50EE01FA77FD335E99D2B8BF085B799A84B7047112607D4FFF00581AED2B0A8F5B1AC1681451454161D783D2BCD350B6FB1EA33DBF647207D3B7E98AF4BAE2FC5F6DE56A115C01F2CA983F51FF00D622AE9BD6C44D6860034F06A3069C0D6C644A0D381A881A70340C941A5CD460D2E6901EDBE1ABEFED1F0E595C31CB98F639FF00697E53FCB356D86188F4AE5BE1BDC99345B9B7273E54F91EC180FEA0D75528C487DEBC694796ACA27AB17CD4D486D14945310B45251400B5D2D7335D356553A1A53EA793D1499A335EA1E78B452668CD006C787466FDCFA467F98AE7BE2B487FE2551F6FDEB1FF00C77FFAF5D17870FF00A64BFF005CFF00A8AE5FE2B1FF0049D2FF00DC93F9AD73C7FDE97F5D0DE5FEEECF3DCD2E6999A5CD7A4700ECD19A6E68CD1701F9A334DCD19A2E077BE16B6F23475908F9A662FF008741FCBF5ADACD62F87B528EF74E48861658142328F41D0D6BE6B9E5B9B2D87E68CD33346690C7E6B17C536DE7E8ED201968583FE1D0FF003FD2B5F3591E21D4A3B3D39E2386967528AA7D0F534E3B89EC70B9A50D51E69735D0624A1A9C1AA1CD286A044C1A9C1AA10D4E0D401E89F0C643E66A71F62236FF00D0BFC6BBD9FEF8FA579EFC2FE6EB523FEC27F335E8339F987D2BC8C47F1DFF005D0F4E8FF0511D149454142D14945002D74F5CBD75159D4E8694FA9E4D451457A879E145145006CF873FE3F25FFAE7FD4572DF15BFE3E74BFF00724FE6B5D47877FE3F25FF00AE7FD4572DF15BFE3E74BFF724FE6B5CD1FF00795FD743797FBBB3CF33466929335E89C23B34669B9A33400ECD2E6999A5CD005CD3EFE5D3AF12E233D3865FEF0EE2BD0EDAEA3BBB749E26CA38C8AF30ADBF0F6AFF0061B8FB3CCDFE8F29EA7F85BD6A26AFA97176D0EE7751BAA3DD46EAC4D44B9BA8ED2DDE795B088326BCF350BF9751BC7B894F5E157FBA3B0ABFE21D5FEDD71F6785BFD1E23D47F137AD6256D056D4CA4EE3B34669B9A335A103F34B9A666941A007834E06A3069C0D311E89F0B4E6E353FF00723FE6D5E8339F9C7D2BCF3E161FF48D4FFDC8FF009B57A15C7DF1F4AF2311FC77FD743D2A1FC14479A33499A335050B9A33499A33400B9AEA6B95CD75559D4E8694FA9E4B451457A879E145145006CF877FE3F25FFAE7FD4572DF158FFA4E99FEE49FCD6BA8F0EFFC7E4BFF005CFF00A8AE5BE2B7FC7CE99FEE49FCD6B9A3FEF2BFAE86F2FF0077679D668A28AF40E20A28A2800A28A2800A28A2803B1F0E6ADF6987EC9337EFA31F293FC4BFE228F11EADF6687EC90B7EFA41F311FC2BFE26B9286692DE649A26DAE8720D134D25C4CF34ADB9DCE49A8E4D6E5F369623A28A2AC80A33451400B9A5CD368A007834E06982945508F45F8587FD2353FF00723FE6D5E85707E71F4AF3CF857FF1F3A9FF00B91FF36AF42B8FBE3E95E4E23F8EFF00AE87A347F8288A8A4A2A0A168A4A28016BACAE4ABADACEA7434A67FFD9, N'正常')
SET IDENTITY_INSERT [dbo].[MemberInfo] OFF
/****** Object:  Table [dbo].[MemberHistoryInfo]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberHistoryInfo](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[CardID] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[CardType] [varchar](50) NULL,
	[IDCardType] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[IDCard] [varchar](50) NULL,
	[Sex] [varchar](50) NULL,
	[StartTime] [varchar](50) NULL,
	[Birthday] [varchar](50) NULL,
	[EndTime] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Count] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[AddTime] [varchar](50) NULL,
	[AddUserName] [varchar](50) NULL,
	[InfoType] [varchar](50) NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK__MemberHi__0CF04B381ED998B2] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MemberHistoryInfo] ON
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (2, N'123456', N'327549286@qq.com', N'10次体验卡', N'身份证', N'金浩', N'612422198802265210', N'男', N'2014-2-11 11:52:11', N'1988-2-11 11:52:11', N'2014-2-11 11:52:11', N'18629075037', N'10', N'', N'2014-2-11 11:53:15', N'用户名：赵武男', N'添加', NULL)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (3, N'123341', N'12312', N'半年卡', N'身份证', N'qwe', N'2132', N'男', N'2014-2-15 16:2:14', N'2014-2-15 16:2:10', N'2014-8-15 16:2:14', N'12312', N'', N'123', N'2014-2-15 16:2:21', N'赵武男', N'添加', NULL)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (4, N'13123', N'123', N'包年费', N'身份证', N'123123', N'123', N'男', N'2014-2-15 16:2:27', N'2014-2-15 16:2:25', N'2015-2-15 16:2:27', N'123', N'', N'13', N'2014-2-15 16:2:40', N'赵武男', N'添加', NULL)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (5, N'213', N'123', N'包年费', N'身份证', N'123', N'13', N'男', N'2014-2-15 16:36:11', N'2014-2-15 16:36:8', N'2015-2-15 16:36:11', N'123', N'', N'13', N'2014-2-15 16:36:15', N'赵武男', N'添加', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800FD00F903012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00EDA8A4A2BD73CC168A4A280168A4A280168A4A280168A4A280168A4A280168A4A28016BABAE4EBACAC2BF436A5D428A28AC0D828A28A0028A28A0028A28A0028A28A0028A28A0028A28A002B7AB06B7AB2A9D0B81E6B452515EA1C02D14945002D14945002D14945002D14945002D14945002D14945002D7599AE4ABACAE7AFD0D6975173466928AC0D85CD19A4A280173466928A005CD19A4A280173466928A005CD19A4A280173466928A005CD6F56056FD6553A1A533CCE8A4A2BD43CF168A4A280168A4A280168A4A280168A4A28016A582DE6B99447046CEE7B015774AD1A6D49B79263801E5FD7D857564D8689645D9A3B7817EF331EA7FA9AC2A57517CAB566D0A4E5ABD118B69E157601AEE6D9FEC47C9FCEB5E0D0B4E8318B70E7D643BBF4E95CA6A9E3F66263D3200ABD3CE94649FA2FF8FE55CBDDEAFA85FB1373793480FF000EEC2FE438A4A8D7A9AC9D8A75294348AB9EB25B4DB63B09B588FA12AB4F5BAB198ED49ADDC9EC1D4D78C8A5A7F52FEF0BEB5E47B3BDA40FFF002CC03EDC556934EC731BE7D9ABCB2D354BFB120DB5DCD181FC21B8FCBA574FA678EE54223D4A1122FF00CF588608FA8E87F0C5672C2D48EB1772E35E12DD58DF78DE36DAEA41F7A6D6A5BDD5A6A96A2582449A23DC763FD0D53B9B5683E61F327AFA562A5AD9EE68E3D515E8A28AA2428A28A0028A28A0028A28A0028A28A002B7EB02B7EB2A9D0D20799514668CD7AA79E14519A33400514668CD0014519A33400568E8FA636A37586C8813976FE82A8468D2CA91A0CB390A07B9AEE6DE28347D2CEF60B1C485E47F538E4D615EA722B2DD9B528733BBD90CD5755B3D034D12CA005036C512F058FA0FF1AF2CD5B5ABCD66E8CD7527CA3EE463EEA0F61FD69BAEEB536B7A93DCBE5631F2C51FF757FC7D6B381ADB0F8754D5E5B99D6ACE6ECB625069C0D440D381AE93026069735106A706A4324CD19A6669734017B4DD56EB49BA13DAC854FF00129FBAE3D08AF4ED1B59B6D6ECBCD8BE571C4B11392A7FC3DEBC8B357B49D526D23504BA84E40E1D33C3AF715CD5F0EAA2BADCDA8D670767B1E99756FE43E57EE1E9EDED55F35A70CD0EA3629344DBA2954329FF003DEB3594A3153D41C1AF3E2EFA3DCEC92EA84CD19A28AB24334668A2800CD19A28A00334668A2800CD7415CFD7415954E8694CF31A2928AF50F3C5A2928A005A2928A005A2928A00DBF0D5A896FDA761F2C2BC7D4F4FEB507C43D58C165069B1B61A73BE4C7F741E07E27F956D786A2F2F4D693BC8E4FE038FF1AF38F18DE1BBF145E1CFCB111128F4DA39FD735CF4A3ED31177D0DE6F928E9D4C6069E1AA10D4A1ABD33889C35286A843538352B01306A706A8435286A5619306A5DD5106A5DD4AC04BBA9334CDD46EA00EF3C03A99649F4D76FBBFBD8FE9D187F23F89AE9EF93122B8FE21835E61E1BBC367E21B293380D208DBE8DC7F5AF55BC5DD013E8735E5E263C956EBA9DF425CD4EDD8CEA28A2A0A0A28A2800A28A2800A28A2800AE82B9FAE82B2A9D0D299E61452515EA9E70B45251400B45251400B45251401DC68C36E916C07F749FD4D78CEA9219757BD909E5A7727FEFA35EC5A23EFD220F6041FCCD78F6B511835CBF88FF000DC38FFC78D6184FE24CDF11F044A99A5CD479A5CD7A1739090353835439A70345C44A1A9C1AA1069734C098353B7541BA9775004FBA8DD50EEA5DD4AC05AB790C773138EAAE08FCEBDAE7E607FA578958A19EFEDE21C9795547E240AF6B9CE217FA579D8EF8A276E136919D45145731A851451400514514005145140057415CFD74159D4E8694CF2FA28CD19AF54F3828A33466800A28CD19A0028A33466803A7F0D4FBAD25849E51F23E87FF00D55C0F8F2C8DA78964940C25CA2C83EBD0FEA33F8D751A25D8B5D45431C249F21FE9FAD59F1C68E753D17CF89775C5A92EA0752BFC43FAFE15CA9FB2C45DECCE9B73D1B754793E697349457A4718E06941A68A70A0438528A68A514C42E6973494A2980B9A334940A00E87C1B666F3C496E7194833337B63A7EA457A95D362303D4D735E06D24D8E94D792AE26BAC119EC83A7E7D7F2ADEB87DD260745E2BC7C44FDA56D3647A3463C94F5EA459A33494548C5CD19A4A280173466928A005CD19A4A2801735D0573D5D0D6553A1A533CBA8A28AF54F3828A28A0028A28A0028A28A002BAFD235017B6815CFEF9061F3DFDEB90A9AD2EA4B3B859A33C8EA3B11E958D6A5ED236EA694AA724BC8C4F187869B49BC3776C87EC3336463FE59B7F77E9E95CC62BDBA396D757B16464592271B648DB9C7B1AF3CF117832E34D67B9B1569ED3A95032F1FD7D47BD3C3E22FEE54D1955A8FDA86C72829C28C518AED394514A2814A29882968C52E298098AE87C2DE1D7D62F04B32916511CB9FEF9FEE8FEB52E81E11B9D51967BA0D059F5C918671FEC8F4F7AF4882182C2D52082358E2418555AE1C4E2945724373AA8506FDE96C492388A301401C6140ED54E9CEE5DB269B5C318D91D5277614514551214514500145145001451450015D0D73D5D0D6553A1A533CB68A28AF54F3828A28A0028A28A0028A28A0028A28A009ADAEA6B494490B9561D7D0FD6BA6B1D6A0BB012422297D09E0FD0D615A6917577860BE5A1FE27E3F215B36FA05AC58329695BDCE07E42B92BBA4F7DFC8E9A2AA2DB62BEABE11D2F546690C66DE73C9921E327DC743FCEB95BCF87FA8C249B59A1B85EC09D8DF91E3F5AEF2E2FAC34C840B9BA82D900E048E17F2CD44FADD8A8C894BFFBAA6B2A55AB47E1D51A54A749FC5A33CD64F0A6B71121B4F90E3FBA437F23447E15D6E4202E9F20CFF7885FE66BD2175DB33D7CC1F55A0EBB663A7987E8B5D1F5AAFF00CA63EC297F31C5DA780B529883732C36EBDF9DEDF90E3F5AEA34BF08699A6912321B9987F1CBC807D874FE75A11EB364FF00F2D0A9FF00694D4B6BA8595FAE6D6EA19C77F2DC363EB5CF56BD792F7B446D4E9525B6A4EF284E3A9AAECE5CE49A99A153D38A89A365ED91ED594394B9730CA28CD19AD480A28CD19A0028A33466800A28CD19A0028A33466800AE86B9ECD7435954E8694CF2CA28A2BD53CE0A28A2800A28A2800A28AB563632DF4FB13851F798F40293692BB1A4DBB222B7B796EA511C28598FE9F5AE96C34586D407940965F53D07D054C05968D60F248EB0C318CBC8E7AFD6BCDFC4BE3BB9D48BDAE9A5EDED3A171C3C9FE03DBFFD55CBCD52BBE58688E8B428ABCF56765AE78D74BD14B441CDD5D0FF0096511E87FDA6E83F53ED5E7DAAF8EF5BD48B2C73FD8E13D120E0FE2DD7F2C57378A315D74B0B4E1D2ECE6A9889CFC90D76791CBBB1663C9663926BD2EC275BAB08265390E80FE3DEBCD715B7A0EBBFD9C4DBDC64DB31C8239287D7E95B4E375A1941D9EA77140A6433473C4B2C4E1E36190C3A1A5925486369247088A32598E00AE7360B8996DADA499CFCB1A9635E6A8ECAE1D58AB039041C106B6F5ED785F0FB2DB67ECE0E598F1BCFF85618ADE11B2D4CA72BBD0E974BF1B6B3A715579FED508FE09FE63F8375AEF345F19E9BAB95899BECB727FE59CA7827D9BA1FD0D7908A70AC6AE1A9CFA599A53C44E1E68F7A7883723835032953822BCEBC3BE35B9D34ADB5F97B8B4E8189CBC7F4F51ED5E936F716F7F6A93DBC8B2C2E32AEA6BCF9C2745DA5B1DB09C6AABC7722A29CE850E0F4A6D09DC028A28A60145145001451450015D1573B5D156553A1A533CAE8A4A2BD53CE168A4A280168A4A28027B5B67BBB84863EAC793E83D6BAAFF44D174E79247114112EE776EFEFF5A8F48B01656DB9C7EFA4196CF6F6AF35F1BF89FF00B5EFBEC56AFF00E856EDD41FF58FEBF41DBF3AE377C454E45B23A55A8C399EECA5E26F13DC7882ECF2D1D9C67F75167FF1E6F53FCAB06933466BD38414172C7638252727762D06933466A8421A5552EEAAA32CC70052135A7E1FB6FB56B500232B19F31BF0E9FAE293764095D9DD5A402D6D21817A46817EB8A5BA805D5A4D0374910AFE952D15CC741E6054A395618607047BD28357F5FB6FB2EB338030B21F317F1EBFAE6B381AE95AAB9CED5992834F151034F06901256D7877C4571A0DD82097B573FBD8B3FA8F435860D2E6A6515256638C9C5DD1EEB6D7306A1691DC5BC824864195614C60558835E69E0EF119D22F7ECB72FF00E853B724FF00CB36FEF7D3D7FF00AD5EA522875C8EA3A5793529BA33E57B1E9C26AAC6EB72B668CD145300CD19A28A00334668A2800CD7475CE57475954E8694FA9E559A3349457AA79C2E68CD251400B9AD3D12D3ED37BBD86638BE63EE7B565D75BA2DBFD9F4E4247CD27CE7F1E9FA561889F2C34EA6B461CD3313C7BAF1D2747FB2C0F8BABBCA020F2A9FC47FA7E3ED5E420D6CF8B7573AC788AE6756CC319F2A2F4DABDFF1393F8D6266BA70D4BD9D34BAB31AF539E7E43F34B9A6668CD6E623F3499A6E68CD003B35D6783ADF11DC5D11F7888D4FD393FD2B90CD7A26896DF64D1EDA3230C577B7D4F3515362A0B534F3466999A33581B1CDF8C2DF31DBDD01D098DBF1E47F5AE50357A06B76DF6BD1EE23032C177AFD4735E760D6F4F6319EE4E1A9E1AAB86A786AA249C1A766A10D4E068024CD7A9F81B5B3A96946D266CDC5A80B927964EC7F0E9F9579566B5FC33AA9D275EB6B82D8898F972FFBA7AFE5C1FC2B9F114BDA536BA9B50A9C93BF43D8255DAD9EC6A3AB128DC87DB9AAF9AF320EE8F424ACC28A33466AC90A28CD19A002BA4AE6F35D256553A1A53EA79451499A335EA9E70B452668CD00490C6669E38875760BF9D74BE24BEFECAF0CDEDCA1DAC916C8C8ECC7E51FA9158DA2C7E66A9167A2E5BF4AAFF13AE8C5E1FB7B707066B819F70013FCF15CB5573D68C0E8A6F9694A4794669734DCD19AF50F3C7669734DCD1400ECD266928CD005AD3EDBED9A8DBDBF50EE01FA77FD335E99D2B8BF085B799A84B7047112607D4FFF00581AED2B0A8F5B1AC1681451454161D783D2BCD350B6FB1EA33DBF647207D3B7E98AF4BAE2FC5F6DE56A115C01F2CA983F51FF00D622AE9BD6C44D6860034F06A3069C0D6C644A0D381A881A70340C941A5CD460D2E6901EDBE1ABEFED1F0E595C31CB98F639FF00697E53FCB356D86188F4AE5BE1BDC99345B9B7273E54F91EC180FEA0D75528C487DEBC694796ACA27AB17CD4D486D14945310B45251400B5D2D7335D356553A1A53EA793D1499A335EA1E78B452668CD006C787466FDCFA467F98AE7BE2B487FE2551F6FDEB1FF00C77FFAF5D17870FF00A64BFF005CFF00A8AE5FE2B1FF0049D2FF00DC93F9AD73C7FDE97F5D0DE5FEEECF3DCD2E6999A5CD7A4700ECD19A6E68CD1701F9A334DCD19A2E077BE16B6F23475908F9A662FF008741FCBF5ADACD62F87B528EF74E48861658142328F41D0D6BE6B9E5B9B2D87E68CD33346690C7E6B17C536DE7E8ED201968583FE1D0FF003FD2B5F3591E21D4A3B3D39E2386967528AA7D0F534E3B89EC70B9A50D51E69735D0624A1A9C1AA1CD286A044C1A9C1AA10D4E0D401E89F0C643E66A71F62236FF00D0BFC6BBD9FEF8FA579EFC2FE6EB523FEC27F335E8339F987D2BC8C47F1DFF005D0F4E8FF0511D149454142D14945002D74F5CBD75159D4E8694FA9E4D451457A879E145145006CF873FE3F25FFAE7FD4572DF15BFE3E74BFF00724FE6B5D47877FE3F25FF00AE7FD4572DF15BFE3E74BFF724FE6B5CD1FF00795FD743797FBBB3CF33466929335E89C23B34669B9A33400ECD2E6999A5CD005CD3EFE5D3AF12E233D3865FEF0EE2BD0EDAEA3BBB749E26CA38C8AF30ADBF0F6AFF0061B8FB3CCDFE8F29EA7F85BD6A26AFA97176D0EE7751BAA3DD46EAC4D44B9BA8ED2DDE795B088326BCF350BF9751BC7B894F5E157FBA3B0ABFE21D5FEDD71F6785BFD1E23D47F137AD6256D056D4CA4EE3B34669B9A335A103F34B9A666941A007834E06A3069C0D311E89F0B4E6E353FF00723FE6D5E8339F9C7D2BCF3E161FF48D4FFDC8FF009B57A15C7DF1F4AF2311FC77FD743D2A1FC14479A33499A335050B9A33499A33400B9AEA6B95CD75559D4E8694FA9E4B451457A879E145145006CF877FE3F25FFAE7FD4572DF158FFA4E99FEE49FCD6BA8F0EFFC7E4BFF005CFF00A8AE5BE2B7FC7CE99FEE49FCD6B9A3FEF2BFAE86F2FF0077679D668A28AF40E20A28A2800A28A2800A28A2803B1F0E6ADF6987EC9337EFA31F293FC4BFE228F11EADF6687EC90B7EFA41F311FC2BFE26B9286692DE649A26DAE8720D134D25C4CF34ADB9DCE49A8E4D6E5F369623A28A2AC80A33451400B9A5CD368A007834E06982945508F45F8587FD2353FF00723FE6D5E85707E71F4AF3CF857FF1F3A9FF00B91FF36AF42B8FBE3E95E4E23F8EFF00AE87A347F8288A8A4A2A0A168A4A28016BACAE4ABADACEA7434A67FFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (6, N'qe', N'qwe', N'包年费', N'身份证', N'qwe', N'qe', N'男', N'2014-2-15 16:37:43', N'2014-2-15 16:37:41', N'2015-2-15 16:37:43', N'qwe', N'', N'qe', N'2014-2-15 16:37:48', N'赵武男', N'添加', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800FD00F903012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00EDA8A4A2BD73CC168A4A280168A4A280168A4A280168A4A280168A4A280168A4A28016BABAE4EBACAC2BF436A5D428A28AC0D828A28A0028A28A0028A28A0028A28A0028A28A0028A28A002B7AB06B7AB2A9D0B81E6B452515EA1C02D14945002D14945002D14945002D14945002D14945002D14945002D7599AE4ABACAE7AFD0D6975173466928AC0D85CD19A4A280173466928A005CD19A4A280173466928A005CD19A4A280173466928A005CD6F56056FD6553A1A533CCE8A4A2BD43CF168A4A280168A4A280168A4A280168A4A28016A582DE6B99447046CEE7B015774AD1A6D49B79263801E5FD7D857564D8689645D9A3B7817EF331EA7FA9AC2A57517CAB566D0A4E5ABD118B69E157601AEE6D9FEC47C9FCEB5E0D0B4E8318B70E7D643BBF4E95CA6A9E3F66263D3200ABD3CE94649FA2FF8FE55CBDDEAFA85FB1373793480FF000EEC2FE438A4A8D7A9AC9D8A75294348AB9EB25B4DB63B09B588FA12AB4F5BAB198ED49ADDC9EC1D4D78C8A5A7F52FEF0BEB5E47B3BDA40FFF002CC03EDC556934EC731BE7D9ABCB2D354BFB120DB5DCD181FC21B8FCBA574FA678EE54223D4A1122FF00CF588608FA8E87F0C5672C2D48EB1772E35E12DD58DF78DE36DAEA41F7A6D6A5BDD5A6A96A2582449A23DC763FD0D53B9B5683E61F327AFA562A5AD9EE68E3D515E8A28AA2428A28A0028A28A0028A28A0028A28A002B7EB02B7EB2A9D0D20799514668CD7AA79E14519A33400514668CD0014519A33400568E8FA636A37586C8813976FE82A8468D2CA91A0CB390A07B9AEE6DE28347D2CEF60B1C485E47F538E4D615EA722B2DD9B528733BBD90CD5755B3D034D12CA005036C512F058FA0FF1AF2CD5B5ABCD66E8CD7527CA3EE463EEA0F61FD69BAEEB536B7A93DCBE5631F2C51FF757FC7D6B381ADB0F8754D5E5B99D6ACE6ECB625069C0D440D381AE93026069735106A706A4324CD19A6669734017B4DD56EB49BA13DAC854FF00129FBAE3D08AF4ED1B59B6D6ECBCD8BE571C4B11392A7FC3DEBC8B357B49D526D23504BA84E40E1D33C3AF715CD5F0EAA2BADCDA8D670767B1E99756FE43E57EE1E9EDED55F35A70CD0EA3629344DBA2954329FF003DEB3594A3153D41C1AF3E2EFA3DCEC92EA84CD19A28AB24334668A2800CD19A28A00334668A2800CD7415CFD7415954E8694CF31A2928AF50F3C5A2928A005A2928A005A2928A00DBF0D5A896FDA761F2C2BC7D4F4FEB507C43D58C165069B1B61A73BE4C7F741E07E27F956D786A2F2F4D693BC8E4FE038FF1AF38F18DE1BBF145E1CFCB111128F4DA39FD735CF4A3ED31177D0DE6F928E9D4C6069E1AA10D4A1ABD33889C35286A843538352B01306A706A8435286A5619306A5DD5106A5DD4AC04BBA9334CDD46EA00EF3C03A99649F4D76FBBFBD8FE9D187F23F89AE9EF93122B8FE21835E61E1BBC367E21B293380D208DBE8DC7F5AF55BC5DD013E8735E5E263C956EBA9DF425CD4EDD8CEA28A2A0A0A28A2800A28A2800A28A2800AE82B9FAE82B2A9D0D299E61452515EA9E70B45251400B45251400B45251401DC68C36E916C07F749FD4D78CEA9219757BD909E5A7727FEFA35EC5A23EFD220F6041FCCD78F6B511835CBF88FF000DC38FFC78D6184FE24CDF11F044A99A5CD479A5CD7A1739090353835439A70345C44A1A9C1AA1069734C098353B7541BA9775004FBA8DD50EEA5DD4AC05AB790C773138EAAE08FCEBDAE7E607FA578958A19EFEDE21C9795547E240AF6B9CE217FA579D8EF8A276E136919D45145731A851451400514514005145140057415CFD74159D4E8694CF2FA28CD19AF54F3828A33466800A28CD19A0028A33466803A7F0D4FBAD25849E51F23E87FF00D55C0F8F2C8DA78964940C25CA2C83EBD0FEA33F8D751A25D8B5D45431C249F21FE9FAD59F1C68E753D17CF89775C5A92EA0752BFC43FAFE15CA9FB2C45DECCE9B73D1B754793E697349457A4718E06941A68A70A0438528A68A514C42E6973494A2980B9A334940A00E87C1B666F3C496E7194833337B63A7EA457A95D362303D4D735E06D24D8E94D792AE26BAC119EC83A7E7D7F2ADEB87DD260745E2BC7C44FDA56D3647A3463C94F5EA459A33494548C5CD19A4A280173466928A005CD19A4A2801735D0573D5D0D6553A1A533CBA8A28AF54F3828A28A0028A28A0028A28A002BAFD235017B6815CFEF9061F3DFDEB90A9AD2EA4B3B859A33C8EA3B11E958D6A5ED236EA694AA724BC8C4F187869B49BC3776C87EC3336463FE59B7F77E9E95CC62BDBA396D757B16464592271B648DB9C7B1AF3CF117832E34D67B9B1569ED3A95032F1FD7D47BD3C3E22FEE54D1955A8FDA86C72829C28C518AED394514A2814A29882968C52E298098AE87C2DE1D7D62F04B32916511CB9FEF9FEE8FEB52E81E11B9D51967BA0D059F5C918671FEC8F4F7AF4882182C2D52082358E2418555AE1C4E2945724373AA8506FDE96C492388A301401C6140ED54E9CEE5DB269B5C318D91D5277614514551214514500145145001451450015D0D73D5D0D6553A1A533CB68A28AF54F3828A28A0028A28A0028A28A0028A28A009ADAEA6B494490B9561D7D0FD6BA6B1D6A0BB012422297D09E0FD0D615A6917577860BE5A1FE27E3F215B36FA05AC58329695BDCE07E42B92BBA4F7DFC8E9A2AA2DB62BEABE11D2F546690C66DE73C9921E327DC743FCEB95BCF87FA8C249B59A1B85EC09D8DF91E3F5AEF2E2FAC34C840B9BA82D900E048E17F2CD44FADD8A8C894BFFBAA6B2A55AB47E1D51A54A749FC5A33CD64F0A6B71121B4F90E3FBA437F23447E15D6E4202E9F20CFF7885FE66BD2175DB33D7CC1F55A0EBB663A7987E8B5D1F5AAFF00CA63EC297F31C5DA780B529883732C36EBDF9DEDF90E3F5AEA34BF08699A6912321B9987F1CBC807D874FE75A11EB364FF00F2D0A9FF00694D4B6BA8595FAE6D6EA19C77F2DC363EB5CF56BD792F7B446D4E9525B6A4EF284E3A9AAECE5CE49A99A153D38A89A365ED91ED594394B9730CA28CD19AD480A28CD19A0028A33466800A28CD19A0028A33466800AE86B9ECD7435954E8694CF2CA28A2BD53CE0A28A2800A28A2800A28AB563632DF4FB13851F798F40293692BB1A4DBB222B7B796EA511C28598FE9F5AE96C34586D407940965F53D07D054C05968D60F248EB0C318CBC8E7AFD6BCDFC4BE3BB9D48BDAE9A5EDED3A171C3C9FE03DBFFD55CBCD52BBE58688E8B428ABCF56765AE78D74BD14B441CDD5D0FF0096511E87FDA6E83F53ED5E7DAAF8EF5BD48B2C73FD8E13D120E0FE2DD7F2C57378A315D74B0B4E1D2ECE6A9889CFC90D76791CBBB1663C9663926BD2EC275BAB08265390E80FE3DEBCD715B7A0EBBFD9C4DBDC64DB31C8239287D7E95B4E375A1941D9EA77140A6433473C4B2C4E1E36190C3A1A5925486369247088A32598E00AE7360B8996DADA499CFCB1A9635E6A8ECAE1D58AB039041C106B6F5ED785F0FB2DB67ECE0E598F1BCFF85618ADE11B2D4CA72BBD0E974BF1B6B3A715579FED508FE09FE63F8375AEF345F19E9BAB95899BECB727FE59CA7827D9BA1FD0D7908A70AC6AE1A9CFA599A53C44E1E68F7A7883723835032953822BCEBC3BE35B9D34ADB5F97B8B4E8189CBC7F4F51ED5E936F716F7F6A93DBC8B2C2E32AEA6BCF9C2745DA5B1DB09C6AABC7722A29CE850E0F4A6D09DC028A28A60145145001451450015D1573B5D156553A1A533CAE8A4A2BD53CE168A4A280168A4A28027B5B67BBB84863EAC793E83D6BAAFF44D174E79247114112EE776EFEFF5A8F48B01656DB9C7EFA4196CF6F6AF35F1BF89FF00B5EFBEC56AFF00E856EDD41FF58FEBF41DBF3AE377C454E45B23A55A8C399EECA5E26F13DC7882ECF2D1D9C67F75167FF1E6F53FCAB06933466BD38414172C7638252727762D06933466A8421A5552EEAAA32CC70052135A7E1FB6FB56B500232B19F31BF0E9FAE293764095D9DD5A402D6D21817A46817EB8A5BA805D5A4D0374910AFE952D15CC741E6054A395618607047BD28357F5FB6FB2EB338030B21F317F1EBFAE6B381AE95AAB9CED5992834F151034F06901256D7877C4571A0DD82097B573FBD8B3FA8F435860D2E6A6515256638C9C5DD1EEB6D7306A1691DC5BC824864195614C60558835E69E0EF119D22F7ECB72FF00E853B724FF00CB36FEF7D3D7FF00AD5EA522875C8EA3A5793529BA33E57B1E9C26AAC6EB72B668CD145300CD19A28A00334668A2800CD7475CE57475954E8694FA9E559A3349457AA79C2E68CD251400B9AD3D12D3ED37BBD86638BE63EE7B565D75BA2DBFD9F4E4247CD27CE7F1E9FA561889F2C34EA6B461CD3313C7BAF1D2747FB2C0F8BABBCA020F2A9FC47FA7E3ED5E420D6CF8B7573AC788AE6756CC319F2A2F4DABDFF1393F8D6266BA70D4BD9D34BAB31AF539E7E43F34B9A6668CD6E623F3499A6E68CD003B35D6783ADF11DC5D11F7888D4FD393FD2B90CD7A26896DF64D1EDA3230C577B7D4F3515362A0B534F3466999A33581B1CDF8C2DF31DBDD01D098DBF1E47F5AE50357A06B76DF6BD1EE23032C177AFD4735E760D6F4F6319EE4E1A9E1AAB86A786AA249C1A766A10D4E068024CD7A9F81B5B3A96946D266CDC5A80B927964EC7F0E9F9579566B5FC33AA9D275EB6B82D8898F972FFBA7AFE5C1FC2B9F114BDA536BA9B50A9C93BF43D8255DAD9EC6A3AB128DC87DB9AAF9AF320EE8F424ACC28A33466AC90A28CD19A002BA4AE6F35D256553A1A53EA79451499A335EA9E70B452668CD00490C6669E38875760BF9D74BE24BEFECAF0CDEDCA1DAC916C8C8ECC7E51FA9158DA2C7E66A9167A2E5BF4AAFF13AE8C5E1FB7B707066B819F70013FCF15CB5573D68C0E8A6F9694A4794669734DCD19AF50F3C7669734DCD1400ECD266928CD005AD3EDBED9A8DBDBF50EE01FA77FD335E99D2B8BF085B799A84B7047112607D4FFF00581AED2B0A8F5B1AC1681451454161D783D2BCD350B6FB1EA33DBF647207D3B7E98AF4BAE2FC5F6DE56A115C01F2CA983F51FF00D622AE9BD6C44D6860034F06A3069C0D6C644A0D381A881A70340C941A5CD460D2E6901EDBE1ABEFED1F0E595C31CB98F639FF00697E53FCB356D86188F4AE5BE1BDC99345B9B7273E54F91EC180FEA0D75528C487DEBC694796ACA27AB17CD4D486D14945310B45251400B5D2D7335D356553A1A53EA793D1499A335EA1E78B452668CD006C787466FDCFA467F98AE7BE2B487FE2551F6FDEB1FF00C77FFAF5D17870FF00A64BFF005CFF00A8AE5FE2B1FF0049D2FF00DC93F9AD73C7FDE97F5D0DE5FEEECF3DCD2E6999A5CD7A4700ECD19A6E68CD1701F9A334DCD19A2E077BE16B6F23475908F9A662FF008741FCBF5ADACD62F87B528EF74E48861658142328F41D0D6BE6B9E5B9B2D87E68CD33346690C7E6B17C536DE7E8ED201968583FE1D0FF003FD2B5F3591E21D4A3B3D39E2386967528AA7D0F534E3B89EC70B9A50D51E69735D0624A1A9C1AA1CD286A044C1A9C1AA10D4E0D401E89F0C643E66A71F62236FF00D0BFC6BBD9FEF8FA579EFC2FE6EB523FEC27F335E8339F987D2BC8C47F1DFF005D0F4E8FF0511D149454142D14945002D74F5CBD75159D4E8694FA9E4D451457A879E145145006CF873FE3F25FFAE7FD4572DF15BFE3E74BFF00724FE6B5D47877FE3F25FF00AE7FD4572DF15BFE3E74BFF724FE6B5CD1FF00795FD743797FBBB3CF33466929335E89C23B34669B9A33400ECD2E6999A5CD005CD3EFE5D3AF12E233D3865FEF0EE2BD0EDAEA3BBB749E26CA38C8AF30ADBF0F6AFF0061B8FB3CCDFE8F29EA7F85BD6A26AFA97176D0EE7751BAA3DD46EAC4D44B9BA8ED2DDE795B088326BCF350BF9751BC7B894F5E157FBA3B0ABFE21D5FEDD71F6785BFD1E23D47F137AD6256D056D4CA4EE3B34669B9A335A103F34B9A666941A007834E06A3069C0D311E89F0B4E6E353FF00723FE6D5E8339F9C7D2BCF3E161FF48D4FFDC8FF009B57A15C7DF1F4AF2311FC77FD743D2A1FC14479A33499A335050B9A33499A33400B9AEA6B95CD75559D4E8694FA9E4B451457A879E145145006CF877FE3F25FFAE7FD4572DF158FFA4E99FEE49FCD6BA8F0EFFC7E4BFF005CFF00A8AE5BE2B7FC7CE99FEE49FCD6B9A3FEF2BFAE86F2FF0077679D668A28AF40E20A28A2800A28A2800A28A2803B1F0E6ADF6987EC9337EFA31F293FC4BFE228F11EADF6687EC90B7EFA41F311FC2BFE26B9286692DE649A26DAE8720D134D25C4CF34ADB9DCE49A8E4D6E5F369623A28A2AC80A33451400B9A5CD368A007834E06982945508F45F8587FD2353FF00723FE6D5E85707E71F4AF3CF857FF1F3A9FF00B91FF36AF42B8FBE3E95E4E23F8EFF00AE87A347F8288A8A4A2A0A168A4A28016BACAE4ABADACEA7434A67FFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (7, N'sfedfsadf', N'asdf', N'工本费', N'身份证', N'asdf', N'asdf', N'男', N'2014-2-15 16:45:42', N'2014-2-15 16:45:42', N'2014-2-15 16:45:42', N'asdfasdasdf', N'', N'sadf', N'2014-2-15 16:45:55', N'赵武男', N'添加', NULL)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (8, N'12', N'123', N'工本费', N'身份证', N'213', N'13', N'男', N'2014-2-15 16:48:18', N'2014-2-15 16:48:18', N'2014-2-15 16:48:18', N'123', N'', N'13', N'2014-2-15 16:48:25', N'赵武男', N'添加', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800FD00F903012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00EDA8A4A2BD73CC168A4A280168A4A280168A4A280168A4A280168A4A280168A4A28016BABAE4EBACAC2BF436A5D428A28AC0D828A28A0028A28A0028A28A0028A28A0028A28A0028A28A002B7AB06B7AB2A9D0B81E6B452515EA1C02D14945002D14945002D14945002D14945002D14945002D14945002D7599AE4ABACAE7AFD0D6975173466928AC0D85CD19A4A280173466928A005CD19A4A280173466928A005CD19A4A280173466928A005CD6F56056FD6553A1A533CCE8A4A2BD43CF168A4A280168A4A280168A4A280168A4A28016A582DE6B99447046CEE7B015774AD1A6D49B79263801E5FD7D857564D8689645D9A3B7817EF331EA7FA9AC2A57517CAB566D0A4E5ABD118B69E157601AEE6D9FEC47C9FCEB5E0D0B4E8318B70E7D643BBF4E95CA6A9E3F66263D3200ABD3CE94649FA2FF8FE55CBDDEAFA85FB1373793480FF000EEC2FE438A4A8D7A9AC9D8A75294348AB9EB25B4DB63B09B588FA12AB4F5BAB198ED49ADDC9EC1D4D78C8A5A7F52FEF0BEB5E47B3BDA40FFF002CC03EDC556934EC731BE7D9ABCB2D354BFB120DB5DCD181FC21B8FCBA574FA678EE54223D4A1122FF00CF588608FA8E87F0C5672C2D48EB1772E35E12DD58DF78DE36DAEA41F7A6D6A5BDD5A6A96A2582449A23DC763FD0D53B9B5683E61F327AFA562A5AD9EE68E3D515E8A28AA2428A28A0028A28A0028A28A0028A28A002B7EB02B7EB2A9D0D20799514668CD7AA79E14519A33400514668CD0014519A33400568E8FA636A37586C8813976FE82A8468D2CA91A0CB390A07B9AEE6DE28347D2CEF60B1C485E47F538E4D615EA722B2DD9B528733BBD90CD5755B3D034D12CA005036C512F058FA0FF1AF2CD5B5ABCD66E8CD7527CA3EE463EEA0F61FD69BAEEB536B7A93DCBE5631F2C51FF757FC7D6B381ADB0F8754D5E5B99D6ACE6ECB625069C0D440D381AE93026069735106A706A4324CD19A6669734017B4DD56EB49BA13DAC854FF00129FBAE3D08AF4ED1B59B6D6ECBCD8BE571C4B11392A7FC3DEBC8B357B49D526D23504BA84E40E1D33C3AF715CD5F0EAA2BADCDA8D670767B1E99756FE43E57EE1E9EDED55F35A70CD0EA3629344DBA2954329FF003DEB3594A3153D41C1AF3E2EFA3DCEC92EA84CD19A28AB24334668A2800CD19A28A00334668A2800CD7415CFD7415954E8694CF31A2928AF50F3C5A2928A005A2928A005A2928A00DBF0D5A896FDA761F2C2BC7D4F4FEB507C43D58C165069B1B61A73BE4C7F741E07E27F956D786A2F2F4D693BC8E4FE038FF1AF38F18DE1BBF145E1CFCB111128F4DA39FD735CF4A3ED31177D0DE6F928E9D4C6069E1AA10D4A1ABD33889C35286A843538352B01306A706A8435286A5619306A5DD5106A5DD4AC04BBA9334CDD46EA00EF3C03A99649F4D76FBBFBD8FE9D187F23F89AE9EF93122B8FE21835E61E1BBC367E21B293380D208DBE8DC7F5AF55BC5DD013E8735E5E263C956EBA9DF425CD4EDD8CEA28A2A0A0A28A2800A28A2800A28A2800AE82B9FAE82B2A9D0D299E61452515EA9E70B45251400B45251400B45251401DC68C36E916C07F749FD4D78CEA9219757BD909E5A7727FEFA35EC5A23EFD220F6041FCCD78F6B511835CBF88FF000DC38FFC78D6184FE24CDF11F044A99A5CD479A5CD7A1739090353835439A70345C44A1A9C1AA1069734C098353B7541BA9775004FBA8DD50EEA5DD4AC05AB790C773138EAAE08FCEBDAE7E607FA578958A19EFEDE21C9795547E240AF6B9CE217FA579D8EF8A276E136919D45145731A851451400514514005145140057415CFD74159D4E8694CF2FA28CD19AF54F3828A33466800A28CD19A0028A33466803A7F0D4FBAD25849E51F23E87FF00D55C0F8F2C8DA78964940C25CA2C83EBD0FEA33F8D751A25D8B5D45431C249F21FE9FAD59F1C68E753D17CF89775C5A92EA0752BFC43FAFE15CA9FB2C45DECCE9B73D1B754793E697349457A4718E06941A68A70A0438528A68A514C42E6973494A2980B9A334940A00E87C1B666F3C496E7194833337B63A7EA457A95D362303D4D735E06D24D8E94D792AE26BAC119EC83A7E7D7F2ADEB87DD260745E2BC7C44FDA56D3647A3463C94F5EA459A33494548C5CD19A4A280173466928A005CD19A4A2801735D0573D5D0D6553A1A533CBA8A28AF54F3828A28A0028A28A0028A28A002BAFD235017B6815CFEF9061F3DFDEB90A9AD2EA4B3B859A33C8EA3B11E958D6A5ED236EA694AA724BC8C4F187869B49BC3776C87EC3336463FE59B7F77E9E95CC62BDBA396D757B16464592271B648DB9C7B1AF3CF117832E34D67B9B1569ED3A95032F1FD7D47BD3C3E22FEE54D1955A8FDA86C72829C28C518AED394514A2814A29882968C52E298098AE87C2DE1D7D62F04B32916511CB9FEF9FEE8FEB52E81E11B9D51967BA0D059F5C918671FEC8F4F7AF4882182C2D52082358E2418555AE1C4E2945724373AA8506FDE96C492388A301401C6140ED54E9CEE5DB269B5C318D91D5277614514551214514500145145001451450015D0D73D5D0D6553A1A533CB68A28AF54F3828A28A0028A28A0028A28A0028A28A009ADAEA6B494490B9561D7D0FD6BA6B1D6A0BB012422297D09E0FD0D615A6917577860BE5A1FE27E3F215B36FA05AC58329695BDCE07E42B92BBA4F7DFC8E9A2AA2DB62BEABE11D2F546690C66DE73C9921E327DC743FCEB95BCF87FA8C249B59A1B85EC09D8DF91E3F5AEF2E2FAC34C840B9BA82D900E048E17F2CD44FADD8A8C894BFFBAA6B2A55AB47E1D51A54A749FC5A33CD64F0A6B71121B4F90E3FBA437F23447E15D6E4202E9F20CFF7885FE66BD2175DB33D7CC1F55A0EBB663A7987E8B5D1F5AAFF00CA63EC297F31C5DA780B529883732C36EBDF9DEDF90E3F5AEA34BF08699A6912321B9987F1CBC807D874FE75A11EB364FF00F2D0A9FF00694D4B6BA8595FAE6D6EA19C77F2DC363EB5CF56BD792F7B446D4E9525B6A4EF284E3A9AAECE5CE49A99A153D38A89A365ED91ED594394B9730CA28CD19AD480A28CD19A0028A33466800A28CD19A0028A33466800AE86B9ECD7435954E8694CF2CA28A2BD53CE0A28A2800A28A2800A28AB563632DF4FB13851F798F40293692BB1A4DBB222B7B796EA511C28598FE9F5AE96C34586D407940965F53D07D054C05968D60F248EB0C318CBC8E7AFD6BCDFC4BE3BB9D48BDAE9A5EDED3A171C3C9FE03DBFFD55CBCD52BBE58688E8B428ABCF56765AE78D74BD14B441CDD5D0FF0096511E87FDA6E83F53ED5E7DAAF8EF5BD48B2C73FD8E13D120E0FE2DD7F2C57378A315D74B0B4E1D2ECE6A9889CFC90D76791CBBB1663C9663926BD2EC275BAB08265390E80FE3DEBCD715B7A0EBBFD9C4DBDC64DB31C8239287D7E95B4E375A1941D9EA77140A6433473C4B2C4E1E36190C3A1A5925486369247088A32598E00AE7360B8996DADA499CFCB1A9635E6A8ECAE1D58AB039041C106B6F5ED785F0FB2DB67ECE0E598F1BCFF85618ADE11B2D4CA72BBD0E974BF1B6B3A715579FED508FE09FE63F8375AEF345F19E9BAB95899BECB727FE59CA7827D9BA1FD0D7908A70AC6AE1A9CFA599A53C44E1E68F7A7883723835032953822BCEBC3BE35B9D34ADB5F97B8B4E8189CBC7F4F51ED5E936F716F7F6A93DBC8B2C2E32AEA6BCF9C2745DA5B1DB09C6AABC7722A29CE850E0F4A6D09DC028A28A60145145001451450015D1573B5D156553A1A533CAE8A4A2BD53CE168A4A280168A4A28027B5B67BBB84863EAC793E83D6BAAFF44D174E79247114112EE776EFEFF5A8F48B01656DB9C7EFA4196CF6F6AF35F1BF89FF00B5EFBEC56AFF00E856EDD41FF58FEBF41DBF3AE377C454E45B23A55A8C399EECA5E26F13DC7882ECF2D1D9C67F75167FF1E6F53FCAB06933466BD38414172C7638252727762D06933466A8421A5552EEAAA32CC70052135A7E1FB6FB56B500232B19F31BF0E9FAE293764095D9DD5A402D6D21817A46817EB8A5BA805D5A4D0374910AFE952D15CC741E6054A395618607047BD28357F5FB6FB2EB338030B21F317F1EBFAE6B381AE95AAB9CED5992834F151034F06901256D7877C4571A0DD82097B573FBD8B3FA8F435860D2E6A6515256638C9C5DD1EEB6D7306A1691DC5BC824864195614C60558835E69E0EF119D22F7ECB72FF00E853B724FF00CB36FEF7D3D7FF00AD5EA522875C8EA3A5793529BA33E57B1E9C26AAC6EB72B668CD145300CD19A28A00334668A2800CD7475CE57475954E8694FA9E559A3349457AA79C2E68CD251400B9AD3D12D3ED37BBD86638BE63EE7B565D75BA2DBFD9F4E4247CD27CE7F1E9FA561889F2C34EA6B461CD3313C7BAF1D2747FB2C0F8BABBCA020F2A9FC47FA7E3ED5E420D6CF8B7573AC788AE6756CC319F2A2F4DABDFF1393F8D6266BA70D4BD9D34BAB31AF539E7E43F34B9A6668CD6E623F3499A6E68CD003B35D6783ADF11DC5D11F7888D4FD393FD2B90CD7A26896DF64D1EDA3230C577B7D4F3515362A0B534F3466999A33581B1CDF8C2DF31DBDD01D098DBF1E47F5AE50357A06B76DF6BD1EE23032C177AFD4735E760D6F4F6319EE4E1A9E1AAB86A786AA249C1A766A10D4E068024CD7A9F81B5B3A96946D266CDC5A80B927964EC7F0E9F9579566B5FC33AA9D275EB6B82D8898F972FFBA7AFE5C1FC2B9F114BDA536BA9B50A9C93BF43D8255DAD9EC6A3AB128DC87DB9AAF9AF320EE8F424ACC28A33466AC90A28CD19A002BA4AE6F35D256553A1A53EA79451499A335EA9E70B452668CD00490C6669E38875760BF9D74BE24BEFECAF0CDEDCA1DAC916C8C8ECC7E51FA9158DA2C7E66A9167A2E5BF4AAFF13AE8C5E1FB7B707066B819F70013FCF15CB5573D68C0E8A6F9694A4794669734DCD19AF50F3C7669734DCD1400ECD266928CD005AD3EDBED9A8DBDBF50EE01FA77FD335E99D2B8BF085B799A84B7047112607D4FFF00581AED2B0A8F5B1AC1681451454161D783D2BCD350B6FB1EA33DBF647207D3B7E98AF4BAE2FC5F6DE56A115C01F2CA983F51FF00D622AE9BD6C44D6860034F06A3069C0D6C644A0D381A881A70340C941A5CD460D2E6901EDBE1ABEFED1F0E595C31CB98F639FF00697E53FCB356D86188F4AE5BE1BDC99345B9B7273E54F91EC180FEA0D75528C487DEBC694796ACA27AB17CD4D486D14945310B45251400B5D2D7335D356553A1A53EA793D1499A335EA1E78B452668CD006C787466FDCFA467F98AE7BE2B487FE2551F6FDEB1FF00C77FFAF5D17870FF00A64BFF005CFF00A8AE5FE2B1FF0049D2FF00DC93F9AD73C7FDE97F5D0DE5FEEECF3DCD2E6999A5CD7A4700ECD19A6E68CD1701F9A334DCD19A2E077BE16B6F23475908F9A662FF008741FCBF5ADACD62F87B528EF74E48861658142328F41D0D6BE6B9E5B9B2D87E68CD33346690C7E6B17C536DE7E8ED201968583FE1D0FF003FD2B5F3591E21D4A3B3D39E2386967528AA7D0F534E3B89EC70B9A50D51E69735D0624A1A9C1AA1CD286A044C1A9C1AA10D4E0D401E89F0C643E66A71F62236FF00D0BFC6BBD9FEF8FA579EFC2FE6EB523FEC27F335E8339F987D2BC8C47F1DFF005D0F4E8FF0511D149454142D14945002D74F5CBD75159D4E8694FA9E4D451457A879E145145006CF873FE3F25FFAE7FD4572DF15BFE3E74BFF00724FE6B5D47877FE3F25FF00AE7FD4572DF15BFE3E74BFF724FE6B5CD1FF00795FD743797FBBB3CF33466929335E89C23B34669B9A33400ECD2E6999A5CD005CD3EFE5D3AF12E233D3865FEF0EE2BD0EDAEA3BBB749E26CA38C8AF30ADBF0F6AFF0061B8FB3CCDFE8F29EA7F85BD6A26AFA97176D0EE7751BAA3DD46EAC4D44B9BA8ED2DDE795B088326BCF350BF9751BC7B894F5E157FBA3B0ABFE21D5FEDD71F6785BFD1E23D47F137AD6256D056D4CA4EE3B34669B9A335A103F34B9A666941A007834E06A3069C0D311E89F0B4E6E353FF00723FE6D5E8339F9C7D2BCF3E161FF48D4FFDC8FF009B57A15C7DF1F4AF2311FC77FD743D2A1FC14479A33499A335050B9A33499A33400B9AEA6B95CD75559D4E8694FA9E4B451457A879E145145006CF877FE3F25FFAE7FD4572DF158FFA4E99FEE49FCD6BA8F0EFFC7E4BFF005CFF00A8AE5BE2B7FC7CE99FEE49FCD6B9A3FEF2BFAE86F2FF0077679D668A28AF40E20A28A2800A28A2800A28A2803B1F0E6ADF6987EC9337EFA31F293FC4BFE228F11EADF6687EC90B7EFA41F311FC2BFE26B9286692DE649A26DAE8720D134D25C4CF34ADB9DCE49A8E4D6E5F369623A28A2AC80A33451400B9A5CD368A007834E06982945508F45F8587FD2353FF00723FE6D5E85707E71F4AF3CF857FF1F3A9FF00B91FF36AF42B8FBE3E95E4E23F8EFF00AE87A347F8288A8A4A2A0A168A4A28016BACAE4ABADACEA7434A67FFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (9, N'2123', N'123', N'工本费', N'身份证', N'123', N'13', N'男', N'2014-2-15 16:50:40', N'2014-2-15 16:50:40', N'2014-2-15 16:50:40', N'123', N'', N'13', N'2014-2-15 16:50:53', N'赵武男', N'添加', NULL)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (10, N'123457', N'15672938213@193.com', N'包年卡', N'身份证', N'王琦', N'612432188982983217', N'男', N'2014-2-15 19:40:39', N'2014-2-15 19:40:32', N'2015-2-15 19:40:39', N'15672938213', N'', N'', N'2014-2-15 19:41:18', N'赵武男', N'添加', NULL)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (11, N'1111', N'11', N'季度卡', N'身份证', N'1111', N'111', N'男', N'2014-02-18 0:28:59', N'2014-02-18 0:0:0', N'2014-05-18 0:28:59', N'11', N'', N'111', N'2014-02-18 0:29:03', N'赵武男', N'添加', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800FD00F903012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00EDA8A4A2BD73CC168A4A280168A4A280168A4A280168A4A280168A4A280168A4A28016BABAE4EBACAC2BF436A5D428A28AC0D828A28A0028A28A0028A28A0028A28A0028A28A0028A28A002B7AB06B7AB2A9D0B81E6B452515EA1C02D14945002D14945002D14945002D14945002D14945002D14945002D7599AE4ABACAE7AFD0D6975173466928AC0D85CD19A4A280173466928A005CD19A4A280173466928A005CD19A4A280173466928A005CD6F56056FD6553A1A533CCE8A4A2BD43CF168A4A280168A4A280168A4A280168A4A28016A582DE6B99447046CEE7B015774AD1A6D49B79263801E5FD7D857564D8689645D9A3B7817EF331EA7FA9AC2A57517CAB566D0A4E5ABD118B69E157601AEE6D9FEC47C9FCEB5E0D0B4E8318B70E7D643BBF4E95CA6A9E3F66263D3200ABD3CE94649FA2FF8FE55CBDDEAFA85FB1373793480FF000EEC2FE438A4A8D7A9AC9D8A75294348AB9EB25B4DB63B09B588FA12AB4F5BAB198ED49ADDC9EC1D4D78C8A5A7F52FEF0BEB5E47B3BDA40FFF002CC03EDC556934EC731BE7D9ABCB2D354BFB120DB5DCD181FC21B8FCBA574FA678EE54223D4A1122FF00CF588608FA8E87F0C5672C2D48EB1772E35E12DD58DF78DE36DAEA41F7A6D6A5BDD5A6A96A2582449A23DC763FD0D53B9B5683E61F327AFA562A5AD9EE68E3D515E8A28AA2428A28A0028A28A0028A28A0028A28A002B7EB02B7EB2A9D0D20799514668CD7AA79E14519A33400514668CD0014519A33400568E8FA636A37586C8813976FE82A8468D2CA91A0CB390A07B9AEE6DE28347D2CEF60B1C485E47F538E4D615EA722B2DD9B528733BBD90CD5755B3D034D12CA005036C512F058FA0FF1AF2CD5B5ABCD66E8CD7527CA3EE463EEA0F61FD69BAEEB536B7A93DCBE5631F2C51FF757FC7D6B381ADB0F8754D5E5B99D6ACE6ECB625069C0D440D381AE93026069735106A706A4324CD19A6669734017B4DD56EB49BA13DAC854FF00129FBAE3D08AF4ED1B59B6D6ECBCD8BE571C4B11392A7FC3DEBC8B357B49D526D23504BA84E40E1D33C3AF715CD5F0EAA2BADCDA8D670767B1E99756FE43E57EE1E9EDED55F35A70CD0EA3629344DBA2954329FF003DEB3594A3153D41C1AF3E2EFA3DCEC92EA84CD19A28AB24334668A2800CD19A28A00334668A2800CD7415CFD7415954E8694CF31A2928AF50F3C5A2928A005A2928A005A2928A00DBF0D5A896FDA761F2C2BC7D4F4FEB507C43D58C165069B1B61A73BE4C7F741E07E27F956D786A2F2F4D693BC8E4FE038FF1AF38F18DE1BBF145E1CFCB111128F4DA39FD735CF4A3ED31177D0DE6F928E9D4C6069E1AA10D4A1ABD33889C35286A843538352B01306A706A8435286A5619306A5DD5106A5DD4AC04BBA9334CDD46EA00EF3C03A99649F4D76FBBFBD8FE9D187F23F89AE9EF93122B8FE21835E61E1BBC367E21B293380D208DBE8DC7F5AF55BC5DD013E8735E5E263C956EBA9DF425CD4EDD8CEA28A2A0A0A28A2800A28A2800A28A2800AE82B9FAE82B2A9D0D299E61452515EA9E70B45251400B45251400B45251401DC68C36E916C07F749FD4D78CEA9219757BD909E5A7727FEFA35EC5A23EFD220F6041FCCD78F6B511835CBF88FF000DC38FFC78D6184FE24CDF11F044A99A5CD479A5CD7A1739090353835439A70345C44A1A9C1AA1069734C098353B7541BA9775004FBA8DD50EEA5DD4AC05AB790C773138EAAE08FCEBDAE7E607FA578958A19EFEDE21C9795547E240AF6B9CE217FA579D8EF8A276E136919D45145731A851451400514514005145140057415CFD74159D4E8694CF2FA28CD19AF54F3828A33466800A28CD19A0028A33466803A7F0D4FBAD25849E51F23E87FF00D55C0F8F2C8DA78964940C25CA2C83EBD0FEA33F8D751A25D8B5D45431C249F21FE9FAD59F1C68E753D17CF89775C5A92EA0752BFC43FAFE15CA9FB2C45DECCE9B73D1B754793E697349457A4718E06941A68A70A0438528A68A514C42E6973494A2980B9A334940A00E87C1B666F3C496E7194833337B63A7EA457A95D362303D4D735E06D24D8E94D792AE26BAC119EC83A7E7D7F2ADEB87DD260745E2BC7C44FDA56D3647A3463C94F5EA459A33494548C5CD19A4A280173466928A005CD19A4A2801735D0573D5D0D6553A1A533CBA8A28AF54F3828A28A0028A28A0028A28A002BAFD235017B6815CFEF9061F3DFDEB90A9AD2EA4B3B859A33C8EA3B11E958D6A5ED236EA694AA724BC8C4F187869B49BC3776C87EC3336463FE59B7F77E9E95CC62BDBA396D757B16464592271B648DB9C7B1AF3CF117832E34D67B9B1569ED3A95032F1FD7D47BD3C3E22FEE54D1955A8FDA86C72829C28C518AED394514A2814A29882968C52E298098AE87C2DE1D7D62F04B32916511CB9FEF9FEE8FEB52E81E11B9D51967BA0D059F5C918671FEC8F4F7AF4882182C2D52082358E2418555AE1C4E2945724373AA8506FDE96C492388A301401C6140ED54E9CEE5DB269B5C318D91D5277614514551214514500145145001451450015D0D73D5D0D6553A1A533CB68A28AF54F3828A28A0028A28A0028A28A0028A28A009ADAEA6B494490B9561D7D0FD6BA6B1D6A0BB012422297D09E0FD0D615A6917577860BE5A1FE27E3F215B36FA05AC58329695BDCE07E42B92BBA4F7DFC8E9A2AA2DB62BEABE11D2F546690C66DE73C9921E327DC743FCEB95BCF87FA8C249B59A1B85EC09D8DF91E3F5AEF2E2FAC34C840B9BA82D900E048E17F2CD44FADD8A8C894BFFBAA6B2A55AB47E1D51A54A749FC5A33CD64F0A6B71121B4F90E3FBA437F23447E15D6E4202E9F20CFF7885FE66BD2175DB33D7CC1F55A0EBB663A7987E8B5D1F5AAFF00CA63EC297F31C5DA780B529883732C36EBDF9DEDF90E3F5AEA34BF08699A6912321B9987F1CBC807D874FE75A11EB364FF00F2D0A9FF00694D4B6BA8595FAE6D6EA19C77F2DC363EB5CF56BD792F7B446D4E9525B6A4EF284E3A9AAECE5CE49A99A153D38A89A365ED91ED594394B9730CA28CD19AD480A28CD19A0028A33466800A28CD19A0028A33466800AE86B9ECD7435954E8694CF2CA28A2BD53CE0A28A2800A28A2800A28AB563632DF4FB13851F798F40293692BB1A4DBB222B7B796EA511C28598FE9F5AE96C34586D407940965F53D07D054C05968D60F248EB0C318CBC8E7AFD6BCDFC4BE3BB9D48BDAE9A5EDED3A171C3C9FE03DBFFD55CBCD52BBE58688E8B428ABCF56765AE78D74BD14B441CDD5D0FF0096511E87FDA6E83F53ED5E7DAAF8EF5BD48B2C73FD8E13D120E0FE2DD7F2C57378A315D74B0B4E1D2ECE6A9889CFC90D76791CBBB1663C9663926BD2EC275BAB08265390E80FE3DEBCD715B7A0EBBFD9C4DBDC64DB31C8239287D7E95B4E375A1941D9EA77140A6433473C4B2C4E1E36190C3A1A5925486369247088A32598E00AE7360B8996DADA499CFCB1A9635E6A8ECAE1D58AB039041C106B6F5ED785F0FB2DB67ECE0E598F1BCFF85618ADE11B2D4CA72BBD0E974BF1B6B3A715579FED508FE09FE63F8375AEF345F19E9BAB95899BECB727FE59CA7827D9BA1FD0D7908A70AC6AE1A9CFA599A53C44E1E68F7A7883723835032953822BCEBC3BE35B9D34ADB5F97B8B4E8189CBC7F4F51ED5E936F716F7F6A93DBC8B2C2E32AEA6BCF9C2745DA5B1DB09C6AABC7722A29CE850E0F4A6D09DC028A28A60145145001451450015D1573B5D156553A1A533CAE8A4A2BD53CE168A4A280168A4A28027B5B67BBB84863EAC793E83D6BAAFF44D174E79247114112EE776EFEFF5A8F48B01656DB9C7EFA4196CF6F6AF35F1BF89FF00B5EFBEC56AFF00E856EDD41FF58FEBF41DBF3AE377C454E45B23A55A8C399EECA5E26F13DC7882ECF2D1D9C67F75167FF1E6F53FCAB06933466BD38414172C7638252727762D06933466A8421A5552EEAAA32CC70052135A7E1FB6FB56B500232B19F31BF0E9FAE293764095D9DD5A402D6D21817A46817EB8A5BA805D5A4D0374910AFE952D15CC741E6054A395618607047BD28357F5FB6FB2EB338030B21F317F1EBFAE6B381AE95AAB9CED5992834F151034F06901256D7877C4571A0DD82097B573FBD8B3FA8F435860D2E6A6515256638C9C5DD1EEB6D7306A1691DC5BC824864195614C60558835E69E0EF119D22F7ECB72FF00E853B724FF00CB36FEF7D3D7FF00AD5EA522875C8EA3A5793529BA33E57B1E9C26AAC6EB72B668CD145300CD19A28A00334668A2800CD7475CE57475954E8694FA9E559A3349457AA79C2E68CD251400B9AD3D12D3ED37BBD86638BE63EE7B565D75BA2DBFD9F4E4247CD27CE7F1E9FA561889F2C34EA6B461CD3313C7BAF1D2747FB2C0F8BABBCA020F2A9FC47FA7E3ED5E420D6CF8B7573AC788AE6756CC319F2A2F4DABDFF1393F8D6266BA70D4BD9D34BAB31AF539E7E43F34B9A6668CD6E623F3499A6E68CD003B35D6783ADF11DC5D11F7888D4FD393FD2B90CD7A26896DF64D1EDA3230C577B7D4F3515362A0B534F3466999A33581B1CDF8C2DF31DBDD01D098DBF1E47F5AE50357A06B76DF6BD1EE23032C177AFD4735E760D6F4F6319EE4E1A9E1AAB86A786AA249C1A766A10D4E068024CD7A9F81B5B3A96946D266CDC5A80B927964EC7F0E9F9579566B5FC33AA9D275EB6B82D8898F972FFBA7AFE5C1FC2B9F114BDA536BA9B50A9C93BF43D8255DAD9EC6A3AB128DC87DB9AAF9AF320EE8F424ACC28A33466AC90A28CD19A002BA4AE6F35D256553A1A53EA79451499A335EA9E70B452668CD00490C6669E38875760BF9D74BE24BEFECAF0CDEDCA1DAC916C8C8ECC7E51FA9158DA2C7E66A9167A2E5BF4AAFF13AE8C5E1FB7B707066B819F70013FCF15CB5573D68C0E8A6F9694A4794669734DCD19AF50F3C7669734DCD1400ECD266928CD005AD3EDBED9A8DBDBF50EE01FA77FD335E99D2B8BF085B799A84B7047112607D4FFF00581AED2B0A8F5B1AC1681451454161D783D2BCD350B6FB1EA33DBF647207D3B7E98AF4BAE2FC5F6DE56A115C01F2CA983F51FF00D622AE9BD6C44D6860034F06A3069C0D6C644A0D381A881A70340C941A5CD460D2E6901EDBE1ABEFED1F0E595C31CB98F639FF00697E53FCB356D86188F4AE5BE1BDC99345B9B7273E54F91EC180FEA0D75528C487DEBC694796ACA27AB17CD4D486D14945310B45251400B5D2D7335D356553A1A53EA793D1499A335EA1E78B452668CD006C787466FDCFA467F98AE7BE2B487FE2551F6FDEB1FF00C77FFAF5D17870FF00A64BFF005CFF00A8AE5FE2B1FF0049D2FF00DC93F9AD73C7FDE97F5D0DE5FEEECF3DCD2E6999A5CD7A4700ECD19A6E68CD1701F9A334DCD19A2E077BE16B6F23475908F9A662FF008741FCBF5ADACD62F87B528EF74E48861658142328F41D0D6BE6B9E5B9B2D87E68CD33346690C7E6B17C536DE7E8ED201968583FE1D0FF003FD2B5F3591E21D4A3B3D39E2386967528AA7D0F534E3B89EC70B9A50D51E69735D0624A1A9C1AA1CD286A044C1A9C1AA10D4E0D401E89F0C643E66A71F62236FF00D0BFC6BBD9FEF8FA579EFC2FE6EB523FEC27F335E8339F987D2BC8C47F1DFF005D0F4E8FF0511D149454142D14945002D74F5CBD75159D4E8694FA9E4D451457A879E145145006CF873FE3F25FFAE7FD4572DF15BFE3E74BFF00724FE6B5D47877FE3F25FF00AE7FD4572DF15BFE3E74BFF724FE6B5CD1FF00795FD743797FBBB3CF33466929335E89C23B34669B9A33400ECD2E6999A5CD005CD3EFE5D3AF12E233D3865FEF0EE2BD0EDAEA3BBB749E26CA38C8AF30ADBF0F6AFF0061B8FB3CCDFE8F29EA7F85BD6A26AFA97176D0EE7751BAA3DD46EAC4D44B9BA8ED2DDE795B088326BCF350BF9751BC7B894F5E157FBA3B0ABFE21D5FEDD71F6785BFD1E23D47F137AD6256D056D4CA4EE3B34669B9A335A103F34B9A666941A007834E06A3069C0D311E89F0B4E6E353FF00723FE6D5E8339F9C7D2BCF3E161FF48D4FFDC8FF009B57A15C7DF1F4AF2311FC77FD743D2A1FC14479A33499A335050B9A33499A33400B9AEA6B95CD75559D4E8694FA9E4B451457A879E145145006CF877FE3F25FFAE7FD4572DF158FFA4E99FEE49FCD6BA8F0EFFC7E4BFF005CFF00A8AE5BE2B7FC7CE99FEE49FCD6B9A3FEF2BFAE86F2FF0077679D668A28AF40E20A28A2800A28A2800A28A2803B1F0E6ADF6987EC9337EFA31F293FC4BFE228F11EADF6687EC90B7EFA41F311FC2BFE26B9286692DE649A26DAE8720D134D25C4CF34ADB9DCE49A8E4D6E5F369623A28A2AC80A33451400B9A5CD368A007834E06982945508F45F8587FD2353FF00723FE6D5E85707E71F4AF3CF857FF1F3A9FF00B91FF36AF42B8FBE3E95E4E23F8EFF00AE87A347F8288A8A4A2A0A168A4A28016BACAE4ABADACEA7434A67FFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (12, N'1111', N'11', N'补卡费', N'身份证', N'1111', N'111', N'男', N'2014-02-18 0:28:59', N'2014-02-18 0:0:0', N'2014-05-18 0:28:59', N'1111', N'', N'111', N'2014-02-18 0:29:28', N'赵武男', N'修改', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080067004803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F6A120FBAC703D6A4FB428E0738ACB1382327B54D0CCA4963D0F6AD2C6299A0B3B11C74A733B8C726A185D4F18AB023DC79A4591CF2F97034849C01DBA9AF2FF00891ACEA569A49B099638A1BCFE143BA4DA083D7EB8AF509C318F0003C8EB5E3DF1196E2F6FDE49318854A0D8B8DB8C1CFE67AFB5388D227F8631C3A7E872EA124477DE4E20181D978C9FC49AF4AD262B44D32DE6B650CB24618363B62B98F0CDC59D9F84965B268DADF61947987680C79209FA9C57516EE96BA65BAA205511AED51D863A54A77654D5922CBC4AF82490739A29A18B90DD38A2A8C8C1B69C3E43727A63F1AB913A938E3A2E31F415836C597041C296FF00D98D6ADB60E7AF0ABD7E829B2626D40D9518ABB1E6A9590DCA335A6898152CD911915E63E36881F39D630C1B976CF1E9FD6BD4644F94E2B2A5B44F2678D914863F36475CF5A13B0D2386F0ED9DCD968BA644F17EEAE54C6EAC4AECC925587E04576738F319426768E9F4AC6595E3F0F412A8124B6808284F5DA718FAE2B6AD6ED248A364C1474DEAD4968D84EED22589B6B05607A5150BDD0624E73E807AD155632B9856D0B3306EBC9FFD0AAF449B5CFA855CFE550C60AA0C00003C81FEF7AD594930C48403E55CFE42993136ACC7CAA474AD21D2B36CB80B8E845698E959B365B0845675F9091CCC4E0000935A47A565EAA375ADCAFAC47FAD2296E79CA6B171677926C8C4D0C8F930B1C64FB1EC6BA9B688C0B15BA80163854100E704718AC4D02C05CEA125ECC316F6BC827A17FF00EB75FCAB6348D406A562F7C23016695F61F540768FE59FC6B47672D096DA8938F9240C4670738A29647F6A2AEC6172379D49D90A823232C470391D28498A3B03DD5707F01503CF1A1299392410AA324F229A92F9924AACBB4ED5E09CFF0008A91C59D05948485CF4AD7439515836926C0109FA1AD7865E00A868D913B1C0ACBBE70EFE59E03A15357659302B17559B62C72138504827F0FF00EB52B6852DCA1AC246BA4BE9B66CB02B260B019C03D7F13CD58B2B44B2D32D6D5082B144AB90319E3AD7386F24B979E5FF00966BD09AE8A2951E04092A9DAA149CE704538315556412267A514C772A48241F7073456BA9CFA1463B4291B38FBC0A9C0F7239269372319304128ABC839E768A4C4B32092E4E554AE231C0CE571C7F8D5771E5CD2BAE0121323B1F9454891B704BB9467835A704C4AF3D6B063606356079CFE55A30CC64886787143354CBF24BBC819C1ACED6C23692F0A1DCD23019F4EF5389372E3F88706B1B57BD4B1780CBC4649C924000F18E4F1EBD4FFF005D34EDA149FBDA90B69EB1E99B58ED0304FBD47E1BB0F2EDEEA4797E4B8999A260074079FAE79FCA992EA716B3BACACE50095396521B1C138E09C138EF8FC6A3F01EA2352D0259A64C2DB4EF1A21FE118047F335318B5AB2AA4EEAC6A4DB5256556DCA0F068AB53DBA4EC0420061F7D8F4E9456AA48E669998D70CCC1635E38E5FA7F0F6FF001AA53C8F1B4AD236F0427CD8C63E515719047B7CC3B38E84727A76AA534D1C8661F302027CAE307EEAF38A484581290CACA7BE3EB5AB04DBD548C861FA1AE74CA619547DE4EB8F4AD88E4076491E33EB432932E09C82DC61B3C8AE33C75AC5C595F58BDBB956F29C103041191C107823D8D7566753B9B2030C707B579AFC479D9353B1E700C2483FF0235505A8EE6659789AF0F88EC26925DA21972A00088A4F60AA3009E0741EF5D5FC369E5B3D32F8342FB1DE365620ED3C1079AE47C1904179E29804D18912206450C38DC3A1C7E39AF652FE5C8A1300347C0C71C52A934A5CA5C60DC798B4842C400032FD71F4A2B3EE2EA4F9D00FBDC8C1E831454D88B8D923400B2925F2327F2FF0AC8BD84349203D73190476E168A2844322493FD202498271F2B63AD5F3BA150E9F8AD145302D452248AB263208E41AE4BC6DA0A6BD2D898E4FB3BA874048C82383823B51452936A3746B4D272B323F0DF87934086FE46984F323C04384C60166040FCC7E55D8B4997B3C9C65F693F518A28AC5B6DA6CE9B249A5FD683A5261B82426F5E9C9A28A2B74719FFFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (13, N'123456', N'327549286@qq.com', N'补卡费', N'身份证', N'金浩', N'612422198802265210', N'男', N'2014-02-11 11:52:11', N'1988-02-11 0:0:0', N'2014-02-11 11:52:11', N'金浩', N'10', N'', N'2014-02-18 0:33:41', N'赵武男', N'修改', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080067004803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F6A120FBAC703D6A4FB428E0738ACB1382327B54D0CCA4963D0F6AD2C6299A0B3B11C74A733B8C726A185D4F18AB023DC79A4591CF2F97034849C01DBA9AF2FF00891ACEA569A49B099638A1BCFE143BA4DA083D7EB8AF509C318F0003C8EB5E3DF1196E2F6FDE49318854A0D8B8DB8C1CFE67AFB5388D227F8631C3A7E872EA124477DE4E20181D978C9FC49AF4AD262B44D32DE6B650CB24618363B62B98F0CDC59D9F84965B268DADF61947987680C79209FA9C57516EE96BA65BAA205511AED51D863A54A77654D5922CBC4AF82490739A29A18B90DD38A2A8C8C1B69C3E43727A63F1AB913A938E3A2E31F415836C597041C296FF00D98D6ADB60E7AF0ABD7E829B2626D40D9518ABB1E6A9590DCA335A6898152CD911915E63E36881F39D630C1B976CF1E9FD6BD4644F94E2B2A5B44F2678D914863F36475CF5A13B0D2386F0ED9DCD968BA644F17EEAE54C6EAC4AECC925587E04576738F319426768E9F4AC6595E3F0F412A8124B6808284F5DA718FAE2B6AD6ED248A364C1474DEAD4968D84EED22589B6B05607A5150BDD0624E73E807AD155632B9856D0B3306EBC9FFD0AAF449B5CFA855CFE550C60AA0C00003C81FEF7AD594930C48403E55CFE42993136ACC7CAA474AD21D2B36CB80B8E845698E959B365B0845675F9091CCC4E0000935A47A565EAA375ADCAFAC47FAD2296E79CA6B171677926C8C4D0C8F930B1C64FB1EC6BA9B688C0B15BA80163854100E704718AC4D02C05CEA125ECC316F6BC827A17FF00EB75FCAB6348D406A562F7C23016695F61F540768FE59FC6B47672D096DA8938F9240C4670738A29647F6A2AEC6172379D49D90A823232C470391D28498A3B03DD5707F01503CF1A1299392410AA324F229A92F9924AACBB4ED5E09CFF0008A91C59D05948485CF4AD7439515836926C0109FA1AD7865E00A868D913B1C0ACBBE70EFE59E03A15357659302B17559B62C72138504827F0FF00EB52B6852DCA1AC246BA4BE9B66CB02B260B019C03D7F13CD58B2B44B2D32D6D5082B144AB90319E3AD7386F24B979E5FF00966BD09AE8A2951E04092A9DAA149CE704538315556412267A514C772A48241F7073456BA9CFA1463B4291B38FBC0A9C0F7239269372319304128ABC839E768A4C4B32092E4E554AE231C0CE571C7F8D5771E5CD2BAE0121323B1F9454891B704BB9467835A704C4AF3D6B063606356079CFE55A30CC64886787143354CBF24BBC819C1ACED6C23692F0A1DCD23019F4EF5389372E3F88706B1B57BD4B1780CBC4649C924000F18E4F1EBD4FFF005D34EDA149FBDA90B69EB1E99B58ED0304FBD47E1BB0F2EDEEA4797E4B8999A260074079FAE79FCA992EA716B3BACACE50095396521B1C138E09C138EF8FC6A3F01EA2352D0259A64C2DB4EF1A21FE118047F335318B5AB2AA4EEAC6A4DB5256556DCA0F068AB53DBA4EC0420061F7D8F4E9456AA48E669998D70CCC1635E38E5FA7F0F6FF001AA53C8F1B4AD236F0427CD8C63E515719047B7CC3B38E84727A76AA534D1C8661F302027CAE307EEAF38A484581290CACA7BE3EB5AB04DBD548C861FA1AE74CA619547DE4EB8F4AD88E4076491E33EB432932E09C82DC61B3C8AE33C75AC5C595F58BDBB956F29C103041191C107823D8D7566753B9B2030C707B579AFC479D9353B1E700C2483FF0235505A8EE6659789AF0F88EC26925DA21972A00088A4F60AA3009E0741EF5D5FC369E5B3D32F8342FB1DE365620ED3C1079AE47C1904179E29804D18912206450C38DC3A1C7E39AF652FE5C8A1300347C0C71C52A934A5CA5C60DC798B4842C400032FD71F4A2B3EE2EA4F9D00FBDC8C1E831454D88B8D923400B2925F2327F2FF0AC8BD84349203D73190476E168A2844322493FD202498271F2B63AD5F3BA150E9F8AD145302D452248AB263208E41AE4BC6DA0A6BD2D898E4FB3BA874048C82383823B51452936A3746B4D272B323F0DF87934086FE46984F323C04384C60166040FCC7E55D8B4997B3C9C65F693F518A28AC5B6DA6CE9B249A5FD683A5261B82426F5E9C9A28A2B74719FFFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (14, N'123341', N'12312', N'补卡费', N'身份证', N'qwe', N'2132', N'男', N'2014-02-15 16:02:14', N'2014-02-15 0:0:0', N'2014-08-15 16:02:14', N'qwe', N'', N'123', N'2014-02-18 0:33:50', N'赵武男', N'修改', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080067004803012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F6A120FBAC703D6A4FB428E0738ACB1382327B54D0CCA4963D0F6AD2C6299A0B3B11C74A733B8C726A185D4F18AB023DC79A4591CF2F97034849C01DBA9AF2FF00891ACEA569A49B099638A1BCFE143BA4DA083D7EB8AF509C318F0003C8EB5E3DF1196E2F6FDE49318854A0D8B8DB8C1CFE67AFB5388D227F8631C3A7E872EA124477DE4E20181D978C9FC49AF4AD262B44D32DE6B650CB24618363B62B98F0CDC59D9F84965B268DADF61947987680C79209FA9C57516EE96BA65BAA205511AED51D863A54A77654D5922CBC4AF82490739A29A18B90DD38A2A8C8C1B69C3E43727A63F1AB913A938E3A2E31F415836C597041C296FF00D98D6ADB60E7AF0ABD7E829B2626D40D9518ABB1E6A9590DCA335A6898152CD911915E63E36881F39D630C1B976CF1E9FD6BD4644F94E2B2A5B44F2678D914863F36475CF5A13B0D2386F0ED9DCD968BA644F17EEAE54C6EAC4AECC925587E04576738F319426768E9F4AC6595E3F0F412A8124B6808284F5DA718FAE2B6AD6ED248A364C1474DEAD4968D84EED22589B6B05607A5150BDD0624E73E807AD155632B9856D0B3306EBC9FFD0AAF449B5CFA855CFE550C60AA0C00003C81FEF7AD594930C48403E55CFE42993136ACC7CAA474AD21D2B36CB80B8E845698E959B365B0845675F9091CCC4E0000935A47A565EAA375ADCAFAC47FAD2296E79CA6B171677926C8C4D0C8F930B1C64FB1EC6BA9B688C0B15BA80163854100E704718AC4D02C05CEA125ECC316F6BC827A17FF00EB75FCAB6348D406A562F7C23016695F61F540768FE59FC6B47672D096DA8938F9240C4670738A29647F6A2AEC6172379D49D90A823232C470391D28498A3B03DD5707F01503CF1A1299392410AA324F229A92F9924AACBB4ED5E09CFF0008A91C59D05948485CF4AD7439515836926C0109FA1AD7865E00A868D913B1C0ACBBE70EFE59E03A15357659302B17559B62C72138504827F0FF00EB52B6852DCA1AC246BA4BE9B66CB02B260B019C03D7F13CD58B2B44B2D32D6D5082B144AB90319E3AD7386F24B979E5FF00966BD09AE8A2951E04092A9DAA149CE704538315556412267A514C772A48241F7073456BA9CFA1463B4291B38FBC0A9C0F7239269372319304128ABC839E768A4C4B32092E4E554AE231C0CE571C7F8D5771E5CD2BAE0121323B1F9454891B704BB9467835A704C4AF3D6B063606356079CFE55A30CC64886787143354CBF24BBC819C1ACED6C23692F0A1DCD23019F4EF5389372E3F88706B1B57BD4B1780CBC4649C924000F18E4F1EBD4FFF005D34EDA149FBDA90B69EB1E99B58ED0304FBD47E1BB0F2EDEEA4797E4B8999A260074079FAE79FCA992EA716B3BACACE50095396521B1C138E09C138EF8FC6A3F01EA2352D0259A64C2DB4EF1A21FE118047F335318B5AB2AA4EEAC6A4DB5256556DCA0F068AB53DBA4EC0420061F7D8F4E9456AA48E669998D70CCC1635E38E5FA7F0F6FF001AA53C8F1B4AD236F0427CD8C63E515719047B7CC3B38E84727A76AA534D1C8661F302027CAE307EEAF38A484581290CACA7BE3EB5AB04DBD548C861FA1AE74CA619547DE4EB8F4AD88E4076491E33EB432932E09C82DC61B3C8AE33C75AC5C595F58BDBB956F29C103041191C107823D8D7566753B9B2030C707B579AFC479D9353B1E700C2483FF0235505A8EE6659789AF0F88EC26925DA21972A00088A4F60AA3009E0741EF5D5FC369E5B3D32F8342FB1DE365620ED3C1079AE47C1904179E29804D18912206450C38DC3A1C7E39AF652FE5C8A1300347C0C71C52A934A5CA5C60DC798B4842C400032FD71F4A2B3EE2EA4F9D00FBDC8C1E831454D88B8D923400B2925F2327F2FF0AC8BD84349203D73190476E168A2844322493FD202498271F2B63AD5F3BA150E9F8AD145302D452248AB263208E41AE4BC6DA0A6BD2D898E4FB3BA874048C82383823B51452936A3746B4D272B323F0DF87934086FE46984F323C04384C60166040FCC7E55D8B4997B3C9C65F693F518A28AC5B6DA6CE9B249A5FD683A5261B82426F5E9C9A28A2B74719FFFD9)
INSERT [dbo].[MemberHistoryInfo] ([MemberID], [CardID], [Mail], [CardType], [IDCardType], [Name], [IDCard], [Sex], [StartTime], [Birthday], [EndTime], [Phone], [Count], [Unit], [AddTime], [AddUserName], [InfoType], [Photo]) VALUES (15, N'23q2', N'32q3', N'补卡费', N'身份证', N'23q23', N'q23q2', N'男', N'2014-02-18 0:40:42', N'2014-02-18 0:0:0', N'2014-02-18 0:40:42', N'q23', N'', N'23q', N'2014-02-18 0:40:50', N'赵武男', N'添加', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC000110800FD00F903012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00EDA8A4A2BD73CC168A4A280168A4A280168A4A280168A4A280168A4A280168A4A28016BABAE4EBACAC2BF436A5D428A28AC0D828A28A0028A28A0028A28A0028A28A0028A28A0028A28A002B7AB06B7AB2A9D0B81E6B452515EA1C02D14945002D14945002D14945002D14945002D14945002D14945002D7599AE4ABACAE7AFD0D6975173466928AC0D85CD19A4A280173466928A005CD19A4A280173466928A005CD19A4A280173466928A005CD6F56056FD6553A1A533CCE8A4A2BD43CF168A4A280168A4A280168A4A280168A4A28016A582DE6B99447046CEE7B015774AD1A6D49B79263801E5FD7D857564D8689645D9A3B7817EF331EA7FA9AC2A57517CAB566D0A4E5ABD118B69E157601AEE6D9FEC47C9FCEB5E0D0B4E8318B70E7D643BBF4E95CA6A9E3F66263D3200ABD3CE94649FA2FF8FE55CBDDEAFA85FB1373793480FF000EEC2FE438A4A8D7A9AC9D8A75294348AB9EB25B4DB63B09B588FA12AB4F5BAB198ED49ADDC9EC1D4D78C8A5A7F52FEF0BEB5E47B3BDA40FFF002CC03EDC556934EC731BE7D9ABCB2D354BFB120DB5DCD181FC21B8FCBA574FA678EE54223D4A1122FF00CF588608FA8E87F0C5672C2D48EB1772E35E12DD58DF78DE36DAEA41F7A6D6A5BDD5A6A96A2582449A23DC763FD0D53B9B5683E61F327AFA562A5AD9EE68E3D515E8A28AA2428A28A0028A28A0028A28A0028A28A002B7EB02B7EB2A9D0D20799514668CD7AA79E14519A33400514668CD0014519A33400568E8FA636A37586C8813976FE82A8468D2CA91A0CB390A07B9AEE6DE28347D2CEF60B1C485E47F538E4D615EA722B2DD9B528733BBD90CD5755B3D034D12CA005036C512F058FA0FF1AF2CD5B5ABCD66E8CD7527CA3EE463EEA0F61FD69BAEEB536B7A93DCBE5631F2C51FF757FC7D6B381ADB0F8754D5E5B99D6ACE6ECB625069C0D440D381AE93026069735106A706A4324CD19A6669734017B4DD56EB49BA13DAC854FF00129FBAE3D08AF4ED1B59B6D6ECBCD8BE571C4B11392A7FC3DEBC8B357B49D526D23504BA84E40E1D33C3AF715CD5F0EAA2BADCDA8D670767B1E99756FE43E57EE1E9EDED55F35A70CD0EA3629344DBA2954329FF003DEB3594A3153D41C1AF3E2EFA3DCEC92EA84CD19A28AB24334668A2800CD19A28A00334668A2800CD7415CFD7415954E8694CF31A2928AF50F3C5A2928A005A2928A005A2928A00DBF0D5A896FDA761F2C2BC7D4F4FEB507C43D58C165069B1B61A73BE4C7F741E07E27F956D786A2F2F4D693BC8E4FE038FF1AF38F18DE1BBF145E1CFCB111128F4DA39FD735CF4A3ED31177D0DE6F928E9D4C6069E1AA10D4A1ABD33889C35286A843538352B01306A706A8435286A5619306A5DD5106A5DD4AC04BBA9334CDD46EA00EF3C03A99649F4D76FBBFBD8FE9D187F23F89AE9EF93122B8FE21835E61E1BBC367E21B293380D208DBE8DC7F5AF55BC5DD013E8735E5E263C956EBA9DF425CD4EDD8CEA28A2A0A0A28A2800A28A2800A28A2800AE82B9FAE82B2A9D0D299E61452515EA9E70B45251400B45251400B45251401DC68C36E916C07F749FD4D78CEA9219757BD909E5A7727FEFA35EC5A23EFD220F6041FCCD78F6B511835CBF88FF000DC38FFC78D6184FE24CDF11F044A99A5CD479A5CD7A1739090353835439A70345C44A1A9C1AA1069734C098353B7541BA9775004FBA8DD50EEA5DD4AC05AB790C773138EAAE08FCEBDAE7E607FA578958A19EFEDE21C9795547E240AF6B9CE217FA579D8EF8A276E136919D45145731A851451400514514005145140057415CFD74159D4E8694CF2FA28CD19AF54F3828A33466800A28CD19A0028A33466803A7F0D4FBAD25849E51F23E87FF00D55C0F8F2C8DA78964940C25CA2C83EBD0FEA33F8D751A25D8B5D45431C249F21FE9FAD59F1C68E753D17CF89775C5A92EA0752BFC43FAFE15CA9FB2C45DECCE9B73D1B754793E697349457A4718E06941A68A70A0438528A68A514C42E6973494A2980B9A334940A00E87C1B666F3C496E7194833337B63A7EA457A95D362303D4D735E06D24D8E94D792AE26BAC119EC83A7E7D7F2ADEB87DD260745E2BC7C44FDA56D3647A3463C94F5EA459A33494548C5CD19A4A280173466928A005CD19A4A2801735D0573D5D0D6553A1A533CBA8A28AF54F3828A28A0028A28A0028A28A002BAFD235017B6815CFEF9061F3DFDEB90A9AD2EA4B3B859A33C8EA3B11E958D6A5ED236EA694AA724BC8C4F187869B49BC3776C87EC3336463FE59B7F77E9E95CC62BDBA396D757B16464592271B648DB9C7B1AF3CF117832E34D67B9B1569ED3A95032F1FD7D47BD3C3E22FEE54D1955A8FDA86C72829C28C518AED394514A2814A29882968C52E298098AE87C2DE1D7D62F04B32916511CB9FEF9FEE8FEB52E81E11B9D51967BA0D059F5C918671FEC8F4F7AF4882182C2D52082358E2418555AE1C4E2945724373AA8506FDE96C492388A301401C6140ED54E9CEE5DB269B5C318D91D5277614514551214514500145145001451450015D0D73D5D0D6553A1A533CB68A28AF54F3828A28A0028A28A0028A28A0028A28A009ADAEA6B494490B9561D7D0FD6BA6B1D6A0BB012422297D09E0FD0D615A6917577860BE5A1FE27E3F215B36FA05AC58329695BDCE07E42B92BBA4F7DFC8E9A2AA2DB62BEABE11D2F546690C66DE73C9921E327DC743FCEB95BCF87FA8C249B59A1B85EC09D8DF91E3F5AEF2E2FAC34C840B9BA82D900E048E17F2CD44FADD8A8C894BFFBAA6B2A55AB47E1D51A54A749FC5A33CD64F0A6B71121B4F90E3FBA437F23447E15D6E4202E9F20CFF7885FE66BD2175DB33D7CC1F55A0EBB663A7987E8B5D1F5AAFF00CA63EC297F31C5DA780B529883732C36EBDF9DEDF90E3F5AEA34BF08699A6912321B9987F1CBC807D874FE75A11EB364FF00F2D0A9FF00694D4B6BA8595FAE6D6EA19C77F2DC363EB5CF56BD792F7B446D4E9525B6A4EF284E3A9AAECE5CE49A99A153D38A89A365ED91ED594394B9730CA28CD19AD480A28CD19A0028A33466800A28CD19A0028A33466800AE86B9ECD7435954E8694CF2CA28A2BD53CE0A28A2800A28A2800A28AB563632DF4FB13851F798F40293692BB1A4DBB222B7B796EA511C28598FE9F5AE96C34586D407940965F53D07D054C05968D60F248EB0C318CBC8E7AFD6BCDFC4BE3BB9D48BDAE9A5EDED3A171C3C9FE03DBFFD55CBCD52BBE58688E8B428ABCF56765AE78D74BD14B441CDD5D0FF0096511E87FDA6E83F53ED5E7DAAF8EF5BD48B2C73FD8E13D120E0FE2DD7F2C57378A315D74B0B4E1D2ECE6A9889CFC90D76791CBBB1663C9663926BD2EC275BAB08265390E80FE3DEBCD715B7A0EBBFD9C4DBDC64DB31C8239287D7E95B4E375A1941D9EA77140A6433473C4B2C4E1E36190C3A1A5925486369247088A32598E00AE7360B8996DADA499CFCB1A9635E6A8ECAE1D58AB039041C106B6F5ED785F0FB2DB67ECE0E598F1BCFF85618ADE11B2D4CA72BBD0E974BF1B6B3A715579FED508FE09FE63F8375AEF345F19E9BAB95899BECB727FE59CA7827D9BA1FD0D7908A70AC6AE1A9CFA599A53C44E1E68F7A7883723835032953822BCEBC3BE35B9D34ADB5F97B8B4E8189CBC7F4F51ED5E936F716F7F6A93DBC8B2C2E32AEA6BCF9C2745DA5B1DB09C6AABC7722A29CE850E0F4A6D09DC028A28A60145145001451450015D1573B5D156553A1A533CAE8A4A2BD53CE168A4A280168A4A28027B5B67BBB84863EAC793E83D6BAAFF44D174E79247114112EE776EFEFF5A8F48B01656DB9C7EFA4196CF6F6AF35F1BF89FF00B5EFBEC56AFF00E856EDD41FF58FEBF41DBF3AE377C454E45B23A55A8C399EECA5E26F13DC7882ECF2D1D9C67F75167FF1E6F53FCAB06933466BD38414172C7638252727762D06933466A8421A5552EEAAA32CC70052135A7E1FB6FB56B500232B19F31BF0E9FAE293764095D9DD5A402D6D21817A46817EB8A5BA805D5A4D0374910AFE952D15CC741E6054A395618607047BD28357F5FB6FB2EB338030B21F317F1EBFAE6B381AE95AAB9CED5992834F151034F06901256D7877C4571A0DD82097B573FBD8B3FA8F435860D2E6A6515256638C9C5DD1EEB6D7306A1691DC5BC824864195614C60558835E69E0EF119D22F7ECB72FF00E853B724FF00CB36FEF7D3D7FF00AD5EA522875C8EA3A5793529BA33E57B1E9C26AAC6EB72B668CD145300CD19A28A00334668A2800CD7475CE57475954E8694FA9E559A3349457AA79C2E68CD251400B9AD3D12D3ED37BBD86638BE63EE7B565D75BA2DBFD9F4E4247CD27CE7F1E9FA561889F2C34EA6B461CD3313C7BAF1D2747FB2C0F8BABBCA020F2A9FC47FA7E3ED5E420D6CF8B7573AC788AE6756CC319F2A2F4DABDFF1393F8D6266BA70D4BD9D34BAB31AF539E7E43F34B9A6668CD6E623F3499A6E68CD003B35D6783ADF11DC5D11F7888D4FD393FD2B90CD7A26896DF64D1EDA3230C577B7D4F3515362A0B534F3466999A33581B1CDF8C2DF31DBDD01D098DBF1E47F5AE50357A06B76DF6BD1EE23032C177AFD4735E760D6F4F6319EE4E1A9E1AAB86A786AA249C1A766A10D4E068024CD7A9F81B5B3A96946D266CDC5A80B927964EC7F0E9F9579566B5FC33AA9D275EB6B82D8898F972FFBA7AFE5C1FC2B9F114BDA536BA9B50A9C93BF43D8255DAD9EC6A3AB128DC87DB9AAF9AF320EE8F424ACC28A33466AC90A28CD19A002BA4AE6F35D256553A1A53EA79451499A335EA9E70B452668CD00490C6669E38875760BF9D74BE24BEFECAF0CDEDCA1DAC916C8C8ECC7E51FA9158DA2C7E66A9167A2E5BF4AAFF13AE8C5E1FB7B707066B819F70013FCF15CB5573D68C0E8A6F9694A4794669734DCD19AF50F3C7669734DCD1400ECD266928CD005AD3EDBED9A8DBDBF50EE01FA77FD335E99D2B8BF085B799A84B7047112607D4FFF00581AED2B0A8F5B1AC1681451454161D783D2BCD350B6FB1EA33DBF647207D3B7E98AF4BAE2FC5F6DE56A115C01F2CA983F51FF00D622AE9BD6C44D6860034F06A3069C0D6C644A0D381A881A70340C941A5CD460D2E6901EDBE1ABEFED1F0E595C31CB98F639FF00697E53FCB356D86188F4AE5BE1BDC99345B9B7273E54F91EC180FEA0D75528C487DEBC694796ACA27AB17CD4D486D14945310B45251400B5D2D7335D356553A1A53EA793D1499A335EA1E78B452668CD006C787466FDCFA467F98AE7BE2B487FE2551F6FDEB1FF00C77FFAF5D17870FF00A64BFF005CFF00A8AE5FE2B1FF0049D2FF00DC93F9AD73C7FDE97F5D0DE5FEEECF3DCD2E6999A5CD7A4700ECD19A6E68CD1701F9A334DCD19A2E077BE16B6F23475908F9A662FF008741FCBF5ADACD62F87B528EF74E48861658142328F41D0D6BE6B9E5B9B2D87E68CD33346690C7E6B17C536DE7E8ED201968583FE1D0FF003FD2B5F3591E21D4A3B3D39E2386967528AA7D0F534E3B89EC70B9A50D51E69735D0624A1A9C1AA1CD286A044C1A9C1AA10D4E0D401E89F0C643E66A71F62236FF00D0BFC6BBD9FEF8FA579EFC2FE6EB523FEC27F335E8339F987D2BC8C47F1DFF005D0F4E8FF0511D149454142D14945002D74F5CBD75159D4E8694FA9E4D451457A879E145145006CF873FE3F25FFAE7FD4572DF15BFE3E74BFF00724FE6B5D47877FE3F25FF00AE7FD4572DF15BFE3E74BFF724FE6B5CD1FF00795FD743797FBBB3CF33466929335E89C23B34669B9A33400ECD2E6999A5CD005CD3EFE5D3AF12E233D3865FEF0EE2BD0EDAEA3BBB749E26CA38C8AF30ADBF0F6AFF0061B8FB3CCDFE8F29EA7F85BD6A26AFA97176D0EE7751BAA3DD46EAC4D44B9BA8ED2DDE795B088326BCF350BF9751BC7B894F5E157FBA3B0ABFE21D5FEDD71F6785BFD1E23D47F137AD6256D056D4CA4EE3B34669B9A335A103F34B9A666941A007834E06A3069C0D311E89F0B4E6E353FF00723FE6D5E8339F9C7D2BCF3E161FF48D4FFDC8FF009B57A15C7DF1F4AF2311FC77FD743D2A1FC14479A33499A335050B9A33499A33400B9AEA6B95CD75559D4E8694FA9E4B451457A879E145145006CF877FE3F25FFAE7FD4572DF158FFA4E99FEE49FCD6BA8F0EFFC7E4BFF005CFF00A8AE5BE2B7FC7CE99FEE49FCD6B9A3FEF2BFAE86F2FF0077679D668A28AF40E20A28A2800A28A2800A28A2803B1F0E6ADF6987EC9337EFA31F293FC4BFE228F11EADF6687EC90B7EFA41F311FC2BFE26B9286692DE649A26DAE8720D134D25C4CF34ADB9DCE49A8E4D6E5F369623A28A2AC80A33451400B9A5CD368A007834E06982945508F45F8587FD2353FF00723FE6D5E85707E71F4AF3CF857FF1F3A9FF00B91FF36AF42B8FBE3E95E4E23F8EFF00AE87A347F8288A8A4A2A0A168A4A28016BACAE4ABADACEA7434A67FFD9)
SET IDENTITY_INSERT [dbo].[MemberHistoryInfo] OFF
/****** Object:  Table [dbo].[LossCast]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LossCast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[PayableAmount] [decimal](18, 0) NOT NULL,
	[PaymentAmount] [decimal](18, 0) NOT NULL,
	[ChangeAmount] [decimal](18, 0) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__LossCast__3214EC071367E606] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应交费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast', @level2type=N'COLUMN',@level2name=N'PayableAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'交费金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast', @level2type=N'COLUMN',@level2name=N'PaymentAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'找零金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast', @level2type=N'COLUMN',@level2name=N'ChangeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'挂失费用表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast'
GO
/****** Object:  Table [dbo].[LossCard]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LossCard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[PatchCardNo] [varchar](50) NOT NULL,
	[PatchTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_LossCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCard', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'领补卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCard', @level2type=N'COLUMN',@level2name=N'PatchCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'领补时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCard', @level2type=N'COLUMN',@level2name=N'PatchTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCard', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'挂失信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCard'
GO
/****** Object:  Table [dbo].[ExtensionCard]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExtensionCard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[ExtensionStartTm] [datetime] NOT NULL,
	[ExtensionEndTm] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__Extensio__3214EC07164452B1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ExtensionCard', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'延期开始时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ExtensionCard', @level2type=N'COLUMN',@level2name=N'ExtensionStartTm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'延期结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ExtensionCard', @level2type=N'COLUMN',@level2name=N'ExtensionEndTm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ExtensionCard', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'延期信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ExtensionCard'
GO
/****** Object:  Table [dbo].[CunsumeType]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CunsumeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CusType] [varchar](50) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__CunsumeT__3214EC07108B795B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeType', @level2type=N'COLUMN',@level2name=N'CusType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeType', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
/****** Object:  Table [dbo].[CunsumeCast]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CunsumeCast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[CusType] [varchar](50) NOT NULL,
	[TransactDate] [datetime] NOT NULL,
	[PriceAmount] [decimal](18, 0) NOT NULL,
	[Count] [int] NOT NULL,
	[PayableAmount] [decimal](18, 0) NOT NULL,
	[PaymentAmount] [decimal](18, 0) NOT NULL,
	[ChangeAmount] [decimal](18, 0) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__CunsumeC__3214EC070DAF0CB0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'CusType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'办理时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'TransactDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'PriceAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'Count'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应付金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'PayableAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'交费金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'PaymentAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'找零金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'ChangeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单次消费表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeCast'
GO
/****** Object:  Table [dbo].[CardTypeInfo]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CardTypeInfo](
	[CardTypeID] [int] IDENTITY(1,1) NOT NULL,
	[CardTypeName] [varchar](150) NULL,
	[MonthsPrice] [varchar](150) NULL,
	[Months] [varchar](150) NULL,
	[DayPrice] [varchar](150) NULL,
	[DateTime] [varchar](150) NULL,
	[TypeName] [varchar](50) NULL,
	[CardCount] [varchar](50) NULL,
 CONSTRAINT [PK__CardType__AB0A3D3121B6055D] PRIMARY KEY CLUSTERED 
(
	[CardTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'CardTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'CardTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'MonthsPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时长/月' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'Months'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价/日' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'DayPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'DateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo', @level2type=N'COLUMN',@level2name=N'CardCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CardTypeInfo'
GO
SET IDENTITY_INSERT [dbo].[CardTypeInfo] ON
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (2, N'补卡费', N'10', N'12', N'10', N'2014-1-21 19:41:26', N'固定收费产品', NULL)
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (3, N'包年卡', N'1000', N'12', N'3', N'2014-2-15 18:19:56', N'计时产品', NULL)
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (4, N'半年卡', N'600', N'6', N'3', N'2014-2-10 21:39:53', N'计时产品', NULL)
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (5, N'季度卡', N'300', N'3', N'3', N'2014-2-10 21:39:49', N'计时产品', NULL)
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (6, N'月卡', N'100', N'1', N'3', N'2014-2-10 21:39:41', N'计时产品', NULL)
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (7, N'10次体验卡', N'188', N'10', N'0', N'2014-02-17 23:41:29', N'计次产品', N'10')
INSERT [dbo].[CardTypeInfo] ([CardTypeID], [CardTypeName], [MonthsPrice], [Months], [DayPrice], [DateTime], [TypeName], [CardCount]) VALUES (8, N'20次贵宾卡', N'288', N'10', N'0', N'2014-02-17 23:41:35', N'计次产品', N'20')
SET IDENTITY_INSERT [dbo].[CardTypeInfo] OFF
/****** Object:  Table [dbo].[BackCardCost]    Script Date: 02/18/2014 00:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackCardCost](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[PayedAmount] [decimal](18, 0) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[BackAmount] [decimal](18, 0) NOT NULL,
	[UsedAmount] [decimal](18, 0) NOT NULL,
	[PatchAmount] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_BackCardCost] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'已交费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost', @level2type=N'COLUMN',@level2name=N'PayedAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'退还金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost', @level2type=N'COLUMN',@level2name=N'BackAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'已用费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost', @level2type=N'COLUMN',@level2name=N'UsedAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'补交金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost', @level2type=N'COLUMN',@level2name=N'PatchAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'退卡记录表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardCost'
GO
