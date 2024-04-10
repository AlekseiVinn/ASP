using AcademicPerformanceLog_MVC.Data;
using Microsoft.EntityFrameworkCore;

namespace AcademicPerformanceLog_MVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PerformanceLogContext(
                                        serviceProvider.GetRequiredService<DbContextOptions<PerformanceLogContext>>()))
            {
                if (context == null || context.Disciplines == null)
                {
                    throw new ArgumentNullException("Null context");
                }
                if (context.Disciplines.Any())
                    return;

                context.Disciplines.AddRange(
                    new Discipline
                    {
                        Name = "Технологии программирования"
                    },
                    new Discipline
                    {
                        Name = "Введение в базы данных"
                    },
                    new Discipline
                    {
                        Name = "Программирование на C#"
                    },
                    new Discipline
                    {
                        Name = "PostgreSQL"
                    },
                    new Discipline
                    {
                        Name = "Разработка WinApp на C#"
                    });
                
                context.SaveChanges();
            }
            
        }
    }
}
