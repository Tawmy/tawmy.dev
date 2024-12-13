namespace tawmy.dev.Data;

public record ProjectCategory(string Title, IEnumerable<Project> Entries);