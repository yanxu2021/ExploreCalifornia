# ※MSSA Project-ExploreCalifornia※
## *ExploreCalifornia* is a traval interactive blog web application in progress that will be built using ASP.NET MVC, Azure SQL Server database, and Azure Cloud hosting. 


![logo](https://github.com/yanxu2021/ExploreCalifornia/blob/main/image/removebg%20logo.png)

## ※Project Step 17 - Test Readiness Review (TRR)※
### Continuing with the implementation phase of the SDLC, and using Test Driven Development (TDD) leads to a pattern of recursive test-fix-test activities.

### Updated requirement(indicating which have been implemented, tested, passing (and when), or failing, and method of test.)

| Requirement ID | Requirement Description | Test Procedure | Test Result | Notes |
| -------------: | :---------------------- | :------------: | :---------: | :---: |
| 1 | The system shall allow the current user to log in, create a user account or continue as a guest.	| User Login | :green_circle: | The system Allows users to login |
| 1.1 | The system shall provide means for an existing user to enter his/her user ID and password.	|  | :green_circle: |  |
| 1.1.1 | Given a user ID, the system shall verify the validity of the user ID and password. |  | :green_circle: |  |
| 1.1.2 | Given authorization, the system shall allow the user access to their journey list	|  | :red_circle: | As of 16 May all users can see published journey|
| 1.1.3 | The system shall allow the new user to create new user ID and allow the new user to create a password. |  | :green_circle: |  |
| 1.1.4 | The system shall give access to the application when the user continues as guest.	|  | :green_circle: |  |
| 1.2 | The system shall allow the user to visit the journey photo gallery	| Website Layout | :green_circle: |  |
| 1.2.1| The system shall display options to upload the photos to gallery	|  | :red_circle: |  |
| 1.2.2 | The system shall display options to delete the photos from journey, not allowed from gallery	|  | :red_circle: |  |
| 1.3| The system shall allow the user to display the user’s journey list.	|  | :orange_circle: | Displays a journey list that shows everyone's |
| 1.3.1 | The system shall allow the user to create a journey |  | :green_circle: |  |
| 1.3.2 | The system shall allow the user to update a journey	|  | :red_circle: | Calendar need to be fixed |
| 1.3.3| The system shall allow the user to update a journey	| Website Layout | :green_circle: |  |
| 1.3.4 | The system shall display all published journey(the system shall allow the user to read a journey)		|  | :green_circle: |  |
| 1.3.5 | The system shall display options to delete a journey	|  | :green_circle: |  |
| 2 | The system shall save the data provided by the user in the application database.	|  | :green_circle: |  |


[Back to the top](https://github.com/yanxu2021/ExploreCalifornia/blob/main/README.md)

## ※Project Step 18 - Final Presentation(Product Release / Project Presentation)※
### 1. This is the starting point for the presentation. Describe project experience including each phase of the SDLC and the project artifacts (design documents, requirements trace, test reports...) code and architecture walk-through.
### 2. Product demonstration
### 3. Lessons learned
<P>The lesson I learned from this project is “There is always a gap between ideal and reality, fortunately there exists the differences, otherwise, who will care about ideal?”</P>
<P>The original idea for my project was to create a game web API, I was thinking to explore more about the algorithm using C# language. At that moment, I was even not quite sure what is the web API means. I know it is Application Programming Interface for the Web. But specifically, what it is and how to create a one, honestly, I still feel hard to explain and to implement one. Similar, there are lots of concepts I did not make them clear enough especially something related to the project design (regarding to the software development flow) and ASP.NET.</P>
<P>Because mine was online game with single page, I did not do that much with the Database, wireframe, and user stories/use cases design. Along with the study of the ASP.NET, I do feel I lack knowledge about the platform itself and HTML5, CSS, and JavaScript as well, my project turned out to be so overwhelmed, I lost the interests to learn the basics but try to get something easy and quick available to my project.</P>
<P>“More haste, less speed”, after project step 16(Yes! I was hesitating and lost a lot of time), I finally decided to move foward to something SIMPLE but still using the core knowlege from the class and the textbook, which means I am going to use <b>SportsStore Solution</b> as my template, and I keep telling myself that I am playing with this template until I am fully understand each part and switch that into something with my new idea becasue I have to narrow down my scope, not overwhelm myself, do more practices,and the same time, don't lose my passion on software engineering. </P>

### 3.1 What did you do RIGHT?
<p>Learn and implement web API from the very begninning but important point like the folder names of all MVC applications are the same. The MVC framework is based on the default naming. The controller is written in the Controllers folder, the view is written in the Views folder, and the model is written in the Models folder. The standardized naming reduces the amount of code and at the same time helps developers understand the MVC project.</p>
<p><b>Pages folder</b> 
  <ul>Contains Razor pages and supporting files. </ul>
  <ul>Each Razor page is a pair of files:</ul>
  <ul><b>A .cshtml</b> file that has HTML markup with C# code using Razor syntax.</ul>
  <ul><b>A .cshtml.cs</b> file that has C# code that handles page events.Supporting files have names that begin with an underscore. </ul>
  <ul>For example, the _Layout.cshtml file configures UI elements common to all pages. </ul>
  <ul>This file sets up the navigation menu at the top of the page and the copyright notice at the bottom of the page.</ul></p>
<p><b>wwwroot folder</b> Contains static assets, like HTML files, JavaScript files, and CSS files.</p>
<p><b>appsettings.json</b> Contains configuration data, like connection strings. </p>
<p><b>Program.cs</b> Contains the entry point for the app. </p>
<p><b>Startup.cs</b> Contains code that configures app behavior. </p>

### 3.2 What did you do WRONG?
### 3.3 Where were you LUCKY?
### 3.4 What would you CHANGE? What do you know now that you wish you knew "THEN"?

[Back to the top](https://github.com/yanxu2021/ExploreCalifornia/blob/main/README.md)

For questions, reporting bugs, or general technical support, please contact me at...
-----------------------
Email: yan.xu2021@outlook.com

[Back To Top](#toc)
