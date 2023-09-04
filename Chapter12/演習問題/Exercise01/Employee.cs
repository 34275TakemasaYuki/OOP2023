using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class Employee {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime HireDate { get; set; }

        public override string ToString() {
            return string.Format("[Id={0},Name={1},Published={2}", Id, Name, HireDate);
        }
    }
}
