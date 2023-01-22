using System;
using System.Threading;
using IbmMQConsole.Interface;

namespace IbmMQConsole.Services
{
    public class MockMQService : IQueueManager
    {
        public void Sender(string value)
        {
            if (value == "throw")
            {
                throw new Exception("Send error");
            }
            Console.WriteLine($"{nameof(Sender)}: {value}");
        }

        public void Publisher(string value)
        {
            if (value == "throw")
            {
                throw new Exception("Publish error");
            }
            Console.WriteLine($"{nameof(Publisher)}: {value}");
        }

        public void Listener(int second)
        {
            if (second == 999)
            {
                throw new Exception("Listen error");
            }
            for (int i = second; i > 0; i--)
            {
                Console.WriteLine($"{nameof(Listener)} for {i} seconds");
                Thread.Sleep(1000);
            }
        }

        public void Subscriber(string topicName)
        {
            if (topicName == "throw")
            {
                throw new Exception("Subscribe error");
            }
            Console.WriteLine($"{nameof(Subscriber)}: {topicName}");
        }
    }
}