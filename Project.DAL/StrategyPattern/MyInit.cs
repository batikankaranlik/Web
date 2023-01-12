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
            ap.UserName = "dgk";
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
            p1.Name = "deneme1";
            p1.SubTitle = "asdasdasadasdasdasdasdasdasd1";
            p1.Category = "denemcatogry1";
            p1.Description = "asdasdasdasdasdsadasdasdsa1";
            context.Products.Add(p1);
            context.SaveChanges();
            Product p2 = new Product();
            p2.Name = "deneme2";
            p2.SubTitle = "asdasdasadasdasdasdasdasdasd2";
            p2.Category = "denemcatogry2";
            p2.Description = "asdasdasdasdasdsadasdasdsa2";
            context.Products.Add(p2);
            context.SaveChanges(); 
            Product p3 = new Product();
            p3.Name = "deneme3";
            p3.SubTitle = "asdasdasadasdasdasdasdasdasd3";
            p3.Category = "denemcatogry3";
            p3.Description = "asdasdasdasdasdsadasdasdsa3";
            context.Products.Add(p3);
            context.SaveChanges();

            Service s = new Service();
            s.Icon = "";
            s.Title = "denemeservice";
            s.Description = "denemeeeeeeee";
            context.Services.Add(s);
            context.SaveChanges();
            Service s1 = new Service();
            s1.Icon = "";
            s1.Title = "denemeservice1";
            s1.Description = "denemeeeeeeee1";
            context.Services.Add(s1);
            context.SaveChanges();
            Service s2 = new Service();
            s2.Icon = "";
            s2.Title = "denemeservice2";
            s2.Description = "denemeeeeeeee2";
            context.Services.Add(s2);
            context.SaveChanges();

            Team t = new Team();
            t.ProfileImage = "";
            t.NameSurname = "deneme deneme";
            t.Title = "dsadasdasdasdasdasd";
            context.Teams.Add(t);
            context.SaveChanges(); 
            Team t1 = new Team();
            t1.ProfileImage = "";
            t1.NameSurname = "deneme deneme1";
            t1.Title = "dsadasdasdasdasdasd1";
            context.Teams.Add(t1);
            context.SaveChanges(); 
            Team t2 = new Team();
            t2.ProfileImage = "";
            t2.NameSurname = "deneme deneme2";
            t2.Title = "dsadasdasdasdasdasd2";
            context.Teams.Add(t2);
            context.SaveChanges();



        }
    }
}
