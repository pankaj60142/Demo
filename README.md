# Demo
use any datatabase like SQL Server (SQL Server Express), or use in memory database.

CREATE TABLE ACCOUNTS (
                [AccountID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
                [AccountName] varchar(240) NULL,
                [Snam] varchar(50) NULL
)
INSERT INTO ACCOUNTS (AccountName,Snam) VALUES ('Happy','TST001')
INSERT INTO ACCOUNTS (AccountName,Snam) VALUES ('Lucky','TST002')
INSERT INTO ACCOUNTS (AccountName,Snam) VALUES ('Good','TST003')

Create a Web API in .NET Core or .NET that will do the following:
1. Show all ACCOUNTS
2. Show an Account by AccountID, AccountName, Snam (Use the same code for this)
3. Update AccountName for a Snam (don't update all the fields in ACCOUNTS, only update AccountName)
4. Log Table:
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] varchar(255) NOT NULL,
	[Level] varchar(50) NOT NULL,
	[Logger] varchar(255) NOT NULL,
	[Message] varchar(4000) NOT NULL,
	[Exception] varchar(2000) NULL
) ON [PRIMARY]

Steps to Run API

1. Download Visual Studio community Edition
2. Download SQL Express
3. Dowalod Zip file for Code
4. Open .sln Solution File
5. Compile and Run
6. Download Postman
7. Import Json and test

