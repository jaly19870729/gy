USE [Gymnasium]
GO

/****** Object:  Table [dbo].[LossCast]    Script Date: 02/18/2014 21:18:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LossCast]') AND type in (N'U'))
DROP TABLE [dbo].[LossCast]
GO

USE [Gymnasium]
GO

/****** Object:  Table [dbo].[LossCast]    Script Date: 02/18/2014 21:18:41 ******/
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


