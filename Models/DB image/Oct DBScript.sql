USE [DB_Oct_Student]
GO
/****** Object:  Table [dbo].[tblStudent]    Script Date: 13.6.25 17:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RollNo] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[TotalMarks] [int] NULL,
	[DOB] [date] NULL,
	[FeesPaid] [float] NULL,
 CONSTRAINT [PK_tblStudent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblStudent] ON 

INSERT [dbo].[tblStudent] ([ID], [RollNo], [Name], [TotalMarks], [DOB], [FeesPaid]) VALUES (1, 1, N'Rajesh', 12345, CAST(N'2000-01-01' AS Date), 30000)
INSERT [dbo].[tblStudent] ([ID], [RollNo], [Name], [TotalMarks], [DOB], [FeesPaid]) VALUES (3, 2, N'Dinesh', 896, CAST(N'2021-05-05' AS Date), 35000)
INSERT [dbo].[tblStudent] ([ID], [RollNo], [Name], [TotalMarks], [DOB], [FeesPaid]) VALUES (4, 12, N'mangesh waghmare', 560, CAST(N'2021-12-05' AS Date), 50000)
SET IDENTITY_INSERT [dbo].[tblStudent] OFF
GO
