using Microsoft.EntityFrameworkCore;

namespace TyperProject.Words
{
    public static class WordsEndpointsExtension
    {
        public static void MapWordsEndpoints(this WebApplication app)
        {
            app.MapGet("/words", async (ApplicationDbContext applicationDbContext) =>
            {
                var words = applicationDbContext.Words.ToListAsync();
                return words;
            });
        }
    }
}
