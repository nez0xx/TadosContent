namespace Content.WebApi.Controllers.Content.Dto
{
    // Скорее всего этот enum потребуется перенести в другое место
    public enum ContentCategory
    {
        /// <summary>
        /// Статья
        /// </summary>
        Article = 0,
        
        /// <summary>
        /// Видео
        /// </summary>
        Video = 1,
        
        /// <summary>
        /// Галерея
        /// </summary>
        Gallery = 2,
    }
}