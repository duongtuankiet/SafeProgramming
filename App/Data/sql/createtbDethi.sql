USE [tracnghiem]
GO

/****** Object:  Table [dbo].[Dethi]    Script Date: 3/27/2023 10:05:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dethi](
	[macauhoi] [nvarchar](1000) NOT NULL,
	[dapandung] [nvarchar](1000) NOT NULL,
	[dapan1] [nvarchar](1000) NOT NULL,
	[dapan2] [nvarchar](1000) NOT NULL,
	[dapan3] [nvarchar](1000) NOT NULL,
	[cauhoi] [nvarchar](1000) NOT NULL,
	[dapan4] [nvarchar](1000) NULL
) ON [PRIMARY]
GO

