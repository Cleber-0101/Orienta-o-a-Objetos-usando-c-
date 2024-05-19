Album Djonga = new Album();
Djonga.Nome = "O menino queria ser Deus";

Musica musica1 = new Musica();
musica1.Nome = "fantasma";

Musica musica2 = new Musica();
musica2.Nome = "Corra";


Djonga.AdicionarMusica(musica1);
Djonga.AdicionarMusica(musica2);


Djonga.ExibirMusicasDoAlbum();