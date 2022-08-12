# Pierre's Authorized and Authenticated Application

#### Contributors: Anthony DiFalco

#### A site where users can view and edit a database of treats and flavors

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MySQL
* HTML

## Description

This project uses ASP.NET Core to simulate a program that allows Pierre to keep track of their treats and flavors, and where users can view the lists and details of all treats and flavors.

The header has links to the home page, flavors, and treats. On the list pages, each falvor/treat links to their respective details page. Details pages display the object's basic information, as well as the list of the treats/flavors relationships to flavors/treats respectively. Each relationship can be removed by clicking the delete button from the details page.

Buttons at the bottom of the page link to edit the object and delete the object. Treats have an additional option to add a flavor.

Each link functions like so:

Add:
  * Select an existing flavor to add to a treat. only available from the treats' details page

Edit:
  * Object's basic information can be adjusted here
  * Flavors have a name
  * Treats have a name and a description

Delete:
  * Deletes the selected Treat/Flavor from the database
  * Clicking the button redirects to a confirmation page

## Setup/Installation Requirements

Installation from GitHub:

* To run this program you will need to install VSCode, along with C# and .NET
* From your terminal run&emsp;`git clone https://github.com/Di-Falco/code-review-11`
* From the root directory run&emsp;`dotnet restore` and `dotnet build`

SQL setup:

* In the Root directory, create an appsetting.json file. The terminal command for this is&emsp;`touch appsettings.json`
* Within appsettings.json, insert the following:

`"ConnectionStrings": {`

&emsp;`  "DefaultConnection": "Server=localhost;Port=3306;database=anthony_difalco;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"`

`}`
* Replace&ensp;`[YOUR-USERNAME-HERE]`&ensp;and&ensp;`[YOUR-PASSWORD-HERE]`&ensp;with your username and password for MySqlWorkbench
* Launch MySQLWorkbench
* From the administration tab, select&ensp;`Data Import/Restore`
* Select&ensp;`Import from Self-Contained File`
* From the field on the right, navigate to the location of&ensp;`anthony_difalco.sql`&ensp;in this project's&ensp;`/code-review-11`&ensp;directory on your computer
* Under&ensp;`Default Schema to be Imported`&ensp;select&ensp;`New`
* Name the schema `anthony_difalco` and click `OK`
* Click&ensp;`Start Import`&ensp; at the bottom of the menu

To Run the Program:
* Navigate to the root directory from your terminal
* Enter the command `dotnet run`
* The program should launch on&ensp;`localhost:5000`

## Known Bugs

* The permission branch does not work because the way permissions are set up is incorrect

## License

## Contact Information