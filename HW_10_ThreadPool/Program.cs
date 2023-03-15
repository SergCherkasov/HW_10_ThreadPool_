ThreadPool.SetMinThreads(1, 1);
ThreadPool.SetMaxThreads(3, 2);

for (int i = 0; i < 1000; i++)
{
    ThreadPool.QueueUserWorkItem(BackgroundTask, i);
}


Console.ReadKey();

void BackgroundTask(object obj)
{
    int i = (int)obj;
    Console.WriteLine($"Iter:{i}\nThreadPool?: {Thread.CurrentThread.IsThreadPoolThread}\nThreadID:{Thread.CurrentThread.ManagedThreadId}\nThreadsCount:{ThreadPool.ThreadCount}\n\n\n");
    Thread.Sleep(10000);
}