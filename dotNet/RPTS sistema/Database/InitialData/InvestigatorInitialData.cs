using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Models;
using RPTS_sistema.Service;
using RPTS_sistema.Service.IService;
using System.Data;
using System.Xml.Linq;

namespace RPTS_sistema.Database.InitialData
{
    public static class InvestigatorInitialData
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalUser>().HasData(
                CreateUser(1, "Admin", "Admin", "justinaskersys@gmail.com", "Admin", "Admin"),
                CreateUser(2, "Veronika", "Dabulskienė", "v.dabulskiene@litfood.lt", "Investigator", "Veronika"),
                CreateUser(3, "Irmantas", "Baltūsis", "i.baltusis@litfood.lt", "Investigator", "Irmantas"),
                CreateUser(4, "Audrius", "Marcinkus", "a.marcinkus@litfood.lt", "Director", "Audrius"),
                CreateUser(5, "Gabrielė", "Markevičiūtė", "g.markeviciute@litfood.lt", "Investigator", "Gabrielė"),
                CreateUser(6, "Justinas", "Keršys", "j.kersys@litfood.lt", "Investigator", "Justinas"),
                CreateUser(7, "Laura", "Matusevičienė", "l.matuseviciene@litfood.lt", "Investigator", "Laura"),
                CreateUser(8, "Ignas", "Zlatkus", "i.zlatkus@litfood.lt", "Investigator", "Ignas"),
                CreateUser(9, "Giedrė", "Markevičienė", "g.markeviciene@litfood.lt", "Investigator", "Giedrė"),
                CreateUser(10, "Lina", "Danauskienė", "l.danauskiene@litfood.lt", "Investigator", "Laura"),
                CreateUser(11, "Žyvilė", "Kravecienė", "z.kraveciene@litfood.lt", "Investigator", "Žyvilė"),
                CreateUser(12, "Audrius", "Karvelis", "a.karvelis@litfood.lt", "Investigator", "Audrius")
            );
        }

        public static LocalUser CreateUser(int id, string name, string lastname, string email, string role, string password)
        {
            var admin = new LocalUser();
            var passwordService = new PasswordService();
            byte[] passwordSalt;
            byte[] passwordHash;

            passwordService.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            admin.Id = id;
            admin.Name = name;
            admin.Lastname = lastname;
            admin.Email = email;
            admin.Role = (UserRole)Enum.Parse(typeof(UserRole), role);
            admin.PasswordHash = passwordHash;
            admin.PasswordSalt = passwordSalt;

            return admin;
        }
    }
}         




//        public static readonly LocalUser[] DataSeed = new LocalUser[] {

//            new LocalUser
//            {
//                Id = 1,
//                Name = "Admin",
//                Lastname = "Admin",
//                Email = "justinaskersys@gmail.com",
//                Role = UserRole.Admin,
//                PasswordHash =
//                StillWorking = true,
//            },
//            new LocalUser
//            {
//                Id = 2,
//                Name = "Veronika",
//                Lastname = "Dabulskienė",
//                Email = "v.dabulskiene@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = false,
//            },
//             new LocalUser
//            {
//                Id = 3,
//                Name = "Irmantas",
//                Lastname = "Baltūsis",
//                Email = "i.baltusis@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = false,
//            },
//              new LocalUser
//            {
//                Id = 4,
//                Name = "Audrius",
//                Lastname = "Marcinkus",
//                Email = "a.marcinkus@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//               new LocalUser
//            {
//                Id = 5,
//                Name = "Gabrielė",
//                Lastname = "Markevičiūtė",
//                Email = "g.markeviciute@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//                new LocalUser
//            {
//                Id = 6,
//                Name = "Justinas",
//                Lastname = "Keršys",
//                Email = "j.kersys@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//                new LocalUser
//            {
//                Id = 7,
//                Name = "Laura",
//                Lastname = "Matusevičienė",
//                Email = "l.matuseviciene@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//                new LocalUser
//            {
//                Id = 8,
//                Name = "Ignas ",
//                Lastname = "Zlatkus",
//                Email = "i.zlatkus@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//                new LocalUser
//            {
//                Id = 9,
//                Name = "Giedrė",
//                Lastname = "Markevičienė",
//                Email = "g.markeviciene@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//                new LocalUser
//            {
//                Id = 10,
//                Name = "Lina",
//                Lastname = "Danauskienė",
//                Email = "l.danauskiene@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },
//                new LocalUser
//            {
//                Id = 11,
//                Name = "Žyvilė",
//                Lastname = "Kravecienė",
//                Email = "z.kraveciene@litfood.lt",
//                Role = UserRole.Investigator,
//                StillWorking = true,
//            },



//        };
//    }
//}
