<h1 align="center"><u><b>Car Shop Management System</b></u></h1>

```
Chapter: 01 (Introduction)
```
The **Car Shop Management System** is a computer-based application that helps a car
showroom run its business more smoothly. It allows customers to sign up, log in, see the
available cars, and place orders. After a customer orders a car, the manager can handle the
payment. Customers can also check their order history and payment status. Admins have full
control over the system. They can add or remove managers, view customer and manager
details, manage car information, and check all orders and payments. The system helps keep
everything organized and saves time by reducing manual work.
Key features of the system include:

- **User Management** for Admins, Managers, and Customers.
- **Car Browsing and Ordering** for customers to explore and order cars.
- **Order and Payment Tracking** to keep records of orders and payments.
- **Manager Panel** to handle customer orders and payments.
- **Sales Report** to view monthly business performance.
The system is built using C# and SQL Server. It uses a well-organized database that keeps all
the information safe, accurate, and easy to find. This system makes it easier for the car shop to
provide fast and reliable service to its users.

```
Chapter: 0 2 (User Story)
```
**As a Customer,**
I want to **register and log in** ,
So that I can securely access the system and use its features.

- The system stores my information in the UserInfo table.
- The system matches the Email and Password from UserInfo table while login.

**As a Customer,**
I want to **browse and search for my desired cars** ,
So that I can view cars with different specifications and choose the one I prefer.

- The system shows the list of cars where the car status = ‘Available’.
- Car details are fetched from Car, Color and Brand table.

**As a Customer,**
I want to place an order for a car,
So that I can proceed with purchasing my desired car.

- The system stores my order details in the Order table.
- Order status is initially marked as Pending.

**As a Customer,**
I want to view my order list and payment status,
So that I can track or cancel what I’ve ordered and how much I’ve paid or still owe.

- The system displays order entries for my userID from the Order table.
- Order details are fetched from Order, UserInfo and Car table.

**As a Customer,**
I want to update or edit my profile,
So that I can keep my personal information accurate and up to date.

- I can update my information in the UserInfo table.


**As a Manager,**
I want to view customer orders,
So that I can manage and process them efficiently.

- The system displays all the order entries made by the customers.
- I can update the status field in the Order table to either ‘Delivered’ or ‘Cancelled’.

**As a Manager,**
I want to record payments made by customers,
So that payment records are accurately reflected in the system.

- I insert payment records into the payment table with references to the orderID and my
    managerID.

**As a Manager,**
I want to edit my profile information,
So that I can maintain accurate contact and identification details.

- I can update my information in the UserInfo table.

**As an Admin,**
I want to manage managers,
So that I can control and manage access to managerial features.

- I can perform CRUD operations on UserInfo table.

**As an Admin,**
I want to view customer and manager details,
So that I can monitor system usage and manage user accounts.

- I can view the UserInfo table containing all the users like customers and managers.

**As an Admin,**
I want to view all order lists,
So that I can oversee order activities and track sales performance.

- I can monitor the order list and handle the orders if needed.

**As an Admin,**
I want to manage cars and update car information,
So that the catalog remains accurate and appealing to customers.

- I can perform CRUD operation on Car, Color and Brand table.

**As an Admin,**
I want to see the sales report,
So that I can evaluate business performance and make informed decisions.

- I can monitor the monthly sales records and the business performance.


```
Chapter: 0 3 (ER Diagram)
```
<img width="600" alt="ER Diagram" src="https://github.com/user-attachments/assets/364c2aca-4ae1-433c-820e-79dd83d0d6ef" />

```
Chapter: 0 3 (SQL Queries)
```
1. INSERT INTO UserInfo (Name, Email, [Password], [Address], Mobile, Dob, Gender,
    UsertypeID) VALUES ('Rahim', 'rahim@gmail.com', '336a', 'Badda', 17345678541 ,
    '2000- 02 - 01', 'Male', 2 );
2. INSERT INTO UserInfo (Name, Email, [Password], [Address], Mobile, Dob, Gender,
    UsertypeID) VALUES ('Lamia', 'lamia@gmail.com', 'lamia321', 'Dhanmondi',
    152233445, '2002- 11 - 25', 'Female', 3);
