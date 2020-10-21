using BestPracticesInjectionDependency.Queue;
using System.Collections.Concurrent;

namespace BestPracticesInjectionDependency.Services.BestPractice5
{
    public class BestPractice5Service : IBestPractice5Service
    {
        private readonly ConcurrentQueue<MessagesQueue> _queue;

        public BestPractice5Service()
        {
            this._queue = new ConcurrentQueue<MessagesQueue>();
        }

        public int Count() => this._queue.Count;

        public void Enqueue(MessagesQueue data)
        {
            this._queue.Enqueue(data);
        }

        public MessagesQueue Dequeue()
        {
            if (this._queue.TryDequeue(out MessagesQueue data))
            {
                return data;
            }

            return default;
        }
    }
}
