// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

HttpClient cliente = new HttpClient();
await DownloadStringWithRetries(cliente, new Uri("https://google.com/"));

async Task<string> DownloadStringWithRetries(HttpClient client, Uri uri)
{
// Retry after 1 second, then after 2 seconds, then 4.
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3));
    TimeSpan nextDelay = TimeSpan.FromSeconds(1);
    for (int i = 0; i != 3; ++i)
    {
        try
        {
            return await client.GetStringAsync(uri);
        }
        catch
        {
        }
        await Task.Delay(nextDelay);
        nextDelay += nextDelay;
    }
// Try one last time, allowing the error to propagate.
    return await client.GetStringAsync(uri);
}

// Task.WhenAny to implement a “soft time‐out.”
async Task<string> DownloadStringWithTimeout(HttpClient client, string uri)
{
    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3));
    Task<string> downloadTask = client.GetStringAsync(uri);
    Task timeoutTask = Task.Delay(Timeout.InfiniteTimeSpan, cts.Token);
    Task completedTask = await Task.WhenAny(downloadTask, timeoutTask);
    if (completedTask == timeoutTask) return null;
    return await downloadTask;
}
