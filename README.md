Vending Machine Simulation in C#  


📌 Project Overview  


This "Vending Machine Simulation" is a console-based C# application that simulates the operations of a vending machine. It demonstrates "object-oriented programming (OOP) principles", including "encapsulation, abstraction, and modular design", using C# and .NET technologies.  

The project allows users to:  


✅ Insert coins of different denominations  


✅ Purchase products with available balance 


✅ Receive accurate change in coins  


✅ Manage product inventory


✅ Remove coins from the machine  



This simulation is structured to handle real-world vending machine functionalities, including cash transactions, inventory tracking, and user interactions.  


🛠️ Features  


1️⃣ Coin Handling System


- Supports multiple coin denominations: Nickel, Dime, Quarter, Dollar, Five Dollar

  
- Stores inserted coins in a "temporary coin box" before purchase confirmation


- Computes **exact change** dynamically using available coins


- Allows removing all coins from the vending machine  

2️⃣ Product Inventory Management


- Supports multiple products with "dynamic pricing"

  
- Keeps track of available "stock quantity"

  
- Enables product selection and purchase  

3️⃣ Transaction Mechanism


- Validates whether the inserted coins are **sufficient** for purchase


- Computes **change** and returns it in available coin denominations


- Allows **cancellation of transactions**, refunding inserted money


- Provides an option to **remove all coins** from the vending machine
  

4️⃣ Object-Oriented Design
- Encapsulated classes: `Coin`, `CoinBox`, `Product`, `VendingMachine`, and `VendingMachineMenu`  
- Modular approach** for coin management, inventory tracking, and transaction handling  
- Uses lists and collections to store products and coins efficiently  


💡 Technologies Used  
🔹 C# – Object-Oriented Programming  
🔹 NET Framework – Windows Application Development  
🔹 Data Structures – Lists, Dictionaries for managing inventory and coins  


🚀 How It Works  


1️⃣ User inserts coins into the vending machine 


2️⃣ User selects a product from the available inventory  


3️⃣ Vending machine processes the transaction 


   - If the inserted money is **sufficient**, the product is dispensed

     
   - If there is **extra money**, change is returned

     
   - If the **balance is insufficient**, the transaction is canceled

      
4️⃣ Coins are added to the vending machine’s balance


5️⃣ Admin can remove all coins from the machine when needed  


 🔥 Why This Project? 

 
This project is a practical demonstration of real-world programming skills, including:  


✅ OOP concepts like encapsulation, abstraction, and polymorphism 


✅ Algorithmic thinking in handling money and making change  


✅ Data structures for managing vending machine operations 


✅ Software design principles with modular, maintainable code  



🏆 Future Enhancements  

🔹 GUI version using WinForms/WPF for a better user experience  
🔹 Database integration for persistent product inventory and transactions  
🔹 Enhanced error handling and exception management  
🔹 More realistic user interactions with enhanced logging  
