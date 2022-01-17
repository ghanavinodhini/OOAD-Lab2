# OOAD-Lab2

This project has refactored code applying following principles:
* Single Responsibility Principle - OrderService class is split into ProcessPriority,Order,EmailService,Logger classes
* Open Close Principle - Applied OCP by creating method  in interface IOrderService and overided it in classes for priority levels (High,Low,Medium,SuperHigh)
* Dependency Inversion Principle - Created Interfaces, common Factory class