3. INSERT INTO Color (Name) VALUES ('Teal');
4. INSERT INTO Brand (Name) VALUES ('BMW');
5. INSERT INTO Car (BrandID, Model, RegYear, EngineCC, Gear, ColorID, Price,
    [Status]) VALUES (1,'Corolla',2010, '1500', 'Automatic', 3, 2000000, 'Available');
6. SELECT Car.ID, Brand.Name AS Brand, Car.Model, Car.EngineCC, Car.RegYear,
    Color.Name AS Color, Car.Gear, Car.Price, Car.Status FROM Car, Brand, Color
    WHERE Car.BrandID = Brand.ID AND Car.ColorID = Color.ID;
7. SELECT ID AS OrderID, CustomerID, CarID, DateTime, Status, Price, Paid, Due
    FROM [Order] ORDER BY DateTime DESC;
8. SELECT ID, Name, Email, Password, Gender, DOB, Address, Mobile FROM
    UserInfo WHERE UserTypeID = 2;
9. UPDATE Car SET BrandID = 1, Model = 'Premio', RegYear = 2020, EngineCC =
    '2000', Gear = 'Automatic', ColorID = 3, Price = 4000000, Status = 'Available'
    WHERE ID = 22;
10. UPDATE UserInfo SET Name = 'Rahim', Email = 'rahim@gmail.com', Password =
    '1234', Gender = 'Male', Dob = '2000- 01 - 01', Address = 'Badda', Mobile =
    1734567890 WHERE ID = 23;
11. UPDATE [Order] SET [Status] = 'Delivered' WHERE ID = 13;
12. DELETE FROM Car WHERE ID = 2;
13. INSERT INTO Payment (OrderID, ManagerID, PaymentMethod, Date, Amount)
    VALUES (13, 20, 'Card', '2025- 06 - 28 10:30:00', 500000);
14. DELETE FROM Brand WHERE ID = 1;
15. SELECT COUNT(*) AS CT FROM Car;

```
Chapter: 0 4 (Screenshots)
```

### 🔐 Login Form  
<img width="600" alt="Login Form" src="https://github.com/user-attachments/assets/b6253bd0-949a-4beb-825e-9df8777918b6" />

### 📝 Registration Form for Customer  
<img width="600" alt="Registration Form" src="https://github.com/user-attachments/assets/ce2d6cfa-fae8-4784-8dd9-e687bb0b9969" />

### 🚗 Manage Cars  
<img width="600" alt="Manage Cars" src="https://github.com/user-attachments/assets/cd7f24d4-fe9d-4170-818d-d10a0c103b3d" />

### 🎨 Manage Car Brands  
<img width="600" alt="Manage Car Brands" src="https://github.com/user-attachments/assets/a1544167-5504-4c51-b6ef-db48346f815d" />

### 👥 View Customers  
<img width="600" alt="View Customers" src="https://github.com/user-attachments/assets/2f4f7cdd-5345-4bc0-b6db-18ccbe3f66f7" />

### 👔 Manage Managers  
<img width="600" alt="Manage Managers" src="https://github.com/user-attachments/assets/717c6f28-801f-4d54-a43e-897ee76b167f" />

### 📊 Monitor Sales Records  
<img width="600" alt="Monitor Sales Records" src="https://github.com/user-attachments/assets/d06a3e0f-d76e-49d9-8159-9cf8144e9660" />

### 📦 Manage Orders (with Car Details)  
<img width="600" alt="Manage Orders Car View" src="https://github.com/user-attachments/assets/1b5ea7f4-2129-4dca-b131-989ce6632a50" />

### 📋 Manage Orders (with Customer Details)  
<img width="600" alt="Manage Orders Customer View" src="https://github.com/user-attachments/assets/32c4ce0c-90ce-4fa3-b01e-3c419e0c688e" />

### 💳 Manage Payment  
<img width="600" alt="Manage Payment" src="https://github.com/user-attachments/assets/e1990fe6-ac52-4d4e-8e45-433d1a331c6f" />

### 🔧 Update User Profile  
<img width="600" alt="Update Profile" src="https://github.com/user-attachments/assets/fc7bbf6c-6094-4dd6-af62-70c9b79b0c13" />

### 🚘 Available Car List for Customer  
<img width="600" alt="Available Cars" src="https://github.com/user-attachments/assets/16bbf6e7-d2d0-40f1-ae0f-706931cd59c4" />
