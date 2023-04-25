USE [tracnghiem]
GO

/****** Object:  Table [dbo].[users]    Script Date: 3/27/2023 10:05:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users](
	[username] [nvarchar](200) NOT NULL,
	[password] [nvarchar](2000) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
	[flag] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

