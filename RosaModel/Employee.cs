﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class Employee
    {
        public int employeeId { get; set; }
        public RolesEnum role { get; set; }
        public string employeeName { get; set; } //full name
        public string username { get; set; } //used for login
        public string password { get; set; } //used for login
    }
}
