# ExploreCalifornia
MSSA Project

## Project Step 17 - Test Readiness Review (TRR)
### Continuing with the implementation phase of the SDLC, and using Test Driven Development (TDD) leads to a pattern of recursive test-fix-test activities.

## Updated requirement(indicating which have been implemented, tested, passing (and when), or failing, and method of test.)

| Requirement ID | Requirement Description | Test Procedure | Test Result | Notes |
| -------------: | :---------------------- | :------------: | :---------: | :---: |
| 1 | The system shall allow the current user to log in, create a user account or continue as a guest.	| User Login | :green_circle: | The system Allows users to login |
| 1.1 | The system shall provide means for an existing user to enter his/her user ID and password.	|  | :green_circle: |  |
| 1.1.1 | Given a user ID, the system shall verify the validity of the user ID and password. |  | :green_circle: |  |
| 1.1.2 | Given authorization, the system shall allow the user access to their task list.	|  | :red_circle: | As of 16 May all users can see everyones tasks |
| 1.1.3 | The system shall allow the new user to create new user ID and allow the new user to create a password. |  | :green_circle: |  |
| 1.1.4 | The system shall give access to the application when the user continues as guest.	|  | :green_circle: |  |
| 1.2 | The system shall allow the user to access the calendar, task list, and timer.	| Website Layout | :orange_circle: | The Calendar view no longer exits |
| 1.2.1 | The system shall allow the user to display the user’s task list.	|  | :orange_circle: | Displays a task list that shows everyones tasks |
| 1.2.2 | The system shall allow the user to display the Pomodoro Timer. |  | :green_circle: |  |
| 1.2.3 | The system shall allow the user to display the calendar.	|  | :red_circle: | Calendar view no longer exits |
| 1.3 | The system shall display options to create a new task.	| Website Layout | :green_circle: |  |
| 1.3.1 | The system shall display options to edit a task.		|  | :green_circle: |  |
| 1.3.2 | The system shall display options to delete a task.	|  | :green_circle: |  |
| 1.4 | The system shall display options to edit the durations of the timers.	|  | :red_circle: |  |
| 2 | The system shall save the data provided by the user in the application database.	|  | :green_circle: |  |
| 2.2 | the System shall only save data from a guest user for that session.	|  | :red_circle: | With the current build everyone can create tasks and display everyones task. |

[Back to the top](https://github.com/yanxu2021/ExploreCalifornia/blob/main/README.md)
