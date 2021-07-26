using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
       
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new RazorPagesMovieContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<RazorPagesMovieContext>>()))
                {
                    // Look for any movies.
                    if (context.Movie.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            RealeaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Rating = "S"
                        },

                        new Movie
                        {
                            Title = "Ghostbusters ",
                            RealeaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Price = 8.99M,
                            Rating = "S"
                        },

                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            RealeaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Price = 9.99M,
                            Rating = "S"
                        },

                        new Movie
                        {
                            Title = "Rio Bravo",
                            RealeaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Price = 5.99M,
                            Rating = "S"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }

