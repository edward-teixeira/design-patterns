using System.Collections.Concurrent;

namespace Logging_Library;

public abstract class BaseContentWriter : IContentWriter
{
    private readonly object _lock = new();
    private readonly ConcurrentQueue<string> queue = new();

    public Task<bool> Write(string content)
    {
        queue.Enqueue(content);
        if (queue.Count <= 10)
            return Task.FromResult(true);
        lock (_lock)
        {
            var temp = Task.Run(() => Flush());
            Task.WaitAll(temp);
        }

        return Task.FromResult(true);
    }

//---- Write to Media
    protected abstract bool WriteToMedia(string logcontent);

    private Task Flush()
    {
        var count = 0;
        while (queue.TryDequeue(out var content) && count <= 10)
        {
//--- Write to Appropriate Media
//--- Calls the Overriden method
            WriteToMedia(content);
            count++;
        }

        return Task.CompletedTask;
    }
}

public interface IContentWriter
{
    Task<bool> Write(string content);
}
