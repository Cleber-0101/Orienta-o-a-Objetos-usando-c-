﻿  class Musica
{

    //Propriedades
   public string Nome {  get; set; }
   public string Artista { get; set; }
   public int Duracao {  get; set; }
   public bool Disponivel {  get; set; }
   public string DescricaoResumida
    {
        get
        {
            return $"A musica {Nome} pertence a banda {Artista} ";
        }
    }


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




