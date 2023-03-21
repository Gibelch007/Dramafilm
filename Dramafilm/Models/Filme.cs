namespace Dramafilm.Models;
    public class Filme
    {
        //Atributos
        public int Numero { get;set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public List<string> Tipo { get; set; }
        public double Duracao { get; set; }
        public string Imagem { get; set; }
    

    //Método Construtor
    public Dramafilm()
    {
        Filme = new List<string>
    }
    
    }