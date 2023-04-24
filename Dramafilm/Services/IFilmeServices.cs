using Dramafilm.Models;
using Dramafilm.Services;

namespace Dramafilm.Services
{
    public interface IFilmeServices
    {
        List<Series> GetSeries();
        List<Genero> GetGenero();
        Genero GetGenero(int Numero);

    }
}