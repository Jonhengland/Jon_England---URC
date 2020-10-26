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

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using URC.Areas.Identity.Data;
using URC.Models;

namespace URC.Data
{
    /// <summary>
    /// Initializes the Database if there isn't one
    /// </summary>
    public static class DbInitializer
    {

        public static void Initialize(URCContext context)
        {
            context.Database.EnsureCreated();

            if (context.Opportunities.Any())
            {
                return;
            }

            Opportunity[] oppsToSeed = new Opportunity[]
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
                new Opportunity
                {
                    ProjectName = "generic research",
                    ProfessorName = "professor",
                    ProjectDescription = "research stuff",
                    Image = "/Images/generic_cola.jpg",
                    MentorName = "gene",
                    BeginDate = new DateTime(2020, 10, 23, 0, 0, 0),
                    EndDate = new DateTime(2020, 10, 24, 0, 0, 0),
                    Pay = 7.50,
                    Filled = false,
                    Tags = new List<Tag>()
                },
                new Opportunity
                {
                ProjectName = "Parallelizing Convolutional Neural Network",
                ProfessorName = "professor_mary",
                ProjectDescription = "analyze the performance vs cost factor of parallelizing convolutional neural networks with OpenMP",
                Image = "/Images/openmp.gif",
                MentorName = "Marek Baranowski",
                BeginDate = new DateTime(2019, 8, 21, 0, 0, 0),
                EndDate = new DateTime(2019, 12, 3, 0, 0, 0),
                Pay = 8.00,
                Filled = true,
                Tags = new List<Tag>()
                }
           };

            List<Opportunity> oppsInDB = context.Opportunities.ToList();

            foreach (Opportunity opp in oppsToSeed)
            {
                if (oppsInDB.Contains(opp))
                {
                    continue;
                }
                context.Opportunities.Add(opp);
            }
            context.SaveChanges();

            oppsInDB = context.Opportunities.ToList();

            var reqSkillsToSeed = new RequiredSkill[]
            {
                new RequiredSkill {OpportunityID=oppsInDB[0].OpportunityID, Skill="Compiler"},
                new RequiredSkill {OpportunityID=oppsInDB[1].OpportunityID, Skill="Functional Programming"},
                new RequiredSkill {OpportunityID=oppsInDB[2].OpportunityID, Skill="xv6"},
                new RequiredSkill {OpportunityID=oppsInDB[3].OpportunityID, Skill="Moore's Law"},
                new RequiredSkill {OpportunityID=oppsInDB[4].OpportunityID, Skill="LLVM"},
                new RequiredSkill {OpportunityID=oppsInDB[4].OpportunityID, Skill="Compiler"}
            };

            List<RequiredSkill> oppSkillsInDB = context.RequiredSkills.ToList();

            foreach (RequiredSkill rs in reqSkillsToSeed)
            {
                if (oppSkillsInDB.Contains(rs))
                {
                    continue;
                }
                context.RequiredSkills.Add(rs);
            }
            context.SaveChanges();

            Tag[] tagsToSeed = new Tag[]
            {
                new Tag{OpportunityID=oppsInDB[0].OpportunityID, TheTag="Compilers"},
                new Tag{OpportunityID=oppsInDB[1].OpportunityID, TheTag="Programming Languages"},
                new Tag{OpportunityID=oppsInDB[2].OpportunityID, TheTag="Operating Systems"},
                new Tag{OpportunityID=oppsInDB[3].OpportunityID, TheTag="Computer Organization"},
                new Tag{OpportunityID=oppsInDB[4].OpportunityID, TheTag="Compilers"},
                new Tag{OpportunityID=oppsInDB[4].OpportunityID, TheTag="LLVM"}
            };

            List<Tag> tagsInDB = context.Tags.ToList();
            
            foreach (Tag tag in tagsToSeed)
            {
                if (tagsInDB.Contains(tag))
                {
                    continue;
                }
                context.Tags.Add(tag);
            }
            context.SaveChanges();

            Application[] appsToSeed = new Application[]
            {
                new Application
                {
                    Email="u0000000@utah.edu",
                    Resume="resume.pdf",
                    ExpectedGradDate = new DateTime(2020, 10, 24),
                    DegreePlan = "CS",
                    GPA = (float)3.5,
                    UID="u0000000",
                    HoursPerWeek=10,
                    PersonalStatement = "I am student 0 looking for an opportunity!",
                    ApplicationDate = new DateTime(2020, 10, 24),
                    Active = true,
                    CompletedCourses = new List<CompletedCourse>(),
                    Skills = new List<StudentSkill>(),
                    Interests = new List<StudentInterest>()
                },
                new Application
                {
                    Email="u0000001@utah.edu",
                    Resume="resume.pdf",
                    ExpectedGradDate = new DateTime(2020, 10, 24),
                    DegreePlan = "CE",
                    GPA = (float)3.0,
                    UID="u0000001",
                    HoursPerWeek=20,
                    PersonalStatement = "I am student 1 looking for an opportunity!",
                    ApplicationDate = new DateTime(2020, 10, 24),
                    Active = true,
                    CompletedCourses = new List<CompletedCourse>(),
                    Skills = new List<StudentSkill>(),
                    Interests = new List<StudentInterest>()
                }
            };

