using BestPracticesInjectionDependency.Queue;

namespace BestPracticesInjectionDependency.Services.BestPractice5
{
    public interface IBestPractice5Service
    {
        int Count();
        void Enqueue(MessagesQueue data);
        MessagesQueue Dequeue();
    }
}
