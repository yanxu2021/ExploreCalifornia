# ExploreCalifornia
MSSA Project

## Project Step 17 - Test Readiness Review (TRR)
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

## Project Step 18 - Final Presentation(Product Release / Project Presentation)
### This is the starting point for your presentation. 

### Describe project experience including each phase of the SDLC and the project artifacts (design documents, requirements trace, test reports...) code and architecture walk-through
### product demonstration
lessons learned:
1. what did you do right?
<p><b><ul>Pages folder</b> Contains Razor pages and supporting files. </ul>
  <ul>Each Razor page is a pair of files:</ul>
  <ul>A .cshtml file that has HTML markup with C# code using Razor syntax.</ul>
  <ul>A .cshtml.cs file that has C# code that handles page events.Supporting files have names that begin with an underscore. </ul>
  <ul>For example, the _Layout.cshtml file configures UI elements common to all pages. </ul>
  <ul>This file sets up the navigation menu at the top of the page and the copyright notice at the bottom of the page.</ul></p>
<p><b>wwwroot folder</b> Contains static assets, like HTML files, JavaScript files, and CSS files.</p>
<p><b>appsettings.json</b> Contains configuration data, like connection strings. </p>
<p><b>Program.cs</b> Contains the entry point for the app. </p>
<p><b>Startup.cs</b> Contains code that configures app behavior. </p>

3. what did you do wrong?
4. where were you lucky?
5. what would you change? 
6. what do you know now that you wish you knew "then"?

[Back to the top](https://github.com/yanxu2021/ExploreCalifornia/blob/main/README.md)

For questions, reporting bugs, or general technical support, please contact me at...
-----------------------
Email: yan.xu2021@outlook.com

[Back To Top](#toc)
