## Accrual and Storage System for tracking points
Each month an employee earns points depending on their role and tenure.
The desktop application calculates the number of accrued points from employee start date to-date.

### Set Up
* Install Microsoft SQL Server 2008
* Create a database, AccrueDB
* Create a table **employees** below are the columns

| Columns        | DataTypes/specifics                           |
|----------------|:---------------------------------------------:|
|emp_id          | Primary_Key, identity column, auto increment  |
|Employee_ID     | nvarchar(10)                                  |
|Employee_Name   | nvarchar(MAX)                                 |
|Start_Date      | nvarchar(50)                                  |
|Seniority       | nvarchar(10)                                  |
|Points          | float                                         |

* Clone/download repo
* Open project in Visual Studio

### To Install
* Follow the above 4 steps
* Navigate to the debug folder and double-click the .exe to install

### Technology stack
* Visual Studio
* Microsoft SQL Server 2008
* C# 
* SQL

**Please note the rest of the folders are random projects labeled with Question_ e.g: QuestionThreee**

#### Author
Elijah Ayeeta
