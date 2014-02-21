USE [Gymnasium]
GO

/****** Object:  Table [dbo].[CunsumeType]    Script Date: 02/21/2014 22:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CunsumeType]') AND type in (N'U'))
DROP TABLE [dbo].[CunsumeType]
GO

USE [Gymnasium]
GO

/****** Object:  Table [dbo].[CunsumeType]    Script Date: 02/21/2014 22:38:48 ******/
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


insert into  [dbo].[CunsumeType] ([CusType],[CreateTime] ,[CusPrice] ) values ('健身房',GETDATE(),10);