using AnddysFootware.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnddysFootware.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcAndyContext(serviceProvider.GetRequiredService<DbContextOptions<MvcAndyContext>>()))
            {
                if (context.AndysFootware.Any())
                {
                    return;
                }

                context.AndysFootware.AddRange(
                    new AndysFootware
                    {
                        companyName = "Nike",
                        category = "Running",
                        modelName = "Air Jordon",
                        color="Yellow",
                        size=9,
                        rating=4
                    },
                    new AndysFootware
                    {
                        companyName = "Gap",
                        category = "Classic",
                        modelName = "Lofer",
                        color = "Brown",
                        size = 7,
                        rating = 5
                    },
                    new AndysFootware
                    {
                        companyName = "Addi",
                        category = "Slipper",
                        modelName = "flipflop",
                        color = "Green",
                        size = 8,
                        rating = 3
                    },
                    new AndysFootware
                    {
                        companyName = "Puma",
                        category = "Classic",
                        modelName = "Jordon",
                        color = "Green",
                        size = 5,
                        rating = 2
                    },
                    new AndysFootware
                    {
                        companyName = "Nike",
                        category = "Higher",
                        modelName = "Kid",
                        color = "Blue",
                        size = 3,
                        rating = 4
                    },
                    new AndysFootware
                    {
                        companyName = "Puma",
                        category = "golf",
                        modelName = "Air Jordon",
                        color = "White",
                        size = 11,
                        rating = 1
                    },
                    new AndysFootware
                    {
                        companyName = "Nike",
                        category = "Classic",
                        modelName = "Air Jordon",
                        color = "Blue",
                        size = 7,
                        rating = 4
                    },
                    new AndysFootware
                    {
                        companyName = "Aldo",
                        category = "formal",
                        modelName = "formal",
                        color = "black",
                        size = 9,
                        rating = 5
                    },
                    new AndysFootware
                    {
                        companyName = "Walmart",
                        category = "working",
                        modelName = "Safty",
                        color = "yellow",
                        size = 8,
                        rating = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
