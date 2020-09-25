/*
Author: Peter Forsling
Date: 24 September 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the RequiredSkill entity for the database
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URC.Models
{
    /// <summary>
    /// The RequiredSkill entity
    /// </summary>
    public class RequiredSkill
    {

        /// <summary>
        /// The ID for the required skill (Primary key)
        /// </summary>
        public int RequiredSkillID { get; set; }

        /// <summary>
        /// The ID for the corresponding Opportunity (Foreign Key)
        /// </summary>
        public int OpportunityID { get; set; }

        /// <summary>
        /// The required skill
        /// </summary>
        public string Skill { get; set; }
    }
}
