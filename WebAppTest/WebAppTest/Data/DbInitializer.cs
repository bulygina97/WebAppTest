using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTest.Controllers;
using WebAppTest.Models;

namespace WebAppTest.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NotesContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Note.Any())
            {
                return;   // DB has been seeded
            }

            var Note = new Note[]
            {
            new Note{Name="Покупки",Text="Молоко, хлеб",Date_system=DateTime.Parse("2021-09-01"),UrlNote ="Покупки" , CategoryID=1, TagID=1},
            new Note{Name="Фильмы на каникулы",Text="Монстры на каникулах, Огонь, Чудо женщина",Date_system=DateTime.Parse("2021-10-05"),UrlNote ="Фильмы" , CategoryID=1, TagID=1}
            };
            foreach (Note s in Note)
            {
                context.Note.Add(s);
            }
            context.SaveChanges();

            var Category = new Category[]
            {
            new Category{Id=1,Name="Заметки",UrlSlug="Заметки"},
            new Category{Id=2,Name="Напоминания",UrlSlug="Напоминания"}
            };
            foreach (Category c in Category)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();

            var Tag = new Tag[]
            {
            new Tag{Id=1,Name="Покупки",UrlSlug="", Description="покупка"},
            new Tag{Id=2,Name="Фильмы",UrlSlug="", Description="кино"}
            };
            foreach (Tag e in Tag)
            {
                context.Tag.Add(e);
            }
            context.SaveChanges();
        }
    }
}
