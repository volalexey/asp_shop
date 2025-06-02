using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Импортирует пространство имен для работы с Identity и Entity Framework Core
using Microsoft.EntityFrameworkCore; // Импортирует пространство имен для работы с Entity Framework Core


public class UserContext : IdentityDbContext
{

    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }
}
