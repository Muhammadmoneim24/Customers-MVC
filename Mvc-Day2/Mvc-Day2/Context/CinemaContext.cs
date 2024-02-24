using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Mvc_Day2.Models;
using System.Data;

namespace Mvc_Day2.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            //default connectionstring      
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer() {Id=1, Name="Ahmed", BirthDate=new DateTime(), IsSubscribedToNewLitter=false, MembershipTypeId=1,NumberOfWatchedMovies=5 },
                new Customer() {Id=2, Name="Mohamed", BirthDate=new DateTime(), IsSubscribedToNewLitter=true, MembershipTypeId=2,NumberOfWatchedMovies=2 },
                new Customer() {Id=3, Name="Ali", BirthDate=new DateTime(), IsSubscribedToNewLitter=false, MembershipTypeId=4,NumberOfWatchedMovies=10 },
                new Customer() {Id=4, Name="Mona", BirthDate=new DateTime(), IsSubscribedToNewLitter=true, MembershipTypeId=3,NumberOfWatchedMovies=3 }
            }
                );

            modelBuilder.Entity<MembershipType>().HasData(new MembershipType[]
            {
                new MembershipType(){Id=1, Name="pay as you go", SingUpFee=50, DiscountRate=20, DurationInMonths=1},
                new MembershipType(){Id=2, Name="monthly", SingUpFee=100, DiscountRate=20, DurationInMonths=1} ,
                new MembershipType(){Id=3, Name="Quartarly", SingUpFee=400, DiscountRate=20, DurationInMonths=4}   ,
                new MembershipType(){Id=4, Name="Annual", SingUpFee=1000, DiscountRate=20, DurationInMonths=12}
            }

                );
        }


    }

}
