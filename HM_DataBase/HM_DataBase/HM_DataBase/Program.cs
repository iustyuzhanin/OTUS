using HM_DataBase.Controller;

// Создание продукта
var productController = new ProductController();
var product = productController.CreateProduct(new Guid(), "Колбаса", "Описание Колбасы", 120, 10);
var product2 = productController.CreateProduct(new Guid(), "Сыр", "Описание ", 220, 80);
var product3 = productController.CreateProduct(new Guid(), "Молоко", "Описание ", 70, 1);
var product4 = productController.CreateProduct(new Guid(), "Масло", "Описание ", 85, 30);
var product5 = productController.CreateProduct(new Guid(), "Творог", "Описание ", 94, 30);
var product6 = productController.CreateProduct(new Guid(), "Пельмени", "Описание ", 300, 3);
var product7 = productController.CreateProduct(new Guid(), "Сок", "Описание ", 140, 2);

// Изменение цены продукта
product = productController.UpdateProductPrice(product.ID, 150);

// Создание пользователей
var userController = new UserController();
var userAlex = userController.CreateUser(new Guid(), "Alex", "alex@gmail.com");
var userTom = userController.CreateUser(new Guid(), "Tom", "tom@gmail.com");
var userBob = userController.CreateUser(new Guid(), "Bob", "Bob@gmail.com");
var userAlisa = userController.CreateUser(new Guid(), "Alisa", "Alisa@gmail.com");
var userMark = userController.CreateUser(new Guid(), "Mark", "Mark@gmail.com");
var userRob = userController.CreateUser(new Guid(), "Rob", "Rob@gmail.com");
var userTed = userController.CreateUser(new Guid(), "Ted", "Ted@gmail.com");

// Создание заказов
var orderController = new OrderController();
//var userBob = new HM_DB.Domain.User() { UserName = "Bob", Email = "Bob@gmail.com" };
//var userAlisa = new HM_DB.Domain.User() { UserName = "Alisa", Email = "Alisa@gmail.com" };
//var userMark = new HM_DB.Domain.User() { UserName = "Mark", Email = "Mark@gmail.com" }; 
//var userRob = new HM_DB.Domain.User() { UserName = "Rob", Email = "Rob@gmail.com" };
//var userTed = new HM_DB.Domain.User() { UserName = "Ted", Email = "Ted@gmail.com" };

// Получение пользователя по Guid
var userBobFind = userController.Get(userBob.ID);

var order = orderController.CreateOrder(new Guid(), userBobFind.ID, HM_DataBase.Domain.Enum.Status.Ready);
var order2 = orderController.CreateOrder(new Guid(), userAlisa.ID, HM_DataBase.Domain.Enum.Status.Payment);
orderController.CreateOrder(new Guid(), userAlex.ID, HM_DataBase.Domain.Enum.Status.Assembled);
orderController.CreateOrder(new Guid(), userRob.ID, HM_DataBase.Domain.Enum.Status.Delivered);
orderController.CreateOrder(new Guid(), userAlex.ID, HM_DataBase.Domain.Enum.Status.Payment);

//orderController.CreateOrder(user2, HM_DataBase.Domain.Enum.Status.Ready);
//orderController.CreateOrder(user2, HM_DataBase.Domain.Enum.Status.Delivered);
//orderController.CreateOrder(user2, HM_DataBase.Domain.Enum.Status.Assembled);

//Выбор всех заказов определенного пользователя
var orders = orderController.GetByUser(userAlex.ID);
foreach (var ord in orders)
{
    Console.WriteLine($"ID зааза - {ord.ID}, статус - {ord.Status}");
}

// Получение заказа по Guid
var orderFind = orderController.Get(order.ID);

// Получение продукта по Guid
var productFind = productController.Get(product.ID);

// Создание деталей заказов
var orderDetailorderDetail = new OrderDetailController();
orderDetailorderDetail.CreateOrderDetail(new Guid(), orderFind.ID, productFind.ID, 5, 10000);
orderDetailorderDetail.CreateOrderDetail(new Guid(), order2.ID, productFind.ID, 2, 20000);
orderDetailorderDetail.CreateOrderDetail(new Guid(), order2.ID, productFind.ID, 6, 20000);
orderDetailorderDetail.CreateOrderDetail(new Guid(), order.ID, productFind.ID, 10, 80000);
orderDetailorderDetail.CreateOrderDetail(new Guid(), order2.ID, productFind.ID, 9, 20000);
orderDetailorderDetail.CreateOrderDetail(new Guid(), orderFind.ID, productFind.ID, 1, 30000);
orderDetailorderDetail.CreateOrderDetail(new Guid(), orderFind.ID, productFind.ID, 3, 70000);

// Расчет общей стоимости заказа
var totalCost = orderController.GetTotalCost(order2.ID);
Console.WriteLine(totalCost);

// Подсчет количества товаров на складе
var quantityInStock = productController.GetQuantityInStock();
Console.WriteLine(quantityInStock);

// Получение 3 самых дорогих товаров
var productTop = productController.GetProductsTop(3);
foreach (var top in productTop)
{
    Console.WriteLine($"{top.ProductName}, цена: {top.Price}");
}

// Список товаров с низким запасом (менее 5 штук)
var productLowStock = productController.GetLowStock();
foreach (var stock in productLowStock)
{
    Console.WriteLine($"{stock.ProductName} - {stock.QuantityInStock} шт.");
}