using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql111
{
    public class Employee
    {
        public string _id { get; set; }
        public string _name { get; set; }
        public string _birthdate { get; set; }
        public string _sex { get; set; }
        public string _salary { get; set; }
        public string _branchId { get; set; }
        public string _supId { get; set; }

        public Employee(string name, string birthdate, string sex, string salary, string branchId, string supId)
        {
            _name = name;
            _birthdate = birthdate;
            _sex = sex;
            _salary = salary;
            _branchId = branchId;
            _supId = supId;
        }
        public Employee(string id)
        {
            _id = id;
        }
    }
}
