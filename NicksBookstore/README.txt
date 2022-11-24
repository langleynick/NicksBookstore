Assigment 2

Nicholas Langley
0106967

NicksBookstore

11-11-22

Created initial files for the project, and added in the new bootstrap file
Theme of bootstrap.css file is Lux

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
Confirmed as "20221113210904_DefaultIdentityMigration.cs"
Changed appsettings.json to include database name

4:15 pm

Added Category.cs file and added the migration to the database titled "AddCategoryToDb"
Confirmed as "20221113212729_AddCategoryToDb.cs"
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

9:00 pm

Added UnitofWork and IUnitOfWork class and interface- respectively
Added service in Startup.cs to register UnitOfWork in project
Fixed error with ISP_Call interface, made it public.

9:30 pm

Added CategoryController class
and respective razor view "Index.cshtml" in Views\Category
Added link to Category index page in the dropdown nav
Built to check for issues

9:45 pm
Added Font awesome icons using javascript file provided
Added the Upsert IActionResult in the CategoryController
Created the View for the Upsert
Made partial views for Create and back buttons, also edit and back buttons

10:00 pm

Edited Upsert view to include the partial views, dynamically change the title, and created specific labels for columns
Added asp-action reference to Index page for Upsert
Added section call to the validation scripts in the Upsert view

10:30 pm

Added Post action method in the Category controller to handle adding categories
Added Save() void method to IUnitOfWork
Removed _db.SaveChanges from CategoryRepository.cs
Changed Upsert post method to save after adding category
Fixed error where edit page was not working
	I changed the Upsert method into the post method, instead of adding the post method after the action method

11:00 pm

Added the HTTPDelete API call in the CategoryController.cs
Altered the category.js file to add reference to the delete method with an onclick function
	Added delete function code using Sweet Alert and Toastr

11/24/22

3:00 pm

Added CoverType.cs file into the Models section
	Gave properties id and name

3:10 pm

Added migration with the name "AddCoverTypeToDb"
Added CoverType reference in DbContext file
Updated database and confirmed in SQL Server Object Explorer

3:20 pm

Added CoverType repository interface and class

3:45 pm

Added references to CoverType in UnitOfWork and IUnitOfWork

4:00 pm

Added CoverType controller, and view pages
	Index.cshtml
	Upsert.cshtml
ERROR FIX: Added Area reference in CoverTypeController to route the user to the correct page

4:30 pm

Added Product model class and implemented it into the application db context
Migration: AddProductToDb
updated database

4:40 pm

Added validation to the product class making title, ISBN, and author required fields
Migration: AddValidationToProduct
updated database

4:50 pm

Added ProductRepository and IProductRepository with changes to the update method in ProductRepository

5:00 pm

Added Product controller and Product View Model
Downloaded Microsoft.AspNetCore.Mvc.ViewFeatures package to use

5:20 pm

Added reference to Product model in IUnitOfWork and UnitOfWork
Added index page for Product
Created product.js file
Referenced Product page in _Layout page

5:45 pm

Added Upsert View for Product
Made product.js file for data table
Used Tiny cloud to implement the API
	Created an account with my school email
	My api reference: <script src="https://cdn.tiny.cloud/1/shb3gfzzoppvcvlnmocoukcs735tkp03tpyvkf9wo6un98u5/tinymce/6/tinymce.min.js" referrerpolicy="origin"></script>