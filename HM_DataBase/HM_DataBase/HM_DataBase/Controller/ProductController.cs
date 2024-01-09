using HM_DataBase.Domain;
using HM_DataBase.DataAccessLayer;

namespace HM_DataBase.Controller
{
    public class ProductController
    {
        /// <summary>
        /// Создание продукта
        /// </summary>
        public Product CreateProduct(Guid productUId, string productName, string description, decimal price, int quantityInStock)
        {
            using (DataContext db = new DataContext())
            {
                var product = new Product
                {
                    ID = productUId,
                    ProductName = productName,
                    Description = description,
                    Price = price,
                    QuantityInStock = quantityInStock,
                };

                db.Products.Add(product);
                db.SaveChanges();
                Console.WriteLine($"Создан продукт \"{product.ProductName}\"");

                return product;
            }
        }

        /// <summary>
        /// Изменение цены продукта
        /// </summary>
        /// <param name="productID">Продукт</param>
        /// <param name="price">Новая цена</param>
        public Product? UpdateProductPrice(Guid productID, decimal price)
        {
            using (DataContext db = new DataContext())
            {
                var productUpdate = db.Products.FirstOrDefault(x => x.ID == productID);
                if (productUpdate != null)
                {
                    productUpdate.Price = price;
                    db.Update(productUpdate);
                    db.SaveChanges();

                    Console.WriteLine($"Изменена цена продукта \"{productUpdate.ProductName}\" на {price}");
                }
                
                return productUpdate;
            }
        }

        /// <summary>
        /// Подсчет количества товаров на складе
        /// </summary>
        public int GetQuantityInStock()
        {
            using (DataContext db = new DataContext())
            {
                Console.WriteLine($"Подсчет количества товаров на складе");

                return db.Products.Sum(x => x.QuantityInStock);
            }
        }

        /// <summary>
        /// Получение самых дорогих товаров
        /// </summary>
        /// <param name="top">Количество самых дорогих товаров</param>
        public List<Product> GetProductsTop(int top)
        {
            using (DataContext db = new DataContext())
            {
                var productsOrder = db.Products.OrderBy(x => x.Price);
                var productsTop = productsOrder.Take(top).ToList();

                Console.WriteLine($"Получение самых дорогих товаров");

                return productsTop;
            }
        }

        /// <summary>
        /// Список товаров с низким запасом (менее 5 штук)
        /// </summary>
        public List<Product> GetLowStock()
        {
            using (DataContext db = new DataContext())
            {
                var orderLowStock = db.Products.Where(x => x.QuantityInStock < 5).ToList();
                Console.WriteLine($"Список товаров с низким запасом (менее 5 штук)");

                return orderLowStock;
            }
        }

        /// <summary>
        /// Получение продукта по Guid
        /// </summary>
        public Product Get(Guid uid)
        {
            using (DataContext db = new DataContext())
            {
                var product = db.Products.FirstOrDefault(x => x.ID == uid);

                if (product != null)
                {
                    Console.WriteLine($"Получение продукта - {product.ProductName} по Guid");
                    return product;
                }

                Console.WriteLine($"Не найден продукт");
                return new Product { };
            }
        }
    }
}
