using System.Diagnostics;

namespace tawmy.dev.Services;

public class TailwindService : IHostedService
{
    private Process? _process;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _process = Process.Start(new ProcessStartInfo
        {
            FileName = "pnpm",
            Arguments = "tailwindcss -i ./Styles/source.css -o ./wwwroot/css/tailwind.css --watch",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        })!;

        _process.EnableRaisingEvents = true;
        _process.OutputDataReceived += PrintToConsole;
        _process.ErrorDataReceived += PrintToConsole;

        _process.BeginOutputReadLine();
        _process.BeginErrorReadLine();

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Tailwind: STOP");
        _process?.Kill(true);
        return Task.CompletedTask;
    }

    private static void PrintToConsole(object _, DataReceivedEventArgs e)
    {
        if (!string.IsNullOrEmpty(e.Data))
        {
            Console.WriteLine($"Tailwind: {e.Data}");
        }
    }
}