using System;

namespace ObjectAndClasses_Exercise___02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            int n = int.Parse(Console.ReadLine());
            Article article = new Article();

            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Edit")
                {
                    string newContentAsInput = tokens[1];
                    article.Edit(newContentAsInput);
                }

                if (tokens[0] == "ChangeAuthor")
                {
                    string newAuthorAsinput = tokens[1];
                    article.ChangeAuthor(newAuthorAsinput);
                }
                if (tokens[0] == "Rename")
                {
                    string newTitleAsInput = tokens[1];
                    article.Rename(newTitleAsInput);
                }
            }

            Console.WriteLine(string.Join(" ", article));
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit( string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor( string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
