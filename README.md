#  Pierre's Sweet and Savory Treats

#### By Yodel Guanzon <yodelguanzon@gmail.com>

#### This is an independent project to test our skills in Basic Web Application using ASP .Net Core MVC.

## Technologies Used

* .Net 6 SDK
* C#
* EF Core 6.0
* ASP.Net MVC
* Razor
* MySql 6

## Description

Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:

* The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update, and delete functionality. All users should be able to have read functionality.
* There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
* A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

### Install Database Tools
* Download and install MySQL Community Server and MySQL Workbench using the following link: (https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)

### Creating appsettings.json for Database Connection Setup
* Using a text editor, create a file. Paste the following code, replacing the USERNAME, PASSWORD with your own information. Make sure to also remove the enclosing braces.

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=candyshop;uid=[USERNAME];pwd=[PASSWORD];",
      "TestConnection": "Server=localhost;Port=3306;database=candyshop;uid=[USERNAME];pwd=[PASSWORD];"
      
  }
}
```

* Save the file as ```appsettings.json``` under the project directory located at ../CandyShop.Solution/CandyShop.

### Building the Database

* Using the terminal, Navigate to the main project directory located at ../CandyShop.Solution/CandyShop
* Run ```dotnet restore``` to restore all dependencies (optional)
* Run ```dotnet ef database update``` command to automatically create the database using the migrations in the CandyShop Project
       - Optionally, you could run the command `dotnet ef migrations add MigrationName` where `MigrationName` is your custom name for the migration to create your own migration before running the database update command. You could do this if for some reason ../CandyShop.Solution/CandyShop/Migrations is missing.

### Running the project

* Navigate to the main project located in ../CandyShop.Solution/CandyShop using bash or cmd
* Use ``` dotnet restore ``` to install/restore dependencies.
* For Building, use ```dotnet build```
* For running the console application with a watcher, use ```dotnet watcher run```
* After running the project, you can also open the webapp using your browser manually using the following url (https://localhost:5001/) or (http://localhost:5000/)

## Known Bugs

* None

Found a bug? Email me at <yodelguanzon@gmail.com>

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 01/13/2023 Yodel Guanzon

