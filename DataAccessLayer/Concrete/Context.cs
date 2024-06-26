﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BorayGulpinar;database=CoreProjeDB;integrated security=true");
        }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Education> Educations{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Portfolio> Portfolios{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
    }
}
