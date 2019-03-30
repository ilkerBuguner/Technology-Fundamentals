using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectAndClasses_Exercise___03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Article article = new Article();

                string[] input = Console.ReadLine().Split(", ");

                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                listOfArticles.Add(article);
            }

            string orderType = Console.ReadLine();

            if (orderType == "title")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Title).ToList();
                foreach (var article in listOfArticles)
                {
                    Console.WriteLine(article);
                }
            }
            else if (orderType == "content")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Content).ToList();
                foreach (var article in listOfArticles)
                {
                    Console.WriteLine(article);
                }
            }
            else if (orderType == "author")
            {
                listOfArticles = listOfArticles.OrderBy(x => x.Author).ToList();
                foreach (var article in listOfArticles)
                {
                    Console.WriteLine(article);
                }
            }
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
