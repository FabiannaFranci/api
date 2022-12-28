using Chapter.WebApi.Models;

namespace Chapter.WebApi.Interface
{
    public interface ILivroRepository
    {
        List<Livro> Ler();
    }
}
