  class Musica
{


    //Construtor
    public Musica(Banda artista, string nome )
    {
        Artista = artista;
        Nome = nome;
    }

   //Propriedades

   public string Nome {  get; }
   public Banda Artista { get; }
   public int Duracao {  get; set; }
   public bool Disponivel {  get; set; }
   public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista} ";


    //função
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"artista: {Artista}");
        Console.WriteLine($"duração: {Duracao}");
        if ( Disponivel  )
        {
            Console.WriteLine("Disponivel no plano");
        }else
        {
            Console.WriteLine("Adquira o plano plus");   
        }
    }

}




