


class Album
{

    private List<Musica> musicas = new List<Musica> ();


    //construtores
    public Album(string nome)
    { 
        Nome = nome;
    }

    public string Nome { get;  }
    public int DuracaoTotal { get; set; }


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);    
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas {musicas}");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome} ");
        }
    }
}