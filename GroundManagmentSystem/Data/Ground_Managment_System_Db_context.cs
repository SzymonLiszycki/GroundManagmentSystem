
using GroundManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace GroundManagmentSystem.Data
{
    public class Ground_Managment_System_Db_context :DbContext
    { 
        public Ground_Managment_System_Db_context(DbContextOptions<Ground_Managment_System_Db_context>options)  :base (options)
        {
            
        }
        public DbSet<ISA_Model> ISA_Models { get; set; }
        public DbSet<Line_Model> Line_Models { get; set; }
    }
}
