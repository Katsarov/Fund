using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, int> sentMessages = new Dictionary<string, int>();
            Dictionary<string, int> receivedMessages = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] cmdArgs = command.Split("=");
                string cmdType = cmdArgs[0];

                if (cmdType.Contains("Add"))
                {
                    string username = cmdArgs[1];
                    int sent = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);

                    if (!sentMessages.ContainsKey(username))
                    {
                        sentMessages.Add(username, sent);
                        receivedMessages.Add(username, received);
                    }
                }

                else if (cmdType.Contains("Message"))
                {
                    string sender = cmdArgs[1];
                    string receiver = cmdArgs[2];

                    if (sentMessages.ContainsKey(sender) && receivedMessages.ContainsKey(receiver))
                    {
                        ProcessMessaging(capacity, sentMessages, receivedMessages, sender, receiver);
                    }
                }

                else if (cmdType.Contains("Empty"))
                {
                    string username = cmdArgs[1];

                    if (username == "All")
                    {
                        sentMessages.Clear();
                        receivedMessages.Clear();
                    }
                    else
                    {
                        if (sentMessages.ContainsKey(username))
                        {
                            sentMessages.Remove(username);
                            receivedMessages.Remove(username);
                        }
                    }
                }

                command = Console.ReadLine();
            }
            // няма значение каунта на кое от 2-те дикшинърита ще вземем
            Console.WriteLine($"Users count: {sentMessages.Count}");

            var sorted = receivedMessages.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kpv in sorted)
            {
                string username = kpv.Key;
                int totalMessages = kpv.Value + sentMessages[username];

                Console.WriteLine($"{username} - {totalMessages}");
            }
        }

        private static void ProcessMessaging(int capacity, Dictionary<string, int> sentMessages, Dictionary<string, int> receivedMessages, string sender, string receiver)
        {
            sentMessages[sender]++;
            receivedMessages[receiver]++;

            int senderTotalMessages = sentMessages[sender] + receivedMessages[sender];

            if (senderTotalMessages >= capacity)
            {
                RemoveUser(sentMessages, receivedMessages, sender);
            }

            int receiverTotalMessages = receivedMessages[receiver] + sentMessages[receiver];
            if (receiverTotalMessages >= capacity)
            {
                RemoveUser(sentMessages, receivedMessages, receiver);
            }
        }

        private static void RemoveUser(Dictionary<string, int> sentMessages, Dictionary<string, int> receivedMessages, string username)
        {
            sentMessages.Remove(username);
            receivedMessages.Remove(username);
            Console.WriteLine($"{username} reached the capacity!");
        }
    }
}
