using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Models;

namespace OneToManyDemo.Data
{
    public class SeedData
    {
       public static void AddRecords(ModelBuilder modelBuilder)
        {

            // seeding data
            modelBuilder.Entity<Auteur>().HasData(
                               new Auteur { AuteurId = 1, Naam = "Alain CHarlier" },
                               new Auteur { AuteurId = 2, Naam = "Rick Rizka" },
                               new Auteur { AuteurId = 3, Naam = "Deny Pratama" },
                               new Auteur { AuteurId = 4, Naam = "David vander vaken" }
            );

            modelBuilder.Entity<Boek>().HasData(
                               new Boek { BoekId = 1, Titel = "Asp.Net", AuteurId = 1 },
                               new Boek { BoekId = 2, Titel = "C# For beginer", AuteurId = 2 },
                               new Boek { BoekId = 3, Titel = "SQL Server", AuteurId = 1 },
                               new Boek { BoekId = 4, Titel = "EF Core", AuteurId = 3 },
                               new Boek { BoekId = 5, Titel = "De wereld van .NET", AuteurId = 4 },
                               new Boek { BoekId = 6, Titel = "De avonturen van Code 8", AuteurId = 2 },
                               new Boek { BoekId = 7, Titel = "HTML", AuteurId = 4 },
                               new Boek { BoekId = 8, Titel = "CSS", AuteurId = 3 }
           );
        }
    }
}
