USE [PinkFlamingos]
GO

/****** Object:  Table [dbo].[billingAddress]    Script Date: 9/25/2016 12:49:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[billingAddress](
	[idBillingAdd] [int] IDENTITY(1,1) NOT NULL,
	[idTransaction] [int] NOT NULL,
	[idUser] [int] NOT NULL,
	[addressLine1] [varchar](50) NOT NULL,
	[addressLine2] [varchar](30) NOT NULL,
	[zipCode] [int] NOT NULL,
	[city] [varchar](20) NOT NULL,
	[state] [varchar](20) NOT NULL,
	[country] [varchar](20) NOT NULL,
	[telephoneNumber] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBillingAdd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


