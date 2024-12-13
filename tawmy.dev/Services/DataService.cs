using System.Text.Json;
using tawmy.dev.Data;

namespace tawmy.dev.Services;

public class DataService
{
    private static readonly string PathData = GetDataPath();

    private IEnumerable<Introduction>? _introductions;
    private IEnumerable<ProjectCategory>? _projects;
    private IEnumerable<SocialLink>? _socials;

    internal async Task LoadDataAsync()
    {
        var introductions = LoadIntroductionsAsync();
        var projects = LoadProjectsAsync();
        var socials = LoadSocialsAsync();

        await Task.WhenAll(introductions, projects, socials);

        _introductions = introductions.Result;
        _projects = projects.Result;
        _socials = socials.Result;
    }

    public IEnumerable<Introduction> GetIntroductions()
    {
        if (_introductions is null)
        {
            throw new InvalidOperationException("Introductions are not loaded.");
        }

        return _introductions;
    }

    public IEnumerable<ProjectCategory> GetProjects()
    {
        if (_projects is null)
        {
            throw new InvalidOperationException("Projects are not loaded.");
        }

        return _projects;
    }

    public IEnumerable<SocialLink> GetSocials()
    {
        if (_socials is null)
        {
            throw new InvalidOperationException("SocialLinks are not loaded.");
        }

        return _socials;
    }

    private static string GetDataPath()
    {
        if (bool.TryParse(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER"),
                out var runningInContainer) is false || runningInContainer is false)
        {
            // during development, use wwwroot
            return "wwwroot/data";
        }

        return "/mnt/data";
    }

    private static async Task<IEnumerable<Introduction>> LoadIntroductionsAsync()
    {
        var pathIntroduction = Path.Combine(PathData, "introductions.json");
        await using var fileStream = File.OpenRead(pathIntroduction);

        if (await JsonSerializer.DeserializeAsync<IEnumerable<Introduction>>(fileStream) is { } introductions)
        {
            return introductions;
        }

        throw new InvalidOperationException("Introductions could not be loaded, result was null.");
    }

    private static async Task<IEnumerable<ProjectCategory>> LoadProjectsAsync()
    {
        var pathProjects = Path.Combine(PathData, "projects.json");
        await using var fileStream = File.OpenRead(pathProjects);

        if (await JsonSerializer.DeserializeAsync<IEnumerable<ProjectCategory>>(fileStream) is { } projects)
        {
            return projects;
        }

        throw new InvalidOperationException("Projects could not be loaded, result was null.");
    }

    private static async Task<IEnumerable<SocialLink>> LoadSocialsAsync()
    {
        var pathSocialLinks = Path.Combine(PathData, "socials.json");
        await using var fileStream = File.OpenRead(pathSocialLinks);

        if (await JsonSerializer.DeserializeAsync<IEnumerable<SocialLink>>(fileStream) is { } socials)
        {
            return socials;
        }

        throw new InvalidOperationException("Socials could not be loaded, result was null.");
    }
}