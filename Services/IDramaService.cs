using Dramafilm.Models;

namespace Servises;

    public interface IDramaService
    {
        List<Dramafilm> GetDramafilm();
        List<Genero> GetGenero();
        Dramafilm GetDramafilm(int Numero);
        DramafilmDto GetDramafilmDto();
        DetailsDto GetDetailsDto(int Numero);
        Genero GetGenero(string nome);
    }
