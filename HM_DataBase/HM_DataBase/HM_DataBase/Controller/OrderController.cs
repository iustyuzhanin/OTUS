using HM_DataBase.Domain;
using HM_DataBase.DataAccessLayer;
using HM_DataBase.Domain.Enum;

namespace HM_DataBase.Controller
{
    public class OrderController
    {
        /// <summary>
        /// Создание заказа
        /// </summary>
        public Order CreateOrder(Guid orderUId, Guid userID, Status status)
        {
            using (DataContext db = new DataContext())
            {
                var order = new Order
                {
                    ID = orderUId,
                    UserID = userID,
                    Status = status,
                    OrderDate = DateTime.UtcNow,
                };

                db.Orders.Add(order);
                db.SaveChanges();
                Console.WriteLine($"Создан заказ со статусом - {order.Status}");

                return order;
            }
        }

        /// <summary>
        /// Получение всех заказов определенного пользователя
        /// </summary>
        public List<Order> GetByUser(Guid userID)
        {
            using (DataContext db = new DataContext())
            {
                var orders = new List<Order>();

                if (userID != Guid.Empty)
                {
                    orders = db.Orders.Where(x => x.UserID == userID).ToList();
                }

                Console.WriteLine($"Получение всех заказов определенного пользователя - {userID}");
                return orders;
            }
        }

        /// <summary>
        /// Расчет общей стоимости заказа
        /// </summary>
        public decimal GetTotalCost(Guid orderID)
        {
            using (DataContext db = new DataContext())
            {
                decimal totalCost = 0;

                if (orderID != Guid.Empty)
                {
                    totalCost = db.OrderDetails.Where(x=>x.OrderID == orderID).Sum(x => x.TotalCost);
                }

                Console.WriteLine($"Расчет общей стоимости заказа");
                return totalCost;
            }
        }

        /// <summary>
        /// Получение заказа по Guid
        /// </summary>
        public Order Get(Guid uid)
        {
            using (DataContext db = new DataContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.ID == uid);
                if (order != null)
                {
                    Console.WriteLine($"Получение заказа - со статусом {order.Status} по Guid");
                    return order;
                }    

                Console.WriteLine($"Не найден заказ");
                return new Order { };
            }
        }
    }
}
