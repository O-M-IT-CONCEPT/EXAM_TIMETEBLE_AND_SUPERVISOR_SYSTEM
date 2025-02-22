
USE [DATA_PROCESSING]
GO
/****** Object:  Table [dbo].[Activation]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HardwareID] [nchar](100) NOT NULL,
	[ActivationID] [nchar](150) NOT NULL,
 CONSTRAINT [PK_Activation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advance_settings]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advance_settings](
	[dmarkup] [float] NULL,
	[phar] [bit] NULL,
	[dispatch] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ASECURITY]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASECURITY](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Menu] [nchar](100) NULL,
	[LEV1] [bit] NULL,
	[LEV2] [bit] NULL,
	[LEV3] [bit] NULL,
 CONSTRAINT [PK_ASECURITY] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[BankName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[BankName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankAccountLedger]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankAccountLedger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[AccNo] [nchar](50) NULL,
	[LedgerNo] [nchar](200) NULL,
	[Label] [nchar](200) NULL,
	[Debit] [decimal](18, 5) NULL,
	[Credit] [decimal](18, 5) NULL,
 CONSTRAINT [PK_BankAccountLedger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankAccountRegistration]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankAccountRegistration](
	[AccountNo] [nchar](50) NOT NULL,
	[AccountName] [nchar](200) NULL,
	[AccountType] [nchar](100) NULL,
	[OpeningDate] [datetime] NULL,
	[BalanceAmount] [decimal](18, 5) NULL,
	[Active] [nchar](10) NULL,
	[BranchID] [int] NULL,
	[Id] [int] NULL,
 CONSTRAINT [PK_BankAccountRegistration] PRIMARY KEY CLUSTERED 
(
	[AccountNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankBranch]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankBranch](
	[Id] [int] NOT NULL,
	[BranchName] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[ContactNo] [nchar](100) NULL,
	[SwiftCode] [nchar](50) NULL,
	[IFSCCode] [nchar](50) NULL,
	[BankName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_BankBranch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Batches]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Batches](
	[BID] [int] IDENTITY(1,1) NOT NULL,
	[PID] [int] NULL,
	[BatchCode] [varchar](50) NULL,
	[BatchName] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[Quantity] [decimal](18, 5) NULL,
	[ManufactureDate] [datetime] NULL,
	[ExpiryDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bin]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[bin] [nchar](255) NULL,
	[code] [nchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[block_items]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[block_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[block_id] [nchar](100) NULL,
	[item_id] [nchar](100) NULL,
	[qty] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[block_man]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[block_man](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nchar](100) NULL,
	[qf] [nchar](100) NULL,
	[address] [nchar](100) NULL,
	[phone] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[block_test]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[block_test](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[op] [nchar](100) NULL,
	[cw] [nchar](100) NULL,
	[bq] [nchar](100) NULL,
	[ac] [nchar](100) NULL,
	[wl] [nchar](100) NULL,
	[cost] [nchar](100) NULL,
	[bid] [int] NULL,
	[pid] [int] NULL,
	[mg] [int] NULL,
	[bmid] [int] NULL,
	[dated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blocktest_LST]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blocktest_LST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[qty] [float] NOT NULL,
	[ProductID] [int] NOT NULL,
	[TRNSID] [int] NOT NULL,
	[DATED] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bom]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bom](
	[dom_id] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NULL,
	[item_id] [int] NULL,
	[qty] [nchar](10) NULL,
	[total] [nchar](10) NULL,
	[price] [nchar](10) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[dom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branch_adjustment_list]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branch_adjustment_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NULL,
	[qty] [nchar](100) NULL,
	[var] [nchar](100) NULL,
	[counted] [nchar](100) NULL,
	[unit] [nchar](100) NULL,
	[total] [nchar](100) NULL,
	[adjstid] [nchar](100) NULL,
	[batches] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branch_card]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branch_card](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dated] [date] NULL,
	[ref] [nchar](100) NULL,
	[pna] [nchar](100) NULL,
	[total] [nchar](100) NULL,
	[ntotal] [nchar](100) NULL,
	[ptotal] [nchar](100) NULL,
	[userd] [nchar](100) NULL,
	[fromb] [nchar](100) NULL,
	[tob] [nchar](100) NULL,
	[pid] [int] NULL,
	[p] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[branches]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branches](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [char](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CardProcessing]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardProcessing](
	[CP_ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NULL,
	[PF] [decimal](18, 5) NULL,
	[Amount] [decimal](18, 5) NULL,
	[InvoiceAmount] [decimal](18, 5) NULL,
 CONSTRAINT [PK_CardProcessing] PRIMARY KEY CLUSTERED 
(
	[CP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryName] [nchar](200) NOT NULL,
	[BColor] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cbom]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cbom](
	[dom_id] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NULL,
	[item_id] [int] NULL,
	[qty] [nchar](10) NULL,
	[total] [nchar](10) NULL,
	[price] [nchar](10) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[dom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClockIN]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClockIN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](100) NULL,
	[ClockINDate] [datetime] NULL,
 CONSTRAINT [PK_ClockIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClockOUT]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClockOUT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClockInID] [int] NULL,
	[ClockOUTDate] [datetime] NULL,
 CONSTRAINT [PK_ClockOUT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cmanu]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cmanu](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[p_id] [nchar](10) NULL,
	[qty] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](250) NOT NULL,
	[MailingName] [nvarchar](250) NULL,
	[Country] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nchar](200) NULL,
	[State] [nchar](200) NULL,
	[PinCode] [nchar](30) NULL,
	[ContactNo] [nchar](100) NULL,
	[Fax] [nchar](100) NULL,
	[Email] [nchar](200) NULL,
	[Website] [nvarchar](max) NULL,
	[TIN] [nchar](50) NULL,
	[LicenseNo] [nchar](50) NULL,
	[ServiceTaxNo] [nvarchar](max) NULL,
	[CST] [nchar](50) NULL,
	[PAN] [nchar](100) NULL,
	[CurrencyCode] [nchar](10) NULL,
	[Currency] [nchar](100) NULL,
	[Logo] [image] NULL,
	[ShowLogo] [nchar](20) NULL,
	[CapitalAccount] [decimal](18, 5) NULL,
	[NP] [int] NULL,
	[QCode] [nchar](10) NULL,
	[BCode] [nchar](10) NULL,
	[InvoiceHeader] [nchar](50) NULL,
	[ItemWiseVAT] [nchar](10) NULL,
	[QTC] [nvarchar](max) NULL,
	[ZeroPrice] [varchar](50) NULL,
	[BelowCost] [varchar](50) NULL,
	[ActiveBelow] [varchar](50) NULL,
	[patchinter] [bit] NULL,
	[wscalable] [bit] NULL,
	[pscalable] [bit] NULL,
	[MultiCurrencyReceipt] [bit] NULL,
	[ShowMultiCurrency] [bit] NULL,
	[VatNo] [varchar](50) NULL,
	[RevMaxKey] [varchar](200) NULL,
	[ShowDiscount] [bit] NULL,
	[EnableRevMax] [bit] NULL,
	[selnegative] [bit] NULL,
	[cash] [bit] NULL,
	[autoprint] [bit] NULL,
	[autoprintshift] [bit] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseCode] [nvarchar](20) NOT NULL,
	[CourseName] [nvarchar](100) NOT NULL,
	[FacultyID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[ProgramID] [int] NOT NULL,
	[LevelID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [nvarchar](100) NOT NULL,
	[course_code] [nvarchar](50) NOT NULL,
	[deptid] [int] NOT NULL,
	[facultyid] [int] NOT NULL,
	[venue_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCustomer]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCustomer](
	[CC_ID] [int] NOT NULL,
	[CreditCustomerID] [nchar](30) NOT NULL,
	[Name] [nchar](200) NULL,
	[ContactNo] [nchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[TRN] [nchar](30) NULL,
	[OpeningBalance] [decimal](18, 5) NULL,
	[OpeningBalanceType] [nchar](10) NULL,
	[RegistrationDate] [datetime] NULL,
	[Active] [nchar](10) NOT NULL,
	[CreditLimit] [decimal](18, 5) NULL,
	[CustPic] [image] NULL,
	[Discount] [varchar](50) NULL,
 CONSTRAINT [PK_CreditCustomer] PRIMARY KEY CLUSTERED 
(
	[CC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCustomerLedger]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCustomerLedger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[LedgerNo] [nchar](50) NULL,
	[Label] [nchar](200) NULL,
	[Debit] [decimal](18, 5) NULL,
	[Credit] [decimal](18, 5) NULL,
	[CreditCustomer_ID] [int] NULL,
 CONSTRAINT [PK_CreditCustomerLedger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCustomerPayment]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCustomerPayment](
	[T_ID] [int] NOT NULL,
	[TransactionID] [nchar](20) NULL,
	[Date] [datetime] NOT NULL,
	[PaymentMode] [nchar](30) NULL,
	[CreditCustomer_ID] [int] NOT NULL,
	[Amount] [decimal](18, 5) NULL,
	[Remarks] [nvarchar](250) NULL,
	[PaymentModeDetails] [nvarchar](250) NULL,
	[OpenID] [int] NULL,
 CONSTRAINT [PK_CreditCustomerPayment] PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 7/8/2024 4:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyCode] [nchar](10) NOT NULL,
	[Currencyname] [nchar](200) NOT NULL,
	[Rate] [decimal](18, 5) NULL,
	[Datechanged] [nchar](50) NOT NULL,
	[fra] [decimal](18, 5) NULL,
	[smcurrency] [nchar](100) NULL,
	[fraunit] [decimal](18, 5) NULL,
	[nformat] [nchar](100) NULL,
 CONSTRAINT [PK_CurrencyRate] PRIMARY KEY CLUSTERED 
(
	[CurrencyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CC_ID] [int] NOT NULL,
	[CustomerID] [nchar](30) NOT NULL,
	[Name] [nchar](200) NULL,
	[ContactNo] [nchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[TRN] [nchar](30) NULL,
	[RegistrationDate] [datetime] NULL,
	[Active] [nchar](10) NOT NULL,
	[RateType] [nchar](20) NULL,
	[TradeName] [varchar](255) NULL,
	[VatNumber] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[Province] [varchar](255) NULL,
	[Street] [varchar](255) NULL,
	[HouseNo] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[Discount] [varchar](50) NULL,
 CONSTRAINT [PK_CashCustomer] PRIMARY KEY CLUSTERED 
(
	[CC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerMaster]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerMaster](
	[Cid] [int] NOT NULL,
	[CName] [nchar](150) NULL,
	[ContactNo] [nchar](100) NULL,
	[RS] [nchar](10) NULL,
	[RC] [nchar](10) NULL,
	[RAx] [nchar](10) NULL,
	[RAd] [nchar](10) NULL,
	[RI] [nchar](10) NULL,
	[LS] [nchar](10) NULL,
	[LC] [nchar](10) NULL,
	[LAx] [nchar](10) NULL,
	[LAd] [nchar](10) NULL,
	[LI] [nchar](10) NULL,
	[Remarks] [nchar](250) NULL,
	[RegisteredDate] [datetime] NULL,
	[Active] [nchar](10) NULL,
 CONSTRAINT [PK_CustomerMaster] PRIMARY KEY CLUSTERED 
(
	[Cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeletedInvoices]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeletedInvoices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [nchar](15) NULL,
	[BillDate] [datetime] NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[Operator] [nchar](100) NULL,
	[PaymentMode] [nchar](100) NULL,
	[Reason] [nchar](200) NULL,
	[DeletedDate] [datetime] NULL,
	[BillType] [nchar](20) NULL,
	[Canceled_Deleted] [nchar](20) NULL,
 CONSTRAINT [PK_DeletedInvoices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dept]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dept](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[facultyid] [int] NOT NULL,
	[dept] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiscountSetting]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiscountSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](100) NULL,
	[MaxDiscPerAllowed] [decimal](18, 5) NULL,
 CONSTRAINT [PK_DiscountSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doclist]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doclist](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](255) NULL,
	[lname] [varchar](255) NULL,
	[initials] [varchar](255) NULL,
	[samdcno] [varchar](255) NULL,
	[groupno] [varchar](255) NULL,
	[phone] [varchar](255) NULL,
	[address] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doz]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doz](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[doz] [nchar](1000) NULL,
	[p_id] [nchar](10) NULL,
	[Code] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailSetting]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServerName] [nchar](150) NOT NULL,
	[SMTPAddress] [nvarchar](250) NOT NULL,
	[Username] [nchar](200) NOT NULL,
	[Password] [nchar](100) NOT NULL,
	[Port] [int] NOT NULL,
	[TLS_SSL_Required] [nchar](10) NOT NULL,
	[IsDefault] [nchar](10) NOT NULL,
	[IsActive] [nchar](10) NOT NULL,
 CONSTRAINT [PK_EmailSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[ExpenseName] [nvarchar](250) NOT NULL,
	[ExpenseType] [nchar](200) NOT NULL,
 CONSTRAINT [PK_Expense_1] PRIMARY KEY CLUSTERED 
(
	[ExpenseName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseType]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseType](
	[Type] [nchar](200) NOT NULL,
 CONSTRAINT [PK_ExpenseType] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[faculty]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[faculty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[faculty] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundDeposit]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundDeposit](
	[Id] [int] NOT NULL,
	[DepositerName] [nchar](150) NULL,
	[Amount] [decimal](18, 5) NULL,
	[Date] [datetime] NULL,
	[AccNo] [nchar](50) NULL,
	[Notes] [nchar](200) NULL,
 CONSTRAINT [PK_FundDeposit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundTransfer]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundTransfer](
	[Id] [int] NOT NULL,
	[AccountTransFrom] [nchar](50) NULL,
	[AccountTransTo] [nchar](50) NULL,
	[Amount] [decimal](18, 5) NULL,
	[Date] [datetime] NULL,
	[Operator] [nchar](150) NULL,
	[Notes] [nchar](200) NULL,
 CONSTRAINT [PK_FundTransfer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice_Payment]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice_Payment](
	[IP_ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NULL,
	[PaymentMode] [nchar](150) NULL,
	[Amount] [decimal](18, 5) NULL,
 CONSTRAINT [PK_Invoice_Payment] PRIMARY KEY CLUSTERED 
(
	[IP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice_Product]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice_Product](
	[IPo_ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Barcode] [nchar](100) NULL,
	[MfgDate] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[DiscountPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[Qty] [float] NULL,
	[TotalAmount] [decimal](18, 5) NULL,
	[PurchaseRate] [decimal](18, 5) NULL,
	[Margin] [decimal](18, 5) NULL,
	[SN] [nvarchar](250) NULL,
	[FreeQty] [float] NULL,
 CONSTRAINT [PK_Invoice_Product] PRIMARY KEY CLUSTERED 
(
	[IPo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceCode]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[C1] [nchar](10) NULL,
	[C2] [nchar](10) NULL,
	[C3] [nchar](10) NULL,
	[C4] [nchar](10) NULL,
	[C5] [nchar](10) NULL,
	[C6] [nchar](10) NULL,
	[C7] [nchar](10) NULL,
	[C8] [nchar](10) NULL,
	[C9] [nchar](10) NULL,
	[C10] [nchar](10) NULL,
	[C11] [nchar](10) NULL,
	[C12] [nchar](10) NULL,
	[C13] [nchar](10) NULL,
	[C14] [nchar](10) NULL,
	[C15] [nchar](10) NULL,
	[C16] [nchar](10) NULL,
	[C17] [nchar](10) NULL,
	[C18] [nchar](10) NULL,
 CONSTRAINT [PK_InvoiceCode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceInfo]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceInfo](
	[Inv_ID] [int] NOT NULL,
	[InvoiceNo] [nvarchar](36) NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[OpenID] [int] NULL,
	[CurrencyCode] [nchar](50) NULL,
	[ExchangeRate] [decimal](18, 5) NULL,
	[DiscPer] [decimal](18, 5) NULL,
	[DiscAmt] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[TaxType] [nchar](20) NULL,
	[Member_ID] [nchar](50) NULL,
	[SalesmanID] [int] NULL,
	[Cash] [decimal](18, 5) NULL,
	[Change] [decimal](18, 5) NULL,
	[CustID] [int] NULL,
	[LoyaltyMemberID] [int] NULL,
	[LP] [int] NULL,
	[BillNote] [nvarchar](max) NULL,
	[CName] [nchar](150) NULL,
	[CCN] [nchar](50) NULL,
	[RoundOff] [decimal](18, 5) NULL,
	[QRcode] [image] NULL,
	[QNo] [nchar](30) NULL,
	[DN] [nchar](30) NULL,
	[DeliveryMethod] [nchar](100) NULL,
	[DispatchDate] [datetime] NULL,
	[API_ID] [nvarchar](46) NULL,
	[DeviceID] [varchar](50) NULL,
	[FiscalDay] [varchar](50) NULL,
	[ReceiptNo] [varchar](50) NULL,
	[CustomerRef] [varchar](50) NULL,
	[Vcode] [varchar](80) NULL,
	[pcurrency] [varchar](50) NULL,
	[dispatch] [bit] NOT NULL,
	[dispatchby] [nchar](255) NULL,
	[erp] [bit] NULL,
 CONSTRAINT [PK_InvoiceInfo] PRIMARY KEY CLUSTERED 
(
	[Inv_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Journal]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Journal](
	[ID] [int] NOT NULL,
	[DebitAccount] [nchar](200) NULL,
	[CreditAccount] [nchar](200) NULL,
	[Date] [datetime] NULL,
	[Amount] [decimal](18, 5) NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Journal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LedgerBook]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LedgerBook](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Name] [nchar](200) NOT NULL,
	[AccLedger] [nchar](200) NULL,
	[LedgerNo] [nchar](200) NOT NULL,
	[Label] [nchar](200) NOT NULL,
	[Debit] [decimal](18, 5) NULL,
	[Credit] [decimal](18, 5) NULL,
	[PartyID] [nchar](50) NULL,
	[Rmarks] [nchar](200) NULL,
 CONSTRAINT [PK_LedgerBook] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Level]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level](
	[LevelID] [int] IDENTITY(1,1) NOT NULL,
	[LevelName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](100) NOT NULL,
	[Operation] [nvarchar](250) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoyaltyMember]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoyaltyMember](
	[MemberID] [int] NOT NULL,
	[Name] [nchar](200) NULL,
	[CardNo] [nchar](50) NULL,
	[ContactNo] [nchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[RegistrationDate] [datetime] NULL,
	[Active] [nchar](10) NULL,
 CONSTRAINT [PK_LoyaltyMember] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoyaltyMemberLedgerBook]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoyaltyMemberLedgerBook](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[LedgerNo] [nchar](50) NOT NULL,
	[Label] [nchar](200) NOT NULL,
	[PointsEarned] [decimal](18, 5) NULL,
	[PointsRedeem] [decimal](18, 5) NULL,
	[MemberID] [int] NULL,
 CONSTRAINT [PK_LoyaltyMemberBook] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoyaltySetting]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoyaltySetting](
	[LoyaltyName] [nchar](150) NOT NULL,
	[Amount] [decimal](18, 5) NULL,
	[Points] [decimal](18, 5) NULL,
 CONSTRAINT [PK_LoyaltySetting] PRIMARY KEY CLUSTERED 
(
	[LoyaltyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[manu]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manu](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[p_id] [nchar](10) NULL,
	[qty] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[manu_list]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manu_list](
	[man_id] [bigint] IDENTITY(1,1) NOT NULL,
	[p_id] [bigint] NULL,
	[qty] [bigint] NULL,
	[price] [nchar](100) NULL,
	[dated] [date] NOT NULL,
	[stat] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[man_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANU_LST]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANU_LST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[qty] [float] NOT NULL,
	[ProductID] [int] NOT NULL,
	[TRNSID] [int] NOT NULL,
	[DATED] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[meatgrade]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meatgrade](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[mg] [nchar](100) NULL,
	[mgcode] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MIXING]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MIXING](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TITLE] [nvarchar](255) NULL,
	[PID] [int] NULL,
	[IDS] [int] NULL,
	[INVID] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MultiCurrency]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MultiCurrency](
	[MultiDate] [datetime] NOT NULL,
	[InvoiceID] [nvarchar](50) NULL,
	[Currency] [nvarchar](50) NULL,
	[CurrencySymbol] [nvarchar](50) NULL,
	[Rate] [decimal](18, 5) NULL,
	[Balance] [decimal](18, 5) NULL,
	[UserID] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Party]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Party](
	[PT_ID] [int] NOT NULL,
	[Partyname] [nvarchar](250) NOT NULL,
	[Alias] [nchar](200) NULL,
	[Country] [nvarchar](250) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[City] [nchar](200) NOT NULL,
	[State] [nchar](200) NULL,
	[PinCode] [nchar](30) NULL,
	[ContactNo] [nchar](100) NOT NULL,
	[Fax] [nchar](100) NULL,
	[Email] [nchar](200) NULL,
	[TIN] [nchar](50) NULL,
	[CST] [nchar](50) NULL,
	[PAN] [nchar](50) NULL,
	[OpeningBalance] [decimal](18, 5) NULL,
	[BalanceType] [nchar](20) NOT NULL,
	[CreditLimit] [decimal](18, 5) NULL,
	[CreditDays] [int] NOT NULL,
 CONSTRAINT [PK_Party] PRIMARY KEY CLUSTERED 
(
	[PT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[T_ID] [int] NOT NULL,
	[TransactionID] [nchar](20) NULL,
	[Date] [datetime] NOT NULL,
	[PaymentMode] [nchar](30) NULL,
	[SupplierID] [int] NOT NULL,
	[Amount] [decimal](18, 5) NULL,
	[Remarks] [nvarchar](250) NULL,
	[PaymentModeDetails] [nvarchar](250) NULL,
	[OpenID] [int] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[T_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment_Withdraw]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment_Withdraw](
	[id] [int] NOT NULL,
	[AccountFrom] [nchar](50) NULL,
	[PaymentMode] [nchar](50) NULL,
	[Date] [datetime] NULL,
	[Amount] [decimal](18, 5) NULL,
	[ReceiverName] [nchar](150) NULL,
	[PhoneNo] [nchar](50) NULL,
	[Notes] [nchar](200) NULL,
 CONSTRAINT [PK_Payment_Withdraw] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payroll]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payroll](
	[ID] [int] NOT NULL,
	[PaymentID] [nchar](30) NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentMode] [nchar](150) NULL,
	[UserID] [nchar](100) NULL,
	[Rate] [decimal](18, 5) NULL,
	[Hours] [int] NULL,
	[GrossSalary] [decimal](18, 5) NULL,
	[CPPPer] [decimal](18, 5) NULL,
	[CPP] [decimal](18, 5) NULL,
	[EIPer] [decimal](18, 5) NULL,
	[EI] [decimal](18, 5) NULL,
	[FedTaxPer] [decimal](18, 5) NULL,
	[FedTax] [decimal](18, 5) NULL,
	[NetPay] [decimal](18, 5) NULL,
	[DateFrom] [datetime] NULL,
	[DateTo] [datetime] NULL,
	[Remarks] [nchar](250) NULL,
 CONSTRAINT [PK_Payroll] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payroll_MB]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payroll_MB](
	[ID] [int] NOT NULL,
	[PaymentID] [nchar](30) NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentMode] [nchar](150) NULL,
	[UserID] [nchar](100) NULL,
	[GrossSalary] [decimal](18, 5) NULL,
	[CPPPer] [decimal](18, 5) NULL,
	[CPP] [decimal](18, 5) NULL,
	[EIPer] [decimal](18, 5) NULL,
	[EI] [decimal](18, 5) NULL,
	[FedTaxPer] [decimal](18, 5) NULL,
	[FedTax] [decimal](18, 5) NULL,
	[NetPay] [decimal](18, 5) NULL,
	[Month] [nchar](30) NULL,
	[Year] [int] NULL,
	[Remarks] [nchar](250) NULL,
 CONSTRAINT [PK_Payroll_MB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phars]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phars](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [char](100) NULL,
	[address] [char](100) NULL,
	[q1] [char](100) NULL,
	[q2] [char](100) NULL,
	[q3] [char](100) NULL,
	[yrs] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POS_ClosingCash]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POS_ClosingCash](
	[ClosingID] [int] NOT NULL,
	[OpenID] [int] NOT NULL,
	[ClosingDate] [datetime] NULL,
	[ClosingBalance] [decimal](18, 5) NULL,
	[AdjustedBalance] [decimal](18, 5) NULL,
	[Reason] [nchar](200) NULL,
 CONSTRAINT [PK_POS_ClosingCash] PRIMARY KEY CLUSTERED 
(
	[ClosingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POS_HoldBill]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POS_HoldBill](
	[Hold_ID] [nchar](20) NOT NULL,
	[OpenID] [int] NULL,
	[Date] [datetime] NULL,
	[DiscPer] [decimal](18, 5) NULL,
	[DiscAmt] [decimal](18, 5) NULL,
	[mixtitle] [nvarchar](50) NULL,
	[mixstatus] [bit] NULL,
	[tota] [nchar](100) NULL,
	[cna] [nchar](100) NULL,
	[pharname] [nchar](100) NULL,
 CONSTRAINT [PK_POS_HoldBill] PRIMARY KEY CLUSTERED 
(
	[Hold_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POS_HoldBillItems]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POS_HoldBillItems](
	[HBI_ID] [int] IDENTITY(1,1) NOT NULL,
	[HoldID] [nchar](20) NULL,
	[ProductID] [int] NULL,
	[Barcode] [nchar](100) NULL,
	[MfgDate] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[DiscountPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[Qty] [float] NULL,
	[TotalAmount] [decimal](18, 5) NULL,
	[PurchaseRate] [decimal](18, 5) NULL,
	[Margin] [decimal](18, 5) NULL,
	[MarginPer] [decimal](18, 5) NULL,
	[SN] [nvarchar](250) NULL,
	[FreeQty] [float] NULL,
	[mixstatus] [bit] NULL,
	[doz] [nchar](100) NULL,
 CONSTRAINT [PK_POS_HoldBillItems] PRIMARY KEY CLUSTERED 
(
	[HBI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POS_OpeningCash]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POS_OpeningCash](
	[OpenID] [int] NOT NULL,
	[TillDetails] [nchar](100) NULL,
	[UserID] [nchar](100) NOT NULL,
	[OpeningDate] [datetime] NULL,
	[Closed] [int] NULL,
	[OpeningCash] [decimal](18, 5) NULL,
 CONSTRAINT [PK_POS_OpeningCash] PRIMARY KEY CLUSTERED 
(
	[OpenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PosPrinterSetting]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PosPrinterSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrinterName] [nvarchar](250) NOT NULL,
	[IsEnabled] [nchar](20) NOT NULL,
	[TillID] [nchar](100) NULL,
	[CashDrawer] [nchar](20) NULL,
	[CustomerDisplay] [nchar](20) NULL,
	[CDPort] [nchar](30) NULL,
	[WS] [nchar](30) NULL,
	[WSPortNo] [nchar](30) NULL,
	[PT] [nchar](30) NULL,
	[PTipAddress] [nchar](100) NULL,
	[PTPortNo] [nchar](30) NULL,
	[CCD] [nchar](30) NULL,
	[isOS] [nchar](20) NULL,
	[rands] [bit] NULL,
	[Printername2] [nvarchar](255) NULL,
 CONSTRAINT [PK_PosPrinterSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[PID] [int] NOT NULL,
	[ProductCode] [nchar](50) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[Alias] [nchar](150) NULL,
	[VATCommodity] [nchar](200) NULL,
	[Description] [nvarchar](max) NULL,
	[Barcode] [nchar](100) NULL,
	[Category] [nchar](200) NULL,
	[PurchaseUnit] [nchar](30) NULL,
	[SalesUnit] [nchar](30) NULL,
	[PurchaseCost] [decimal](18, 5) NULL,
	[SalesCost] [decimal](18, 5) NULL,
	[ReorderPoint] [int] NULL,
	[AddedDate] [datetime] NULL,
	[MarginPer] [decimal](18, 5) NULL,
	[ShowPS] [nchar](30) NULL,
	[ButtonUIColor] [int] NULL,
	[ImagePath] [nvarchar](max) NULL,
	[A1] [nchar](10) NULL,
	[A2] [nchar](10) NULL,
	[A3] [nchar](10) NULL,
	[A4] [nchar](10) NULL,
	[A5] [nchar](10) NULL,
	[P1] [decimal](18, 5) NULL,
	[P2] [decimal](18, 5) NULL,
	[P3] [decimal](18, 5) NULL,
	[P4] [decimal](18, 5) NULL,
	[P5] [decimal](18, 5) NULL,
	[B1] [nchar](50) NULL,
	[B2] [nchar](50) NULL,
	[B3] [nchar](50) NULL,
	[B4] [nchar](50) NULL,
	[B5] [nchar](50) NULL,
	[Q1] [int] NULL,
	[Q2] [int] NULL,
	[Q3] [int] NULL,
	[Q4] [int] NULL,
	[Q5] [int] NULL,
	[PColor] [nchar](30) NULL,
	[PSize] [nchar](30) NULL,
	[PSupplier] [nchar](100) NULL,
	[MinSalesCost] [decimal](18, 5) NULL,
	[Rate1] [decimal](18, 5) NULL,
	[Rate2] [decimal](18, 5) NULL,
	[Rate3] [decimal](18, 5) NULL,
	[Rate4] [decimal](18, 5) NULL,
	[TrackBatches] [varchar](50) NULL,
	[markup] [decimal](18, 5) NULL,
	[markuppercent] [decimal](18, 5) NULL,
	[bin] [int] NULL,
	[PN1] [varchar](100) NULL,
	[PN2] [varchar](100) NULL,
	[PN3] [varchar](100) NULL,
	[PN4] [varchar](100) NULL,
	[PQ1] [int] NULL,
	[PQ2] [int] NULL,
	[PQ3] [int] NULL,
	[PQ4] [int] NULL,
	[isPack] [bit] NULL,
	[Bom] [bit] NULL,
	[com] [bit] NULL,
	[phar] [bit] NULL,
	[stre] [nchar](100) NULL,
	[mg] [bigint] NULL,
	[PPU1] [decimal](18, 5) NULL,
	[PPU2] [decimal](18, 5) NULL,
	[PPU3] [decimal](18, 5) NULL,
	[PPU4] [decimal](18, 5) NULL,
	[PP1] [decimal](18, 5) NULL,
	[PP2] [decimal](18, 5) NULL,
	[PP3] [decimal](18, 5) NULL,
	[PP4] [decimal](18, 5) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_OpeningStock]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_OpeningStock](
	[PS_ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[StorageType] [nchar](20) NULL,
	[Warehouse_Store] [nchar](250) NULL,
	[Qty] [decimal](18, 5) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[ManufacturingDate] [nchar](50) NULL,
 CONSTRAINT [PK_Product_OpeningStock] PRIMARY KEY CLUSTERED 
(
	[PS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductLocation]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductLocation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RackNo] [nchar](50) NULL,
	[ProductID] [int] NULL,
	[ShelfPosition] [nchar](20) NULL,
 CONSTRAINT [PK_ProductLocation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EntryDate] [datetime] NULL,
	[ProductID] [int] NULL,
	[MinQty] [int] NULL,
	[FreeQty] [int] NULL,
	[IsExpired] [nchar](10) NULL,
	[ExpiryDate] [datetime] NULL,
	[Active] [nchar](10) NULL,
 CONSTRAINT [PK_Promotion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[ST_ID] [int] NOT NULL,
	[InvoiceNo] [nchar](30) NOT NULL,
	[Date] [datetime] NOT NULL,
	[PurchaseType] [nchar](20) NOT NULL,
	[Supplier_ID] [int] NOT NULL,
	[SubTotal] [decimal](18, 5) NULL,
	[DiscountPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[PreviousDue] [decimal](18, 5) NULL,
	[FreightCharges] [decimal](18, 5) NULL,
	[OtherCharges] [decimal](18, 5) NULL,
	[Total] [decimal](18, 5) NULL,
	[RoundOff] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[TotalPayment] [decimal](18, 5) NULL,
	[PaymentDue] [decimal](18, 5) NULL,
	[Remarks] [nvarchar](max) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[ReferenceNo1] [nchar](50) NULL,
	[ReferenceNo2] [nchar](50) NULL,
	[SupplierInvoiceNo] [nchar](50) NULL,
	[SupplierInvoiceDate] [datetime] NULL,
	[TaxType] [nchar](20) NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[ST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase_Join]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Join](
	[SP_ID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Qty] [decimal](18, 5) NULL,
	[Price] [decimal](18, 5) NULL,
	[TotalAmount] [decimal](18, 5) NULL,
	[StorageType] [nchar](20) NULL,
	[Warehouse_Store] [nchar](250) NOT NULL,
	[SalesCost] [decimal](18, 5) NULL,
	[Barcode] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[ManufacturingDate] [nchar](30) NULL,
	[RackNo] [nchar](50) NULL,
	[packqty] [decimal](18, 5) NULL,
	[packname] [char](255) NULL,
 CONSTRAINT [PK_Purchase_Join] PRIMARY KEY CLUSTERED 
(
	[SP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[PO_ID] [int] NOT NULL,
	[PONumber] [nchar](50) NOT NULL,
	[Date] [datetime] NULL,
	[Supplier_ID] [int] NULL,
	[Terms] [nvarchar](max) NULL,
	[SubTotal] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VATAmount] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[TaxType] [nchar](20) NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[PO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder_Join]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder_Join](
	[POJ_ID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseOrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Qty] [decimal](18, 5) NULL,
	[PricePerUnit] [decimal](18, 5) NULL,
	[Amount] [decimal](18, 5) NULL,
 CONSTRAINT [PK_PurchaseOrder_Join] PRIMARY KEY CLUSTERED 
(
	[POJ_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseReturn]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseReturn](
	[PR_ID] [int] NOT NULL,
	[PRNo] [nchar](30) NULL,
	[Date] [datetime] NULL,
	[PurchaseID] [int] NULL,
	[SubTotal] [decimal](18, 5) NULL,
	[DiscPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VATAmt] [decimal](18, 5) NULL,
	[FreightCharges] [decimal](18, 5) NULL,
	[OtherCharges] [decimal](18, 5) NULL,
	[Total] [decimal](18, 5) NULL,
	[RoundOff] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
 CONSTRAINT [PK_PurchaseReturn] PRIMARY KEY CLUSTERED 
(
	[PR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseReturn_Join]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseReturn_Join](
	[PRJ_ID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseReturnID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Qty] [decimal](18, 5) NULL,
	[Price] [decimal](18, 5) NULL,
	[TotalAmount] [decimal](18, 5) NULL,
	[Warehouse_Store] [nchar](250) NULL,
	[SalesCost] [decimal](18, 5) NULL,
	[Barcode] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[ManufacturingDate] [nchar](30) NULL,
	[ReturnQty] [decimal](18, 5) NULL,
	[StorageType] [nchar](20) NULL,
 CONSTRAINT [PK_PurchaseReturn_Join] PRIMARY KEY CLUSTERED 
(
	[PRJ_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quotation]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quotation](
	[Inv_ID] [int] NOT NULL,
	[InvoiceNo] [nchar](30) NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[CurrencyCode] [nchar](50) NULL,
	[ExchangeRate] [decimal](18, 5) NULL,
	[DiscPer] [decimal](18, 5) NULL,
	[DiscAmt] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[TaxType] [nchar](20) NULL,
	[CustID] [int] NULL,
	[BillNote] [nvarchar](max) NULL,
	[CName] [nchar](150) NULL,
	[CCN] [nchar](50) NULL,
	[RoundOff] [decimal](18, 5) NULL,
	[UserID] [nchar](100) NULL,
	[Status] [nchar](20) NULL,
 CONSTRAINT [PK_Quotation] PRIMARY KEY CLUSTERED 
(
	[Inv_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quotation_Join]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quotation_Join](
	[IPo_ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Barcode] [nchar](100) NULL,
	[MfgDate] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[DiscountPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[Qty] [float] NULL,
	[TotalAmount] [decimal](18, 5) NULL,
	[PurchaseRate] [decimal](18, 5) NULL,
	[Margin] [decimal](18, 5) NULL,
	[SN] [nvarchar](250) NULL,
	[FreeQty] [float] NULL,
 CONSTRAINT [PK_Quotation_Join] PRIMARY KEY CLUSTERED 
(
	[IPo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Racking]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Racking](
	[RackNo] [nchar](50) NOT NULL,
	[NoOfShelves] [int] NULL,
	[Active] [nchar](10) NULL,
 CONSTRAINT [PK_Racking] PRIMARY KEY CLUSTERED 
(
	[RackNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[UserID] [nchar](100) NOT NULL,
	[UserType] [nchar](30) NOT NULL,
	[Password] [nchar](50) NOT NULL,
	[Name] [nchar](150) NOT NULL,
	[ContactNo] [nchar](50) NULL,
	[SSN] [nchar](30) NULL,
	[EmailID] [nchar](150) NULL,
	[JoiningDate] [datetime] NOT NULL,
	[Active] [nchar](10) NULL,
	[PayrollType] [nchar](30) NULL,
	[CardNo] [nchar](30) NULL,
	[AllowAccess] [varchar](20) NULL,
	[Quotation] [varchar](20) NULL,
	[BillReprint] [varchar](20) NULL,
	[CreditCustomer] [varchar](20) NULL,
	[SalesReturn] [varchar](20) NULL,
	[SalesList] [varchar](50) NULL,
	[flogin] [bit] NULL,
	[lall] [bit] NULL,
	[pharname] [varchar](100) NULL,
	[Plev1] [nchar](50) NULL,
	[Plev3] [nchar](50) NULL,
	[Plev2] [nchar](50) NULL,
	[FacultyId] [int] NULL,
	[DeptId] [int] NULL,
	[LevelId] [int] NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[regrade]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[regrade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[frompid] [bigint] NULL,
	[topid] [bigint] NULL,
	[qty] [bigint] NULL,
	[reason] [nchar](100) NULL,
	[userd] [nchar](100) NULL,
	[dated] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SalesID] [int] NOT NULL,
	[BillNo] [nchar](30) NOT NULL,
	[BillDate] [datetime] NOT NULL,
	[BillShamsiDate] [datetime] NOT NULL,
	[RefNo1] [nchar](50) NULL,
	[RefNo2] [nchar](50) NULL,
	[SalesType] [nchar](20) NOT NULL,
	[UserOperator] [nchar](100) NOT NULL,
	[PartyID] [int] NOT NULL,
	[SubTotal] [decimal](18, 5) NULL,
	[DiscountPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[FreightCharges] [decimal](18, 5) NULL,
	[OtherCharges] [decimal](18, 5) NULL,
	[PreviousDue] [decimal](18, 5) NULL,
	[Total] [decimal](18, 5) NULL,
	[RoundOff] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[TotalPaid] [decimal](18, 5) NULL,
	[Balance] [decimal](18, 5) NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales_Product]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Product](
	[SP_ID] [int] IDENTITY(1,1) NOT NULL,
	[SalesID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Warehouse] [nchar](250) NOT NULL,
	[QtyPerCarton] [int] NOT NULL,
	[TotalQty] [int] NOT NULL,
	[PricePerQtyBC] [decimal](18, 5) NULL,
	[CurrencyCode] [nchar](10) NOT NULL,
	[Total_SalesdCurrency] [decimal](18, 5) NULL,
	[ExchangeRate] [decimal](18, 5) NULL,
	[PricePerQty] [decimal](18, 5) NULL,
	[Total_QuotedCurrency] [decimal](18, 5) NULL,
	[DiscountPer] [decimal](18, 5) NULL,
	[Discount] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[AdditionalVAT] [decimal](18, 5) NULL,
	[AdditionalVATPer] [decimal](18, 5) NULL,
	[TotalAmount] [decimal](18, 5) NULL,
 CONSTRAINT [PK_Sales_Product] PRIMARY KEY CLUSTERED 
(
	[SP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesMan]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesMan](
	[SM_ID] [int] NOT NULL,
	[SalesMan_ID] [nchar](30) NULL,
	[Name] [nchar](200) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nchar](200) NULL,
	[State] [nchar](150) NULL,
	[ZipCode] [nchar](15) NULL,
	[ContactNo] [nchar](150) NULL,
	[EmailID] [nchar](200) NULL,
	[Remarks] [nvarchar](max) NULL,
	[Photo] [image] NULL,
	[CommissionPer] [decimal](18, 5) NULL,
 CONSTRAINT [PK_SalesMan] PRIMARY KEY CLUSTERED 
(
	[SM_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salesman_Commission]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salesman_Commission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[CommissionPer] [decimal](18, 5) NULL,
	[Commission] [decimal](18, 5) NULL,
 CONSTRAINT [PK_Salesman_Commission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesReturn]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesReturn](
	[SR_ID] [int] NOT NULL,
	[SRNo] [nchar](50) NULL,
	[Date] [date] NULL,
	[SalesID] [int] NULL,
	[SubTotal] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[OpenID] [int] NULL,
	[API_ID] [nvarchar](36) NULL,
	[DeviceID] [varchar](50) NULL,
	[FiscalDay] [varchar](50) NULL,
	[ReceiptNo] [varchar](50) NULL,
	[CustomerRef] [varchar](50) NULL,
	[Vcode] [varchar](80) NULL,
	[qrcode] [image] NULL,
	[erp] [bit] NULL,
 CONSTRAINT [PK_SalesReturn] PRIMARY KEY CLUSTERED 
(
	[SR_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesReturn_Join]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesReturn_Join](
	[SRJ_ID] [int] IDENTITY(1,1) NOT NULL,
	[SalesReturnID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Barcode] [nchar](50) NULL,
	[ManufacturingDate] [nchar](30) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[Qty] [decimal](18, 5) NULL,
	[SalesCost] [decimal](18, 5) NULL,
	[DiscPer] [decimal](18, 5) NULL,
	[DiscAmt] [decimal](18, 5) NULL,
	[CGSTPer] [decimal](18, 5) NULL,
	[CGSTAmt] [decimal](18, 5) NULL,
	[ReturnQty] [decimal](18, 5) NULL,
	[TotalAmount] [decimal](18, 5) NULL,
 CONSTRAINT [PK_SalesReturn_Join] PRIMARY KEY CLUSTERED 
(
	[SRJ_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseTax] [nchar](20) NOT NULL,
	[SalesTax] [nchar](20) NOT NULL,
 CONSTRAINT [PK_PurchaseSetting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SMSSetting]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SMSSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[APIURL] [nvarchar](max) NOT NULL,
	[IsDefault] [nchar](10) NOT NULL,
	[IsEnabled] [nchar](10) NOT NULL,
 CONSTRAINT [PK_SMSSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock_adjustment_card]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_adjustment_card](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dated] [datetime] NULL,
	[ref] [nchar](100) NULL,
	[pna] [nchar](100) NULL,
	[total] [nchar](100) NULL,
	[ntotal] [nchar](100) NULL,
	[ptotal] [nchar](100) NULL,
	[userd] [nchar](100) NULL,
	[pid] [int] NULL,
	[p] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock_adjustment_card_list]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_adjustment_card_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NULL,
	[qty] [nchar](100) NULL,
	[var] [nchar](100) NULL,
	[counted] [nchar](100) NULL,
	[unit] [nchar](100) NULL,
	[total] [nchar](100) NULL,
	[adjstid] [nchar](100) NULL,
	[batches] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockAdjustment_Store]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockAdjustment_Store](
	[SA_ID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Barcode] [nchar](30) NULL,
	[Date] [datetime] NULL,
	[AdjustmentType] [nchar](20) NULL,
	[Qty] [decimal](18, 5) NULL,
	[Reason] [nchar](200) NULL,
 CONSTRAINT [PK_StockAdjustment_Store] PRIMARY KEY CLUSTERED 
(
	[SA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockAdjustment_Warehouse]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockAdjustment_Warehouse](
	[SA_ID] [int] NOT NULL,
	[Date] [datetime] NULL,
	[Warehouse] [nchar](250) NULL,
	[ProductID] [int] NULL,
	[Barcode] [nchar](30) NULL,
	[AdjustmentType] [nchar](20) NULL,
	[Qty] [decimal](18, 5) NULL,
	[Reason] [nchar](200) NULL,
 CONSTRAINT [PK_StockAdjustment_Warehouse] PRIMARY KEY CLUSTERED 
(
	[SA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockTransfer]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockTransfer](
	[ST_ID] [int] NOT NULL,
	[TransferID] [nchar](30) NULL,
	[Date] [datetime] NOT NULL,
	[CompanyID] [int] NOT NULL,
 CONSTRAINT [PK_StockTransfer_1] PRIMARY KEY CLUSTERED 
(
	[ST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockTransfer_Join]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockTransfer_Join](
	[STJ_ID] [int] IDENTITY(1,1) NOT NULL,
	[StockTransferID] [int] NOT NULL,
	[Warehouse] [nchar](250) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Barcode] [nchar](50) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[ManufacturingDate] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[Qty] [decimal](18, 5) NULL,
 CONSTRAINT [PK_StockTransfer] PRIMARY KEY CLUSTERED 
(
	[STJ_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockTransfer_Join_S2W]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockTransfer_Join_S2W](
	[STJ_ID] [int] IDENTITY(1,1) NOT NULL,
	[StockTransferID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Barcode] [nchar](50) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[ManufacturingDate] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[Qty] [decimal](18, 5) NULL,
 CONSTRAINT [PK_StockTransfer_S2W] PRIMARY KEY CLUSTERED 
(
	[STJ_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockTransfer_Join_W2W]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockTransfer_Join_W2W](
	[STJ_ID] [int] IDENTITY(1,1) NOT NULL,
	[StockTransferID] [int] NOT NULL,
	[Warehouse] [nchar](250) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Barcode] [nchar](50) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[ManufacturingDate] [nchar](50) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[Qty] [decimal](18, 5) NULL,
 CONSTRAINT [PK_StockTransfer_W2W] PRIMARY KEY CLUSTERED 
(
	[STJ_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockTransfer_S2W]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockTransfer_S2W](
	[ST_ID] [int] NOT NULL,
	[TransferID] [nchar](30) NULL,
	[Date] [datetime] NOT NULL,
	[Warehouse] [nchar](250) NOT NULL,
 CONSTRAINT [PK_StockTransfer_S2W_1] PRIMARY KEY CLUSTERED 
(
	[ST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockTransfer_W2W]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockTransfer_W2W](
	[ST_ID] [int] NOT NULL,
	[TransferID] [nchar](30) NULL,
	[Date] [datetime] NOT NULL,
	[Warehouse] [nchar](250) NOT NULL,
 CONSTRAINT [PK_StockTransfer_W2W_1] PRIMARY KEY CLUSTERED 
(
	[ST_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [int] NOT NULL,
	[SupplierID] [nchar](30) NOT NULL,
	[Name] [nchar](200) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nchar](200) NULL,
	[State] [nchar](150) NULL,
	[ZipCode] [nchar](15) NULL,
	[ContactNo] [nchar](150) NULL,
	[EmailID] [nchar](200) NULL,
	[Remarks] [nvarchar](max) NULL,
	[TIN] [nchar](100) NULL,
	[STNo] [nchar](100) NULL,
	[CST] [nchar](100) NULL,
	[PAN] [nchar](100) NULL,
	[AccountName] [nchar](150) NULL,
	[AccountNumber] [nchar](100) NULL,
	[Bank] [nchar](150) NULL,
	[Branch] [nchar](150) NULL,
	[IFSCCode] [nchar](50) NULL,
	[OpeningBalance] [decimal](18, 5) NULL,
	[OpeningBalanceType] [nchar](20) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierLedgerBook]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierLedgerBook](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Name] [nchar](200) NOT NULL,
	[LedgerNo] [nchar](50) NOT NULL,
	[Label] [nchar](200) NOT NULL,
	[Debit] [decimal](18, 5) NULL,
	[Credit] [decimal](18, 5) NULL,
	[PartyID] [nchar](20) NULL,
 CONSTRAINT [PK_SupplierLedgerBook] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxMaster]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxMaster](
	[TaxName] [nchar](200) NOT NULL,
	[TaxType] [nchar](200) NOT NULL,
	[Percentage] [decimal](18, 5) NULL,
	[AdditionalPercentage] [decimal](18, 5) NULL,
 CONSTRAINT [PK_TaxMaster] PRIMARY KEY CLUSTERED 
(
	[TaxName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxType]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxType](
	[Type] [nchar](200) NOT NULL,
 CONSTRAINT [PK_TaxType] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp_Stock]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_Stock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Warehouse] [nchar](250) NOT NULL,
	[Barcode] [nchar](30) NULL,
	[PurchaseRate] [decimal](18, 5) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[Qty] [decimal](18, 5) NULL,
	[ExpiryDate] [nchar](50) NULL,
	[ManufacturingDate] [nchar](50) NULL,
 CONSTRAINT [PK_Temp_Stock] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp_Stock_Company]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_Stock_Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Barcode] [nchar](30) NULL,
	[PurchaseRate] [decimal](18, 5) NULL,
	[SalesRate] [decimal](18, 5) NULL,
	[ManufacturingDate] [nchar](30) NULL,
	[ExpiryDate] [nchar](30) NULL,
	[Qty] [decimal](18, 5) NULL,
 CONSTRAINT [PK_Temp_Stock_Store] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitMaster]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitMaster](
	[Unit] [nchar](150) NOT NULL,
 CONSTRAINT [PK_UnitMaster] PRIMARY KEY CLUSTERED 
(
	[Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRights]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRights](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleName] [nchar](200) NULL,
	[UR_Save] [bit] NULL,
	[UR_Update] [bit] NULL,
	[UR_Delete] [bit] NULL,
	[UR_View] [bit] NULL,
	[UserID] [nchar](100) NULL,
 CONSTRAINT [PK_UserRights] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venues]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[venue_name] [nvarchar](100) NOT NULL,
	[location] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[ID] [int] NOT NULL,
	[VoucherNo] [nchar](30) NOT NULL,
	[Name] [nchar](150) NULL,
	[Date] [datetime] NOT NULL,
	[Details] [nvarchar](max) NULL,
	[PaymentMode] [nchar](150) NOT NULL,
	[SubTotal] [decimal](18, 5) NULL,
	[VATPer] [decimal](18, 5) NULL,
	[VAT] [decimal](18, 5) NULL,
	[GrandTotal] [decimal](18, 5) NULL,
	[OpenID] [int] NULL,
 CONSTRAINT [PK_Voucher] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voucher_OtherDetails]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher_OtherDetails](
	[VD_ID] [int] IDENTITY(1,1) NOT NULL,
	[VoucherID] [int] NOT NULL,
	[Particulars] [nvarchar](250) NOT NULL,
	[Amount] [decimal](18, 5) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Voucher_OtherDetails] PRIMARY KEY CLUSTERED 
(
	[VD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wallet]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wallet](
	[WalletType] [nchar](200) NOT NULL,
 CONSTRAINT [PK_Wallet] PRIMARY KEY CLUSTERED 
(
	[WalletType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[WarehouseName] [nchar](250) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[WarehouseType] [nchar](200) NOT NULL,
	[City] [nchar](200) NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[WarehouseName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WarehouseType]    Script Date: 7/8/2024 4:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WarehouseType](
	[Type] [nchar](200) NOT NULL,
 CONSTRAINT [PK_WarehouseType] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CardProcessing] ADD  CONSTRAINT [DF_CardProcessing_PF]  DEFAULT ((0.00)) FOR [PF]
GO
ALTER TABLE [dbo].[CardProcessing] ADD  CONSTRAINT [DF_CardProcessing_Amount]  DEFAULT ((0.0000)) FOR [Amount]
GO
ALTER TABLE [dbo].[CardProcessing] ADD  CONSTRAINT [DF_CardProcessing_InvoiceAmount]  DEFAULT ((0.00)) FOR [InvoiceAmount]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_LicenseNo]  DEFAULT ((0.00)) FOR [LicenseNo]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_CapitalAccount]  DEFAULT ((0.00)) FOR [CapitalAccount]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [patchinter]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [cash]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [autoprint]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [autoprintshift]
GO
ALTER TABLE [dbo].[CreditCustomer] ADD  CONSTRAINT [DF_CreditCustomer_OpeningBalance]  DEFAULT ((0.00)) FOR [OpeningBalance]
GO
ALTER TABLE [dbo].[CreditCustomer] ADD  CONSTRAINT [DF_CreditCustomer_CreditLimit]  DEFAULT ((0.00)) FOR [CreditLimit]
GO
ALTER TABLE [dbo].[Invoice_Payment] ADD  CONSTRAINT [DF_Invoice_Payment_Amount]  DEFAULT ((0.00)) FOR [Amount]
GO
ALTER TABLE [dbo].[Invoice_Product] ADD  CONSTRAINT [DF_Invoice_Product_DiscountPer]  DEFAULT ((0.00)) FOR [DiscountPer]
GO
ALTER TABLE [dbo].[Invoice_Product] ADD  CONSTRAINT [DF_Invoice_Product_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
ALTER TABLE [dbo].[Invoice_Product] ADD  CONSTRAINT [DF_Invoice_Product_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[Invoice_Product] ADD  CONSTRAINT [DF_Invoice_Product_VAT]  DEFAULT ((0.00)) FOR [VAT]
GO
ALTER TABLE [dbo].[Invoice_Product] ADD  CONSTRAINT [DF_Invoice_Product_Qty]  DEFAULT ((1)) FOR [Qty]
GO
ALTER TABLE [dbo].[Invoice_Product] ADD  CONSTRAINT [DF_Invoice_Product_TotalAmount]  DEFAULT ((0.00)) FOR [TotalAmount]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_ExchangeRate]  DEFAULT ((1.00)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_DiscPer]  DEFAULT ((0.00)) FOR [DiscPer]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_DiscAmt]  DEFAULT ((0.00)) FOR [DiscAmt]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_SalesmanID]  DEFAULT ((0)) FOR [SalesmanID]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_Cash]  DEFAULT ((0.00)) FOR [Cash]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_Change]  DEFAULT ((0.00)) FOR [Change]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_CustID]  DEFAULT ((0)) FOR [CustID]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_LoyaltyMemberID]  DEFAULT ((0)) FOR [LoyaltyMemberID]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [DF_InvoiceInfo_LP]  DEFAULT ((0)) FOR [LP]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  CONSTRAINT [InvoiceInfo_RoundOff]  DEFAULT ((0.00)) FOR [RoundOff]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  DEFAULT ((0)) FOR [dispatch]
GO
ALTER TABLE [dbo].[InvoiceInfo] ADD  DEFAULT ((0)) FOR [erp]
GO
ALTER TABLE [dbo].[Party] ADD  CONSTRAINT [DF_Party_OpeningBalance]  DEFAULT ((0.00)) FOR [OpeningBalance]
GO
ALTER TABLE [dbo].[Party] ADD  CONSTRAINT [DF_Party_CreditLimit]  DEFAULT ((0.00)) FOR [CreditLimit]
GO
ALTER TABLE [dbo].[Party] ADD  CONSTRAINT [DF_Party_CreditDays]  DEFAULT ((0)) FOR [CreditDays]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_Rate]  DEFAULT ((0.00)) FOR [Rate]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_GrossSalary]  DEFAULT ((0.00)) FOR [GrossSalary]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_CPPPer]  DEFAULT ((0.00)) FOR [CPPPer]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_CPP]  DEFAULT ((0.00)) FOR [CPP]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_EIPer]  DEFAULT ((0.00)) FOR [EIPer]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_EI]  DEFAULT ((0.00)) FOR [EI]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_FedTaxPer]  DEFAULT ((0.00)) FOR [FedTaxPer]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_FedTax]  DEFAULT ((0.00)) FOR [FedTax]
GO
ALTER TABLE [dbo].[Payroll] ADD  CONSTRAINT [DF_Payroll_NetPay]  DEFAULT ((0.00)) FOR [NetPay]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_GrossSalary]  DEFAULT ((0.00)) FOR [GrossSalary]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_CPPPer]  DEFAULT ((0.00)) FOR [CPPPer]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_CPP]  DEFAULT ((0.00)) FOR [CPP]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_EIPer]  DEFAULT ((0.00)) FOR [EIPer]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_EI]  DEFAULT ((0.00)) FOR [EI]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_FedTaxPer]  DEFAULT ((0.00)) FOR [FedTaxPer]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_FedTax]  DEFAULT ((0.00)) FOR [FedTax]
GO
ALTER TABLE [dbo].[Payroll_MB] ADD  CONSTRAINT [DF_Payroll_MB_NetPay]  DEFAULT ((0.00)) FOR [NetPay]
GO
ALTER TABLE [dbo].[POS_ClosingCash] ADD  CONSTRAINT [DF_POS_ClosingCash_ClosingBalance]  DEFAULT ((0.00)) FOR [ClosingBalance]
GO
ALTER TABLE [dbo].[POS_ClosingCash] ADD  CONSTRAINT [POS_ClosingCash_AdjustedBalance]  DEFAULT ((0.00)) FOR [AdjustedBalance]
GO
ALTER TABLE [dbo].[POS_HoldBill] ADD  CONSTRAINT [DF_POS_HoldBill_DiscPer]  DEFAULT ((0.00)) FOR [DiscPer]
GO
ALTER TABLE [dbo].[POS_HoldBill] ADD  CONSTRAINT [DF_POS_HoldBill_DiscAmt]  DEFAULT ((0.00)) FOR [DiscAmt]
GO
ALTER TABLE [dbo].[POS_HoldBillItems] ADD  CONSTRAINT [DF_POS_HoldBillItems_DiscountPer]  DEFAULT ((0.00)) FOR [DiscountPer]
GO
ALTER TABLE [dbo].[POS_HoldBillItems] ADD  CONSTRAINT [DF_POS_HoldBillItems_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
ALTER TABLE [dbo].[POS_HoldBillItems] ADD  CONSTRAINT [DF_POS_HoldBillItems_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[POS_HoldBillItems] ADD  CONSTRAINT [DF_POS_HoldBillItems_VAT]  DEFAULT ((0.00)) FOR [VAT]
GO
ALTER TABLE [dbo].[POS_HoldBillItems] ADD  CONSTRAINT [DF_POS_HoldBillItems_Qty]  DEFAULT ((1)) FOR [Qty]
GO
ALTER TABLE [dbo].[POS_HoldBillItems] ADD  CONSTRAINT [DF_POS_HoldBillItems_TotalAmount]  DEFAULT ((0.00)) FOR [TotalAmount]
GO
ALTER TABLE [dbo].[POS_OpeningCash] ADD  CONSTRAINT [DF_POS_OpeningCash_Closed]  DEFAULT ((0)) FOR [Closed]
GO
ALTER TABLE [dbo].[POS_OpeningCash] ADD  CONSTRAINT [DF_POS_OpeningCash_OpeningCash]  DEFAULT ((0.00)) FOR [OpeningCash]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_PurchaseCost]  DEFAULT ((0.00)) FOR [PurchaseCost]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_SalesCost]  DEFAULT ((0.00)) FOR [SalesCost]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_ReorderPoint]  DEFAULT ((0)) FOR [ReorderPoint]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_MarginPer]  DEFAULT ((0.00)) FOR [MarginPer]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Rate1]  DEFAULT ((0.00)) FOR [Rate1]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Rate2]  DEFAULT ((0.00)) FOR [Rate2]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Rate3]  DEFAULT ((0.00)) FOR [Rate3]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Rate4]  DEFAULT ((0.00)) FOR [Rate4]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_isPack]  DEFAULT ((0)) FOR [isPack]
GO
ALTER TABLE [dbo].[Product_OpeningStock] ADD  CONSTRAINT [DF_Product_OpeningStock_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_SubTotal]  DEFAULT ((0.00)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_DiscountPer]  DEFAULT ((0.00)) FOR [DiscountPer]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_PreviousDue]  DEFAULT ((0.00)) FOR [PreviousDue]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_FreightCharges]  DEFAULT ((0.00)) FOR [FreightCharges]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_OtherCharges]  DEFAULT ((0.00)) FOR [OtherCharges]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Total]  DEFAULT ((0.00)) FOR [Total]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_RoundOff]  DEFAULT ((0.00)) FOR [RoundOff]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_TotalPayment]  DEFAULT ((0.00)) FOR [TotalPayment]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_PaymentDue]  DEFAULT ((0.00)) FOR [PaymentDue]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_VAT]  DEFAULT ((0.00)) FOR [VAT]
GO
ALTER TABLE [dbo].[Purchase_Join] ADD  CONSTRAINT [DF_Purchase_Join_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[Purchase_Join] ADD  CONSTRAINT [DF_Purchase_Join_Price]  DEFAULT ((0.00)) FOR [Price]
GO
ALTER TABLE [dbo].[Purchase_Join] ADD  CONSTRAINT [DF_Purchase_Join_SalesCost]  DEFAULT ((0.00)) FOR [SalesCost]
GO
ALTER TABLE [dbo].[PurchaseOrder] ADD  CONSTRAINT [DF_PurchaseOrder_SubTotal]  DEFAULT ((0.00)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[PurchaseOrder] ADD  CONSTRAINT [DF_PurchaseOrder_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[PurchaseOrder] ADD  CONSTRAINT [DF_PurchaseOrder_VATAmount]  DEFAULT ((0.00)) FOR [VATAmount]
GO
ALTER TABLE [dbo].[PurchaseOrder] ADD  CONSTRAINT [DF_PurchaseOrder_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
ALTER TABLE [dbo].[PurchaseOrder_Join] ADD  CONSTRAINT [DF_PurchaseOrder_Join_PricePerUnit]  DEFAULT ((0.00)) FOR [PricePerUnit]
GO
ALTER TABLE [dbo].[PurchaseOrder_Join] ADD  CONSTRAINT [DF_PurchaseOrder_Join_Amount]  DEFAULT ((0.00)) FOR [Amount]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_SubTotal]  DEFAULT ((0.00)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_DiscPer]  DEFAULT ((0.00)) FOR [DiscPer]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_VATAmt]  DEFAULT ((0.00)) FOR [VATAmt]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_Total]  DEFAULT ((0.00)) FOR [Total]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_RoundOff]  DEFAULT ((0.00)) FOR [RoundOff]
GO
ALTER TABLE [dbo].[PurchaseReturn] ADD  CONSTRAINT [DF_PurchaseReturn_GrandTotal]  DEFAULT ((0.00)) FOR [GrandTotal]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_ExchangeRate]  DEFAULT ((1.00)) FOR [ExchangeRate]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_DiscPer]  DEFAULT ((0.00)) FOR [DiscPer]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_DiscAmt]  DEFAULT ((0.00)) FOR [DiscAmt]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [DF_Quotation_CustID]  DEFAULT ((0)) FOR [CustID]
GO
ALTER TABLE [dbo].[Quotation] ADD  CONSTRAINT [Quotation_RoundOff]  DEFAULT ((0.00)) FOR [RoundOff]
GO
ALTER TABLE [dbo].[Quotation_Join] ADD  CONSTRAINT [DF_Quotation_Join_DiscountPer]  DEFAULT ((0.00)) FOR [DiscountPer]
GO
ALTER TABLE [dbo].[Quotation_Join] ADD  CONSTRAINT [DF_Quotation_Join_Discount]  DEFAULT ((0.00)) FOR [Discount]
GO
ALTER TABLE [dbo].[Quotation_Join] ADD  CONSTRAINT [DF_Quotation_Join_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[Quotation_Join] ADD  CONSTRAINT [DF_Quotation_Join_VAT]  DEFAULT ((0.00)) FOR [VAT]
GO
ALTER TABLE [dbo].[Quotation_Join] ADD  CONSTRAINT [DF_Quotation_Join_Qty]  DEFAULT ((1)) FOR [Qty]
GO
ALTER TABLE [dbo].[Quotation_Join] ADD  CONSTRAINT [DF_Quotation_Join_TotalAmount]  DEFAULT ((0.00)) FOR [TotalAmount]
GO
ALTER TABLE [dbo].[Registration] ADD  DEFAULT ((1)) FOR [flogin]
GO
ALTER TABLE [dbo].[SalesMan] ADD  CONSTRAINT [DF_SalesMan_Commission]  DEFAULT ((0.00)) FOR [CommissionPer]
GO
ALTER TABLE [dbo].[Salesman_Commission] ADD  CONSTRAINT [DF_Salesman_Commission_CommissionPer]  DEFAULT ((0.00)) FOR [CommissionPer]
GO
ALTER TABLE [dbo].[Salesman_Commission] ADD  CONSTRAINT [DF_Salesman_Commission_Commission]  DEFAULT ((0.00)) FOR [Commission]
GO
ALTER TABLE [dbo].[SalesReturn] ADD  DEFAULT ((0)) FOR [erp]
GO
ALTER TABLE [dbo].[StockTransfer_Join] ADD  CONSTRAINT [DF_StockTransfer_Join_SalesRate]  DEFAULT ((0.00)) FOR [SalesRate]
GO
ALTER TABLE [dbo].[StockTransfer_Join_S2W] ADD  CONSTRAINT [DF_StockTransfer_Join_S2W_SalesRate]  DEFAULT ((0.00)) FOR [SalesRate]
GO
ALTER TABLE [dbo].[StockTransfer_Join_W2W] ADD  CONSTRAINT [DF_StockTransfer_Join_W2W_SalesRate]  DEFAULT ((0.00)) FOR [SalesRate]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_OpeningBalance]  DEFAULT ((0.00)) FOR [OpeningBalance]
GO
ALTER TABLE [dbo].[Temp_Stock] ADD  CONSTRAINT [DF_Temp_Stock_SalesRate]  DEFAULT ((0.00)) FOR [SalesRate]
GO
ALTER TABLE [dbo].[Temp_Stock] ADD  CONSTRAINT [DF_Temp_Stock_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[Temp_Stock_Company] ADD  CONSTRAINT [DF_Temp_Stock_Company_SalesRate]  DEFAULT ((0.00)) FOR [SalesRate]
GO
ALTER TABLE [dbo].[Temp_Stock_Company] ADD  CONSTRAINT [DF_Temp_Stock_Company_Qty]  DEFAULT ((0.00)) FOR [Qty]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_SubTotal]  DEFAULT ((0.00)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_VATPer]  DEFAULT ((0.00)) FOR [VATPer]
GO
ALTER TABLE [dbo].[Voucher] ADD  CONSTRAINT [DF_Voucher_VAT]  DEFAULT ((0.00)) FOR [VAT]
GO
ALTER TABLE [dbo].[BankAccountLedger]  WITH CHECK ADD  CONSTRAINT [FK_BankAccountLedger_BankAccountRegistration] FOREIGN KEY([AccNo])
REFERENCES [dbo].[BankAccountRegistration] ([AccountNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BankAccountLedger] CHECK CONSTRAINT [FK_BankAccountLedger_BankAccountRegistration]
GO
ALTER TABLE [dbo].[BankAccountRegistration]  WITH CHECK ADD  CONSTRAINT [FK_BankAccountRegistration_BankBranch] FOREIGN KEY([BranchID])
REFERENCES [dbo].[BankBranch] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BankAccountRegistration] CHECK CONSTRAINT [FK_BankAccountRegistration_BankBranch]
GO
ALTER TABLE [dbo].[BankBranch]  WITH CHECK ADD  CONSTRAINT [FK_BankBranch_Bank] FOREIGN KEY([BankName])
REFERENCES [dbo].[Bank] ([BankName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BankBranch] CHECK CONSTRAINT [FK_BankBranch_Bank]
GO
ALTER TABLE [dbo].[Batches]  WITH CHECK ADD  CONSTRAINT [FK_Batches_Product] FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO
ALTER TABLE [dbo].[Batches] CHECK CONSTRAINT [FK_Batches_Product]
GO
ALTER TABLE [dbo].[CardProcessing]  WITH CHECK ADD  CONSTRAINT [FK_CardProcessing_InvoiceInfo] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[InvoiceInfo] ([Inv_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CardProcessing] CHECK CONSTRAINT [FK_CardProcessing_InvoiceInfo]
GO
ALTER TABLE [dbo].[ClockOUT]  WITH CHECK ADD  CONSTRAINT [FK_ClockOUT_ClockIN] FOREIGN KEY([ClockInID])
REFERENCES [dbo].[ClockIN] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClockOUT] CHECK CONSTRAINT [FK_ClockOUT_ClockIN]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[dept] ([id])
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD FOREIGN KEY([FacultyID])
REFERENCES [dbo].[faculty] ([id])
GO
ALTER TABLE [dbo].[CreditCustomerLedger]  WITH CHECK ADD  CONSTRAINT [FK_CreditCustomerLedger_CreditCustomer] FOREIGN KEY([CreditCustomer_ID])
REFERENCES [dbo].[CreditCustomer] ([CC_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CreditCustomerLedger] CHECK CONSTRAINT [FK_CreditCustomerLedger_CreditCustomer]
GO
ALTER TABLE [dbo].[CreditCustomerPayment]  WITH CHECK ADD  CONSTRAINT [FK_CreditCustomerPayment_CreditCustomer] FOREIGN KEY([CreditCustomer_ID])
REFERENCES [dbo].[CreditCustomer] ([CC_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CreditCustomerPayment] CHECK CONSTRAINT [FK_CreditCustomerPayment_CreditCustomer]
GO
ALTER TABLE [dbo].[dept]  WITH CHECK ADD FOREIGN KEY([facultyid])
REFERENCES [dbo].[faculty] ([id])
GO
ALTER TABLE [dbo].[DiscountSetting]  WITH CHECK ADD  CONSTRAINT [FK_DiscountSetting_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DiscountSetting] CHECK CONSTRAINT [FK_DiscountSetting_Registration]
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD  CONSTRAINT [FK_Expense_ExpenseType] FOREIGN KEY([ExpenseType])
REFERENCES [dbo].[ExpenseType] ([Type])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Expense] CHECK CONSTRAINT [FK_Expense_ExpenseType]
GO
ALTER TABLE [dbo].[FundDeposit]  WITH CHECK ADD  CONSTRAINT [FK_FundDeposit_BankAccountRegistration] FOREIGN KEY([AccNo])
REFERENCES [dbo].[BankAccountRegistration] ([AccountNo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[FundDeposit] CHECK CONSTRAINT [FK_FundDeposit_BankAccountRegistration]
GO
ALTER TABLE [dbo].[Invoice_Payment]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Payment_InvoiceInfo] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[InvoiceInfo] ([Inv_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice_Payment] CHECK CONSTRAINT [FK_Invoice_Payment_InvoiceInfo]
GO
ALTER TABLE [dbo].[Invoice_Product]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Product_InvoiceInfo] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[InvoiceInfo] ([Inv_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice_Product] CHECK CONSTRAINT [FK_Invoice_Product_InvoiceInfo]
GO
ALTER TABLE [dbo].[Invoice_Product]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Product_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Invoice_Product] CHECK CONSTRAINT [FK_Invoice_Product_Product]
GO
ALTER TABLE [dbo].[InvoiceInfo]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_POS_OpeningCash] FOREIGN KEY([OpenID])
REFERENCES [dbo].[POS_OpeningCash] ([OpenID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[InvoiceInfo] CHECK CONSTRAINT [FK_InvoiceInfo_POS_OpeningCash]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Registration]
GO
ALTER TABLE [dbo].[LoyaltyMemberLedgerBook]  WITH CHECK ADD  CONSTRAINT [FK_LoyaltyMemberLedgerBook_LoyaltyMember] FOREIGN KEY([MemberID])
REFERENCES [dbo].[LoyaltyMember] ([MemberID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LoyaltyMemberLedgerBook] CHECK CONSTRAINT [FK_LoyaltyMemberLedgerBook_LoyaltyMember]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Supplier]
GO
ALTER TABLE [dbo].[Payment_Withdraw]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Withdraw_BankAccountRegistration] FOREIGN KEY([AccountFrom])
REFERENCES [dbo].[BankAccountRegistration] ([AccountNo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Payment_Withdraw] CHECK CONSTRAINT [FK_Payment_Withdraw_BankAccountRegistration]
GO
ALTER TABLE [dbo].[Payroll]  WITH CHECK ADD  CONSTRAINT [FK_Payroll_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Payroll] CHECK CONSTRAINT [FK_Payroll_Registration]
GO
ALTER TABLE [dbo].[Payroll_MB]  WITH CHECK ADD  CONSTRAINT [FK_Payroll_MB_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Payroll_MB] CHECK CONSTRAINT [FK_Payroll_MB_Registration]
GO
ALTER TABLE [dbo].[POS_ClosingCash]  WITH CHECK ADD  CONSTRAINT [FK_POS_ClosingCash_POS_OpeningCash] FOREIGN KEY([OpenID])
REFERENCES [dbo].[POS_OpeningCash] ([OpenID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[POS_ClosingCash] CHECK CONSTRAINT [FK_POS_ClosingCash_POS_OpeningCash]
GO
ALTER TABLE [dbo].[POS_HoldBill]  WITH CHECK ADD  CONSTRAINT [FK_POS_HoldBill_POS_OpeningCash] FOREIGN KEY([OpenID])
REFERENCES [dbo].[POS_OpeningCash] ([OpenID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[POS_HoldBill] CHECK CONSTRAINT [FK_POS_HoldBill_POS_OpeningCash]
GO
ALTER TABLE [dbo].[POS_HoldBillItems]  WITH CHECK ADD  CONSTRAINT [FK_POS_HoldBillItems_POS_HoldBill] FOREIGN KEY([HoldID])
REFERENCES [dbo].[POS_HoldBill] ([Hold_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[POS_HoldBillItems] CHECK CONSTRAINT [FK_POS_HoldBillItems_POS_HoldBill]
GO
ALTER TABLE [dbo].[POS_HoldBillItems]  WITH CHECK ADD  CONSTRAINT [FK_POS_HoldBillItems_Product1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[POS_HoldBillItems] CHECK CONSTRAINT [FK_POS_HoldBillItems_Product1]
GO
ALTER TABLE [dbo].[POS_OpeningCash]  WITH CHECK ADD  CONSTRAINT [FK_POS_OpeningCash_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[POS_OpeningCash] CHECK CONSTRAINT [FK_POS_OpeningCash_Registration]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([CategoryName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_TaxMaster] FOREIGN KEY([VATCommodity])
REFERENCES [dbo].[TaxMaster] ([TaxName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_TaxMaster]
GO
ALTER TABLE [dbo].[Product_OpeningStock]  WITH CHECK ADD  CONSTRAINT [FK_Product_OpeningStock_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_OpeningStock] CHECK CONSTRAINT [FK_Product_OpeningStock_Product]
GO
ALTER TABLE [dbo].[ProductLocation]  WITH CHECK ADD  CONSTRAINT [FK_ProductLocation_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductLocation] CHECK CONSTRAINT [FK_ProductLocation_Product]
GO
ALTER TABLE [dbo].[ProductLocation]  WITH CHECK ADD  CONSTRAINT [FK_ProductLocation_Racking] FOREIGN KEY([RackNo])
REFERENCES [dbo].[Racking] ([RackNo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductLocation] CHECK CONSTRAINT [FK_ProductLocation_Racking]
GO
ALTER TABLE [dbo].[Promotion]  WITH CHECK ADD  CONSTRAINT [FK_Promotion_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Promotion] CHECK CONSTRAINT [FK_Promotion_Product]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Supplier] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Supplier] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Supplier]
GO
ALTER TABLE [dbo].[Purchase_Join]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Join_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Purchase_Join] CHECK CONSTRAINT [FK_Purchase_Join_Product]
GO
ALTER TABLE [dbo].[Purchase_Join]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Join_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchase] ([ST_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchase_Join] CHECK CONSTRAINT [FK_Purchase_Join_Purchase]
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_Supplier] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Supplier] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrder] CHECK CONSTRAINT [FK_PurchaseOrder_Supplier]
GO
ALTER TABLE [dbo].[PurchaseOrder_Join]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_Join_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrder_Join] CHECK CONSTRAINT [FK_PurchaseOrder_Join_Product]
GO
ALTER TABLE [dbo].[PurchaseOrder_Join]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_Join_PurchaseOrder] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[PurchaseOrder] ([PO_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrder_Join] CHECK CONSTRAINT [FK_PurchaseOrder_Join_PurchaseOrder]
GO
ALTER TABLE [dbo].[PurchaseReturn]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseReturn_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchase] ([ST_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseReturn] CHECK CONSTRAINT [FK_PurchaseReturn_Purchase]
GO
ALTER TABLE [dbo].[PurchaseReturn_Join]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseReturn_Join_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PurchaseReturn_Join] CHECK CONSTRAINT [FK_PurchaseReturn_Join_Product]
GO
ALTER TABLE [dbo].[PurchaseReturn_Join]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseReturn_Join_PurchaseReturn] FOREIGN KEY([PurchaseReturnID])
REFERENCES [dbo].[PurchaseReturn] ([PR_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseReturn_Join] CHECK CONSTRAINT [FK_PurchaseReturn_Join_PurchaseReturn]
GO
ALTER TABLE [dbo].[Quotation]  WITH CHECK ADD  CONSTRAINT [FK_Quotation_Customer] FOREIGN KEY([CustID])
REFERENCES [dbo].[Customer] ([CC_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Quotation] CHECK CONSTRAINT [FK_Quotation_Customer]
GO
ALTER TABLE [dbo].[Quotation]  WITH CHECK ADD  CONSTRAINT [FK_Quotation_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Quotation] CHECK CONSTRAINT [FK_Quotation_Registration]
GO
ALTER TABLE [dbo].[Quotation_Join]  WITH CHECK ADD  CONSTRAINT [FK_Quotation_Join_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Quotation_Join] CHECK CONSTRAINT [FK_Quotation_Join_Product]
GO
ALTER TABLE [dbo].[Quotation_Join]  WITH CHECK ADD  CONSTRAINT [FK_Quotation_Join_Quotation] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Quotation] ([Inv_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Quotation_Join] CHECK CONSTRAINT [FK_Quotation_Join_Quotation]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Party] FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PT_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Party]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Registration] FOREIGN KEY([UserOperator])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Registration]
GO
ALTER TABLE [dbo].[Sales_Product]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Product_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sales_Product] CHECK CONSTRAINT [FK_Sales_Product_Product]
GO
ALTER TABLE [dbo].[Sales_Product]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Product_Sales] FOREIGN KEY([SalesID])
REFERENCES [dbo].[Sales] ([SalesID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sales_Product] CHECK CONSTRAINT [FK_Sales_Product_Sales]
GO
ALTER TABLE [dbo].[Sales_Product]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Product_Warehouse] FOREIGN KEY([Warehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sales_Product] CHECK CONSTRAINT [FK_Sales_Product_Warehouse]
GO
ALTER TABLE [dbo].[Salesman_Commission]  WITH CHECK ADD  CONSTRAINT [FK_Salesman_Commission_InvoiceInfo] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[InvoiceInfo] ([Inv_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Salesman_Commission] CHECK CONSTRAINT [FK_Salesman_Commission_InvoiceInfo]
GO
ALTER TABLE [dbo].[SalesReturn]  WITH CHECK ADD  CONSTRAINT [FK_SalesReturn_InvoiceInfo] FOREIGN KEY([SalesID])
REFERENCES [dbo].[InvoiceInfo] ([Inv_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SalesReturn] CHECK CONSTRAINT [FK_SalesReturn_InvoiceInfo]
GO
ALTER TABLE [dbo].[SalesReturn_Join]  WITH CHECK ADD  CONSTRAINT [FK_SalesReturn_Join_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalesReturn_Join] CHECK CONSTRAINT [FK_SalesReturn_Join_Product]
GO
ALTER TABLE [dbo].[SalesReturn_Join]  WITH CHECK ADD  CONSTRAINT [FK_SalesReturn_Join_SalesReturn] FOREIGN KEY([SalesReturnID])
REFERENCES [dbo].[SalesReturn] ([SR_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalesReturn_Join] CHECK CONSTRAINT [FK_SalesReturn_Join_SalesReturn]
GO
ALTER TABLE [dbo].[StockAdjustment_Store]  WITH CHECK ADD  CONSTRAINT [FK_StockAdjustment_Store_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockAdjustment_Store] CHECK CONSTRAINT [FK_StockAdjustment_Store_Product]
GO
ALTER TABLE [dbo].[StockAdjustment_Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_StockAdjustment_Warehouse_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockAdjustment_Warehouse] CHECK CONSTRAINT [FK_StockAdjustment_Warehouse_Product]
GO
ALTER TABLE [dbo].[StockAdjustment_Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_StockAdjustment_Warehouse_Warehouse] FOREIGN KEY([Warehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockAdjustment_Warehouse] CHECK CONSTRAINT [FK_StockAdjustment_Warehouse_Warehouse]
GO
ALTER TABLE [dbo].[StockTransfer]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer] CHECK CONSTRAINT [FK_StockTransfer_Company]
GO
ALTER TABLE [dbo].[StockTransfer_Join]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Join_StockTransfer] FOREIGN KEY([StockTransferID])
REFERENCES [dbo].[StockTransfer] ([ST_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join] CHECK CONSTRAINT [FK_StockTransfer_Join_StockTransfer]
GO
ALTER TABLE [dbo].[StockTransfer_Join]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join] CHECK CONSTRAINT [FK_StockTransfer_Product]
GO
ALTER TABLE [dbo].[StockTransfer_Join]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Warehouse] FOREIGN KEY([Warehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join] CHECK CONSTRAINT [FK_StockTransfer_Warehouse]
GO
ALTER TABLE [dbo].[StockTransfer_Join_S2W]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Join_S2W_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join_S2W] CHECK CONSTRAINT [FK_StockTransfer_Join_S2W_Product]
GO
ALTER TABLE [dbo].[StockTransfer_Join_S2W]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Join_S2W_StockTransfer_S2W] FOREIGN KEY([StockTransferID])
REFERENCES [dbo].[StockTransfer_S2W] ([ST_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join_S2W] CHECK CONSTRAINT [FK_StockTransfer_Join_S2W_StockTransfer_S2W]
GO
ALTER TABLE [dbo].[StockTransfer_Join_W2W]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Join_W2W_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join_W2W] CHECK CONSTRAINT [FK_StockTransfer_Join_W2W_Product]
GO
ALTER TABLE [dbo].[StockTransfer_Join_W2W]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_Join_W2W_StockTransfer_W2W] FOREIGN KEY([StockTransferID])
REFERENCES [dbo].[StockTransfer_W2W] ([ST_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_Join_W2W] CHECK CONSTRAINT [FK_StockTransfer_Join_W2W_StockTransfer_W2W]
GO
ALTER TABLE [dbo].[StockTransfer_S2W]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_S2W_Warehouse] FOREIGN KEY([Warehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_S2W] CHECK CONSTRAINT [FK_StockTransfer_S2W_Warehouse]
GO
ALTER TABLE [dbo].[StockTransfer_W2W]  WITH CHECK ADD  CONSTRAINT [FK_StockTransfer_W2W_Warehouse] FOREIGN KEY([Warehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StockTransfer_W2W] CHECK CONSTRAINT [FK_StockTransfer_W2W_Warehouse]
GO
ALTER TABLE [dbo].[TaxMaster]  WITH CHECK ADD  CONSTRAINT [FK_TaxMaster_TaxType] FOREIGN KEY([TaxType])
REFERENCES [dbo].[TaxType] ([Type])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaxMaster] CHECK CONSTRAINT [FK_TaxMaster_TaxType]
GO
ALTER TABLE [dbo].[Temp_Stock]  WITH CHECK ADD  CONSTRAINT [FK_Temp_Stock_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Temp_Stock] CHECK CONSTRAINT [FK_Temp_Stock_Product]
GO
ALTER TABLE [dbo].[Temp_Stock]  WITH CHECK ADD  CONSTRAINT [FK_Temp_Stock_Warehouse] FOREIGN KEY([Warehouse])
REFERENCES [dbo].[Warehouse] ([WarehouseName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Temp_Stock] CHECK CONSTRAINT [FK_Temp_Stock_Warehouse]
GO
ALTER TABLE [dbo].[Temp_Stock_Company]  WITH CHECK ADD  CONSTRAINT [FK_Temp_Stock_Store_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([PID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Temp_Stock_Company] CHECK CONSTRAINT [FK_Temp_Stock_Store_Product]
GO
ALTER TABLE [dbo].[UserRights]  WITH CHECK ADD  CONSTRAINT [FK_UserRights_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRights] CHECK CONSTRAINT [FK_UserRights_Registration]
GO
ALTER TABLE [dbo].[Voucher_OtherDetails]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_OtherDetails_Expense] FOREIGN KEY([Particulars])
REFERENCES [dbo].[Expense] ([ExpenseName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Voucher_OtherDetails] CHECK CONSTRAINT [FK_Voucher_OtherDetails_Expense]
GO
ALTER TABLE [dbo].[Voucher_OtherDetails]  WITH CHECK ADD  CONSTRAINT [FK_Voucher_OtherDetails_Voucher] FOREIGN KEY([VoucherID])
REFERENCES [dbo].[Voucher] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Voucher_OtherDetails] CHECK CONSTRAINT [FK_Voucher_OtherDetails_Voucher]
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_WarehouseType] FOREIGN KEY([WarehouseType])
REFERENCES [dbo].[WarehouseType] ([Type])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_WarehouseType]
GO
USE [master]
GO
ALTER DATABASE [DATA_PROCESSING] SET  READ_WRITE 
GO
