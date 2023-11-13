using ScreenSoundApi.Modelos;
namespace ScreenSoundApi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }

        Console.WriteLine($"total de gêneros musicais: {todosOsGenerosMusicais.Count()}");
    }

    public static void FiltrarTodosOsArtistasPorNome(List<Musica> musicas)
    {
        var todosOsArtistas = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        foreach (var artista in todosOsArtistas)
        {
            Console.WriteLine($"Artista - {artista}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
        .Select(musica => musica.Artista)
        .Distinct()
        .ToList();

        Console.WriteLine($"Exibindo os artistas do gênero {genero}:");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");  
        }
    }

    public static void FiltrarMusicasPorArtistas(List<Musica> musicas, string artista)
    {
        var musicasPorArtistas = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).Distinct().ToList();

        Console.WriteLine($"Exibindo as músicas do artista {artista}:");
        foreach (var musica in musicasPorArtistas)
        {
            Console.WriteLine($"{musica} - {artista}");  
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade!
            .Equals(tonalidade))
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo os músicas da Tonalidade {tonalidade}:");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"{musica} - {tonalidade}");  
        }
    }
}


