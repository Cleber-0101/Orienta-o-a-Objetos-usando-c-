Banda Djongaa = new Banda("O menino ");

Album Djonga = new Album("O menino queria ser Deus");
Djonga.DuracaoTotal = 254;

Musica musica1 = new Musica(Djongaa , "fantasma");
Djonga.DuracaoTotal = 554;

Musica musica2 = new Musica(Djongaa , "Corra");



//funçoes
Djonga.AdicionarMusica(musica1);
Djonga.AdicionarMusica(musica2);

Djongaa.AdicionarAlbum(Djonga);
Djongaa.ExibirDiscografia();
Djonga.ExibirMusicasDoAlbum();
