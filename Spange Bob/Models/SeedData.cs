

using Microsoft.EntityFrameworkCore;

namespace Spange_Bob.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Homes.Any())
                {
                    return;
                }

                var homes = new List<Home>
                {
                    new Home
                    {
                        HomeType = "Rock",
                        IsNeighbour = true
                    },
                    new Home
                    {
                        HomeType = "Chum Backet",
                        IsNeighbour = false
                    },
                    new Home
                    {
                        HomeType = "FACE",
                        IsNeighbour = true
                    },
                    new Home
                    {
                        HomeType = "Anchor",
                        IsNeighbour = false
                    }
                };

                var friends = new List<Friend>
                {
                    new Friend
                    {
                        FirstName = "Patrick",
                        LastName = "???",
                        Job = "don't have work",
                        JobPlace = "???",
                        SkinColor = "pink",
                        Home = homes[0]
                    },
                    new Friend
                    {
                        FirstName = "Sheldon",
                        LastName = "Plancton",
                        Job = "creater of chum backet",
                        JobPlace = "chum backet",
                        SkinColor = "green",
                        Home = homes[1]
                    },
                    new Friend
                    {
                        FirstName = "Skuidward",
                        LastName = "Tentacles",
                        Job = "cashier",
                        JobPlace = "Krasty krab",
                        SkinColor = "gray",
                        Home = homes[2]
                    },
                    new Friend
                    {
                        FirstName = "Mr.Krabs",
                        LastName = "???",
                        Job = "owner Krasty krab",
                        JobPlace = "Krasty krab",
                        SkinColor = "red",
                        Home = homes[3]
                    }
                };

                homes.ForEach(x => context.Homes.Add(x));
                friends.ForEach(x => context.Friends.Add(x));

                context.SaveChanges();
            }
        }
    }
}
