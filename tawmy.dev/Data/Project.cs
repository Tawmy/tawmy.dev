namespace tawmy.dev.Data;

public record Project(string Title, string Description, IEnumerable<NoWrapElement> Tech, string? ExternalUrl);