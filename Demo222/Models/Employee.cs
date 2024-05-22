using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo22.Models
{
    internal class Employee
    {
        public Employee() { }
        public Employee(decimal initialSalary) {
            salary = initialSalary;
        }
        [JsonPropertyName("FullName")]
        public String name { get; set; }
        [JsonIgnore]
        public String email { get; set; }
        [JsonInclude]
        public decimal salary { get; set; }
    }
}
