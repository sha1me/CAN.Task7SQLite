using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN.Task7SQLite.Model
{
    public class ProductDbContext : DbContext
    {
        #region Конструктор
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public свойства
        public DbSet<Product> Products { get; set; }
        #endregion

        #region Методы
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts() => new Product[]
        {
            new Product{ProductID = 1,
                        ProductName = "Пицца Пепперони",
                        ProductDescription = "35 см, традиционное тесто, 760 г Пикантная пепперони, увеличенная порция моцареллы, фирменный томатный соус",
                        ProductPrice = 749,
                        ProductUnit = 1},
            new Product{ProductID = 2,
                        ProductName = "Пицца Сырная",
                        ProductDescription = "35 см, традиционное тесто, 670 г Моцарелла, сыры чеддер и пармезан, фирменный соус альфредо",
                        ProductPrice = 609,
                        ProductUnit = 2},
            new Product{ProductID = 3,
                        ProductName = "Пицца Ветчина и сыр",
                        ProductDescription = "35 см, традиционное тесто, 670 г Ветчина, моцарелла, фирменный соус альфредо",
                        ProductPrice = 689,
                        ProductUnit = 3},
            new Product{ProductID = 4,
                        ProductName = "Пицца Сырный цыпленок",
                        ProductDescription = "35 см, традиционное тесто, 870 гЦыпленок, моцарелла, сыры чеддер и пармезан, сырный соус, томаты, фирменный соус альфредо, чеснок",
                        ProductPrice = 799,
                        ProductUnit = 4},
            new Product{ProductID = 5,
                        ProductName = "Пицца Песто",
                        ProductDescription = "35 см, традиционное тесто, 860 г Цыпленок, соус песто, кубики брынзы, томаты, моцарелла, фирменный соус альфредо",
                        ProductPrice = 799,
                        ProductUnit = 5},
            new Product{ProductID = 6,
                        ProductName = "Пицца Мясная",
                        ProductDescription = "35 см, традиционное тесто, 860 г Цыпленок, соус песто, кубики брынзы, томаты, моцарелла, фирменный соус альфредо",
                        ProductPrice = 799,
                        ProductUnit = 6},
            new Product{ProductID = 7,
                        ProductName = "Пицца Цыпленок карри",
                        ProductDescription = "35 см, традиционное тесто, 870 г Цыпленок, ананасы, соус карри, красный лук, сладкий перец, моцарелла, фирменный томатный соус",
                        ProductPrice = 749,
                        ProductUnit = 7},
            new Product{ProductID = 8,
                        ProductName = "Пицца Четыре сыра",
                        ProductDescription = "35 см, традиционное тесто, 690 г Сыр блю чиз, смесь сыров чеддер и пармезан, моцарелла, фирменный соус альфредо",
                        ProductPrice = 799,
                        ProductUnit = 8},
            new Product{ProductID = 9,
                        ProductName = "Пицца Ветчина и грибы",
                        ProductDescription = "35 см, традиционное тесто, 810 г Ветчина, шампиньоны, увеличенная порция моцареллы, фирменный томатный соус",
                        ProductPrice = 689,
                        ProductUnit = 9},
            new Product{ProductID = 10,
                        ProductName = "Пицца Колбаски барбекю",
                        ProductDescription = "35 см, традиционное тесто, 650 г Острая чоризо, соус барбекю, томаты, красный лук, моцарелла, фирменный томатный соус",
                        ProductPrice = 749,
                        ProductUnit = 10},
            new Product{ProductID = 11,
                        ProductName = "Пицца Маргарита",
                        ProductDescription = "35 см, традиционное тесто, 850 г Увеличенная порция моцареллы, томаты, итальянские травы, фирменный томатный соус",
                        ProductPrice = 689,
                        ProductUnit = 11},
            new Product{ProductID = 12,
                        ProductName = "Пицца Цыпленок барбекю",
                        ProductDescription = "35 см, традиционное тесто, 930 г Цыпленок, бекон, соус барбекю, красный лук, моцарелла, фирменный томатный соус",
                        ProductPrice = 949,
                        ProductUnit = 12}
        };
        #endregion
    }
}
