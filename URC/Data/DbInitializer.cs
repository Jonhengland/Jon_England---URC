/*
Author: Peter Forsling
Date: 24 September 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the Database Initializer, used to seed the database.
*/

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using URC.Models;

namespace URC.Data
{
    /// <summary>
    /// Initializes the Database if there isn't one
    /// </summary>
    public static class DbInitializer
    {

        /// <summary>
        /// Initializes the database if there isn't one
        /// </summary>
        /// <param name="context">The database to be seeded</param>
        public static void Initialize(URCContext context)
        {
            context.Database.EnsureCreated();

            // Look for any opportunities
            if (context.Opportunities.Any())
            {
                return;   // DB has been seeded
            }

            var opportunities = new Opportunity[]
            {
                new Opportunity
                {
                    ProjectName="DFA Compiler",
                    ProfessorName="Erin Parker",
                    ProjectDescription="Analyze DFAs for efficient compilers",
                    Image="/Images/DFA.jpg",
                    MentorName="Daisy",
                    BeginDate=new DateTime(2020, 9, 23, 0, 0, 0),
                    EndDate=new DateTime(2020, 9, 24, 0, 0, 0),
                    Pay=103014102100242044.00,
                    Filled=false,
                    Tags=new List<Tag>()
                },
                new Opportunity
                {
                    ProjectName="How to Design Programs",
                    ProfessorName="Matthew Flatt",
                    ProjectDescription="5 steps of designing a program effectively",
                    Image="/Images/lambda.png",
                    MentorName="Racket",
                    BeginDate=new DateTime(2000, 9, 23, 0, 0, 0),
                    EndDate=new DateTime(2100, 6, 6, 0, 0, 0),
                    Pay=35.20,
                    Filled=true,
                    Tags=new List<Tag>()
                },
                new Opportunity
                {
                    ProjectName="Sick OS Databasing",
                    ProfessorName="Ryan Stutsman",
                    ProjectDescription="Build an efficient distributed database",
                    Image="/Images/ubuntu20logo.jpg",
                    MentorName="Ankit",
                    BeginDate=new DateTime(2020, 1, 8, 0, 0, 0),
                    EndDate=new DateTime(2020, 5, 4, 0, 0, 0),
                    Pay=54.60,
                    Filled=false,
                    Tags=new List<Tag>()
                },
                new Opportunity
                {
                    ProjectName="Power Saving Computer Architecture",
                    ProfessorName="Mahdi Bojnordi",
                    ProjectDescription="Design an energy efficient machine",
                    Image="/Images/IntelPentiumCPU.png",
                    MentorName="Sarabjeet",
                    BeginDate=new DateTime(2019, 1, 12, 0, 0, 0),
                    EndDate=new DateTime(2020, 5, 1, 0, 0, 0),
                    Pay=38.10,
                    Filled=true,
                    Tags=new List<Tag>()
                },
                new Opportunity
                {
                    ProjectName="Make LLVM but better",
                    ProfessorName="John Regehr",
                    ProjectDescription="LLVM isn't good enough",
                    Image="/Images/llvm.jpg",
                    MentorName="Prof. Regehr's cats",
                    BeginDate=new DateTime(2019, 8, 21, 0, 0, 0),
                    EndDate=new DateTime(2019, 12, 15, 0, 0, 0),
                    Pay=10.30,
                    Filled=false,
                    Tags=new List<Tag>()
                },
            };

            context.Opportunities.AddRange(opportunities);
            context.SaveChanges();

            var requiredSkills = new RequiredSkill[]
            {
                new RequiredSkill {OpportunityID=3, Skill="Compiler"},
                new RequiredSkill {OpportunityID=4, Skill="Functional Programming"},
                new RequiredSkill {OpportunityID=5, Skill="xv6"},
                new RequiredSkill {OpportunityID=6, Skill="Moore's Law"},
                new RequiredSkill {OpportunityID=7, Skill="LLVM"}
            };

            context.RequiredSkills.AddRange(requiredSkills);
            context.SaveChanges();

            var tags = new Tag[]
            {
                new Tag{OpportunityID=3, TheTag="Compilers"},
                new Tag{OpportunityID=4, TheTag="Programming Languages"},
                new Tag{OpportunityID=5, TheTag="Operating Systems"},
                new Tag{OpportunityID=6, TheTag="Computer Organization"},
                new Tag{OpportunityID=7, TheTag="Compilers"},
            };

            context.Tags.AddRange(tags);
            context.SaveChanges();
        }
    }
}
