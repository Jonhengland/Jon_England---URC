/*
Author: Peter Forsling
Date: 12 October 2020
Course: CS 4540, University of Utah, School of Computing
Copyright: CS 4540 and Peter Forsling - This work may not be copied for use in Academic Coursework.

I, Peter Forsling, certify that I wrote this code from scratch and did not copy it in part or whole from
another source. Any references used in the completion of the assignment are cited in my README file.

File Contents
This file contains the Identity User for the Identity Database
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace URC.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the URCUser class
    public class URCUser : IdentityUser
    {
    }
}
