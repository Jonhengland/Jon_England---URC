/*
Author: Peter Forsling
Date: 24 September 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the Opportunity Entity for the Database
*/


using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URC.Models
{
    /// <summary>
    /// The Opportunity Entity
    /// </summary>
    public class Opportunity
    {

        /// <summary>
        /// Opportunity ID (Primary Key)
        /// </summary>
        public int OpportunityID { get; set; }

        /// <summary>
        /// Name of Project
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Name of Professor leading Project
        /// </summary>
        public string ProfessorName { get; set; }

        /// <summary>
        /// Description of Project
        /// </summary>
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Image associated with project (Filename for PS4)
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Name of Student Mentor
        /// </summary>
        public string MentorName { get; set; }

        /// <summary>
        /// When the Project starts
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// When the Project ends
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// How much the student will be paid
        /// </summary>
        public double Pay { get; set; }

        /// <summary>
        /// Whether or not the opportunity has been filled
        /// </summary>
        public bool Filled { get; set; }

        /// <summary>
        /// The required skills associated with the project
        /// </summary>
        public ICollection<RequiredSkill> RequiredSkills { get; set; }

        /// <summary>
        /// The tags associated with the project
        /// </summary>
        public ICollection<Tag> Tags { get; set; }

    }
}
