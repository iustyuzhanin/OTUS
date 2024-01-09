using HM_DataBase.Domain;
using HM_DataBase.DataAccessLayer;

namespace HM_DataBase.Controller
{
    public class UserController
    {
        /// <summary>
        /// Создание продукта
        /// </summary>
        public User CreateUser(Guid userUId, string userName, string email)
        {
            using (DataContext db = new DataContext())
            {
                var user = new User
                {
                    ID = userUId,
                    UserName = userName,
                    Email = email,
                    RegistrationDate = DateTime.UtcNow,
                };

                db.Users.Add(user);
                db.SaveChanges();
                Console.WriteLine($"Создан пользователь \"{user.UserName}\"");

                return user;
            }
        }

        /// <summary>
        /// Получение пользователя по Guid
        /// </summary>
        public User Get(Guid uid)
        {
            using (DataContext db = new DataContext())
            {
                var user = db.Users.FirstOrDefault(x => x.ID == uid);

                if (user != null)
                {
                    Console.WriteLine($"Получение пользователя - {user.UserName} по Guid");
                    return user;
                }

                Console.WriteLine($"Не найден пользователь");
                return new User { };
            }
        }
    }
}
