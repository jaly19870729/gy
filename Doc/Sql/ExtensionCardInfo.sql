USE [Gymnasium]
GO

/****** Object:  Table [dbo].[ExtensionCardInfo]    Script Date: 02/18/2014 14:17:32 ******/
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