            List<Application> appsInDB = context.Applications.ToList();

            foreach (Application app in appsToSeed)
            {
                if (appsInDB.Contains(app))
                {
                    continue;
                }
                context.Applications.Add(app);
            }
            context.SaveChanges();

            appsInDB = context.Applications.ToList();

            CompletedCourse[] ccToSeed = new CompletedCourse[]
            {
                new CompletedCourse
                {
                    ApplicationID = appsInDB[0].ID,
                    Course = "CS 3500"
                },
                new CompletedCourse
                {
                    ApplicationID = appsInDB[1].ID,
                    Course = "CS 6955"
                }
            };

            List<CompletedCourse> coursesInDB = context.CompletedCourses.ToList();

            foreach (CompletedCourse cc in ccToSeed)
            {
                if (coursesInDB.Contains(cc))
                {
                    continue;
                }
                context.CompletedCourses.Add(cc);
            }
            context.SaveChanges();

            StudentInterest[] interestsToSeed = new StudentInterest[]
            {
                new StudentInterest
                {
                    ApplicationID = appsInDB[0].ID,
                    Interest = "Biking"
                },
                new StudentInterest
                {
                    ApplicationID = appsInDB[1].ID,
                    Interest = "Competitive Calligraphy"
                }
            };

            List<StudentInterest> interestsInDB = context.StudentInterests.ToList();

            foreach (StudentInterest si in interestsToSeed)
            {
                if (interestsInDB.Contains(si))
                {
                    continue;
                }
                context.StudentInterests.Add(si);
            }
            context.SaveChanges();

            StudentSkill[] skillsToSeed = new StudentSkill[]
            {
                new StudentSkill
                {
                    ApplicationID = appsInDB[0].ID,
                    Skill = "Java"
                },
                new StudentSkill
                {
                    ApplicationID = appsInDB[0].ID,
                    Skill = "C#"
                },
                new StudentSkill
                {
                    ApplicationID = appsInDB[0].ID,
                    Skill = "Python"
                },
                new StudentSkill
                {
                    ApplicationID = appsInDB[1].ID,
                    Skill = "C"
                },
                new StudentSkill
                {
                    ApplicationID = appsInDB[1].ID,
                    Skill = "C++"
                },
                new StudentSkill
                {
                    ApplicationID = appsInDB[1].ID,
                    Skill = "Java"
                }
            };

            List<StudentSkill> skillsInDB = context.StudentSkills.ToList();

            foreach (StudentSkill ss in skillsToSeed)
            {
                if (skillsInDB.Contains(ss))
                {
                    continue;
                }
                context.StudentSkills.Add(ss);
            }
            context.SaveChanges();
        }

        ///// <summary>
        ///// Initializes the database if there isn't one
        ///// </summary>
        ///// <param name="context">The database to be seeded</param>
        //public static void Initialize(URCContext context)
        //{
        //    context.Database.EnsureCreated();

        //    // Look for any opportunities
        //    if (context.Opportunities.Any())
        //    {
        //        return;   // DB has been seeded
        //    }

