namespace Content.WebApi.Controllers.Content.Dto
{
    // Скорее всего этот enum потребуется перенести в другое место
    public enum ContentCategory
    {
        /// <summary>
        /// Статья
        /// </summary>
        Article = 1,
        
        /// <summary>
        /// Видео
        /// </summary>
        Video = 2,
        
        /// <summary>
        /// Галерея
        /// </summary>
        Gallery = 3,
    }
}