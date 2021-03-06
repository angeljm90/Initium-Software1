USE [ticket]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 16/10/2020 22:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[cli_id] [int] IDENTITY(1,1) NOT NULL,
	[cli_identificacion] [varchar](25) NULL,
	[cli_nombre] [varchar](150) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[cli_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ticket]    Script Date: 16/10/2020 22:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ticket](
	[tik_id] [int] IDENTITY(1,1) NOT NULL,
	[cli_id] [int] NULL,
	[tic_id] [int] NULL,
	[tik_fecha_registro] [datetime] NULL,
	[tik_fecha_atendido] [datetime] NULL,
	[tik_estado] [int] NULL,
 CONSTRAINT [PK_ticket] PRIMARY KEY CLUSTERED 
(
	[tik_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_colas]    Script Date: 16/10/2020 22:50:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_colas](
	[tic_id] [int] IDENTITY(1,1) NOT NULL,
	[tic_nombre] [varchar](50) NULL,
	[tic_tiempo] [int] NULL,
 CONSTRAINT [PK_tipo_colas] PRIMARY KEY CLUSTERED 
(
	[tic_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tipo_colas] ON 

INSERT [dbo].[tipo_colas] ([tic_id], [tic_nombre], [tic_tiempo]) VALUES (1, N'Tiempo en espera', 2)
INSERT [dbo].[tipo_colas] ([tic_id], [tic_nombre], [tic_tiempo]) VALUES (2, N'Tiempo en espera', 3)
SET IDENTITY_INSERT [dbo].[tipo_colas] OFF
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_cliente] FOREIGN KEY([cli_id])
REFERENCES [dbo].[cliente] ([cli_id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_cliente]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_tipo_colas] FOREIGN KEY([tic_id])
REFERENCES [dbo].[tipo_colas] ([tic_id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_tipo_colas]
GO
