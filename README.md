# Introduction
The following is documentation on the coursework assignment for the ISAD157 module. This will contain the requirements, design process and a description of the final implementation. It will also contain a link to the remote git repository that houses the files for the project.
If you want to understand the final implementation and don’t want to read through the full design process then skip to the implementation section.
> I will be referring to the system user as “System User” and a user that is stored in the database as “User”.
# Design
## Requirements
Using the coursework specification document I have identified that the system is required to do the following:
•	Store user information
•	Store friend connections between users
•	Display information of a particular user
And allow the System User to do the following:
•	Read information of a particular user 
•	Update information of a particular user
•	Delete information of a particular user
•	Delete friend connections of a particular user
•	Create a user
•	Create User friend connections
I have used the terms Create, Read, Update and Delete to relate to CRUD so it is easier to identify which functions require which SQL statements further down the design route. Also note that information relates to any data that has an identifier relating to the user in question – this is described later in the document.
## UML Diagrams
### Entity Relationship Diagrams
The entities within the database are as follows:
•	User
•	Friend
•	Message
#### Initial Relationship Diagram
The relationship between them is such that a user can have many messages and many friends.

![Initial Entity Relationship Diagram](/Images/InitialEntityImg.jpg)

The issue with this diagram is that a user may have many workplaces and many universities/schools. This creates a problem when designing the database as it leads to repetition in the system.
#### Final Relationship Diagram
To correct the issue of multiple data in one field I have separated the data into tables as shown below.

This resolves the issue of having multiple data in one field and abstracts that to separate tables with the userID being used as the Primary Key as Foreign Key. This will help to find the data in the prototype implementation a lot easier than having to loop through and segment data in one field. You will notice that the one-to-any relationships between the entities have been maintained such that the new tables don’t impact the other entities of the databases.
### Class Diagrams
Above is an image displaying the class diagrams with the arrows dictating that the main class “User” is using the other classes as datatypes for certain attributes of “User” class. For example, the lstWorkplace attribute of User class is an array of object “workplace”. The arrow dictation along with the prefixes on the attribute names will allow me to build the class pseudocode more accurately than I would be able to if neither was included.
### Use Cases
#### Use Case Description
As a system user I want to be able to search or select a user and view there information so that I can maintain the database system. If a user doesn't exist I want to be able to create a user with all the relevant information so that I can update the system accordingly. I also want to be able to delete certain elements of the system like friends, users but not messages so I can make sure that the information is up to date.
#### Use Case Diagram
### Activity Diagrams
Above is the activity diagram for the system. It highlights the workflow of a System User interacting with the system. I have used frames to highlight certain functions that need to be included in the final implementation. For example, the addFriend function includes a check for whether the friend exists which is effectively what is done earlier in the program when the system checks if the user that the System User has searched for exists in the database. Using the above diagram I can identify workflow, important elements to include in the prototype and also functions that can be shared by various elements of the system.
### Sequence Diagrams
### View User Sequence Diagram
Below shows a sequence diagram that explains the interaction between the system user and components of the system. Notice that most of the process happen in the backend of the system and is not shown to the system user. This is to prevent a confusing process while using the system.
#### Delete User Sequence Diagram
The beginning of this process is the same as viewing a user so I reference that sequence diagram in the beginning of this sequence diagram and much like view user much of the process occurs in the backend and is not viewable by the user.
#### Edit User Sequence Diagram
This is the same process as deleting a user only with a few changes.
#### Add User Sequence Diagram
Same as before this sequence main operations happen in the backend and it also references the view user sequence to show the user to the System User.
#### Delete Friend Sequence Diagram 
#### Add Friend Sequence Diagram
#### State Diagrams

## List of High Level Functions
This is a list of all the functions that the final implementation of the system needs to have.
•	Search User
•	View User Information
•	View Users Friends
•	View Users Messages
•	Add User
•	Edit User
•	Delete User
•	Add Friend
•	Delete Friend
## Interface Designs
I used an online interface design tool to generate the following design ideas including the finalised interface design. I kept in mind good UX criteria as well as the user requirements and what I know is possible for me to achieve in a reasonable amount of time.
### Design 1
 
All elements are visible and very little interaction in that there are not multiple pages to cycle through to have the functionality required. One issue is that the System User will need to read the subtitles to know what each box is. If I can group, the box by a faint colour then this will be easier to notice for non-colour-blind users. I will make it easier to see for colour-blind users by using high contrasting colours so it doesn’t affect usability.
### Design 2
 
In this design I am focusing on keeping the layout of design 1 but adding coloured shadows while keeping in mind the affects of deuteranopia, protanopia and tritanopia (the three types of colour-blindness). I used a colour palette that is visibly distinguishable regardless of colour-blind variant. This colour-blind sensitive palette in hex is as follows; #F5793A, #A95AA1, #85C0F9, #0F2080. The four regions are User Information, Message To, Message From and Message Content.
### Design 3
 
In this design I am going to focus on increasing accessibility for users such as making certain text bold and increasing contrast between elements of the interface.
### Success Criteria for final design
Same design as design 3 but this time add ability to search for a user instead of scrolling through all of the users.
### Final Design
 
## Link to Git Account
https://github.com/DavidWood2001/ISAD157
# Implementation
## Included Functions
This is a list of the functions that the prototype is going to implement, these are taken from the high level functions list in this document.
•	Search User
•	View User Information
•	View Users Friends
•	View Users Messages
This means I won’t be implementing the ability to edit, add or delete a user, add a friend or delete a friend. This is because these were extra capabilities that aren’t essential to demonstrate the systems potential.
## Interface Design
 
## Program Structure
The general structure will be a frontend that uses the different methods that each class has as well as a general custom library that handles the functions that is used by a lot of different methods such as searching the database and retrieving database records.
# Evaluation
# Conclusion
# Appendix
SQL Syntax Checker - https://www.eversql.com/sql-syntax-check-validator/
