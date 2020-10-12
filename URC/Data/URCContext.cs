/*
Author: Peter Forsling
Date: 24 September 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the scaffolded database
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using URC.Models;

namespace URC.Data
{
    /// <summary>
    /// The backing database for this entire application
    /// </summary>
    public class URCContext : DbContext
    {
        public URCContext (DbContextOptions<URCContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Opportunities DB Entity Set
        /// </summary>
        public DbSet<Opportunity> Opportunities { get; set; }

        /// <summary>
        /// RequiredSkills DB Entity Set
        /// </summary>
        public DbSet<RequiredSkill> RequiredSkills { get; set; }
        
        /// <summary>
        /// Tags DB Entity Set
        /// </summary>
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Opportunity>().ToTable("Opportunity");
            modelBuilder.Entity<RequiredSkill>().ToTable("RequiredSkill");
            modelBuilder.Entity<Tag>().ToTable("Tag");
        }
    }
}
