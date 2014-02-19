USE [Gymnasium]
GO

/****** Object:  Table [dbo].[BackCardInfo]    Script Date: 02/19/2014 22:51:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BackCardInfo]') AND type in (N'U'))
DROP TABLE [dbo].[BackCardInfo]
GO

USE [Gymnasium]
GO

/****** Object:  Table [dbo].[BackCardInfo]    Script Date: 02/19/2014 22:51:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BackCardInfo](
	[Id] [int] NOT NULL,
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
	[CreateTime] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'CardNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'CardType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'Name'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'֤������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'IDCardType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'֤������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'IDCardNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'AddTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Чʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'StartTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ʧЧʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'EndTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'TotalDays'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ʣ������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'LeftDays'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ܴ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'TotalTimes'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ʣ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'LeftTimes'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ѽ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'PaidAmount'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�˻�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'ChangeAmount'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���÷���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BackCardInfo', @level2type=N'COLUMN',@level2name=N'UsedAmount'
GO


