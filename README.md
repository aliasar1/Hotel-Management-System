# Hotel-Management-System

## INTRODUCTION
This is our project about HOTEL MANAGEMENT SYSTEM to manage bookings, employees, 
rooms, service and hotels efficiently in order to provide best service. We have implemented this 
project using the concepts of database designing along with frontend using c# and MS Sql Server 
to make our program more efficient. We have provided few services such CRUD operations for 
all aspects where required. We have also tried to manage project security and integrity using 
various constraints and abstracting data.

## SCREENSHOTS
![image](https://user-images.githubusercontent.com/74453775/194844237-ae852d88-2be9-4d6f-bb05-943125e0e176.png)
![image](https://user-images.githubusercontent.com/74453775/194844305-c8a56825-f212-4fa7-a323-99ca57dd7f21.png)
![image](https://user-images.githubusercontent.com/74453775/194844342-2840c025-5726-4821-8dc3-498136753504.png)
![image](https://user-images.githubusercontent.com/74453775/194844377-04f98059-da06-4c10-9960-c408253856ba.png)
![image](https://user-images.githubusercontent.com/74453775/194844421-80a53c47-ca2d-479f-9780-f3d5b850865e.png)
![image](https://user-images.githubusercontent.com/74453775/194844477-33ba1df0-6db8-46e9-92a0-41db5fba5ad4.png)
![image](https://user-images.githubusercontent.com/74453775/194844545-01c26a2e-65cf-422e-bcbe-545e5fe98cca.png)
![image](https://user-images.githubusercontent.com/74453775/194844605-46958db5-5eec-419f-ad1a-f45b0a102e08.png)
![image](https://user-images.githubusercontent.com/74453775/194844641-7624f77d-f9c4-46da-8086-465c39a086e1.png)
![image](https://user-images.githubusercontent.com/74453775/194844666-ce22dfed-5847-4a49-8858-2d1cc97f2a32.png)
![image](https://user-images.githubusercontent.com/74453775/194844699-a6bbfc48-71dd-44e2-90e5-0ca5efe489fc.png)
![image](https://user-images.githubusercontent.com/74453775/194844733-3e4bd654-ddfa-4a7e-b235-35e77d537ad9.png)
![image](https://user-images.githubusercontent.com/74453775/194844756-03de03df-8924-4be8-a7e0-eb3050c910da.png)
![image](https://user-images.githubusercontent.com/74453775/194844777-50dfbb43-c84d-43cf-9e63-7fa513e25670.png)
![image](https://user-images.githubusercontent.com/74453775/194844826-7bf282bc-15b8-4b30-b526-9fcf131b65cc.png)
![image](https://user-images.githubusercontent.com/74453775/194844961-99e3d6d7-8893-4018-9678-fb2557093a84.png)
![image](https://user-images.githubusercontent.com/74453775/194845062-e285f15a-afc2-491f-b2f9-8eb2123f1910.png)
![image](https://user-images.githubusercontent.com/74453775/194845110-0c79fa34-28fa-47b5-b731-84c4e23193bb.png)
![image](https://user-images.githubusercontent.com/74453775/194845144-aee0fd8c-931f-42b5-93c8-f1ef0c247cdc.png)
![image](https://user-images.githubusercontent.com/74453775/194845170-889eb6d8-f259-4682-94f2-dbdcfa773c9b.png)
![image](https://user-images.githubusercontent.com/74453775/194845204-f1e24881-841b-4827-bc36-d86f15ce80d2.png)
![image](https://user-images.githubusercontent.com/74453775/194845255-a691caea-fdf7-4c2b-a886-ce053146c9ec.png)
![image](https://user-images.githubusercontent.com/74453775/194845282-2b07bfe4-2b35-4363-88f6-84901ef4a0bf.png)


## OBJECTIVES
Here's the logic behind our project. The design of our project is based on SAS applications where 
we provide Software as Service. Firstly, we are the super admins of this application and the hotel 
owners can get our application on subscription based model. We will be registering the hotels in 
database and authenticating them to use this application.
The purpose is to build this in a way that this reduces the manual and paper work for managing 
hotels, guest’s and employee’s data. Moreover, we have also added to functionality to provide 
hotel reports in order to maintain the record of bookings and payments.
We have provided full rights to user where he can add, update, search and delete information when 
required. Best database design is used in order to increase efficiency of managing data from various 
hotels.
Application have following features: 
• Adding, updating, deleting and searching Hotels.
• Generate hotel reports based of bookings.
• Adding services.
• Adding employees. (CRUD)
• Adding guests (CRUD)
• Maintaining payments of guests. 
• Maintaining revenue of hotel.

## MOTIVATION
The motivation behind the idea is that now a days the world is getting digitalized so in order 
to remove all manual and paper work we have created system which would help us to manage 
data more accurately and efficiently. Moreover, this would give an ability to keep records of 
guests and employees which could be further used for analytics.

## FLOW OF APPLICATION
1. When a hotel owners comes to register his hotel in database and avail subscription, we will 
add hotel details in the database and provide a username and password which must be 
change when the user login for the first time.
2. Hotel owner (user) has a right to add employee, add services, add discounts and add rooms. 
He can also view details of bookings, guests and payments. Total revenue would be visible 
only for the owner.
3. He can also add room type and departments in the system.
4. Once a hotel owner adds employee, if he is from HR, Admin or IT department so it’s 
necessary to create account that would be auto generated. 
5. When employee login first time, he will change password and add security question along 
with answer. This would ensure the maximum security of the application.
6. Registered employee can add guests, rooms, discount, services, payments and bookings. All 
have CRUD operations.
7. Guest status can be changed to check-in and checkout. 
8. Employee can filter data according to check-in and checkout.
9. Aggregate cost of stay duration and services used is automatically generated along with 
giving discount if applicable.
10. On checking out of the guest, the amount is added to hotel gross revenue. 
11. The rooms have status of availability which would be marked as YES if it’s not booked and 
NO if it’s reserved.
12. Room type can be set by employee and ceo along with the rates.
13. Login user can reset there password if required

## CHALLENGES AND LIMITATIONS
We faced most of the challenges in creating relationships among tables. We need to make sure that all 
the relationships created among tables are logical and follow the normalization rules. The most 
challenging part was creating the booking and the rooms table and its relationships with other 
respective tables. Another challenge was to learn and research about the designing framework to use 
for frontend and we ended up using GUNA. It was difficult initially but we were able to integrate it. 
We had some issues initially to use foreign keys where required so to overcome that we used tokens in 
Statics file. We also research about basics of C# as it was new for us along with Visual Studio as it was 
new environment for us to work. Another challenge was that to decide where to use foreign keys in 
regards to using it in plain MS Sql server and then accessing it from the frontend. We wanted to use 
few dependencies in order to generate reports which was a challenge for us. When we create accounts 
our initial approach was to email username and password to user but after 30 May 2022 it was 
restricted by Gmail to access any third party software so we ended up using security question and 
answer to overcome it.

## TOOLS AND TECHNIQUES
The language that is used is C# and for IDE Visual Studio is primarily used. Basic concepts of 
OOP along with best database design approach is used with MS Sql Server.

## CONCLUSION
Overall, the project has achieved its objectives. This was an attempt to create a database 
management system for hotel where a DBA can easily manage the hotels, rooms, bookings, 
guests, employees, departments, services, etc. and other things as well, easily and quickly. 
Overall, it is huge area and we tried to cover most of the parts of it. If we see this project in a long 
run, the world is changing and now everything is digitalize so this will be a productive and to 
optimize work load of everyone and reduce human efforts and work load and replace manual 
paper work.

FOR MORE DETAILED EXPLANATION, PLEASE REVIEW OUR PROJECT REPORT WHICH CONTAINS UI IMAGES AND MORE VALUABLE INFORMATION!

## Extended Software Documentation Repository Link:
> https://github.com/aliasar1/Hotel-Management-System-Documentation

HAPPY CODING! :D
