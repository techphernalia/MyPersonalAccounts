# MyPersonalAccounts
My Accounts Manager

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
