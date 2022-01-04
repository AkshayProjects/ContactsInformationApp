# Contact Application
Contact Application using ASP.NET Core API, Angular 6.0, Angular Material UI 6 and Visual Studio Code. 

### Prerequisite 
.Net Core 2.1.30<br />
NodeJS 8.9.4 <br />
npm 8.1.2 <br />
Angular CLI 6.0 <br />

### Setup Project
git clone https://github.com/AkshayProjects/ContactsInformationApp.git

### install npm packages and restore dotnet nuget pakages in command promt:
npm install <br />
dotnet restore  

### Update Connectionstring in Appsettings.json file
 "ConnectionStrings": {
    "ContactDb": "server=DESKTOP-2DPQDLN\\SQLEXPRESS;database=ContactsDb;Trusted_Connection=true"
	}

### Update Database
dotnet ef database update

### build angular component
ng build

### run project
dotnet run

