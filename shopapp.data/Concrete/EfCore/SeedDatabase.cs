using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Perde",Url="perde"},
            new Category(){Name="Çeyiz",Url="çeyiz"},
            new Category(){Name="Çadır",Url="çadır"},
            new Category(){Name="Diğer ",Url="diğer"}
        };

        private static Product[] Products = {
            new Product(){Name="Perde",Url="perde-tül",Price=20.0,ImageUrl="1.jpg",Description="Balkon Perde", IsApproved=true},
            new Product(){Name="Perde",Url="perde-balkon",Price=30.0,ImageUrl="2.jpg",Description="Saten Perde", IsApproved=false},
            new Product(){Name="Çadır",Url="oyun-çadırı",Price=100.0,ImageUrl="3.jpg",Description="Oyun Çadırı", IsApproved=true},
            new Product(){Name="Battaniye",Url="battaniye",Price=200.0,ImageUrl="4.jpg",Description="Renkli Battaniye", IsApproved=false},
            new Product(){Name="Diğer",Url="Diğer",Price=50.0,ImageUrl="5.jpg",Description="Çeyizlik", IsApproved=true},
        };

        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
        };
    }
}