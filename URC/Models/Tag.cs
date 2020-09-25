 /* Author: Peter Forsling
  * Date: 24 September 2020
  * Course: CS 4540, University of Utah, School of Computing
  *
  * Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.
  * I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
  * another source.  Any references used in the completion of the assignment are cited in my README file.
  *
  *  File Contents:
  *  This file contains Model for the Tag Entity. Tags are used to help with search terms for Research Opportunities.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URC.Models
{
    /// <summary>
    /// The Tag Entity Model. Tags are used to help with search terms for Research Opportunities.
    /// </summary>
    public class Tag
    { 
        /// <summary>
        /// The ID for the given tag (Primary Key)
        /// </summary>
        public int TagID { get; set; }

        /// <summary>
        /// The ID for the corresponding opportunity (Foreign Key)
        /// </summary>
        public int OpportunityID { get; set; }

        /// <summary>
        /// The tag. It is called TheTag instead of Tag because C# properties can't have the same name as the enclosing class.
        /// </summary>
        public string TheTag { get; set; }
    }
}
