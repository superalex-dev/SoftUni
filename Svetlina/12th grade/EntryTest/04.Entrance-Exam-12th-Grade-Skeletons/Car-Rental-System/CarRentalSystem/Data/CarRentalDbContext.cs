using CarRentalSystem.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Data
{
    public class CarRentalDbContext : IdentityDbContext<ApplicationUser>
    {
        private Category HatchbackCategory { get; set; }
        private Category SedanCategory { get; set; }
        private Category SUVCategory { get; set; }
        private Category CrossoverCategory { get; set; }
        private Category CoupeCategory { get; set; }

        private bool seedDb = true;
        private ApplicationUser GuestUser { get; set; }
        private Dealer GuestUserDealer { get; set; }

        public CarRentalDbContext
            (DbContextOptions<CarRentalDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
            this.Database.EnsureCreated();
        }

        public DbSet<Car> Cars { get; init; }
        public DbSet<Category> Categories { get; init; }
        public DbSet<Dealer> Dealers { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (seedDb)
            {
                builder
               .Entity<Car>()
               .HasOne(c => c.Category)
               .WithMany(cat => cat.Cars)
               .HasForeignKey(x => x.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

                builder
                    .Entity<Car>()
                    .HasOne(d => d.Dealer)
                    .WithMany()
                    .HasForeignKey(c => c.DealerId)
                    .OnDelete(DeleteBehavior.Restrict);

                SeedUser();
                builder.Entity<ApplicationUser>()
                    .HasData(this.GuestUser);

                SeeDealer();
                builder.Entity<Dealer>()
                    .HasData(this.GuestUserDealer);

                SeedCategories();
                builder.Entity<Category>()
               .HasData(
               this.HatchbackCategory,
               this.SedanCategory,
               this.SUVCategory,
               this.CoupeCategory,
               this.CrossoverCategory);

                builder.Entity<Car>()
                    .HasData(new Car()
                    {
                        Id = 1,
                        Make = "Citroen",
                        Model = "C5 X",
                        Description = "So it’s a good thing that the C5 X’s ride is so comfortable. Around town you sail over lumps and bumps in the road, and on the motorway you feel like you’re wafting on a cloud.",
                        PricePerDay = 45.99M,
                        ImageUrl = "https://car-data.carwow.co.uk/image?filter%5Bangle%5D=front&filter%5Bbrand_slug%5D=citroen&filter%5Bmodel_review_slug%5D=c5-x-2022&filter%5Bsize%5D=400",
                        CategoryId = 1,
                        DealerId = GuestUserDealer.Id
                    },
                    new Car()
                    {
                        Id = 2,
                        Make = "FIAT",
                        Model = "500X",
                        Description = "The Fiat 500X is a five-seat subcompact SUV powered by a standard 177-horsepower, turbocharged 1.3-liter four-cylinder engine that pairs with a nine-speed automatic transmission.",
                        PricePerDay = 64.99M,
                        ImageUrl = "https://car-data.carwow.co.uk/image?filter%5Bangle%5D=front&filter%5Bbrand_slug%5D=fiat&filter%5Bmodel_review_slug%5D=500X&filter%5Bsize%5D=400",
                        CategoryId = 5,
                        DealerId = GuestUserDealer.Id
                    },
                    new Car()
                    {
                        Id = 3,
                        Make = "Mercedes",
                        Model = "S-Class",
                        Description = "For starters, both of its engines – V8 and V12 – are brilliant, and its interior is one of the best on sale, featuring a striking design and tip-top build quality.",
                        PricePerDay = 65.00M,
                        ImageUrl = "https://car-data.carwow.co.uk/image?filter%5Bbrand_slug%5D=mercedes&filter%5Bcolour%5D=grey%2Csilver%2Cblack%2Cwhite&filter%5Bmodel_review_slug%5D=S-Class-Coupe",
                        CategoryId = 4,
                        DealerId = GuestUserDealer.Id
                    },
                    new Car()
                    {
                        Id = 4,
                        Make = "Toyota",
                        Model = "GT86",
                        Description = "The Toyota GT86 was made by people who wanted to make one of the world’s best driver’s cars – and they’ve done a bang-up job! This sporty coupe is huge fun to drive. Feels a bit cheap on the inside, however.",
                        PricePerDay = 76.00M,
                        ImageUrl = "https://car-data.carwow.co.uk/image?filter%5Bbrand_slug%5D=toyota&filter%5Bcolour%5D=grey%2Csilver%2Cblack%2Cwhite&filter%5Bmodel_review_slug%5D=GT86",
                        CategoryId = 4,
                        DealerId = GuestUserDealer.Id
                    });

            }

            base.OnModelCreating(builder);
        }

        private void SeedCategories()
        {
            this.HatchbackCategory = new Category()
            {
                Id = 1,
                Name = "Hatchback"
            };

            this.SedanCategory = new Category()
            {
                Id = 2,
                Name = "Sedan"
            };

            this.SUVCategory = new Category()
            {
                Id = 3,
                Name = "SUV"
            };

            this.CoupeCategory = new Category()
            {
                Id = 4,
                Name = "Coupe"
            };

            this.CrossoverCategory = new Category()
            {
                Id = 5,
                Name = "Crossover"
            };

        }
        private void SeedUser()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            this.GuestUser = new ApplicationUser()
            {
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM"
            };

            this.GuestUser.PasswordHash = hasher.HashPassword(this.GuestUser, "guest123");
        }
        private void SeeDealer()
        {
            this.GuestUserDealer = new Dealer()
            {
                Id = 1,
                PhoneNumber = "0808080808",
                UserId = this.GuestUser.Id
            };
        }
    }
}
