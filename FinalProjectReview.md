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
### 2. Project DEMONSTRATION.
### 3. Lessons LEARNED.
<P>The lesson I learned from this project is “There is always a gap between ideal and reality, fortunately there exists the differences, otherwise, who will care about ideal?” </P>
<P>The original idea for my project was to create a game web API, I was thinking to explore more about the algorithm using C# language. At that moment, I was even not quite sure what is the web API means. I know it is Application Programming Interface for the Web. But specifically, what it is and how to create a one, honestly, I still feel hard to explain and to implement one. Similar, there are lots of concepts I did not make them clear enough especially something related to the project design (regarding to the software development flow) and ASP.NET. </P>
<P>Because mine was online game with single page, I did not do that much with the Database, wireframe, and user stories/use cases design. Along with the study of the ASP.NET, I do feel I lack knowledge about the platform itself and HTML5, CSS, and JavaScript as well, my project turned out to be so overwhelmed, I lost the interests to learn the basics but try to get something easy and quick available to my project. </P>
<P> “More haste, less speed”, after project step 16(Yes! I was hesitating and lost a lot of time), I finally decided to move forward to something SIMPLE but still using the core knowledge from the class and the textbook, which means I am going to use <b>my Lab Solution</b> as template, and keep learning more about the basics until I am fully understand each part and switch that into something with my new idea because I have to narrow down my scope, not overwhelm myself, do more practices, and the same time, don't lose my passion on software development. </P>

### 3.1 What did you do RIGHT?
<p>The right thing I did is “fail but start the project again” and outlined the tasks need to do. To me, this project turned out more like course review and summarize about what I learned from MSSA. I can conclude my project now with the terms as below:</p>
<ul><li>ASP.NET Core-A framework using C#, it is runtime environment. 
<ul><li>ASP stands for Active Server Parses, which is simple means dynamic web pages, usually connected to a database. </li>
<li>.NET is Microsoft’s software development platform since 2001. .NET 5 is a unified platform. .NET is not a language, and it consists of runtime engine and libraries for executing programs written in a compliant language. </li>
<li>Core means open source, cross-platform version of ASP. </li></ul>
<li>Models Views and Controllers (MVC) is a design patten. </li>
<li>Database setup-CRUD and ORM. </li>
<li>Registration, login, and security. </li>
<li>Search the database-database query. </li>
<li>Work with HTML/CSS/JavaScript to build the web pages. </li></ul>

### 3.2 What did you do WRONG?
<p>I did not do that much research when I pick the project topic. In the beginning, I did not prepare well to study the ASP.NET platform. So, once I realize I stuck somewhere, I got overwhelmed. </p>
<p>I do not understand using MVC, Entity Framework, and ASP.NET Scaffolding, I can create a web application that provides an interface to an existing database. I manually create the database the same time rigidly follow the book/Microsoft doc’s steps, I got the messed-up project. </p>
<p>I am not good designer; I changed my mind very easily. During this whole process, I change my project scope so many times that I even forgot what I planned or supposed to finish, I am so confused what I really want to do from this project. Now I realize, all requirements wrote down are necessary, even it is supposed to be dynamic, but consistency is critical for the project. And I think that is why later we have got sprint plan to help us out of this kind of issues. </p>

### 3.3 Where were you LUCKY?
<p>I was lucky because everybody from this class they share a lot and when I was about to quit, I was inspired from other’s improvement.  And I was super doubt with ASP.NET, feel like I cannot get the right track in this complex platform, but ERAU give us a lot of resources, after continue reading and studying finally I do feel I am lucky I have chance to get familiar with this platform. </p>

### 3.4 What would you CHANGE? What do you know now that you wish you knew "THEN"?
I have the improvement list as below to further polish this website:
<ol><li>Show Journey owner, show caliendar, show the user edit date and time. </li>
<li>Set up categories: public and private journey. </li>
<li>Hide the private journey. </li>
<li>Extended Create to blog/photo gallery function.</li>
<li>Allow comment and share for public journey.</li>
<li>Show top rated journeys base on the user location on homepage(after login).</li>
<li>Insert the Google map function. </li>
<li>Find the solution to create your journey map. </li>
<li>Add subscribe us function.</li>
<li>Create “Add” function to create a journey plan. </li>
<li>Deploy the .NET app and SQL database to Azure App Service. </li>
<li>Continue the webpage improvement by HTML/CSS/JavaScript.</li></ol>


[Back to the top](https://github.com/yanxu2021/ExploreCalifornia/blob/main/README.md)

## ※For questions, reporting bugs, or general technical support, please contact me at...※
-----------------------
Email: yan.xu2021@outlook.com
![contact](https://github.com/yanxu2021/ExploreCalifornia/blob/main/image/contact.JPG)

[Back To Top](#toc)
