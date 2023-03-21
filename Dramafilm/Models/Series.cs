
namespace Dramafilm.Models;

    public class Series
    {
        //Atributos
      public string Numero {get; set;} 
      public string Nome {get; set;}
       public string Descricao {get; set;}
       public List<string> Genero{ get; set;}
       public double Duracao { get; set;}
       public double Duracao { get; set;}
       public string Imagem {get; set;}

       //Método Construtor
       public Dramafilm()
       {
           Genero = new List<string>();
       }
    }
