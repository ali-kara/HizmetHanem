using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EF.MainDB
{
    public class MainDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HizmetHanemDB;User ID=sa;Password=1234;MultipleActiveResultSets=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[] {
                new Category{CategoryId = 1, CategoryName="Yiyecekler"},
                new Category{CategoryId = 2,CategoryName="İçecekler"},
                new Category{CategoryId = 3,CategoryName="Sütlü Tatlılar"},
                new Category{CategoryId = 4,CategoryName="Soğuk Tatlılar"},
                new Category{CategoryId = 5,CategoryName="Meyveler"},
                new Category{CategoryId = 6,CategoryName="Ara Sıcaklar"},

            });

            modelBuilder.Entity<Company>().HasData(new Company[] {
                new Company{

                    CompanyId = 1,
                    Name=FakeData.NameData.GetCompanyName()
                },
                new Company{
                    CompanyId=2,
                    Name=FakeData.NameData.GetCompanyName()
                },
                new Company{
                    CompanyId=3,
                    Name=FakeData.NameData.GetCompanyName()
                },
            });

            modelBuilder.Entity<Menu>().HasData(new Menu[] {
                new Menu{
                    CompanyId=1,
                    MenuId=1,
                    Name="Menu 1"
                },
                new Menu{
                    CompanyId=2,
                    MenuId=2,
                    Name="Menu 2"
                }
            });


            modelBuilder.Entity<MenuItem>().HasData(new MenuItem[] {
                new MenuItem{
                    MenuItemId = 1,
                    ItemName=FakeData.NameData.GetSurname(),
                    Description = FakeData.TextData.GetSentences(3),
                    Price = 40,
                    CategoryId = 1,
                    MenuId = 1,

                },
                new MenuItem{
                    MenuItemId=2,
                    ItemName=FakeData.NameData.GetSurname(),
                    Description = FakeData.TextData.GetSentences(3),
                    Price = 23.4,
                    CategoryId = 3,
                    MenuId=2
                },
                new MenuItem{
                    MenuItemId=3,
                    ItemName=FakeData.NameData.GetSurname(),
                    Description = FakeData.TextData.GetSentences(3),
                    Price = 54,
                    CategoryId = 3,
                    MenuId=2
                }
            });

        }
    }
}
