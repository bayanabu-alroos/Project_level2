using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Customer() { }

        public Customer(int id, string name, int age, string phone, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Phone = phone;
            Address = address;
        }
        public Customer(string name, int age, string phone, string address)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Address = address;
        }
        ~Customer() { }
    }
}
