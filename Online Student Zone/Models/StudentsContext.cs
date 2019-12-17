using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Online_Student_Zone.Models
{
    public class StudentsContext:DbContext
    {
        public DbSet<Students> Students { get; set; }
    }
}