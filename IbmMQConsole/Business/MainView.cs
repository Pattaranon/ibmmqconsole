using IbmMQConsole.Interface;
using CommandDotNet;

namespace IbmMQConsole.Business
{
    public class MainView
    {
        private readonly IQueueManager _queueManager;

        public MainView(IQueueManager queueManager)
        {
            _queueManager = queueManager;
        }

        [Command(Description = "Sender Message to queue")]
        public void Sender(string message)
        {
            _queueManager.Sender(message);
        }

        [Command(Description = "Listener Messages from queue")]
        public void Listener([Option(LongName = "Second", ShortName = "s", Description = "Time for listen.")]int second = 1)
        {
            _queueManager.Listener(second);
        }

        [Command(Description = "Publisher Message to subscriber")]
        public void Publisher(string message)
        {
            _queueManager.Publisher(message);
        }

        [Command(Description = "Subscriber Messages from publisher")]
        public void Subscriber([Option(LongName = "topic", ShortName = "n", Description = "Topic name for subscribe")]string topicName)
        {
            _queueManager.Subscriber(topicName);
        }
    }
}