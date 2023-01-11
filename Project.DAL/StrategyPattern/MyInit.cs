using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.StrategyPattern
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            AppUser au = new AppUser();
            au.Active = true;
            au.UserName = "BK";
            au.Password = "123";
            au.Email = "xxxxxx";
            au.Role = ENTITIES.Enums.UserRole.Admin;

            context.AppUsers.Add(au);
            context.SaveChanges();
            
            AppUser ap = new AppUser();
            ap.Active = true;
            ap.UserName = "BK";
            ap.Password = "123";
            ap.Email = "xxxxxx";
            ap.Role = ENTITIES.Enums.UserRole.Member;

            context.AppUsers.Add(ap);
            context.SaveChanges();


            Banner b = new Banner();
            b.BigTitle = "Deneme büyük başlık";
            b.SmallTitle="Deneme Küçük Başlık";
            b.ButtonText = "deneme Button texti";
            b.ButtonUrl = "deneme button link";

            context.Banners.Add(b);
            context.SaveChanges();

            Product p = new Product();
            p.Name = "deneme";
            p.SubTitle = "asdasdasadasdasdasdasdasdasd";
            p.Category = "denemcatogry";
            p.Description = "asdasdasdasdasdsadasdasdsa";
            context.Products.Add(p);
            context.SaveChanges(); 
            Product p1 = new Product();
            p.Name = "deneme1";
            p.SubTitle = "asdasdasadasdasdasdasdasdasd1";
            p.Category = "denemcatogry1";
            p.Description = "asdasdasdasdasdsadasdasdsa1";
            context.Products.Add(p1);
            context.SaveChanges();
            Product p2 = new Product();
            p.Name = "deneme2";
            p.SubTitle = "asdasdasadasdasdasdasdasdasd2";
            p.Category = "denemcatogry2";
            p.Description = "asdasdasdasdasdsadasdasdsa2";
            context.Products.Add(p2);
            context.SaveChanges(); 
            Product p3 = new Product();
            p.Name = "deneme3";
            p.SubTitle = "asdasdasadasdasdasdasdasdasd3";
            p.Category = "denemcatogry3";
            p.Description = "asdasdasdasdasdsadasdasdsa3";
            context.Products.Add(p3);
            context.SaveChanges();

            Service s = new Service();
            s.Icon = "";
            s.Title = "denemeservice";
            s.Description = "denemeeeeeeee";
            context.Services.Add(s);
            context.SaveChanges();
            Service s1 = new Service();
            s.Icon = "";
            s.Title = "denemeservice1";
            s.Description = "denemeeeeeeee1";
            context.Services.Add(s1);
            context.SaveChanges();
            Service s2 = new Service();
            s.Icon = "";
            s.Title = "denemeservice2";
            s.Description = "denemeeeeeeee2";
            context.Services.Add(s2);
            context.SaveChanges();

            Team t = new Team();
            t.ProfileImage = "";
            t.NameSurname = "deneme deneme";
            t.Title = "dsadasdasdasdasdasd";
            context.Teams.Add(t);
            context.SaveChanges(); 
            Team t1 = new Team();
            t.ProfileImage = "";
            t.NameSurname = "deneme deneme1";
            t.Title = "dsadasdasdasdasdasd1";
            context.Teams.Add(t1);
            context.SaveChanges(); 
            Team t2 = new Team();
            t.ProfileImage = "";
            t.NameSurname = "deneme deneme2";
            t.Title = "dsadasdasdasdasdasd2";
            context.Teams.Add(t2);
            context.SaveChanges();



        }
    }
}
