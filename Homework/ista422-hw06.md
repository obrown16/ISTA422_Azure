## Oscar Brown
## 6/5/2018
## Read chapter 6, pages 157 – 180 in the Fundamentals of Azure, 2nd Edition book

1. What is the target of Azure SQL Databases.
They target online transaction processing workloads

2. By default, how many logical SQL Database servers can you have per Azure subscription?
You can have six per subscription

3. Why does the connection string set the TrustServerCertificate property to False and the Encrypt property to True?
This is to provide additional protection while accessing SQL Database over the Internet.

4. What are transient errors?
Transient errors are errors that are intermittent and likely will be resolved if the command is retried

5. What three things contribute to the total cost for running a SQL Server deployment on Azure Virtual Machines?
It can be represented as Total cost = Windows Server cost + SQL Server license cost + Azure Storage cost.

6. Why do you need to be concerned about high availability and disaster recovery for SQL Server in Azure Virtual Machines?
Azure provides high-availability features for the VMs, but not necessarily for SQL Server running on the VM

7. What are six SQL Server features that are not currently supported in SQL Database (according to the book)?
Windows authentication, FILESTREAM data, Database mirroring, Extended stored procedures, SQL Server Agent/Jobs, SQL Server Reporting Services (SSRS) and SQL Server Integration Services (SSIS)

8. Name four factors to consider when choosing between SQL Database and SQL Server in Azure Virtual Machines.
Database size, existing application versus new application, level of administrative control, business continuity strategy, and hybrid scenarios

9. Who did Microsoft collaborate with to bring their ClearDb database as a service for MySQL to the Azure platform?
SuccessBricks

10. What two options exist in Azure if you dont need a relational database management system (RDBMS)based data storage solution such as SQL Database or SQL Server in Azure Virtual Machines?
DocumentDB and Azure Table storage