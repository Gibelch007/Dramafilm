using System.Text.Json;
using Dramafilm.Models;

namespace Dramafilm.Services;

public class DramaSevices : IDramaSevice
{
  private readonly IHttContextAccessor _session;
  private readonly string GeneroFile @"Data\Genero.Json";

}

      
    
