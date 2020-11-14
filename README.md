# Demo
use any datatabase like SQL Server (SQL Server Express), or use in memory database.

CREATE TABLE ACCOUNTS (
                [AccountID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
                [AccountName] [varchar](240) NULL,
                [Snam] [varchar](50) NULL
)
INSERT INTO ACCOUNTS (AccountName,Snam) VALUES ('Happy','TST001')
INSERT INTO ACCOUNTS (AccountName,Snam) VALUES ('Lucky','TST002')
INSERT INTO ACCOUNTS (AccountName,Snam) VALUES ('Good','TST003')

Create a Web API in .NET Core or .NET that will do the following:
1. Show all ACCOUNTS
2. Show an Account by AccountID, AccountName, Snam (Use the same code for this)
3. Update AccountName for a Snam (don't update all the fields in ACCOUNTS, only update AccountName)
