using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Data
{
    public class AnswerImageDataContext : DbContext
    {
        public DbSet<AnswerImage> AnswerImages
        { 
            get; 
          set; }

        public AnswerImageDataContext(DbContextOptions<AnswerImageDataContext> options)
           : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerImage>().ToTable("AnswerImage");
        }

    }
}