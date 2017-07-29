namespace _04_Websites
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
            List<Website> webSites = new List<Website>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(" |,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string host = tokens[0];
                string domain = tokens[1];
                List<string> queries = new List<string>();

                if (tokens.Length > 2)
                {
                    queries = tokens.Skip(2).Select(q => "[" + q + "]").ToList();
                

                    Website newWebsite = new Website
                    {
                        Host = host,
                        Domain = domain,
                        Queries = queries
                    };
                    webSites.Add(newWebsite);
                }
                else
                {
                    queries.Add(null);
                    Website newWebsite = new Website
                    {
                        Host = host,
                        Domain = domain,
                        Queries = queries
                    };
                    webSites.Add(newWebsite);
                }


                input = Console.ReadLine();
            }

            foreach (var site in webSites)
            {
                if (site.Queries[0] != null)
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}/query?={string.Join("&", site.Queries)}");
                }
                else
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}");
                }
            }

        }
    }
    public class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

    }
}
