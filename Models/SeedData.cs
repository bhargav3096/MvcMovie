using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "3 Idiots",
                    ReleaseDate = DateTime.Parse("2012-12-25"),
                    Genre = "Comedy",
                    Price = 10,
                    Rating = "9"
                  
                },
                new Movie
                {
                    Title = "OMG! ",
                    ReleaseDate = DateTime.Parse("2012-06-30"),
                    Genre = "Comedy",
                    Price = 11,
                    Rating = "9"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2010-10-25"),
                    Genre = "Superhero",
                    Price = 20,
                    Rating = "9.8"    
                },
                new Movie
                {
                    Title = "ABCD",
                    ReleaseDate = DateTime.Parse("2014-02-08"),
                    Genre = "Dance",
                    Price = 15,
                    Rating = "5.9"
                },
                 new Movie
                 {
                     Title = "All the Best",
                     ReleaseDate = DateTime.Parse("2015-12-23"),
                     Genre = "Comedy",
                     Price = 10,
                     Rating = "6.7"
                 },
                   new Movie
                   {
                       Title = "Golmaal",
                       ReleaseDate = DateTime.Parse("1996-10-25"),
                       Genre = "Comedy",
                       Price = 25,
                       Rating = "7.9"
                   }
            );
            context.SaveChanges();
        }
    }
}
