using GithubCommitSaver.Models;
using Microsoft.EntityFrameworkCore;

namespace GithubCommitSaver.Configuration
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    /// <summary>
    /// Контекст web-приложения.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Инициализирует новую сущность <see cref="ApplicationContext"/>/
        /// </summary>
        /// <param name="options">Опции.</param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated(); // создать базу данных при первом обращении
        }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commit>(entity =>
            {
                entity.HasKey(x => x.Id);
            });
        }
    }
}
