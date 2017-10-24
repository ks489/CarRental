USE [TestDatabase]
GO

/****** Object:  Table [dbo].[Vehicles]    Script Date: 24/10/2017 13:21:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Vehicles](
	[CarID] [int] NOT NULL,
	[NumberPlate] [varchar](20) NOT NULL,
	[CurrentMilage] [decimal](18, 2) NOT NULL,
	[RentalCharge] [decimal](18, 2) NOT NULL,
	[VehicleType] varchar(20) NOT NULL,
	[Toilet] [bit] NULL,
	[NumberOfBeds] [int] NULL,
	[Road] [varchar](50) NULL,
	[Under21] [bit] NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_Vehicles_NumberPlate] UNIQUE NONCLUSTERED 
(
	[NumberPlate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




