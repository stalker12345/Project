using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[] { new User("Иван"), new User("Петр"),new User("Семен") };
            ListNews listNews = new ListNews(new News[] { new News(users[0],"Игры","Зимние игры проходили..."), new News(users[1], "Лето", "Лето наступило..."), new News(users[2], "Спорт", "Спорт проходили...") });
            listNews.ShowListNews();
            Console.ReadKey();
        }
    }
    class User
    {
        public string Name;
        public User(string name)
        {
            Name = name;
        }
    }
    class ListNews
    {
        News[] News;
        public ListNews(News[] news)
        {
            News = news;
        }
        public void ShowListNews()
        {
            for (int i = 0; i < News.Length; i++)
            {
                News[i].ShowNews();
            }
        }
    }
    class News
    {
        User User;
        string Description;
        string Date;
        public News(User user, string description, string date)
        {
            User = user;
            Description = description;
            Date = date;
        }
        public void ShowNews()
        {
            Console.WriteLine($"Написал статью: {this.User.Name}");
            Console.WriteLine($"{this.Description}");
            Console.WriteLine($"{this.Date}\n");
        }
    }
}
