using HM_DataBase.Domain.Enum;
using System.Runtime.CompilerServices;

namespace HM_DataBase.Domain
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Основной ключ
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Внешний ключ
        /// </summary>
        public Guid UserID { get; set; }

        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public Status Status { get; set; }
    }
}
