USE [Elija]
GO
/****** Object:  Table [dbo].[Device]    Script Date: 18/01/2014 23:52:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Device](
	[DeviceId] [bigint] NOT NULL,
	[IMEI] [bigint] NULL,
	[Brand] [varchar](50) NOT NULL,
	[Device] [varchar](50) NOT NULL,
	[Display] [varchar](10) NOT NULL,
	[Manufacturer] [varchar](50) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Product] [varchar](50) NOT NULL,
	[Operator] [varchar](50) NULL,
	[AndroidId] [varchar](50) NOT NULL,
	[OsVersion] [varchar](20) NOT NULL,
	[CodeVersion] [varchar](20) NOT NULL,
	[ReleaseVersion] [varchar](20) NOT NULL,
	[IsPhone] [bit] NOT NULL,
	[RegistrationDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 18/01/2014 23:52:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [bigint] NOT NULL,
	[FacebookId] [bigint] NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Age] [int] NULL,
	[Birthday] [date] NULL,
	[Gender] [varchar](10) NULL,
	[FacebookLink] [varchar](150) NULL,
	[TelephoneHome] [varchar](20) NULL,
	[TelephoneOffice] [varchar](20) NULL,
	[TelephoneMobile] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[City] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[RegistrationDate] [datetime] NULL,
	[Token] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserDevice]    Script Date: 18/01/2014 23:52:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDevice](
	[UserId] [bigint] NOT NULL,
	[DeviceId] [bigint] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[LastActivityDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[DeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[UserDevice]  WITH CHECK ADD FOREIGN KEY([DeviceId])
REFERENCES [dbo].[Device] ([DeviceId])
GO
ALTER TABLE [dbo].[UserDevice]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
