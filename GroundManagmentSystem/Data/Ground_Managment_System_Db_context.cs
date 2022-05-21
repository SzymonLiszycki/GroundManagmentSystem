
using GroundManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace GroundManagmentSystem.Data
{
    public class Ground_Managment_System_Db_context :DbContext
    {
        protected readonly IConfiguration Configuration;
        public Ground_Managment_System_Db_context(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        public DbSet<ISA_Model> ISA_Models { get; set; }
        
    }
}
