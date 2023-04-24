
namespace Dramafilm.Models;

    public class Series
    {
        //Atributos
       public string Nome {get; set;}
       public string Descricao {get; set;}
       public string PaisOrigem {get; set;}
       public List<string> Genero{ get; set;}
       public string Imagem {get; set;}
       public string Temporada {get; set;}

       //Método Construtor
       public Dramafilm()
       {
           Genero = new List<string>();
       }
    }
