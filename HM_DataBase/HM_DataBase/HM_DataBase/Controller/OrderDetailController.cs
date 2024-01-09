using HM_DataBase.Domain;
using HM_DataBase.DataAccessLayer;

namespace HM_DataBase.Controller
{
    public class OrderDetailController
    {
        /// <summary>
        /// Создание деталей заказа
        /// </summary>
        public OrderDetail CreateOrderDetail(Guid orderDetailUId, Guid orderID, Guid productID, int quantity, decimal totalCost)
        {
            using (DataContext db = new DataContext())
            {
                var orderDetail = new OrderDetail
                {
                    ID = orderDetailUId,
                    OrderID = orderID,
                    ProductID = productID,
                    Quantity = quantity,
                    TotalCost = totalCost,
                };

                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();
                Console.WriteLine($"Созданы детали заказа");

                return orderDetail;
            }
        }
    }
}
