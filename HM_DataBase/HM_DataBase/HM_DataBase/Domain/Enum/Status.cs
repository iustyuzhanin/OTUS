namespace HM_DataBase.Domain.Enum
{
    /// <summary>
    /// Статус
    /// </summary>
    public enum Status
    {
        // Не определено
        None = 0,

        // Готов
        Ready = 1,

        // В сборке
        Assembled = 2,

        // Доставляется
        Delivered = 3,

        // Ждет оплату
        Payment = 4
    }
}
