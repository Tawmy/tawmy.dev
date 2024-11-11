namespace tawmy.dev.Components.Pages;

public partial class Home
{
    private readonly IEnumerable<Project.ProjectEntry> _activeProjects =
    [
        new("Alyx",
            "Discord bot built for Final Fantasy XIV with an eye for UX and privacy.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("ASP.NET Core", true),
                new NoWrapElements.NoWrapElement("Blazor"),
                new NoWrapElements.NoWrapElement("Entity Framework", true),
                new NoWrapElements.NoWrapElement("Postgres"),
                new NoWrapElements.NoWrapElement("Mediator Pattern", true)
            ],
            "https://github.com/Tawmy/Alyx.Discord"),
        new("NetStone API",
            "API providing various data related to Final Fantasy XIV from the Lodestone.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("ASP.NET Core", true),
                new NoWrapElements.NoWrapElement("Blazor"),
                new NoWrapElements.NoWrapElement("Entity Framework", true),
                new NoWrapElements.NoWrapElement("Postgres"),
                new NoWrapElements.NoWrapElement("OAuth"),
                new NoWrapElements.NoWrapElement("OpenAPI", true),
                new NoWrapElements.NoWrapElement("Unit Testing", true),
                new NoWrapElements.NoWrapElement("CI/CD", true),
                new NoWrapElements.NoWrapElement("Docker")
            ],
            "https://netstone.api.tawmy.net"),
        new("NetStone API Client",
            "Companion client for NetStone API, proving an easy to use client for retrieving data, including resilience in case of connection or parsing issues.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("REST"),
                new NoWrapElements.NoWrapElement(".NET Resilience", true)
            ],
            "https://netstone.api.tawmy.net"),
        new("SystemMonitor",
            "System metrics (memory, disk space, TCP ports to other machines) monitoring extension for Uptime Kuma.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("ASP.NET Core"),
                new NoWrapElements.NoWrapElement("OpenAPI"),
                new NoWrapElements.NoWrapElement("OAuth"),
                new NoWrapElements.NoWrapElement("Linux & Windows", true),
                new NoWrapElements.NoWrapElement("Docker"),
                new NoWrapElements.NoWrapElement("IIS")
            ],
            "https://github.com/Tawmy/SystemMonitor"),
        new("Stylophonix",
            "A lightweight and minimalistic home page for a band.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("Blazor", true),
                new NoWrapElements.NoWrapElement("Docker")
            ],
            "https://stylophonix.de")
    ];

    private readonly IEnumerable<NoWrapElements.NoWrapElement> _alsoDo =
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

    private readonly IEnumerable<NoWrapElements.NoWrapElement> _freeTime =
    [
        new("Cycling", true),
        new("Hiking"),
        new("Geocaching"),
        new("Cats", true),
        new("Video Games")
    ];

    private readonly IEnumerable<Project.ProjectEntry> _pastProjects =
    [
        new("xivapi-cs",
            "XIVAPI wrapper, providing an easy way to retrieve and use data.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("JSON"),
                new NoWrapElements.NoWrapElement("OpenAPI")
            ],
            "https://github.com/Tawmy/xivapi-cs"),
        new("Leyla",
            "Privacy-focused Discord bot, split into multiple modules depending on permissions needed.",
            [
                new NoWrapElements.NoWrapElement(".NET"),
                new NoWrapElements.NoWrapElement("GraphQL"),
                new NoWrapElements.NoWrapElement("REST"),
                new NoWrapElements.NoWrapElement("Entity Framework"),
                new NoWrapElements.NoWrapElement("Postgres")
            ],
            "https://github.com/Tawmy/Leyla.Bot"),
        new("Amadeus",
            "Configuration-rich Discord bot, focused on moderation and usage of new components.",
            [
                new NoWrapElements.NoWrapElement("Python"),
                new NoWrapElements.NoWrapElement("SqlAlchemy"),
                new NoWrapElements.NoWrapElement("Alembic"),
                new NoWrapElements.NoWrapElement("Postgres")
            ],
            "https://github.com/Tawmy/AmadeusBotNeo"),
        new("Zootopia Discord",
            "Landing page for a Discord server, with the constraint of being hosted through GitHub Pages.",
            [
                new NoWrapElements.NoWrapElement("jQuery", true),
                new NoWrapElements.NoWrapElement("HTML"),
                new NoWrapElements.NoWrapElement("CSS"),
                new NoWrapElements.NoWrapElement("JavaScript")
            ],
            "https://zootopiadiscord.com")
    ];

    private readonly IEnumerable<NoWrapElements.NoWrapElement> _techStack =
    [
        new(".NET"),
        new("ASP.NET Core", true),
        new("Blazor", true),
        new("Tailwind CSS"),
        new("Entity Framework", true),
        new("Postgres"),
        new("Keycloak", true),
        new("OAuth & OIDC")
    ];
}