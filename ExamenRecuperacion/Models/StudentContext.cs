﻿using Microsoft.EntityFrameworkCore;

namespace ExamenRecuperacion.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }


    }
}
