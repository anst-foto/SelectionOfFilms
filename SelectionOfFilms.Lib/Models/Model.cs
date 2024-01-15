using System.Text.Json.Serialization;

namespace SelectionOfFilms.Lib.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public class Backdrop
{
    [JsonPropertyName("url")] public object Url;

    [JsonPropertyName("previewUrl")] public object PreviewUrl;
}

public class Budget
{
}

public class Country
{
    [JsonPropertyName("name")] public string Name;
}

public class ExternalId
{
    [JsonPropertyName("kpHD")] public object KpHD;
}

public class Fees
{
    [JsonPropertyName("world")] public World World;

    [JsonPropertyName("russia")] public Russia Russia;

    [JsonPropertyName("usa")] public Usa Usa;
}

public class Genre
{
    [JsonPropertyName("name")] public string Name;
}

public class Name
{
    [JsonPropertyName("name")] public string Name_;

    [JsonPropertyName("language")] public object Language;

    [JsonPropertyName("type")] public string Type;
}

public class Person
{
    [JsonPropertyName("id")] public int Id;

    [JsonPropertyName("photo")] public string Photo;

    [JsonPropertyName("name")] public string Name;

    [JsonPropertyName("enName")] public string EnName;

    [JsonPropertyName("description")] public string Description;

    [JsonPropertyName("profession")] public string Profession;

    [JsonPropertyName("enProfession")] public string EnProfession;
}

public class Poster
{
    [JsonPropertyName("url")] public object Url;

    [JsonPropertyName("previewUrl")] public object PreviewUrl;
}

public class Premiere
{
}

public class Rating
{
    [JsonPropertyName("kp")] public int Kp;

    [JsonPropertyName("imdb")] public int Imdb;

    [JsonPropertyName("filmCritics")] public int FilmCritics;

    [JsonPropertyName("russianFilmCritics")]
    public int RussianFilmCritics;

    [JsonPropertyName("await")] public int Await;
}

public class Root
{
    [JsonPropertyName("id")] public int Id;

    [JsonPropertyName("externalId")] public ExternalId ExternalId;

    [JsonPropertyName("name")] public object Name;

    [JsonPropertyName("alternativeName")] public string AlternativeName;

    [JsonPropertyName("enName")] public object EnName;

    [JsonPropertyName("names")] public List<Name> Names;

    [JsonPropertyName("type")] public string Type;

    [JsonPropertyName("typeNumber")] public int TypeNumber;

    [JsonPropertyName("year")] public int Year;

    [JsonPropertyName("description")] public object Description;

    [JsonPropertyName("shortDescription")] public object ShortDescription;

    [JsonPropertyName("slogan")] public object Slogan;

    [JsonPropertyName("status")] public object Status;

    [JsonPropertyName("rating")] public Rating Rating;

    [JsonPropertyName("votes")] public Votes Votes;

    [JsonPropertyName("movieLength")] public object MovieLength;

    [JsonPropertyName("totalSeriesLength")]
    public object TotalSeriesLength;

    [JsonPropertyName("seriesLength")] public object SeriesLength;

    [JsonPropertyName("ratingMpaa")] public object RatingMpaa;

    [JsonPropertyName("ageRating")] public object AgeRating;

    [JsonPropertyName("poster")] public Poster Poster;

    [JsonPropertyName("backdrop")] public Backdrop Backdrop;

    [JsonPropertyName("genres")] public List<Genre> Genres;

    [JsonPropertyName("countries")] public List<Country> Countries;

    [JsonPropertyName("budget")] public Budget Budget;

    [JsonPropertyName("fees")] public Fees Fees;

    [JsonPropertyName("premiere")] public Premiere Premiere;

    [JsonPropertyName("ticketsOnSale")] public bool TicketsOnSale;

    [JsonPropertyName("sequelsAndPrequels")]
    public List<object> SequelsAndPrequels;

    [JsonPropertyName("watchability")] public Watchability Watchability;

    [JsonPropertyName("top10")] public object Top10;

    [JsonPropertyName("top250")] public object Top250;

    [JsonPropertyName("isSeries")] public bool IsSeries;

    [JsonPropertyName("audience")] public List<object> Audience;

    [JsonPropertyName("deletedAt")] public object DeletedAt;

    [JsonPropertyName("facts")] public List<object> Facts;

    [JsonPropertyName("persons")] public List<Person> Persons;

    [JsonPropertyName("spokenLanguages")] public List<object> SpokenLanguages;

    [JsonPropertyName("seasonsInfo")] public List<object> SeasonsInfo;

    [JsonPropertyName("collections")] public List<object> Collections;

    [JsonPropertyName("productionCompanies")]
    public List<object> ProductionCompanies;

    [JsonPropertyName("similarMovies")] public List<object> SimilarMovies;

    [JsonPropertyName("releaseYears")] public List<object> ReleaseYears;

    [JsonPropertyName("createdAt")] public DateTime CreatedAt;

    [JsonPropertyName("updatedAt")] public DateTime UpdatedAt;

    [JsonPropertyName("networks")] public object Networks;
}

public class Russia
{
}

public class Usa
{
}

public class Votes
{
    [JsonPropertyName("kp")] public int Kp;

    [JsonPropertyName("imdb")] public int Imdb;

    [JsonPropertyName("filmCritics")] public int FilmCritics;

    [JsonPropertyName("russianFilmCritics")]
    public int RussianFilmCritics;

    [JsonPropertyName("await")] public int Await;
}

public class Watchability
{
    [JsonPropertyName("items")] public object Items;
}

public class World
{
}