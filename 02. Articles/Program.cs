using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void EditContent(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
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
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputArticle = Console.ReadLine();
            string[] arguments = inputArticle.Split(", ");
            string title = arguments[0];
            string content = arguments[1];
            string author = arguments[2];

            Article article = new Article(title, content, author);
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                switch (commands[0])
                {
                    case "Edit":
                        string newContent = commands[1];
                        article.EditContent(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = commands[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = commands[1];
                        article.Rename(newTitle);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}