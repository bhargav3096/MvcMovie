2024-05-16
Bhargavkumar Bhupendrabhai Chaudhari

1331 UDT
Web app created with VS2022 .NET 7, No Authentication
Checked on https://localhost:7134/
working good...
Changed the name from "Welcome" to "MVC Movie" on the home page which is https://localhost:7134/ 
For this change edit "index.cshtml" file which found in "View > Home > index.cshtml"
above changes done and tested...
working good

1340 UDT
Started Part-2
Add controller name "Index" and "Welcome"
For above both controller, 2 public strings are created "Index" and "Welcome"
and those strings contains messages for that particular string.

For "Index" controller, the link is https://localhost:7134/MvcMovie
checked, working good and displays the message as expected which is "This is default controller for MVC Movie controller...."

For "Welcome" controller, link is https://localhost:7134/MvcMovie/Welcome
checked, working good and displays the message as expected which is "This is Bhargav's Welcome Message for MVC Movie controller..."

1429 UDT
Tried to add parameters in Welcome controller "name" and "idno"
It didn't work first time but after several attempts i figure out how to change name in URL
first change name in "programs.cs" file from "default" to "Bhargav"

1502 UDT
after that i change above changes i tried to open link https://localhost:7134/HelloWorld/Welcome/3000?name=Bhargav&idno=0852033
it worked and show as expected


1545 UDT
Created image in paint..
saved the image as smile.png and the path of that image is "C:\Users\Bhargav\source\repos\MvcMovie\wwwroot\img"
First, we have to create "img" folder in "wwwroot" folder

Started part 3: Add view
Created a View file name "Index.cshtml" in the folder View>HelloWorld>Index.cshtml
Made changes on the home page and put view message "First view of the website!" in the "Index.cshtml" file.

2024-05-18
1055 UDT
Made the following changes in the "_Layout.cshtml" to modify the webpage content 

1. changed the meta title from "MVC Movie" to "MvcMovie WebPage"
2. changed the page heading (h1) from "MVC Movie List" to "MvcMovie WebPage"
3. changed the footer content from 2024 to 2022

checked 
1145 UDT
Now i passed data from controller to the view ...
to do this edit HelloWorldController.cs file and change the content of the Welcome controller..
in this we passed "name string" and "int idno"
for string name 

2024-05-23 1405 UDT
Started part-4: to add a model

first add a class name "Movie.cs" in model folder..
the content for that file is to define syntex of ID (int), Title(string), release date(datatype date), genre(string) and price(decimal)...

Now the next step is to add a scaffold items in "controller" folder with "MVC Controller with views usidng "
Completed migration timestamp 
20240523181226_InitialCreate.cs Timestamp created....

2024-05-26 11:30 UDT

Part- 7 started.... Add search

Updated the Index method in Controllers/MoviesController.cs to add search string
with this user will able to search movie by changing in the URL
https://localhost:7134/Movies?search=dark

Now i change the index method parameter from string to ID...
Now the user can search movies by the following URL....
https://localhost:7134/Movies/index/dark

Now, above Id changes is made for only me and now i change back to 
the original method which is string..

Now i created a form for movie search, because user can't search movie by changing url..
in the form i asked user to enter the movie name which he/she wants to search..
In the form i put get method to get the search string and displays in the url as below..
https://localhost:7134/Movies?search=dark

Now, i add another movie search option by "Genre"...
it will display by dropdown menu and user can select movie by Genre also :)

Part -8 started...To add a new field in the app..
now i add another field called "Rating" in my movie app to display movie rating..

for that we have to add "public string? Rating {  get; set; }" line in the "Movie.cs" file to add Rating 
property in the movie model..
Now, we have to Bind this "Rating" property in the Moviescontroller.cs file..

Now, we have to migrate the "Rating" into our database to remove database query by running command 
Add-Migration Rating and Update-Database 

We have to add Rating property in  all the pages of View folder > Movie > 
Create.cshtml
Delete.cshtml
Detail.cshtml
Index.cshtml
Edit.cshtml



After that when running the app, output is appear as expected and we can add, edit
delete or see the details of that particular new Rating field..
and it gives output as expected

Part -- 9 started .. add validation
in this section i am validating some of the fields like genre which contains only letters.
also the first letter will be capital

other fields will be done for validating such as "Rating", "title"--lenght must be minimum 3 

price must be integer value not in string
and Release Date field should not be blank...

