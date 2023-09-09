using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Category() { }

        public Category(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        ~Category() { }
    }
}
