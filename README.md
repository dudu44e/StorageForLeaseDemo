# **Storage Leasing business demo**

**Introduction:** this project demoes an online business for storages lease around the world. Main goals of this project are to demonstrate my capabilities to implement backend design and programming skills via c#, and entity framework through SQL database, along the way I taught myself basics of wpf gui in order to test my learning skills.

**Design pattern:** MVVM

**Main Window:**

![](RackMultipart20211205-4-qjhb2p_html_523bfc569a577e14.png)

**Project has 2 main windows:**

1. **User control panel. Options:**

- Search all orders – Show on grid all the orders of the user.
- Search order by ID – Show an order with a given ID.
- Submit new order – User must choose a storage from 7 available options (drop box/combo box), must choose location from 7 available options (drop box/combo box), enter the amount of rental days (must and the system calculates the price automatically and also print the order number) and has an option to add comment for managers.
- Delete order.
- Delete order – this option delete an order and only show on grid.

![](RackMultipart20211205-4-qjhb2p_html_268a2656c74fc473.png)

1. **Manager control panel. Options:**

- Show all customers – show all customer in the grid including all their details: username, user ID, email, password, status (if the user is active or not).
- Delete user – this option is on grid.
- Update user – this option is on greed. Manager can change any detail of the user on grid and its updating database at the same time.
- Search user by user ID.
- Show all orders- this option show all orders in the database.
- Search order by User ID.
- Search order by Product ID.
- Delete order- this is an on-grid option
- Update order – this is an on-grid option
- Show summary – this option present on grid the total number of users and orders.

![](RackMultipart20211205-4-qjhb2p_html_8470fbc485815aa5.png)

**Project has also login and signup windows:**

1. **User login window –** validation included:

- Check if password is at least 8 characters long, has at least one uppercase and at least one digit using regex (this is a frontend method meaning no contact has made with database)
- Check if username and password are a match in database and automatically move user to customer control panel if details are correct else pop a message

1. **User signup window** – include validation methods in frontend and back end

- Check if password is at least 8 characters long, has at least one uppercase and at least one digit using regex (this is a frontend method meaning no contact has made with database)
- Check if email is in the correct format (frontend method)
- Check if user exist in system (backend method)
- Validate ID (every user must enter his personal ID, preset: Israeli ID standards)

![](RackMultipart20211205-4-qjhb2p_html_6dcf72691c318120.png) ![](RackMultipart20211205-4-qjhb2p_html_877c6c6c657b06d1.png)

1. **Manager login window** – include validation methods in frontend and backend same as
 user + manager has authorization code (preset to be 0).


**4.**  **Manager sign up window** - – include validation methods in frontend and backend same as user + manager has authorization code (preset to be 0).

![](RackMultipart20211205-4-qjhb2p_html_758be2e9733e9df7.png) ![](RackMultipart20211205-4-qjhb2p_html_3e9333beaec0a622.png)
