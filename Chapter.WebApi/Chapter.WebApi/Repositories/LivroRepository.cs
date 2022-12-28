using Chapter.WebApi.Contexts;
using Chapter.WebApi.Interface;
using Chapter.WebApi.Models;

namespace Chapter.WebApi.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ChapterContext _chaptercontext;
        public LivroRepository(ChapterContext context) 
        { 
            _chaptercontext = context;
        }
        public List<Livro> Ler()
        {
            return _chaptercontext.Livros.ToList();
        }
    }
}
