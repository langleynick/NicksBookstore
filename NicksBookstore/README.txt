Assigment 2

Nicholas Langley
0106967

NicksBookstore

11-11-22

Created initial files for the project, and added in the new bootstrap file

11-13-22

3:05 pm
Fixed dropdown menu by adding data-toggle into the <a> tag

3:10 pm
Added 3 projects
Added packages for DataAccess project
Moved Data folder into project, deleting old
Changed namespace

3:20 pm
Moved Models folder into Models project, deleting old
Added project references to .DataAccess and Models
Renamed Models folder to ViewModels

3:30 pm
Changed references to ErrorViewModel
Added references to ApplicationDbContext in Startup.cs
Built the project to confirm changes

3:40 pm
Added SD.cs class to NicksBooks.Utility
Added Utilities reference to main project
Added Models and Utility reference to DataAccess

3:45 pm
Added Customer Area
Changed route in Startup.cs
Moved HomeController.cs to Customer/Controllers
Added explicit reference to Customer Area in HomeController.cs
Changed namespace on the HomeController.cs file
Copied over ViewStart and ViewImport files to Customer View and changed reference in ViewStart

3:55 pm
Added Admin Area
Copied View pages into the Admin Area

END OF PART 1

11-13-22

4:00 pm
Built project to check for any errors
Added migration - migration name "DefaultIdentityMigration" in the DataAccess project
Changed appsettings.json to include database name

4:15 pm
Added Category.cs file and added the migration to the database titled "AddCategoryToDb"
Changed ApplicationDbContext to include the Category table
Updated Database

4:30 pm
Added Repository and IRepository folders
Created IRepository class

4:45 pm
Added Category and ICategory class/interface
Built project and found no errors

5:00 pm
Added ISP_Call interface and installed Dapper using find and install
Implemented the ISP_Call into the SP_Call class