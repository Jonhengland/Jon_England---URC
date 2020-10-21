using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URC.Models
{
    public class CompletedCourse
    {

        public int ID { get; set; }

        public int ApplicationID { get; set; }

        public string Course { get; set; }
    }
}
