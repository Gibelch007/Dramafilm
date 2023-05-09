using Dramafilm.Models;
namespace Dramafilm.Services;
    public interface IFilmeServices
    {
        List<Series> GetSeries();
        List<Genero> GetGenero();
        Genero GetGenero(int Numero);
        DramafilmDto GetDramafilmDto();
        DetaisDto GetDetaisDto();
        Genero GetGenero(string Nome);

    }
