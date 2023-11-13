using System.Text.Json;
using ScreenSoundApi.Modelos;
using ScreenSoundApi.Filtros;
using Microsoft.VisualBasic;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musicas[0].ExibirDetalhesDaMusica();

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarTodosOsArtistasPorNome(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "blues");
        //LinqFilter.FiltrarMusicasPorArtistas(musicas, "Eminem");
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "Ab");


        // var musicasPreferidas = new MusicasPreferidas("Guilherme");
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[377]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        // musicasPreferidas.AdicionarMusicasFavoritas(musicas[1467]);

        // musicasPreferidas.ExibirMusicasFavoritas();

        // musicasPreferidas.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");        
    }
}