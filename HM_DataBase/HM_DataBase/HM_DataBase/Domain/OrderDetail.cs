namespace HM_DataBase.Domain
{
    /// <summary>
    /// Детали заказа
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Основной ключ
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Внешний ключ
        /// </summary>
        public Guid OrderID { get; set; }

        /// <summary>
        /// Внешний ключ
        /// </summary>
        public Guid ProductID { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        public decimal TotalCost { get; set; }
    }
}
