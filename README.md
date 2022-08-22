# employee-time-log

Employee time log with basic operations and data management

<br>

## Additional Context

### Scope

- Login (employee or manager)
- Employee
  - View information (non-editable)
  - Time In and Out
  - Logout
- Manager
  - Time In and Out
  - Logout
  - Master Data
    - View employee data in table
    - Search Employee ID, First, Middle, and Last Name (starts with)
    - View data of selected employee from table
    - Add New Employee
    - Update or Delete Existing Employee (from selected)
  - Time Log
    - View time log in table
    - Search Employee ID (starts with)
    - Filter by Date
    - Sort by Oldest or Newest First

Most of the functions are equipped with necessary validations.

### Note

- Except for the ADM10001, the names of the other employees are fictional.
- All data (date and time) in the Time Log are modified to efficiently display the in and out of the employees.
- The assuming schedule of the employees is 9:00 am to 6:00 pm.
- Last data of in and out is to show the real-time capture of date and time.
    
<br>

## Screenshot

![Master Data](https://user-images.githubusercontent.com/84888155/185901849-9a1c9859-f658-4276-88f2-5776cbc6bf59.PNG)

![Time Log](https://user-images.githubusercontent.com/84888155/185901877-e8ccaf82-8110-4637-94dd-5d7a2bfc54d9.PNG)

<br>

## Language and Tools

- C#
- Visual Studio 2019
- MySQL
- XAMPP

<br>

## Preparation

### XAMPP

1. Download XAMPP
2. Run XAMPP Control Panel
3. Click the `Start` button for Apache and MySQL
    - For new versions of XAMPP, MySQL is replaced by MariaDB
4. Click the `Admin` button for MySQL, a web page will appear
5. In the left side, click `New`
6. Enter `employee_time_log` in the Database name, then click `Create`
7. In the top menu, click `Import`
8. Click `Choose File`
9. Navigate to the EmployeeTimeLog folder
10. Select `employee_time_log.sql`

<br>

## Accounts

### Employee

Employee ID: `EMP20001` <br>
Password: `t65oFasbi9`

### Manager

Employee ID: `ADM10001` <br>
Password: `Habac3rXgR`

For other accounts, please refer to the screenshot or database.
