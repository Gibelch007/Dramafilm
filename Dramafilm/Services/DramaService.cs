using System.Text.Json;
using Dramafilm.Models;

namespace Dramafilm.Services;

    public class DramaService
    {
      private readonly IHttpContextAccessor _session;
      private readonly string Generofile = @"Data\Genero.json";
      private readonly string Seriesfile = @"Data\Series.json";
     
      public DramaService (IHttpContextAccessor session)
      {
          _session = session;
          PopularSessao();
      }

      public List<Genero> GetGenero();
      {
          PopularSessao();
          var genero = JsonSerializer.Deserialize<List<Genero>>
          (_session.HttpContext.session.GetString("Genero"));
          Return genero;
      }
      public List<Series> GetSeries();
      {
          PopularSessao();
          var Series = JsonSerializer.Deserialize<List<Series>>
            (_session.HttpContext.session.GetString("Series"));   
            Return series;
      }
      

    }
