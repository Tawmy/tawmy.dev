namespace tawmy.dev.Components.Pages;

public partial class Home
{
    private readonly IEnumerable<CategoryList.CategoryListEntry> _alsoDo =
    [
        new("CI/CD", true),
        new("Linux administration"),
        new("Service monitoring"),
        new("Python", true),
        new("Java"),
        new("Dapper", true),
        new("MS-SQL"),
        new("Podman")
    ];

    private readonly IEnumerable<CategoryList.CategoryListEntry> _freeTime =
    [
        new("Cycling", true),
        new("Hiking"),
        new("Geocaching"),
        new("Cats", true),
        new("Video Games")
    ];

    private readonly IEnumerable<CategoryList.CategoryListEntry> _techStack =
    [
        new(".NET"),
        new("ASP.NET Core", true),
        new("Blazor", true),
        new("HTML & CSS"),
        new("Tailwind CSS"),
        new("Entity Framework", true),
        new("Postgres"),
        new("Keycloak", true),
        new("OAuth & OIDC")
    ];
}