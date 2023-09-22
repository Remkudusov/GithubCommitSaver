namespace GithubCommitSaver.Models
{
    /// <summary>
    /// Коммит.
    /// </summary>
    public class Commit
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Дата и время осуществления коммита.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Ник пользователя, отправившего коммит.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Почта пользователя, отправившего коммит.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Сообщение пользователя об отправленном коммите.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Ссылка на коммит в git.
        /// </summary>
        public string Url { get; set; } = string.Empty;
    }
}
