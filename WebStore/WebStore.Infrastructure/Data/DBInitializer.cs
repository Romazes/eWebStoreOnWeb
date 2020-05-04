using System.Linq;
using WebStore.Core.Entities;

namespace WebStore.Infrastructure.Data
{
    public static class DBInitializer
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Category entries
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            #region Seed Categories
            var сategories = new Category[]
            {
                new Category { CategoryName="Red tea", Description="Chinese red tea is a highly fermented tea" },
                new Category { CategoryName="Puer", Description="The most popular variety of Chinese tea today, shu puer" },
                new Category { CategoryName="Green tea", Description="Represents the largest category of Chinese teas" }
            };

            foreach (Category c in сategories)
            {
                context.Categories.Add(c);
            }

            context.SaveChanges();
            #endregion

            #region Seed Products
            var products = new Product[]
            {
                new Product
                {
                    Name = "Red tea 1",
                    Price = 12.95M,
                    ShortDescription = "Our marvellous Red Tea 1!",
                    LongDescription =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 1,
                    ImageUrl = "/Images/Tea/redtea.jpg",
                    InStock = true,
                    IsProductOfTheWeek = true,
                    ImageThumbnailUrl = "/Images/Tea/redteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Puer 1",
                    Price = 18.95M,
                    ShortDescription = "Famously known for its taste - Puer 1",
                    LongDescription =
                        "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",
                    CategoryId = 2,
                    ImageUrl = "/Images/Tea/puer.jpg",
                    InStock = true,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/puersm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Green Tea 1",
                    Price = 18.95M,
                    ShortDescription = "Our Grean Tea 1 is a miracle",
                    LongDescription =
                        "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                    CategoryId = 3,
                    ImageUrl = "/Images/Tea/greentea.jpg",
                    InStock = true,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/greenteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Red tea 2",
                    Price = 15.95M,
                    ShortDescription = "Our marvellous Red Tea 2!",
                    LongDescription =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 1,
                    ImageUrl = "/Images/Tea/redtea.jpg",
                    InStock = true,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/redteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Puer 2",
                    Price = 13.95M,
                    ShortDescription = "Famously known for its taste - Puer 2",
                    LongDescription =
                        "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",
                    CategoryId = 2,
                    ImageUrl = "/Images/Tea/puer.jpg",
                    InStock = true,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/puersm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Green Tea 2",
                    Price = 17.95M,
                    ShortDescription = "Our Grean Tea 2 is a miracle",
                    LongDescription =
                        "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                    CategoryId = 3,
                    ImageUrl = "/Images/Tea/greentea.jpg",
                    InStock = true,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/greenteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Red tea 3",
                    Price = 15.95M,
                    ShortDescription = "Our marvellous Red Tea 3!",
                    LongDescription =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 1,
                    ImageUrl = "/Images/Tea/redtea.jpg",
                    InStock = false,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/redteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Puer 3",
                    Price = 12.95M,
                    ShortDescription = "Famously known for its taste - Puer 3",
                    LongDescription =
                        "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",
                    CategoryId = 2,
                    ImageUrl = "/Images/Tea/puer.jpg",
                    InStock = true,
                    IsProductOfTheWeek = true,
                    ImageThumbnailUrl = "/Images/Tea/puersm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Green Tea 3",
                    Price = 15.95M,
                    ShortDescription = "Our Grean Tea 3 is a miracle",
                    LongDescription =
                        "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                    CategoryId = 3,
                    ImageUrl = "/Images/Tea/greentea.jpg",
                    InStock = true,
                    IsProductOfTheWeek = true,
                    ImageThumbnailUrl = "/Images/Tea/greenteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Red tea 4",
                    Price = 15.95M,
                    ShortDescription = "Our marvellous Red Tea 3!",
                    LongDescription =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 1,
                    ImageUrl = "/Images/Tea/redtea.jpg",
                    InStock = true,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/redteasm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Puer 4",
                    Price = 18.95M,
                    ShortDescription = "Famously known for its taste - Puer 4",
                    LongDescription =
                        "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.",
                    CategoryId = 2,
                    ImageUrl = "/Images/Tea/puer.jpg",
                    InStock = false,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/puersm.jpg",
                    AllergyInformation = ""
                },

                new Product
                {
                    Name = "Green Tea 4",
                    Price = 18.95M,
                    ShortDescription = "Our Grean Tea 4 is a miracle",
                    LongDescription =
                        "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                    CategoryId = 3,
                    ImageUrl = "/Images/Tea/greentea.jpg",
                    InStock = false,
                    IsProductOfTheWeek = false,
                    ImageThumbnailUrl = "/Images/Tea/greenteasm.jpg",
                    AllergyInformation = ""
                }

            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
            #endregion
        }
    }
}