﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfHelper.Models
{
    public class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Login = "zoldik",
                        Email = "zoldikds@mail.ru",
                        Password = "1111"
                    }
                );
                context.SaveChanges();
            }

            User user = context.Users.FirstOrDefault(e => e.Login == "zoldik");

            DateTime dateTime = new DateTime(2020, 01, 10, 22, 20, 00);
            DateTime dateTime2 = new DateTime(2020, 01, 11, 20, 20, 00);
            DateTime dateTime3 = new DateTime(2020, 01, 12, 22, 29, 00);
            DateTime dateTime4 = new DateTime(2020, 01, 11, 21, 20, 00);

            if (!context.Diaries.Any())
            {
                context.Diaries.AddRange(
                    new Diary
                    {
                        User = user,
                        DateTime = dateTime,
                        Text = "Сегодня была отличная погода"
                    },
                    new Diary
                    {
                        User = user,
                        DateTime = dateTime2,
                        Text = "Я потерял ключи"
                    },
                    new Diary
                    {
                        User = user,
                        DateTime = dateTime3,
                        Text = "Мне предложили интересный проект"
                    },
                    new Diary
                    {
                        User = user,
                        DateTime = dateTime4,
                        Text = "Настроение ничего не делать"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Notes.Any())
            {
                context.Notes.AddRange(
                    new Note
                    {
                        User = user,
                        DateTime = dateTime,
                        Title = "ПСС",
                        Topic = "Учёба",
                        Important = true,
                        Text = "Сделать 20 лабу"
                    },
                    new Note
                    {
                        User = user,
                        DateTime = dateTime2,
                        Title = "КС",
                        Topic = "Учёба",
                        Important = true,
                        Text = "Сделать 22 лабу"
                    },
                    new Note
                    {
                        User = user,
                        DateTime = dateTime3,
                        Title = "ПЗ",
                        Topic = "КП",
                        Important = true,
                        Text = "Сделать 4 часть"
                    },
                    new Note
                    {
                        User = user,
                        DateTime = dateTime4,
                        Title = "Магазин",
                        Topic = "Домашние дела",
                        Important = true,
                        Text = "Купить хлеб"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Targets.Any())
            {
                context.Targets.AddRange(
                    new Target
                    {
                        User = user,
                        Text = "Прыгнуть с парашютом",
                        Status = "Completed",
                        DateTimeFirst = new DateTime(2020, 01, 10, 12, 00, 00),
                        DateTimeSecond = new DateTime(2020, 01, 20, 14, 00, 00)
                    },
                    new Target
                    {
                        User = user,
                        Text = "Научиться делать сальто",
                        Status = "Completed",
                        DateTimeFirst = new DateTime(2020, 01, 10, 10, 00, 00),
                        DateTimeSecond = new DateTime(2020, 01, 20, 20, 20, 00)
                    },
                    new Target
                    {
                        User = user,
                        Text = "Накопить на ssd",
                        Status = "Completed",
                        DateTimeFirst = new DateTime(2020, 01, 10, 12, 00, 00),
                        DateTimeSecond = new DateTime(2020, 02, 02, 14, 00, 00)
                    }
                );
                context.SaveChanges();
            }

            try
            {
                var result = context.DiaryViews.Any();
            }
            catch (Exception)
            {
                context.Database.ExecuteSqlRaw(@"CREATE VIEW DiaryView AS 
                                            SELECT c.Id AS 'Id', c.Text AS 'Text', c.DateTime AS 'DateTime', p.Login AS 'User'
                                            FROM Diaries c
                                            INNER JOIN Users p on p.Id = c.UserId");

                context.SaveChanges();
            }

            try
            {
                var result = context.NoteViews.Any();
            }
            catch (Exception)
            {
                context.Database.ExecuteSqlRaw(@"CREATE VIEW NoteView  AS 
                                            SELECT c.Id AS 'Id', c.Topic AS 'Topic', c.Title AS 'Title',  c.Text AS 'Text', c.DateTime AS 'DateTime', c.Important AS 'Important', p.Login AS 'User'
                                            FROM Notes c
                                            INNER JOIN Users p on p.Id = c.UserId");

                context.SaveChanges();
            }

            try
            {
                var result = context.TargetViews.Any();
            }
            catch (Exception)
            {
                context.Database.ExecuteSqlRaw(@"CREATE VIEW TargetView  AS 
                                            SELECT c.Id AS 'Id',  c.Text AS 'Text', c.DateTimeFirst AS 'DateTimeFirst', c.DateTimeSecond AS 'DateTimeSecond', c.Status AS 'Status', p.Login AS 'User'
                                            FROM Targets c
                                            INNER JOIN Users p on p.Id = c.UserId");

                context.SaveChanges();
            }
        }
    }
}

