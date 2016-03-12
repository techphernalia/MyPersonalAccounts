# MyPersonalAccounts
I will be using this project to feed my personal transactions and get reports out of it

## MyPersonalAccountsModel
MyPersonalAccountsModel contains all the items which are shared across Service and UI
- Models
- Exceptions
- Controller Interfaces

## MyPersonalAccountsController
MyPersonalAccountsController contains Database Interactor (DAL) and Implementation of Interfaces as defined in MyPersonalAccountsModel
- Database Interactor
- Implementation of Interfaces
- WCF Implementation

## MyPersonalAccountsService
MyPersonalAccountsService is our Windows Service which will host WCF and serve data to UI
- Windows Service
- WCF Hosting

## MyPersonalAccountsManager
MyPersonalAccountsManager contains the Runnable UI of Accounts Manager


# Installation
Installation requires 3 major steps
- Go to SQL Scripts and install Database Scripts
- Install Service
  - Open Command Prompt with Admin Rights
  - Set Path to include .Net4.0 Framework `SET PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319;`
  - Browse to MyPersonalAccountsService\bin\Debug folder
  - Fire InstallUtil to install service `InstallUtil -i MyPersonalAccountsService.exe`
  - Open MyPersonalAccountsService.exe.config and Update
    - `SQLConnectionString` with your SQL Server Connection String
	- `baseAddress` if required
- Install UI
  - Open MyPersonalAccountsManager.exe.config and update `address` if required (If you changed `baseAddress` above)
