using Microsoft.EntityFrameworkCore;

public class UserService
{
    private readonly ApplicationContext _dbContext;

    public UserService(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task GetAllUsers()
    {
        var users = await _dbContext.Users.OrderBy(x => x.Id).ToListAsync();
        Console.WriteLine("\nСписок пользователей:");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Имя: {user.Name}");
        }
    }

    public async Task GetUserById()
    {
        Console.Write("\nВведите ID пользователя: ");
        if (long.TryParse(Console.ReadLine(), out var id))
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null)
            {
                Console.WriteLine($"ID: {user.Id}, Имя: {user.Name}");
            }
            else
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод ID.");
        }
    }

    public async Task AddUser()
    {
        Console.Write("\nВведите имя пользователя: ");
        var name = Console.ReadLine();

        var user = new User { Name = name };
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        Console.WriteLine("Пользователь добавлен.");
    }

    public async Task EditUser()
    {
        Console.Write("\nВведите ID пользователя для редактирования: ");
        if (long.TryParse(Console.ReadLine(), out var id))
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null)
            {
                Console.Write("Введите новое имя: ");
                user.Name = Console.ReadLine();
                await _dbContext.SaveChangesAsync();
                Console.WriteLine("Пользователь обновлен.");
            }
            else
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод ID.");
        }
    }

    public async Task DeleteUser()
    {
        Console.Write("\nВведите ID пользователя для удаления: ");
        if (long.TryParse(Console.ReadLine(), out var id))
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
                Console.WriteLine("Пользователь удален.");
            }
            else
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод ID.");
        }
    }
}
