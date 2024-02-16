Requirements for UserInterface 
•	Visual studio latest version based on requirement, framework 4.7.2,MVC 5.2 webapplication
•	For backend purpose MVC WEebAPI,Enity framework,Sqlserver 2019 with database and required project related libraries
1.	MVC Web App Setup
•	Installed visual studio 2022 professional for project development.
•	Create a sample Asp.net MVC vesion 5.2 project”RegistrationAppIData” using visual studio version 4.7.2.
•	Clean and build the solution to avoid the errors. If any error occurred, included required libraries, JavaScript and css files to the solution from nugget package manager.
•	Included webapi connection in client application inside webconfig file.
•	Verified global.aspx page and included routing method.
•	Verified App_start page for routing file, filtering files and bundle files.
•	Verified script files,jquery datatable and css files and included based on requirement.
•	Added required scripts and css files under _layout.cs file for common usage.
•	MVC Wep app (client interface) is ready to develop.
•	Created a controller like as “RegistrationController.cs” under controller method section inside the project.
•	Added model as “UserDetails.cs” based on given parameters.
•	Created different http methods like”HttpGet”,”httpPost”,“httpPut” ,“httpdelete” and created related views using razor view engine.
•	Connected with webapi using routing urls and use action verbs for data retrieving and rprocessing to webapi, use some action method to return the data in json format and assign to specific view based on request.
•	Created List view page to display the user information in datatable.
•	Created a new user registration page like as “AddNewRegistration.cshtml”. This is page for new user registration and added some text label, text fields and button for data submission and also added back or redirect button to go back to previous page.
•	Pop up the status message after clicking to update button and redirecting to listing page for data visible and also added back button to go back to the list page.
•	Added Edit page under list table grid and navigate to new page as “EditUserinfobyID.cshtml” . Retrieving and displaying data to edit page based on userid and allow user to modify the existing data and able to submit the data with existing userid.
•	Pop up the status message after clicking to update button and redirecting to listing page for data visible and also added back button to go back to the list page.
•	Added delete button under list table grid .Clicking the button based on selection id user details delete from list and and reload the page.
•	Included jquery ajax call to display the data 
•	And also verified the included the IIS configuration and change the start page like https://localhost:44333/Registration/Index
•	Tested the application in different scenario like retrieving list data, submitting using httppost and modifying data using httpPut and deleting data using httpdelete and successfully achieved all the scenarios.
