using System.Text.Json;
using SelectionOfFilms.Lib.Models;

namespace SelectionOfFilms.Lib;

public static class KinopoiskApi
{
    public static string baseUrl = "https://api.kinopoisk.dev/v1.4/movie/random";
    public static Film? GetRandomFilm(string genre)
    {
        var kinopoiskApiToken = File.ReadAllText("kinopoisk_api.key"); 
        
        var http = new HttpClient();
        http.DefaultRequestHeaders.Add("X-API-KEY", kinopoiskApiToken);
        var data = http.GetStringAsync($"{baseUrl}?genres.name={genre}").Result;
        //var myDeserializedClass = JsonSerializer.Deserialize<Root>(json);
        
        using var doc = JsonDocument.Parse(data);
        var root = doc.RootElement;
        var name = root.GetProperty("alternativeName").ToString();
        var url = root.GetProperty("poster").GetProperty("previewUrl").ToString();
        
        return new Film()
        {
            Name = name,
            PosterUrl = url
        };
    }
}