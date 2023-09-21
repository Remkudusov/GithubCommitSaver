using Microsoft.EntityFrameworkCore;

namespace GithubCommitSaver.Configuration
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    /// <summary>
    /// Контекст web-приложения.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated(); // создать базу данных при первом обращении
        }
    }
}
