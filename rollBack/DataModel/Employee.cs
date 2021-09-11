using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rollBack.DataModel
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        //public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


    }
}
