USE [PinkFlamingos]
GO

/****** Object:  Table [dbo].[creditCardInfo]    Script Date: 9/25/2016 12:49:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[creditCardInfo](
	[idTransaction] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NOT NULL,
	[creditCardNumber] [bigint] NOT NULL,
	[expDate] [varchar](6) NOT NULL,
	[cvc] [int] NOT NULL,
	[cardName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTransaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


