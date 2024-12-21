class Program
{
    static async Task Main(string[] args)
    {
        using var dbContext = new ApplicationContext();
        var userService = new UserService(dbContext);

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Показать всех пользователей");
            Console.WriteLine("2. Найти пользователя по ID");
            Console.WriteLine("3. Добавить пользователя");
            Console.WriteLine("4. Редактировать пользователя");
            Console.WriteLine("5. Удалить пользователя");
            Console.WriteLine("0. Выйти");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await userService.GetAllUsers();
                    break;
                case "2":
                    await userService.GetUserById();
                    break;
                case "3":
                    await userService.AddUser();
                    break;
                case "4":
                    await userService.EditUser();
                    break;
                case "5":
                    await userService.DeleteUser();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    break;
            }
        }
    }
}
