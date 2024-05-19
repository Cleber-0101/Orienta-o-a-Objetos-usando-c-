

Musica musica1 = new Musica();
musica1.Nome = "Minha dama";
musica1.Artista = "Sidoka";
musica1.Duracao = 245;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "olhos de tigre";
musica2.Artista = "Djonga";
musica2.Duracao = 520;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
Console.WriteLine("************************************");
musica2.ExibirFichaTecnica();

