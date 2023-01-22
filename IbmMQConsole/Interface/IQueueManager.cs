namespace IbmMQConsole.Interface
{
    public interface IQueueManager
    {
        /// <summary>
        /// Send your messages
        /// Mesaj gönderir.
        /// </summary>
        /// <param name="value"></param>
        void Sender(string value);

        /// <summary>
        /// Publish your messages
        /// Mesaj yayınlar.
        /// </summary>
        /// <param name="value"></param>
        void Publisher(string value);

        /// <summary>
        /// It's listen queue
        /// Kuyruğu dinler.
        /// </summary>
        /// <param name="second"></param>
        void Listener(int second);

        /// <summary>
        /// It's listen publisher
        /// Yayıncıyı dinler.
        /// </summary>
        /// <param name="second"></param>
        void Subscriber(string topicName);
    }
}