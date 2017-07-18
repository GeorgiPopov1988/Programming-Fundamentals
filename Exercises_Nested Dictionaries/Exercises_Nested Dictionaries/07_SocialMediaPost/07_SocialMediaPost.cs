namespace _07_SocialMediaPost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static new Dictionary<string, Dictionary<string, string>> postComments = new Dictionary<string, Dictionary<string, string>>();
        static new Dictionary<string, int> postLike = new Dictionary<string, int>();
        static new Dictionary<string, int> postDislike = new Dictionary<string, int>();

        public static void Main()
        {
            string userInput = Console.ReadLine();

            while (userInput != "drop the media")
            {
                string[] input = userInput.Split(' ');

                string command = input[0];
                string postName = input[1];

                switch (command)
                {

                    case "post":
                        {
                            CreateNewPost(postName);
                            break;
                        }
                    case "like":
                        {
                            LikePost(postName);
                            break;
                        }
                    case "dislike":
                        {
                            DisLikePost(postName);
                            break;
                        }
                    case "comment":
                        {
                            string commentatorName = input[2];

                            string commentContent = string.Join(" ",input.Skip(3).ToArray());

                            CommentPost(postName, commentatorName, commentContent);
                            break;
                        }
                }


                userInput = Console.ReadLine();
            }
            foreach (var postCommentData in postComments)
            {
                string postName = postCommentData.Key;
                int likes = postLike[postName];
                int dislikes = postDislike[postName];

                Dictionary<string, string> commentsData = postCommentData.Value;

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");

                Console.WriteLine("Comments:");

                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }

                foreach (var commentData in commentsData)
                {
                    string commentatorName = commentData.Key;

                    string commentContent = commentData.Value;

                    Console.WriteLine($"*  {commentatorName}: {commentContent}");


                }

            }

        }

        static void CreateNewPost(string postName)
        {
            postComments.Add(postName, new Dictionary<string, string>());
            postLike.Add(postName, 0);
            postDislike.Add(postName, 0);
        }

        static void LikePost(string postName)
        {
            postLike[postName]++;
        }

        static void DisLikePost(string postName)
        {
            postDislike[postName]++;
        }

        static void CommentPost(string postName,
                                 string commentatorName,
                                 string commentContent)
        {
            postComments[postName].Add(commentatorName, commentContent);
        }
    }
}
