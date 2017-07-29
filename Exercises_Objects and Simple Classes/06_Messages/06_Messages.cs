namespace _06_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        
        public static void Main()
        {
            var users = new Dictionary<string, User>();
            string input = Console.ReadLine();

            string sender;
            string recipient;

            while (input != "exit")
            {
                string[] tokens = input
                                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "register")
                {
                    string username = tokens[1];

                    users.Add(username, new User(username));
                    

                }
                else
                {
                    sender = tokens[0];
                    recipient = tokens[2];
                    string content = tokens[3];

                    if (users.ContainsKey(sender) &&
                        users.ContainsKey(recipient))
                    {
                        Message message = new Message(users[sender], content);
                        users[recipient].Messages.Add(message);
                    }
                }

                input = Console.ReadLine();
            }

            string[] chatTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            sender = chatTokens[0];
            recipient = chatTokens[1];

            Message[] senderMessages = users[recipient]
                                       .Messages
                                       .Where(m => m.Sender.Username == sender)
                                       .ToArray();
            Message[] recipientMessages = users[sender]
                                      .Messages
                                      .Where(m => m.Sender.Username == recipient)
                                      .ToArray();

            if (senderMessages.Length == 0 &&
                recipientMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            int index = 0;
            while (index < senderMessages.Length &&
                   index < recipientMessages.Length)
            {
                Console.WriteLine($"{sender}: {senderMessages[index].Content}");
                Console.WriteLine($"{recipientMessages[index].Content} :{recipient}");
                index++;
            }
            while (index < senderMessages.Length)
            {
                Console.WriteLine($"{sender}: {senderMessages[index].Content}");
                index++;
            }
            while (index < recipientMessages.Length)
            {
                Console.WriteLine($"{recipientMessages[index].Content} :{recipient}");
                index++;
            }

        }
    }
    class User
    {
        public string Username { get; set; }
        public List<Message> Messages { get; set; }

        public User(string username)
        {
            this.Username = username;
            this.Messages = new List<Message>();
        }
    }
    class Message
    {
        
        public User Sender { get; set; }
        public string Content { get; set; }

        public Message(User sender, string content)
        {
            
            this.Sender = sender;
            this.Content = content;
        }
    }

}
