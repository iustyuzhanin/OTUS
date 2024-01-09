using System;

namespace HM_DataBase.Domain
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Основной ключ
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Название продукта
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Количество на складе
        /// </summary>
        public int QuantityInStock { get; set; }
    }
}
