﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G03.DAL.Models
{//محتاجه اعمل كلاس اللي بيتمثل عندي ف الداتا بيز 
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
