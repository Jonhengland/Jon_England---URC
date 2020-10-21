using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URC.Models
{
    public class StudentSkill
    {

        public int ID { get; set; }

        public int ApplicationID { get; set; }

        public string Skill { get; set; }
    }
}
