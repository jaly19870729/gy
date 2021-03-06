USE [master]
GO
/****** Object:  Database [Gymnasium]    Script Date: 02/21/2014 23:57:26 ******/
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
/****** Object:  Table [dbo].[UserInfo]    Script Date: 02/21/2014 23:57:27 ******/
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
/****** Object:  StoredProcedure [dbo].[UP_GetRecordByPage]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[SystemLoginLog]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[Sys_FunctionSmall]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[Sys_FunctionBig]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[SwipingInfo]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[SellCast]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[Menu]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[MemberInfo]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[MemberHistoryInfo]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[LossCast]    Script Date: 02/21/2014 23:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LossCast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LossCardId] [int] NOT NULL,
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LossCast', @level2type=N'COLUMN',@level2name=N'LossCardId'
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
/****** Object:  Table [dbo].[LossCard]    Script Date: 02/21/2014 23:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LossCard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[OldCardNumber] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[ExtensionCardInfo]    Script Date: 02/21/2014 23:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExtensionCardInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[ExtensionStartTm] [datetime] NOT NULL,
	[ExtensionEndTm] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExtensionCard]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[CunsumeType]    Script Date: 02/21/2014 23:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CunsumeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CusType] [varchar](50) NOT NULL,
	[CusPrice] [decimal](18, 0) NOT NULL,
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeType', @level2type=N'COLUMN',@level2name=N'CusPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CunsumeType', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
/****** Object:  Table [dbo].[CunsumeCast]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[CardTypeInfo]    Script Date: 02/21/2014 23:57:31 ******/
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
/****** Object:  Table [dbo].[BackCardInfo]    Script Date: 02/21/2014 23:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BackCardInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardNumber] [varchar](50) NULL,
	[CardType] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[IDCardType] [varchar](50) NULL,
	[IDCardNumber] [varchar](50) NULL,
	[AddTime] [datetime] NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[TotalDays] [int] NULL,
	[LeftDays] [int] NULL,
	[TotalTimes] [int] NULL,
	[LeftTimes] [int] NULL,
	[PaidAmount] [decimal](18, 0) NULL,
	[ChangeAmount] [decimal](18, 0) NULL,
	[PatchAmount] [decimal](18, 0) NULL,
	[UsedAmount] [decimal](18, 0) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_BackCardInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'CardNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'卡类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'CardType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'证件类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'IDCardType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'证件号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'IDCardNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'办理时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生效时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'失效时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'TotalDays'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'剩余天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'LeftDays'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'总次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'TotalTimes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'剩余次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'LeftTimes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'已交费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'PaidAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'退还费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'ChangeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'已用费用' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'UsedAmount'
GO
/****** Object:  Table [dbo].[BackCardCost]    Script Date: 02/21/2014 23:57:31 ******/
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