        //    var opportunities = new Opportunity[]
        //    {
        //        new Opportunity
        //        {
        //            ProjectName="DFA Compiler",
        //            ProfessorName="Erin Parker",
        //            ProjectDescription="Analyze DFAs for efficient compilers",
        //            Image="/Images/DFA.jpg",
        //            MentorName="Daisy",
        //            BeginDate=new DateTime(2020, 9, 23, 0, 0, 0),
        //            EndDate=new DateTime(2020, 9, 24, 0, 0, 0),
        //            Pay=103014102100242044.00,
        //            Filled=false,
        //            Tags=new List<Tag>()
        //        },
        //        new Opportunity
        //        {
        //            ProjectName="How to Design Programs",
        //            ProfessorName="Matthew Flatt",
        //            ProjectDescription="5 steps of designing a program effectively",
        //            Image="/Images/lambda.png",
        //            MentorName="Racket",
        //            BeginDate=new DateTime(2000, 9, 23, 0, 0, 0),
        //            EndDate=new DateTime(2100, 6, 6, 0, 0, 0),
        //            Pay=35.20,
        //            Filled=true,
        //            Tags=new List<Tag>()
        //        },
        //        new Opportunity
        //        {
        //            ProjectName="Sick OS Databasing",
        //            ProfessorName="Ryan Stutsman",
        //            ProjectDescription="Build an efficient distributed database",
        //            Image="/Images/ubuntu20logo.jpg",
        //            MentorName="Ankit",
        //            BeginDate=new DateTime(2020, 1, 8, 0, 0, 0),
        //            EndDate=new DateTime(2020, 5, 4, 0, 0, 0),
        //            Pay=54.60,
        //            Filled=false,
        //            Tags=new List<Tag>()
        //        },
        //        new Opportunity
        //        {
        //            ProjectName="Power Saving Computer Architecture",
        //            ProfessorName="Mahdi Bojnordi",
        //            ProjectDescription="Design an energy efficient machine",
        //            Image="/Images/IntelPentiumCPU.png",
        //            MentorName="Sarabjeet",
        //            BeginDate=new DateTime(2019, 1, 12, 0, 0, 0),
        //            EndDate=new DateTime(2020, 5, 1, 0, 0, 0),
        //            Pay=38.10,
        //            Filled=true,
        //            Tags=new List<Tag>()
        //        },
        //        new Opportunity
        //        {
        //            ProjectName="Make LLVM but better",
        //            ProfessorName="John Regehr",
        //            ProjectDescription="LLVM isn't good enough",
        //            Image="/Images/llvm.jpg",
        //            MentorName="Prof. Regehr's cats",
        //            BeginDate=new DateTime(2019, 8, 21, 0, 0, 0),
        //            EndDate=new DateTime(2019, 12, 15, 0, 0, 0),
        //            Pay=10.30,
        //            Filled=false,
        //            Tags=new List<Tag>()
        //        },
        //        new Opportunity
        //        {
        //            ProjectName = "generic research",
        //            ProfessorName = "professor",
        //            ProjectDescription = "research stuff",
        //            Image = "/Images/generic_cola.jpg",
        //            MentorName = "gene",
        //            BeginDate = new DateTime(2020, 10, 23, 0, 0, 0),
        //            EndDate = new DateTime(2020, 10, 24, 0, 0, 0),
        //            Pay = 7.50,
        //            Filled = false,
        //            Tags = new List<Tag>()
        //        },
        //        new Opportunity
        //        {
        //        ProjectName = "Parallelizing Convolutional Neural Network",
        //        ProfessorName = "professor_mary",
        //        ProjectDescription = "analyze the performance vs cost factor of parallelizing convolutional neural networks with OpenMP",
        //        Image = "/Images/openmp.gif",
        //        MentorName = "Marek Baranowski",
        //        BeginDate = new DateTime(2019, 8, 21, 0, 0, 0),
        //        EndDate = new DateTime(2019, 12, 3, 0, 0, 0),
        //        Pay = 8.00,
        //        Filled = true,
        //        Tags = new List<Tag>()
        //        }
        //    };

        //    context.Opportunities.AddRange(opportunities);
        //    context.SaveChanges();

        //    var requiredSkills = new RequiredSkill[]
        //    {
        //        new RequiredSkill {OpportunityID=1, Skill="Compiler"},
        //        new RequiredSkill {OpportunityID=2, Skill="Functional Programming"},
        //        new RequiredSkill {OpportunityID=3, Skill="xv6"},
        //        new RequiredSkill {OpportunityID=4, Skill="Moore's Law"},
        //        new RequiredSkill {OpportunityID=5, Skill="LLVM"}
        //    };

        //    context.RequiredSkills.AddRange(requiredSkills);
        //    context.SaveChanges();

        //    var tags = new Tag[]
        //    {
        //        new Tag{OpportunityID=1, TheTag="Compilers"},
        //        new Tag{OpportunityID=2, TheTag="Programming Languages"},
        //        new Tag{OpportunityID=3, TheTag="Operating Systems"},
        //        new Tag{OpportunityID=4, TheTag="Computer Organization"},
        //        new Tag{OpportunityID=5, TheTag="Compilers"},
        //    };

        //    context.Tags.AddRange(tags);
        //    context.SaveChanges();

        //    Application a = new Application
        //    {
        //        Active = true,
        //        ApplicationDate = DateTime.Now,
        //        CompletedCourses = new List<CompletedCourse>(),
        //        DegreePlan = "CS",
        //        Email = "test@utah.edu",
        //        ExpectedGradDate = DateTime.Now,
        //        GPA = 3,
        //        HoursPerWeek = 10,
        //        Interests = new List<StudentInterest>(),
        //        PersonalStatement = "Hello",
        //        Resume = "resume.pdf",
        //        Skills = new List<StudentSkill>(),
        //        UID = "u1234321"
        //    };

        //    context.Applications.Add(a);
        //    context.SaveChanges();

        //    StudentSkill s = new StudentSkill
        //    {
        //        ApplicationID = 1,
        //        Skill = "Programming"
        //    };

        //    context.StudentSkills.Add(s);
        //    context.SaveChanges();

        //    CompletedCourse cc = new CompletedCourse
        //    {
        //        ApplicationID = 1,
        //        Course = "CS 1410"
        //    };

        //    context.CompletedCourses.Add(cc);
        //    context.SaveChanges();

        //    StudentInterest si = new StudentInterest
        //    {
        //        ApplicationID = 1,
        //        Interest = "Biking"
        //    };

        //    context.StudentInterests.Add(si);
        //    context.SaveChanges();

        //}
    }
}
